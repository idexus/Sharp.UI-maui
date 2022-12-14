﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class CheckBox : Microsoft.Maui.Controls.CheckBox, Sharp.UI.ICheckBox, IWrappedBindableObject
    {
        // ----- constructors -----

        public CheckBox() { }

        public CheckBox(out CheckBox checkBox) 
        {
            checkBox = this;
        }

        public CheckBox(System.Action<CheckBox> configure) 
        {
            configure(this);
        }

        public CheckBox(out CheckBox checkBox, System.Action<CheckBox> configure) 
        {
            checkBox = this;
            configure(this);
        }

        // ----- binding context -----

        public new object BindingContext
        {
            get => base.BindingContext;
            set
            {
                var mauiObject = MauiWrapper.GetObject<object>(value);
                base.BindingContext = mauiObject;
            }
        }
        

    }
}

#pragma warning restore CS8669
