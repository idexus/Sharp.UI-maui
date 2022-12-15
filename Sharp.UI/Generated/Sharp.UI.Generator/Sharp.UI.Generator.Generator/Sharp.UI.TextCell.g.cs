﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class TextCell : Microsoft.Maui.Controls.TextCell, Sharp.UI.ITextCell, IMauiWrapper
    {
        // ----- maui object -----

        public Sharp.UI.TextCell MauiObject { get => this; }

        // ----- constructors -----

        public TextCell() { }

        public TextCell(out TextCell textCell) 
        {
            textCell = this;
        }

        public TextCell(System.Action<TextCell> configure) 
        {
            configure(this);
        }

        public TextCell(out TextCell textCell, System.Action<TextCell> configure) 
        {
            textCell = this;
            configure(this);
        }

        public TextCell(string text) 
        {  
            this.Text = text;
        }

        public TextCell(string text, out TextCell textCell) 
        {  
            this.Text = text;;
            textCell = this;
        }

        public TextCell(string text, System.Action<TextCell> configure) 
        {  
            this.Text = text;
            configure(this);
        }

        public TextCell(string text, out TextCell textCell, System.Action<TextCell> configure) 
        {  
            this.Text = text;
            textCell = this;
            configure(this);
        }

        // ----- properties / events -----

        public new object CommandParameter { get => base.CommandParameter; set => base.CommandParameter = MauiWrapper.Value<object>(value); }
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
