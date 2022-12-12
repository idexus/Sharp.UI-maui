﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class OrientationStateTriggerGeneratedExtension
    {
        public static T Orientation<T>(this T obj,
            Microsoft.Maui.Devices.DisplayOrientation? orientation)
            where T : Sharp.UI.IOrientationStateTrigger
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.OrientationStateTrigger>(obj);
            if (orientation != null) mauiObject.Orientation = (Microsoft.Maui.Devices.DisplayOrientation)orientation;
            return obj;
        }
        
        public static T Orientation<T>(this T obj,
            Microsoft.Maui.Devices.DisplayOrientation? orientation,
            Func<BindableDef<Microsoft.Maui.Devices.DisplayOrientation>, BindableDef<Microsoft.Maui.Devices.DisplayOrientation>> definition)
            where T : Sharp.UI.IOrientationStateTrigger
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.OrientationStateTrigger>(obj);
            if (orientation != null) mauiObject.Orientation = (Microsoft.Maui.Devices.DisplayOrientation)orientation;
            var def = definition(new BindableDef<Microsoft.Maui.Devices.DisplayOrientation>(mauiObject, Microsoft.Maui.Controls.OrientationStateTrigger.OrientationProperty));
            if (def.ValueIsSet()) mauiObject.Orientation = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Orientation<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Devices.DisplayOrientation>, BindableDef<Microsoft.Maui.Devices.DisplayOrientation>> definition)
            where T : Sharp.UI.IOrientationStateTrigger
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.OrientationStateTrigger>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Devices.DisplayOrientation>(mauiObject, Microsoft.Maui.Controls.OrientationStateTrigger.OrientationProperty));
            if (def.ValueIsSet()) mauiObject.Orientation = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
