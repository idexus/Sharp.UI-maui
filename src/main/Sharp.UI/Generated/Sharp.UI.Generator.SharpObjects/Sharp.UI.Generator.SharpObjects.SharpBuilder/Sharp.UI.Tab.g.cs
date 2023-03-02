﻿//
// <auto-generated>
//

#nullable enable


using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace Sharp.UI
{
	using Sharp.UI;

    public partial class Tab : IList<Microsoft.Maui.Controls.ShellContent>
	{

        // ----- constructors -----

        public Tab() { }

        public Tab(out Tab tab) 
        {
            tab = this;
        }

        public Tab(System.Func<Tab, Tab> configure) 
        {
            configure(this);
        }

        public Tab(out Tab tab, System.Func<Tab, Tab> configure) 
        {
            tab = this;
            configure(this);
        }

        public Tab(string title, out Tab tab) : this(title)
        {
            tab = this;
        }

        public Tab(string title, System.Func<Tab, Tab> configure) : this(title)
        {
            configure(this);
        }

        public Tab(string title, out Tab tab, System.Func<Tab, Tab> configure) : this(title)
        {
            tab = this;
            configure(this);
        }

        // ----- collection container -----

        public int Count => this.Items.Count;
        public Microsoft.Maui.Controls.ShellContent this[int index] { get => this.Items[index]; set => this.Items[index] = value; }
        public bool IsReadOnly => false;
        public void Clear() => this.Items.Clear();
        public bool Contains(Microsoft.Maui.Controls.ShellContent item) => this.Items.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.ShellContent[] array, int arrayIndex) => this.Items.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.ShellContent> GetEnumerator() => this.Items.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.ShellContent item) => this.Items.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.ShellContent item) => this.Items.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.ShellContent item) => this.Items.Remove(item);
        public void RemoveAt(int index) => this.Items.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.Items.GetEnumerator();
        public void Add(Microsoft.Maui.Controls.ShellContent item) => this.Items.Add(item);

    }
}

#nullable restore
