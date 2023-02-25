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

    public partial class ShellContent : IEnumerable
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

        public ShellContent(string title, object content, out ShellContent shellContent) : this(title, content)
        {
            shellContent = this;
        }

        public ShellContent(string title, object content, System.Action<ShellContent> configure) : this(title, content)
        {
            configure(this);
        }

        public ShellContent(string title, object content, out ShellContent shellContent, System.Action<ShellContent> configure) : this(title, content)
        {
            shellContent = this;
            configure(this);
        }

        // ----- single item container -----

        IEnumerator IEnumerable.GetEnumerator() { yield return this.Content; }
        public void Add(object content) => this.Content = content;

    }
}

#nullable restore
