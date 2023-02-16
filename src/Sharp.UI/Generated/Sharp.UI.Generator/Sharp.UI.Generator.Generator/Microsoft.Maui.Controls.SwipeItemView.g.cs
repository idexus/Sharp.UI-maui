﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class SwipeItemViewGeneratedExtension
    {
        public static T Command<T>(this T obj,
            System.Windows.Input.ICommand command)
            where T : Sharp.UI.ISwipeItemView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItemView>(obj);
            mauiObject.Command = (System.Windows.Input.ICommand)command;
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Sharp.UI.ISwipeItemView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItemView>(obj);
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) mauiObject.Command = builder.GetValue();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
            where T : Sharp.UI.ISwipeItemView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItemView>(obj);
            var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.SwipeItemView.CommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            object commandParameter)
            where T : Sharp.UI.ISwipeItemView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItemView>(obj);
            mauiObject.CommandParameter = (object)commandParameter;
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Sharp.UI.ISwipeItemView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItemView>(obj);
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.CommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Sharp.UI.ISwipeItemView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItemView>(obj);
            var builder = buildBinding(new BindingBuilder<object>(mauiObject, Microsoft.Maui.Controls.SwipeItemView.CommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnInvoked<T>(this T obj, System.EventHandler<System.EventArgs> handler)
            where T : Sharp.UI.ISwipeItemView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItemView>(obj);
            mauiObject.Invoked += handler;
            return obj;
        }
        
        public static T OnInvoked<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISwipeItemView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItemView>(obj);
            mauiObject.Invoked += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
