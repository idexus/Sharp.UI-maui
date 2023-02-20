﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace ExampleApp
{
    using Sharp.UI;

    public static partial class SecondPageViewModelExtension
    {
        public static T Title<T>(this T obj,
            string title)
            where T : ExampleApp.SecondPageViewModel
        {
            obj.Title = title;
            return obj;
        }
        
        public static T Title<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : ExampleApp.SecondPageViewModel
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.Title = builder.GetValue();
            return obj;
        }
        
        public static T Title<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : ExampleApp.SecondPageViewModel
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, ExampleApp.SecondPageViewModel.TitleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Author<T>(this T obj,
            string author)
            where T : ExampleApp.SecondPageViewModel
        {
            obj.Author = author;
            return obj;
        }
        
        public static T Author<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : ExampleApp.SecondPageViewModel
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.Author = builder.GetValue();
            return obj;
        }
        
        public static T Author<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : ExampleApp.SecondPageViewModel
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, ExampleApp.SecondPageViewModel.AuthorProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
