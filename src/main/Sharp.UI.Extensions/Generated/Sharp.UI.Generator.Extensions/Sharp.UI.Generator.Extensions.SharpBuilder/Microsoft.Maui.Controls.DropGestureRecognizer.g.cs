﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class DropGestureRecognizerExtension
    {
        public static T AllowDrop<T>(this T obj,
            bool allowDrop)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            obj.AllowDrop = allowDrop;
            return obj;
        }
        
        public static T AllowDrop<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.AllowDrop = builder.GetValue();
            return obj;
        }
        
        public static T AllowDrop<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.DropGestureRecognizer.AllowDropProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T DragOverCommand<T>(this T obj,
            System.Windows.Input.ICommand dragOverCommand)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            obj.DragOverCommand = dragOverCommand;
            return obj;
        }
        
        public static T DragOverCommand<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buidValue)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buidValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) obj.DragOverCommand = builder.GetValue();
            return obj;
        }
        
        public static T DragOverCommand<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buidBinding)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buidBinding(new BindingBuilder<System.Windows.Input.ICommand>(obj, Microsoft.Maui.Controls.DropGestureRecognizer.DragOverCommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T DragOverCommandParameter<T>(this T obj,
            object dragOverCommandParameter)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            obj.DragOverCommandParameter = dragOverCommandParameter;
            return obj;
        }
        
        public static T DragOverCommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.DragOverCommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T DragOverCommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.DropGestureRecognizer.DragOverCommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T DragLeaveCommand<T>(this T obj,
            System.Windows.Input.ICommand dragLeaveCommand)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            obj.DragLeaveCommand = dragLeaveCommand;
            return obj;
        }
        
        public static T DragLeaveCommand<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buidValue)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buidValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) obj.DragLeaveCommand = builder.GetValue();
            return obj;
        }
        
        public static T DragLeaveCommand<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buidBinding)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buidBinding(new BindingBuilder<System.Windows.Input.ICommand>(obj, Microsoft.Maui.Controls.DropGestureRecognizer.DragLeaveCommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T DragLeaveCommandParameter<T>(this T obj,
            object dragLeaveCommandParameter)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            obj.DragLeaveCommandParameter = dragLeaveCommandParameter;
            return obj;
        }
        
        public static T DragLeaveCommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.DragLeaveCommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T DragLeaveCommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.DropGestureRecognizer.DragLeaveCommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T DropCommand<T>(this T obj,
            System.Windows.Input.ICommand dropCommand)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            obj.DropCommand = dropCommand;
            return obj;
        }
        
        public static T DropCommand<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buidValue)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buidValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) obj.DropCommand = builder.GetValue();
            return obj;
        }
        
        public static T DropCommand<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buidBinding)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buidBinding(new BindingBuilder<System.Windows.Input.ICommand>(obj, Microsoft.Maui.Controls.DropGestureRecognizer.DropCommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T DropCommandParameter<T>(this T obj,
            object dropCommandParameter)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            obj.DropCommandParameter = dropCommandParameter;
            return obj;
        }
        
        public static T DropCommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.DropCommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T DropCommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.DropGestureRecognizer.DropCommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnDragLeave<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.DragEventArgs> handler)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            obj.DragLeave += handler;
            return obj;
        }
        
        public static T OnDragLeave<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            obj.DragLeave += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnDragOver<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.DragEventArgs> handler)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            obj.DragOver += handler;
            return obj;
        }
        
        public static T OnDragOver<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            obj.DragOver += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnDrop<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.DropEventArgs> handler)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            obj.Drop += handler;
            return obj;
        }
        
        public static T OnDrop<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            obj.Drop += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
