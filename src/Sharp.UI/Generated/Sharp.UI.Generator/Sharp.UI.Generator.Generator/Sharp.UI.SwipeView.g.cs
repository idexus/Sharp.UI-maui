﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.SwipeView</c> class.
    /// </summary>
    [ContentProperty("Content")]
    public partial class SwipeView : Microsoft.Maui.Controls.SwipeView, Sharp.UI.ISwipeView, IMauiWrapper, IEnumerable
    {
        // ----- constructors -----

        public SwipeView() { }

        public SwipeView(out SwipeView swipeView) 
        {
            swipeView = this;
        }

        [Obsolete("This constructor is deprecated, use e=>e.FluentMethod(), inside curly braces.")]
        public SwipeView(System.Action<SwipeView> configure) 
        {
            configure(this);
        }

        [Obsolete("This constructor is deprecated, use e=>e.Assign(out symbol).OtherFluentMethod(), inside curly braces.")]
        public SwipeView(out SwipeView swipeView, System.Action<SwipeView> configure) 
        {
            swipeView = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.Content; }
        public void Add(Microsoft.Maui.Controls.View content) => this.Content = content;

        public void Add(Func<Sharp.UI.SwipeView, Sharp.UI.SwipeView> configure) { configure(this); }

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
