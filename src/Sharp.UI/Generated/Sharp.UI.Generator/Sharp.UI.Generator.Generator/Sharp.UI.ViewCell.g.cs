﻿//
// <auto-generated>
//

#nullable enable


using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace Sharp.UI
{
	public partial class ViewCell : IEnumerable
	{

        // ----- constructors -----

        public ViewCell() { }

        public ViewCell(out ViewCell viewCell) 
        {
            viewCell = this;
        }

        public ViewCell(System.Action<ViewCell> configure) 
        {
            configure(this);
        }

        public ViewCell(out ViewCell viewCell, System.Action<ViewCell> configure) 
        {
            viewCell = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.View; }
        public void Add(Microsoft.Maui.Controls.View view) => this.View = view;

    }
}

#nullable restore
