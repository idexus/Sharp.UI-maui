﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class RefreshView : Microsoft.Maui.Controls.RefreshView, Sharp.UI.IRefreshView, IEnumerable, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public RefreshView() { }


        public RefreshView(out RefreshView refreshView) 
        {
            refreshView = this;
        }

        public RefreshView(Action<RefreshView> configure) 
        {
            configure(this);
        }

        public RefreshView(out RefreshView refreshView, Action<RefreshView> configure) 
        {
            refreshView = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { throw new NotImplementedException(); }

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

#pragma warning restore CS0108
#pragma warning restore CS8625
#pragma warning restore CS8669
