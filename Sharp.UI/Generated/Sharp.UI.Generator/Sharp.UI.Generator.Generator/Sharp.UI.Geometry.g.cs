﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class Geometry : Microsoft.Maui.Controls.Shapes.Geometry, Sharp.UI.IGeometry, IMauiWrapper
    {
        // ----- maui object -----

        public Sharp.UI.Geometry MauiObject { get => this; }

        // ----- constructors -----

        public Geometry() { }

        public Geometry(out Geometry geometry) 
        {
            geometry = this;
        }

        public Geometry(System.Action<Geometry> configure) 
        {
            configure(this);
        }

        public Geometry(out Geometry geometry, System.Action<Geometry> configure) 
        {
            geometry = this;
            configure(this);
        }

        // ----- properties / events -----

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
