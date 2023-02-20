﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class StateTriggerBaseExtension
    {
        public static T OnIsActiveChanged<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.StateTriggerBase
        {
            obj.IsActiveChanged += handler;
            return obj;
        }
        
        public static T OnIsActiveChanged<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.StateTriggerBase
        {
            obj.IsActiveChanged += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
