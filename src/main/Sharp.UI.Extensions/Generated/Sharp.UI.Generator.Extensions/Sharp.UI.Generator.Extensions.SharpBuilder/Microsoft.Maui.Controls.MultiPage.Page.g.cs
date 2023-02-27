﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class MultiPageOfPageExtension
    {
        public static T ItemsSource<T>(this T self,
            System.Collections.IEnumerable itemsSource)
            where T : Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>.ItemsSourceProperty, itemsSource);
            return self;
        }
        
        public static T ItemsSource<T>(this T self, Func<PropertyContext<System.Collections.IEnumerable>, IPropertyBuilder<System.Collections.IEnumerable>> configure)
            where T : Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>
        {
            var context = new PropertyContext<System.Collections.IEnumerable>(self, Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>.ItemsSourceProperty);
            configure(context).Build();
            return self;
        }
        
        public static T ItemTemplate<T>(this T self,
            Microsoft.Maui.Controls.DataTemplate itemTemplate)
            where T : Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>.ItemTemplateProperty, itemTemplate);
            return self;
        }
        
        public static T ItemTemplate<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.DataTemplate>, IPropertyBuilder<Microsoft.Maui.Controls.DataTemplate>> configure)
            where T : Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.DataTemplate>(self, Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>.ItemTemplateProperty);
            configure(context).Build();
            return self;
        }
        
        public static T ItemTemplate<T>(this T self, System.Func<object> loadTemplate)
            where T : Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>.ItemTemplateProperty, new DataTemplate(loadTemplate));
            return self;
        }
        
        public static T SelectedItem<T>(this T self,
            object selectedItem)
            where T : Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>.SelectedItemProperty, selectedItem);
            return self;
        }
        
        public static T SelectedItem<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>.SelectedItemProperty);
            configure(context).Build();
            return self;
        }
        
        public static T CurrentPage<T>(this T self,
            Microsoft.Maui.Controls.Page currentPage)
            where T : Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property CurrentPage");
            self.CurrentPage = currentPage;
            return self;
        }
        
        public static T Children<T>(this T self,
            IList<Microsoft.Maui.Controls.Page> children)
            where T : Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>
        {
            foreach (var item in children)
                self.Children.Add(item);
            return self;
        }

        public static T Children<T>(this T self,
            params Microsoft.Maui.Controls.Page[] children)
            where T : Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>
        {
            foreach (var item in children)
                self.Children.Add(item);
            return self;
        }
        
        public static T OnCurrentPageChanged<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>
        {
            self.CurrentPageChanged += handler;
            return self;
        }
        
        public static T OnCurrentPageChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>
        {
            self.CurrentPageChanged += (o, arg) => action(self);
            return self;
        }
        
        public static T OnPagesChanged<T>(this T self, System.Collections.Specialized.NotifyCollectionChangedEventHandler handler)
            where T : Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>
        {
            self.PagesChanged += handler;
            return self;
        }
        
        public static T OnPagesChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.MultiPage<Microsoft.Maui.Controls.Page>
        {
            self.PagesChanged += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
