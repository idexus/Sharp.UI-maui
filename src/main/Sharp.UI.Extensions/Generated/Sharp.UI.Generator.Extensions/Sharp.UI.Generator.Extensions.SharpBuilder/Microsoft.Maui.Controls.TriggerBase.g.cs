﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class TriggerBaseExtension
    {
        public static T EnterActions<T>(this T obj,
            IList<Microsoft.Maui.Controls.TriggerAction> enterActions)
            where T : Microsoft.Maui.Controls.TriggerBase
        {
            foreach (var item in enterActions)
                obj.EnterActions.Add(item);
            return obj;
        }

        public static T EnterActions<T>(this T obj,
            params Microsoft.Maui.Controls.TriggerAction[] enterActions)
            where T : Microsoft.Maui.Controls.TriggerBase
        {
            foreach (var item in enterActions)
                obj.EnterActions.Add(item);
            return obj;
        }
        
        public static T ExitActions<T>(this T obj,
            IList<Microsoft.Maui.Controls.TriggerAction> exitActions)
            where T : Microsoft.Maui.Controls.TriggerBase
        {
            foreach (var item in exitActions)
                obj.ExitActions.Add(item);
            return obj;
        }

        public static T ExitActions<T>(this T obj,
            params Microsoft.Maui.Controls.TriggerAction[] exitActions)
            where T : Microsoft.Maui.Controls.TriggerBase
        {
            foreach (var item in exitActions)
                obj.ExitActions.Add(item);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
