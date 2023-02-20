﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class MultiTriggerExtension
    {
        public static Microsoft.Maui.Controls.MultiTrigger Conditions(this Microsoft.Maui.Controls.MultiTrigger obj,
            IList<Microsoft.Maui.Controls.Condition> conditions)
        {
            foreach (var item in conditions)
                obj.Conditions.Add(item);
            return obj;
        }

        public static Microsoft.Maui.Controls.MultiTrigger Conditions(this Microsoft.Maui.Controls.MultiTrigger obj,
            params Microsoft.Maui.Controls.Condition[] conditions)
        {
            foreach (var item in conditions)
                obj.Conditions.Add(item);
            return obj;
        }
        
        public static Microsoft.Maui.Controls.MultiTrigger Setters(this Microsoft.Maui.Controls.MultiTrigger obj,
            IList<Microsoft.Maui.Controls.Setter> setters)
        {
            foreach (var item in setters)
                obj.Setters.Add(item);
            return obj;
        }

        public static Microsoft.Maui.Controls.MultiTrigger Setters(this Microsoft.Maui.Controls.MultiTrigger obj,
            params Microsoft.Maui.Controls.Setter[] setters)
        {
            foreach (var item in setters)
                obj.Setters.Add(item);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
