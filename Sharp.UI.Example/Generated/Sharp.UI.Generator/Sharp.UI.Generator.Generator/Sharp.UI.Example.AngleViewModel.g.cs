﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI.Example
{  
    using Sharp.UI;

    public partial class AngleViewModel
    {
        // ----- constructors -----

        public AngleViewModel() { }

        public AngleViewModel(out AngleViewModel angleViewModel) 
        {
            angleViewModel = this;
        }

        public AngleViewModel(System.Action<AngleViewModel> configure) 
        {
            configure(this);
        }

        public AngleViewModel(out AngleViewModel angleViewModel, System.Action<AngleViewModel> configure) 
        {
            angleViewModel = this;
            configure(this);
        }

        // ----- bindable properties -----

        public static readonly Microsoft.Maui.Controls.BindableProperty RawAngleProperty =
            BindableProperty.Create(
                nameof(RawAngle),
                typeof(double),
                typeof(Sharp.UI.Example.AngleViewModel),
                default(double),
                propertyChanged: OnAngleChanged);

        public double RawAngle
        {
            get => (double)GetValue(RawAngleProperty);
            set => SetValue(RawAngleProperty, value);
        }
        
        public static readonly Microsoft.Maui.Controls.BindableProperty AngleProperty =
            BindableProperty.Create(
                nameof(Angle),
                typeof(double),
                typeof(Sharp.UI.Example.AngleViewModel),
                default(double),
                coerceValue: CoerceAngle);

        public double Angle
        {
            get => (double)GetValue(AngleProperty);
            set => SetValue(AngleProperty, value);
        }
        
        public static readonly Microsoft.Maui.Controls.BindableProperty MaximumAngleProperty =
            BindableProperty.Create(
                nameof(MaximumAngle),
                typeof(double),
                typeof(Sharp.UI.Example.AngleViewModel),
                (double)360);

        public double MaximumAngle
        {
            get => (double)GetValue(MaximumAngleProperty);
            set => SetValue(MaximumAngleProperty, value);
        }
        
        // ----- set value method -----

        public new void SetValue(Microsoft.Maui.Controls.BindableProperty property, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            ((Microsoft.Maui.Controls.BindableObject)this).SetValue(property, mauiValue);
        }

        public new void SetValue(Microsoft.Maui.Controls.BindablePropertyKey propertyKey, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            ((Microsoft.Maui.Controls.BindableObject)this).SetValue(propertyKey, mauiValue);
        }
    }
}

#pragma warning restore CS8669
