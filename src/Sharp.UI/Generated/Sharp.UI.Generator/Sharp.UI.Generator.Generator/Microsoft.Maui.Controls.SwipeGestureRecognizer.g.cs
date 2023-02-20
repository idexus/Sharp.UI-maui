﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class SwipeGestureRecognizerExtension
    {
        public static Microsoft.Maui.Controls.SwipeGestureRecognizer Command(this Microsoft.Maui.Controls.SwipeGestureRecognizer obj,
            System.Windows.Input.ICommand command)
        {
            obj.Command = command;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.SwipeGestureRecognizer Command(this Microsoft.Maui.Controls.SwipeGestureRecognizer obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) obj.Command = builder.GetValue();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.SwipeGestureRecognizer Command(this Microsoft.Maui.Controls.SwipeGestureRecognizer obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<System.Windows.Input.ICommand>(obj, Microsoft.Maui.Controls.SwipeGestureRecognizer.CommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.SwipeGestureRecognizer CommandParameter(this Microsoft.Maui.Controls.SwipeGestureRecognizer obj,
            object commandParameter)
        {
            obj.CommandParameter = commandParameter;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.SwipeGestureRecognizer CommandParameter(this Microsoft.Maui.Controls.SwipeGestureRecognizer obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.CommandParameter = builder.GetValue();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.SwipeGestureRecognizer CommandParameter(this Microsoft.Maui.Controls.SwipeGestureRecognizer obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.SwipeGestureRecognizer.CommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.SwipeGestureRecognizer Direction(this Microsoft.Maui.Controls.SwipeGestureRecognizer obj,
            Microsoft.Maui.SwipeDirection direction)
        {
            obj.Direction = direction;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.SwipeGestureRecognizer Direction(this Microsoft.Maui.Controls.SwipeGestureRecognizer obj,
            System.Func<ValueBuilder<Microsoft.Maui.SwipeDirection>, ValueBuilder<Microsoft.Maui.SwipeDirection>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.SwipeDirection>());
            if (builder.ValueIsSet()) obj.Direction = builder.GetValue();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.SwipeGestureRecognizer Direction(this Microsoft.Maui.Controls.SwipeGestureRecognizer obj,
            System.Func<BindingBuilder<Microsoft.Maui.SwipeDirection>, BindingBuilder<Microsoft.Maui.SwipeDirection>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.SwipeDirection>(obj, Microsoft.Maui.Controls.SwipeGestureRecognizer.DirectionProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.SwipeGestureRecognizer Threshold(this Microsoft.Maui.Controls.SwipeGestureRecognizer obj,
            uint threshold)
        {
            obj.Threshold = threshold;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.SwipeGestureRecognizer Threshold(this Microsoft.Maui.Controls.SwipeGestureRecognizer obj,
            System.Func<ValueBuilder<uint>, ValueBuilder<uint>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<uint>());
            if (builder.ValueIsSet()) obj.Threshold = builder.GetValue();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.SwipeGestureRecognizer Threshold(this Microsoft.Maui.Controls.SwipeGestureRecognizer obj,
            System.Func<BindingBuilder<uint>, BindingBuilder<uint>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<uint>(obj, Microsoft.Maui.Controls.SwipeGestureRecognizer.ThresholdProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.SwipeGestureRecognizer OnSwiped(this Microsoft.Maui.Controls.SwipeGestureRecognizer obj, System.EventHandler<Microsoft.Maui.Controls.SwipedEventArgs> handler)
        {
            obj.Swiped += handler;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.SwipeGestureRecognizer OnSwiped(this Microsoft.Maui.Controls.SwipeGestureRecognizer obj, System.Action<Microsoft.Maui.Controls.SwipeGestureRecognizer> action)
        {
            obj.Swiped += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
