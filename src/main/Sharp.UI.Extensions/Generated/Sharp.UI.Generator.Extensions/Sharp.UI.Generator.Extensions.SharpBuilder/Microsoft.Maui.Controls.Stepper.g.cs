﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class StepperExtension
    {
        public static T Increment<T>(this T self,
            double increment)
            where T : Microsoft.Maui.Controls.Stepper
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Stepper.IncrementProperty, increment);
            return self;
        }
        
        public static T Increment<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Stepper.IncrementProperty, builder.GetValue());
            return self;
        }
        
        public static T Increment<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Stepper.IncrementProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Task<bool> AnimateIncrementTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Stepper
        {
            double fromValue = self.Increment;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.Increment = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateIncrementTo", transform, callback, length, easing);
        }
        
        public static T Maximum<T>(this T self,
            double maximum)
            where T : Microsoft.Maui.Controls.Stepper
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Stepper.MaximumProperty, maximum);
            return self;
        }
        
        public static T Maximum<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Stepper.MaximumProperty, builder.GetValue());
            return self;
        }
        
        public static T Maximum<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Stepper.MaximumProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Task<bool> AnimateMaximumTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Stepper
        {
            double fromValue = self.Maximum;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.Maximum = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateMaximumTo", transform, callback, length, easing);
        }
        
        public static T Minimum<T>(this T self,
            double minimum)
            where T : Microsoft.Maui.Controls.Stepper
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Stepper.MinimumProperty, minimum);
            return self;
        }
        
        public static T Minimum<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Stepper.MinimumProperty, builder.GetValue());
            return self;
        }
        
        public static T Minimum<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Stepper.MinimumProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Task<bool> AnimateMinimumTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Stepper
        {
            double fromValue = self.Minimum;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.Minimum = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateMinimumTo", transform, callback, length, easing);
        }
        
        public static T Value<T>(this T self,
            double value)
            where T : Microsoft.Maui.Controls.Stepper
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Stepper.ValueProperty, value);
            return self;
        }
        
        public static T Value<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Stepper.ValueProperty, builder.GetValue());
            return self;
        }
        
        public static T Value<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Stepper
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Stepper.ValueProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Task<bool> AnimateValueTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Stepper
        {
            double fromValue = self.Value;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.Value = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateValueTo", transform, callback, length, easing);
        }
        
        public static T OnValueChanged<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ValueChangedEventArgs> handler)
            where T : Microsoft.Maui.Controls.Stepper
        {
            self.ValueChanged += handler;
            return self;
        }
        
        public static T OnValueChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Stepper
        {
            self.ValueChanged += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
