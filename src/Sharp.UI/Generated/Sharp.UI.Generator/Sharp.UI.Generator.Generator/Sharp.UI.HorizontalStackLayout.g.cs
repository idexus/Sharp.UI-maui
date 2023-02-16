﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.HorizontalStackLayout</c> class.
    /// </summary>
    public partial class HorizontalStackLayout : Microsoft.Maui.Controls.HorizontalStackLayout, Sharp.UI.IHorizontalStackLayout, IMauiWrapper, IList<Microsoft.Maui.IView>
    {
        // ----- constructors -----

        public HorizontalStackLayout() { }

        public HorizontalStackLayout(out HorizontalStackLayout horizontalStackLayout) 
        {
            horizontalStackLayout = this;
        }

        [Obsolete("This constructor is deprecated, use e=>e.FluentMethod(), inside curly braces.")]
        public HorizontalStackLayout(System.Action<HorizontalStackLayout> configure) 
        {
            configure(this);
        }

        [Obsolete("This constructor is deprecated, use e=>e.Assign(out symbol).OtherFluentMethod(), inside curly braces.")]
        public HorizontalStackLayout(out HorizontalStackLayout horizontalStackLayout, System.Action<HorizontalStackLayout> configure) 
        {
            horizontalStackLayout = this;
            configure(this);
        }

        public void Add(Func<Sharp.UI.HorizontalStackLayout, Sharp.UI.HorizontalStackLayout> configure) { configure(this); }

        public void Add(Microsoft.Maui.Controls.View view) => base.Add(view);

        public void Add(Action<IList<Microsoft.Maui.Controls.View>> builder)
        {
            List<Microsoft.Maui.Controls.View> items = new List<Microsoft.Maui.Controls.View>();
            builder(items);
            foreach (var item in items)
                base.Add(item);
        }

        public void Add(Func<Microsoft.Maui.Controls.View> builder)
        {
            var item = builder();
            if (item != null)
                base.Add(item);
        }

        public void Add(IEnumerable<Microsoft.Maui.Controls.View> items)
        {
            if (items.GetType().IsAssignableTo(typeof(Microsoft.Maui.Controls.Layout)))
            {
                var item = (Microsoft.Maui.Controls.Layout)items;
                base.Add(item);
            }
            else
            {
                foreach (var item in items)
                    base.Add(item);
            }
        }

        // ----- properties / events -----

        public new Sharp.UI.Style Style { get => new Sharp.UI.Style(base.Style); set => base.Style = value.MauiObject; }
        public new object BindingContext { get => base.BindingContext; set => base.BindingContext = MauiWrapper.Value<object>(value); }

        // ----- set value method -----

        public new void SetValue(Microsoft.Maui.Controls.BindableProperty property, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            ((Microsoft.Maui.Controls.BindableObject)this).SetValue(property, mauiValue);
        }

        public new void SetValue(Microsoft.Maui.Controls.BindablePropertyKey propertyKey, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            ((Microsoft.Maui.Controls.BindableObject)this).SetValue(propertyKey, mauiValue);
        }
    }
}

#pragma warning restore CS8669
