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

    public partial class MenuFlyoutSubItem : IList<Microsoft.Maui.IMenuElement>
	{

        // ----- constructors -----

        public MenuFlyoutSubItem() { }

        public MenuFlyoutSubItem(out MenuFlyoutSubItem menuFlyoutSubItem) 
        {
            menuFlyoutSubItem = this;
        }

        public MenuFlyoutSubItem(System.Func<MenuFlyoutSubItem, MenuFlyoutSubItem> configure) 
        {
            configure(this);
        }

        public MenuFlyoutSubItem(out MenuFlyoutSubItem menuFlyoutSubItem, System.Func<MenuFlyoutSubItem, MenuFlyoutSubItem> configure) 
        {
            menuFlyoutSubItem = this;
            configure(this);
        }

        public MenuFlyoutSubItem(string text, out MenuFlyoutSubItem menuFlyoutSubItem) : this(text)
        {
            menuFlyoutSubItem = this;
        }

        public MenuFlyoutSubItem(string text, System.Func<MenuFlyoutSubItem, MenuFlyoutSubItem> configure) : this(text)
        {
            configure(this);
        }

        public MenuFlyoutSubItem(string text, out MenuFlyoutSubItem menuFlyoutSubItem, System.Func<MenuFlyoutSubItem, MenuFlyoutSubItem> configure) : this(text)
        {
            menuFlyoutSubItem = this;
            configure(this);
        }

    }
}

#nullable restore
