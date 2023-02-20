﻿//
// <auto-generated>
//

#nullable enable


using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace Sharp.UI
{
	public partial class MenuFlyout : IList<Microsoft.Maui.IMenuElement>
	{

        // ----- constructors -----

        public MenuFlyout() { }

        public MenuFlyout(out MenuFlyout menuFlyout) 
        {
            menuFlyout = this;
        }

        public MenuFlyout(System.Action<MenuFlyout> configure) 
        {
            configure(this);
        }

        public MenuFlyout(out MenuFlyout menuFlyout, System.Action<MenuFlyout> configure) 
        {
            menuFlyout = this;
            configure(this);
        }

    }
}

#nullable restore
