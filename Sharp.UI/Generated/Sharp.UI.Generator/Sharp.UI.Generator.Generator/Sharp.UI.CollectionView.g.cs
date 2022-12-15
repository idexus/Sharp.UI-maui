﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class CollectionView : Microsoft.Maui.Controls.CollectionView, Sharp.UI.ICollectionView, IMauiWrapper
    {
        // ----- maui object -----

        public Sharp.UI.CollectionView MauiObject { get => this; }

        // ----- constructors -----

        public CollectionView() { }

        public CollectionView(out CollectionView collectionView) 
        {
            collectionView = this;
        }

        public CollectionView(System.Action<CollectionView> configure) 
        {
            configure(this);
        }

        public CollectionView(out CollectionView collectionView, System.Action<CollectionView> configure) 
        {
            collectionView = this;
            configure(this);
        }

        // ----- properties / events -----

        public new object SelectedItem { get => base.SelectedItem; set => base.SelectedItem = MauiWrapper.Value<object>(value); }
        public new object SelectionChangedCommandParameter { get => base.SelectionChangedCommandParameter; set => base.SelectionChangedCommandParameter = MauiWrapper.Value<object>(value); }
        public new object Header { get => base.Header; set => base.Header = MauiWrapper.Value<object>(value); }
        public new object Footer { get => base.Footer; set => base.Footer = MauiWrapper.Value<object>(value); }
        public new object EmptyView { get => base.EmptyView; set => base.EmptyView = MauiWrapper.Value<object>(value); }
        public new object RemainingItemsThresholdReachedCommandParameter { get => base.RemainingItemsThresholdReachedCommandParameter; set => base.RemainingItemsThresholdReachedCommandParameter = MauiWrapper.Value<object>(value); }
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
