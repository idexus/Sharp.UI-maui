﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class RefreshView : Microsoft.Maui.Controls.RefreshView, Sharp.UI.IRefreshView, IMauiWrapper, IEnumerable
    {
        // ----- maui object -----

        public Sharp.UI.RefreshView MauiObject { get => this; }

        // ----- constructors -----

        public RefreshView() { }

        public RefreshView(out RefreshView refreshView) 
        {
            refreshView = this;
        }

        public RefreshView(System.Action<RefreshView> configure) 
        {
            configure(this);
        }

        public RefreshView(out RefreshView refreshView, System.Action<RefreshView> configure) 
        {
            refreshView = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.Content; }

        public void Add(Microsoft.Maui.Controls.View content) => this.Content = content;

        // ----- properties / events -----

        public new object CommandParameter { get => base.CommandParameter; set => base.CommandParameter = MauiWrapper.Value<object>(value); }
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
