﻿//
// MIT License
// Copyright Pawel Krzywdzinski
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;

namespace Sharp.UI.Generator;

public class SharpBuilder
{
    GeneratorExecutionContext context;

    public static List<string> SharpSealedTypesNameList { get; private set; }
    public static List<string> InterfaceNameList { get; private set; }

    public SharpBuilder(GeneratorExecutionContext context)
    {
        this.context = context;
    }

    //------------- generate -----------------

    List<String> doneExtensions;

    public void Generate()
	{
        doneExtensions = new List<String>();
        SharpSealedTypesNameList = new List<string>();
        InterfaceNameList = new List<string>();

        var wrappedSymbols = context.Compilation.GetSymbolsWithName((s) => true, filter: SymbolFilter.Type)
            .Where(e => !e.IsStatic && e.GetAttributes().FirstOrDefault(e => e.AttributeClass.Name.Contains(SharpSymbol.SharpObjectAttributeString)) != null);

        var wrappedStaticSymbols = context.Compilation.GetSymbolsWithName((s) => true, filter: SymbolFilter.Type)
            .Where(e => e.IsStatic && e.GetAttributes().FirstOrDefault(e => e.AttributeClass.Name.Contains(SharpSymbol.SharpObjectAttributeString)) != null);

        foreach (var symbol in wrappedSymbols)
        {
            var typeSymbol = (INamedTypeSymbol)symbol;
            var sharpSymbol = new SharpSymbol(typeSymbol);
            if (sharpSymbol.IsWrappedType && sharpSymbol.WrappedType.IsSealed)
                SharpSealedTypesNameList.Add(symbol.Name);
        }

        GenerateInterfaces(wrappedSymbols);

        GenerateExtensions(wrappedStaticSymbols);

        GenerateSymbols(wrappedSymbols);
        GenerateExtensions(wrappedSymbols);
    }

    //------------- generate symbols -----------------


    void GenerateSymbols(IEnumerable<ISymbol> symbols)
    {
        foreach (var symbol in symbols)
        {
            var typeSymbol = (INamedTypeSymbol)symbol;
            var sharpSymbol = new SharpSymbol(typeSymbol);
            this.GenerateSymbol(sharpSymbol);
        }
    }

    void GenerateSymbol(SharpSymbol sharpSymbol)
    {
        var builder = new StringBuilder();
        builder.AppendLine("//");
        builder.AppendLine("// <auto-generated>");
        builder.AppendLine("//");
        builder.AppendLine();
        builder.AppendLine("#pragma warning disable CS8669");
        builder.AppendLine();

        sharpSymbol.BuildClass(builder);

        builder.AppendLine();
        builder.AppendLine();
        builder.AppendLine("#pragma warning restore CS8669");

        context.AddSource(sharpSymbol.ClassBuilderSymbolFileNeme(), builder.ToString());
    }

    //------------- generate extensions -----------------

    void GenerateExtensions(IEnumerable<ISymbol> symbols)
    {

        foreach (var symbol in symbols)
        {
            var sharpSymbol = new SharpSymbol(symbol as INamedTypeSymbol);
            this.GenerateExtension(sharpSymbol);
            doneExtensions.Add(sharpSymbol.GetNormalizedName());
        }

        foreach (var symbol in symbols)
        {
            var sharpSymbol = new SharpSymbol(symbol as INamedTypeSymbol);
            if (sharpSymbol.IsWrappedType)
            {
                Helpers.LoopDownToObject(sharpSymbol.WrappedType, type =>
                {
                    var baseSharpSymbol = new SharpSymbol(type);
                    var normalizedName = baseSharpSymbol.GetNormalizedName();
                    if (!doneExtensions.Contains(normalizedName))
                    {
                        this.GenerateExtension(baseSharpSymbol);
                        doneExtensions.Add(normalizedName);
                    }
                    return false;
                });
            }
        }
    }

    void GenerateExtension(SharpSymbol sharpSymbol)
    {
        var builder = new StringBuilder();
        builder.AppendLine("//");
        builder.AppendLine("// <auto-generated>");
        builder.AppendLine("//");
        builder.AppendLine();
        builder.AppendLine("#pragma warning disable CS8669");
        builder.AppendLine();

        if (sharpSymbol.GetNormalizedName().Equals("ActivityIndicator"))
        {

        }

        sharpSymbol.BuildExtension(builder);

        if (sharpSymbol.IsExtensionMethodsGenerated)
        {
            builder.AppendLine();
            builder.AppendLine();
            builder.AppendLine("#pragma warning restore CS8669");

            context.AddSource(sharpSymbol.ExtensionBuilderFileName(), builder.ToString());
        }
    }

    //---------------------------------------------------
    //-------------- generate interfaces ----------------
    //---------------------------------------------------

    void GenerateInterfaces(IEnumerable<ISymbol> symbols)
    {
        var builder = new StringBuilder();
        builder.AppendLine("//");
        builder.AppendLine("// <auto-generated>");
        builder.AppendLine("//");
        builder.AppendLine();
        builder.AppendLine("namespace Sharp.UI;");
        builder.AppendLine();
        builder.AppendLine();

        InterfaceNameList = new List<string>();

        foreach (var symbol in symbols)
        {
            var sharpSymbol = new SharpSymbol(symbol as INamedTypeSymbol);
            if (sharpSymbol.IsWrappedType)
            {
                Helpers.LoopDownToObject(sharpSymbol.WrappedType, type =>
                {
                    var interfaceName = $"I{SharpSymbol.GetNormalizedName(type)}";
                    if (!InterfaceNameList.Contains(interfaceName))
                    {
                        AddInterface(builder, type);
                        InterfaceNameList.Add(interfaceName);
                    }
                    return false;
                });
            }
        }

        if (InterfaceNameList.Count() > 0)
            context.AddSource($"Interfaces.g.cs", builder.ToString());
    }

    void AddInterface(StringBuilder builder, INamedTypeSymbol type)
    {
        var parentInterfaceName = $"I{SharpSymbol.GetNormalizedName(type.BaseType)}";
        var parentString = parentInterfaceName.Equals("IObject") ? "" : $" : {parentInterfaceName}";
        builder.AppendLine($@"public partial interface I{SharpSymbol.GetNormalizedName(type)}{parentString} {{ }}");
    }
}