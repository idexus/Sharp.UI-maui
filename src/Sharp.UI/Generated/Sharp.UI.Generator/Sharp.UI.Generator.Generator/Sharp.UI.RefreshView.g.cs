﻿//
// <auto-generated>
//

#nullable enable


using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace Sharp.UI
{
	public partial class RefreshView : IEnumerable
	{

        // ----- constructors -----

        public RefreshView() { }

        public RefreshView(out RefreshView refreshView) 
        {
            refreshView = this;
        }

        public RefreshView(System.Action<RefreshView> configure) 
        {
            configure(this);
        }

        public RefreshView(out RefreshView refreshView, System.Action<RefreshView> configure) 
        {
            refreshView = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.Content; }
        public void Add(Microsoft.Maui.Controls.View content) => this.Content = content;

        public void Add(Func<Sharp.UI.RefreshView, Sharp.UI.RefreshView> configure) { configure(this); }

    }
}

#nullable restore
