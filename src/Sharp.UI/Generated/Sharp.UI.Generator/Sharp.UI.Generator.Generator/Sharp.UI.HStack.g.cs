﻿//
// <auto-generated>
//

#nullable enable


using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace Sharp.UI
{
	public partial class HStack : IList<Microsoft.Maui.IView>
	{

        // ----- constructors -----

        public HStack() { }

        public HStack(out HStack hStack) 
        {
            hStack = this;
        }

        public HStack(System.Action<HStack> configure) 
        {
            configure(this);
        }

        public HStack(out HStack hStack, System.Action<HStack> configure) 
        {
            hStack = this;
            configure(this);
        }

        public void Add(Func<Sharp.UI.HStack, Sharp.UI.HStack> configure) { configure(this); }

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
