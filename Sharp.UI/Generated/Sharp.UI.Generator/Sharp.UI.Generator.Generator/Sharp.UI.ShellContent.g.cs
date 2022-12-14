﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class ShellContent : Microsoft.Maui.Controls.ShellContent, Sharp.UI.IShellContent, IEnumerable, IWrappedBindableObject
    {
        // ----- constructors -----

        public ShellContent() { }

        public ShellContent(out ShellContent shellContent) 
        {
            shellContent = this;
        }

        public ShellContent(System.Action<ShellContent> configure) 
        {
            configure(this);
        }

        public ShellContent(out ShellContent shellContent, System.Action<ShellContent> configure) 
        {
            shellContent = this;
            configure(this);
        }

        public ShellContent(string title, object content) 
        {  
            this.Title = title;
            this.Content = content;
        }

        public ShellContent(string title, object content, out ShellContent shellContent) 
        {  
            this.Title = title;
            this.Content = content;;
            shellContent = this;
        }

        public ShellContent(string title, object content, System.Action<ShellContent> configure) 
        {  
            this.Title = title;
            this.Content = content;
            configure(this);
        }

        public ShellContent(string title, object content, out ShellContent shellContent, System.Action<ShellContent> configure) 
        {  
            this.Title = title;
            this.Content = content;
            shellContent = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.Content; }

        public void Add(object content) => this.Content = content;

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
