﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace ExampleApp
{
    using Sharp.UI;

    public static partial class EmptyCardViewExtension
    {
        public static T CardTitle<T>(this T obj,
            string cardTitle)
            where T : ExampleApp.EmptyCardView
        {
            obj.CardTitle = cardTitle;
            return obj;
        }
        
        public static T CardTitle<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : ExampleApp.EmptyCardView
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.CardTitle = builder.GetValue();
            return obj;
        }
        
        public static T CardTitle<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : ExampleApp.EmptyCardView
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, ExampleApp.EmptyCardView.CardTitleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CardDescription<T>(this T obj,
            string cardDescription)
            where T : ExampleApp.EmptyCardView
        {
            obj.CardDescription = cardDescription;
            return obj;
        }
        
        public static T CardDescription<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buidValue)
            where T : ExampleApp.EmptyCardView
        {
            var builder = buidValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) obj.CardDescription = builder.GetValue();
            return obj;
        }
        
        public static T CardDescription<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buidBinding)
            where T : ExampleApp.EmptyCardView
        {
            var builder = buidBinding(new BindingBuilder<string>(obj, ExampleApp.EmptyCardView.CardDescriptionProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CardColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color cardColor)
            where T : ExampleApp.EmptyCardView
        {
            obj.CardColor = cardColor;
            return obj;
        }
        
        public static T CardColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : ExampleApp.EmptyCardView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.CardColor = builder.GetValue();
            return obj;
        }
        
        public static T CardColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : ExampleApp.EmptyCardView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, ExampleApp.EmptyCardView.CardColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color borderColor)
            where T : ExampleApp.EmptyCardView
        {
            obj.BorderColor = borderColor;
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : ExampleApp.EmptyCardView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.BorderColor = builder.GetValue();
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : ExampleApp.EmptyCardView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, ExampleApp.EmptyCardView.BorderColorProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
