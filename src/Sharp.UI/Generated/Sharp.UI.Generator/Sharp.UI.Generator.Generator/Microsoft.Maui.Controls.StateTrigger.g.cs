﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class StateTriggerGeneratedExtension
    {
        public static T IsActive<T>(this T obj,
            bool isActive)
            where T : Sharp.UI.IStateTrigger
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.StateTrigger>(obj);
            mauiObject.IsActive = (bool)isActive;
            return obj;
        }
        
        public static T IsActive<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IStateTrigger
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.StateTrigger>(obj);
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.IsActive = builder.GetValue();
            return obj;
        }
        
        public static T IsActive<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Sharp.UI.IStateTrigger
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.StateTrigger>(obj);
            var builder = buildBinding(new BindingBuilder<bool>(mauiObject, Microsoft.Maui.Controls.StateTrigger.IsActiveProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
