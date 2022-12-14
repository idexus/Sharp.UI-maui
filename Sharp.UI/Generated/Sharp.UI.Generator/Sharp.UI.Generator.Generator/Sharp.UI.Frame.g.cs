﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class Frame : Microsoft.Maui.Controls.Frame, Sharp.UI.IFrame, IEnumerable, IWrappedBindableObject
    {
        // ----- constructors -----

        public Frame() { }

        public Frame(out Frame frame) 
        {
            frame = this;
        }

        public Frame(System.Action<Frame> configure) 
        {
            configure(this);
        }

        public Frame(out Frame frame, System.Action<Frame> configure) 
        {
            frame = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.Content; }

        public void Add(Microsoft.Maui.Controls.View content) => this.Content = content;

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
