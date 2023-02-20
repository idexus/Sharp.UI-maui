﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace ExampleApp
{
    using Sharp.UI;

    public static partial class ListViewPageViewModelExtension
    {
        public static T SimpleData<T>(this T obj,
            System.Collections.Generic.List<ExampleApp.DataModel> simpleData)
            where T : ExampleApp.ListViewPageViewModel
        {
            obj.SimpleData = simpleData;
            return obj;
        }
        
        public static T SimpleData<T>(this T obj,
            System.Func<ValueBuilder<System.Collections.Generic.List<ExampleApp.DataModel>>, ValueBuilder<System.Collections.Generic.List<ExampleApp.DataModel>>> buidValue)
            where T : ExampleApp.ListViewPageViewModel
        {
            var builder = buidValue(new ValueBuilder<System.Collections.Generic.List<ExampleApp.DataModel>>());
            if (builder.ValueIsSet()) obj.SimpleData = builder.GetValue();
            return obj;
        }
        
        public static T SimpleData<T>(this T obj,
            System.Func<BindingBuilder<System.Collections.Generic.List<ExampleApp.DataModel>>, BindingBuilder<System.Collections.Generic.List<ExampleApp.DataModel>>> buidBinding)
            where T : ExampleApp.ListViewPageViewModel
        {
            var builder = buidBinding(new BindingBuilder<System.Collections.Generic.List<ExampleApp.DataModel>>(obj, ExampleApp.ListViewPageViewModel.SimpleDataProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
