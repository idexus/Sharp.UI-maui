﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class DeviceStateTriggerGeneratedExtension
    {
        public static T Device<T>(this T obj,
            string? device)
            where T : Sharp.UI.IDeviceStateTrigger
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.DeviceStateTrigger>(obj);
            if (device != null) mauiObject.Device = (string)device;
            return obj;
        }
        
        public static T Device<T>(this T obj,
            string? device,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IDeviceStateTrigger
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.DeviceStateTrigger>(obj);         
            if (device != null) mauiObject.Device = (string)device;
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.DeviceStateTrigger.DeviceProperty));
            if (def.ValueIsSet()) mauiObject.Device = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Device<T>(this T obj,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IDeviceStateTrigger
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.DeviceStateTrigger>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.DeviceStateTrigger.DeviceProperty));
            if (def.ValueIsSet()) mauiObject.Device = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
