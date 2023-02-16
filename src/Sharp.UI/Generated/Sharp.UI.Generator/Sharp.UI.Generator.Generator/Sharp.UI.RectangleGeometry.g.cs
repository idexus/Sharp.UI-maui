﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.Shapes.RectangleGeometry</c> class.
    /// </summary>
    public partial class RectangleGeometry : Microsoft.Maui.Controls.Shapes.RectangleGeometry, Sharp.UI.IRectangleGeometry, IMauiWrapper
    {
        // ----- constructors -----

        public RectangleGeometry() { }

        public RectangleGeometry(out RectangleGeometry rectangleGeometry) 
        {
            rectangleGeometry = this;
        }

        public RectangleGeometry(double x, double y, double width, double height, out RectangleGeometry rectangleGeometry) : this(x, y, width, height)
        {
            rectangleGeometry = this;
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
