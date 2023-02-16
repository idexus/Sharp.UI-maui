﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.FontImageSource</c> class.
    /// </summary>
    public partial class FontImageSource : Microsoft.Maui.Controls.FontImageSource, Sharp.UI.IFontImageSource, IMauiWrapper
    {
        // ----- constructors -----

        public FontImageSource() { }

        public FontImageSource(out FontImageSource fontImageSource) 
        {
            fontImageSource = this;
        }

        public FontImageSource(string glyph, string fontFamily, out FontImageSource fontImageSource) : this(glyph, fontFamily)
        {
            fontImageSource = this;
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
