﻿//
// <auto-generated>
//

#nullable enable


using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace Sharp.UI
{
	public partial class VerticalStackLayout : IList<Microsoft.Maui.IView>
	{

        // ----- constructors -----

        public VerticalStackLayout() { }

        public VerticalStackLayout(out VerticalStackLayout verticalStackLayout) 
        {
            verticalStackLayout = this;
        }

        public VerticalStackLayout(System.Action<VerticalStackLayout> configure) 
        {
            configure(this);
        }

        public VerticalStackLayout(out VerticalStackLayout verticalStackLayout, System.Action<VerticalStackLayout> configure) 
        {
            verticalStackLayout = this;
            configure(this);
        }

        public void Add(Func<Sharp.UI.VerticalStackLayout, Sharp.UI.VerticalStackLayout> configure) { configure(this); }

        public void Add(Action<IList<Microsoft.Maui.IView>> builder)
        {
            List<Microsoft.Maui.IView> items = new List<Microsoft.Maui.IView>();
            builder(items);
            foreach (var item in items)
                base.Add(item);
        }

        public void Add(Func<Microsoft.Maui.IView> builder)
        {
            var item = builder();
            if (item != null)
                base.Add(item);
        }

        public void Add(IEnumerable<Microsoft.Maui.Controls.View> items)
        {
            foreach (var item in items)
                base.Add(item);
        }

    }
}

#nullable restore
