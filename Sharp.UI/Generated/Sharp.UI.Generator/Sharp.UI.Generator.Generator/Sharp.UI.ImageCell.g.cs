﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class ImageCell : Microsoft.Maui.Controls.ImageCell, Sharp.UI.IImageCell, IWrappedBindableObject
    {
        // ----- constructors -----

        public ImageCell() { }

        public ImageCell(out ImageCell imageCell) 
        {
            imageCell = this;
        }

        public ImageCell(System.Action<ImageCell> configure) 
        {
            configure(this);
        }

        public ImageCell(out ImageCell imageCell, System.Action<ImageCell> configure) 
        {
            imageCell = this;
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
