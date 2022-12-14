﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class TapGestureRecognizer : Sharp.UI.ITapGestureRecognizer, ISealedMauiWrapper, IWrappedBindableObject
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.TapGestureRecognizer MauiObject { get => (Microsoft.Maui.Controls.TapGestureRecognizer)_maui_RawObject; set => _maui_RawObject = value; }

        // ----- constructors -----

        protected TapGestureRecognizer(Microsoft.Maui.Controls.TapGestureRecognizer tapGestureRecognizer)
        {
            MauiObject = tapGestureRecognizer;
        }

        public TapGestureRecognizer()
        {
            MauiObject = new Microsoft.Maui.Controls.TapGestureRecognizer();
        }

        public TapGestureRecognizer(out TapGestureRecognizer tapGestureRecognizer) : this()
        {
            tapGestureRecognizer = this;
        }

        public TapGestureRecognizer(System.Action<TapGestureRecognizer> configure) : this()
        {
            configure(this);
        }

        public TapGestureRecognizer(out TapGestureRecognizer tapGestureRecognizer, System.Action<TapGestureRecognizer> configure) : this()
        {
            tapGestureRecognizer = this;
            configure(this);
        }

        // ----- operators -----

        public static implicit operator TapGestureRecognizer(Microsoft.Maui.Controls.TapGestureRecognizer mauiObject) => new TapGestureRecognizer(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.TapGestureRecognizer(TapGestureRecognizer obj) => obj.MauiObject;

        // ----- bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty CommandProperty => Microsoft.Maui.Controls.TapGestureRecognizer.CommandProperty;
        public static Microsoft.Maui.Controls.BindableProperty CommandParameterProperty => Microsoft.Maui.Controls.TapGestureRecognizer.CommandParameterProperty;
        public static Microsoft.Maui.Controls.BindableProperty NumberOfTapsRequiredProperty => Microsoft.Maui.Controls.TapGestureRecognizer.NumberOfTapsRequiredProperty;
        public static Microsoft.Maui.Controls.BindableProperty ButtonsProperty => Microsoft.Maui.Controls.TapGestureRecognizer.ButtonsProperty;
        public static Microsoft.Maui.Controls.BindableProperty AutomationIdProperty => Microsoft.Maui.Controls.Element.AutomationIdProperty;
        public static Microsoft.Maui.Controls.BindableProperty ClassIdProperty => Microsoft.Maui.Controls.Element.ClassIdProperty;
        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public System.Windows.Input.ICommand? Command { get => MauiObject.Command; set => MauiObject.Command = value; }
        public object? CommandParameter { get => MauiObject.CommandParameter; set => MauiObject.CommandParameter = value; }
        public int NumberOfTapsRequired { get => MauiObject.NumberOfTapsRequired; set => MauiObject.NumberOfTapsRequired = value; }
        public Microsoft.Maui.Controls.ButtonsMask Buttons { get => MauiObject.Buttons; set => MauiObject.Buttons = value; }
        public event System.EventHandler<Microsoft.Maui.Controls.TappedEventArgs>? Tapped { add => MauiObject.Tapped += value; remove => MauiObject.Tapped -= value; }
        public string AutomationId { get => MauiObject.AutomationId; set => MauiObject.AutomationId = value; }
        public string ClassId { get => MauiObject.ClassId; set => MauiObject.ClassId = value; }
        public System.Collections.Generic.IList<Microsoft.Maui.Controls.Effect> Effects { get => MauiObject.Effects; }
        public System.Guid Id { get => MauiObject.Id; }
        public string StyleId { get => MauiObject.StyleId; set => MauiObject.StyleId = value; }
        public Microsoft.Maui.Controls.Element RealParent { get => MauiObject.RealParent; }
        public Microsoft.Maui.Controls.Element Parent { get => MauiObject.Parent; set => MauiObject.Parent = value; }
        public Microsoft.Maui.Controls.IEffectControlProvider EffectControlProvider { get => MauiObject.EffectControlProvider; set => MauiObject.EffectControlProvider = value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> ChildAdded { add => MauiObject.ChildAdded += value; remove => MauiObject.ChildAdded -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> ChildRemoved { add => MauiObject.ChildRemoved += value; remove => MauiObject.ChildRemoved -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> DescendantAdded { add => MauiObject.DescendantAdded += value; remove => MauiObject.DescendantAdded -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> DescendantRemoved { add => MauiObject.DescendantRemoved += value; remove => MauiObject.DescendantRemoved -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ParentChangingEventArgs> ParentChanging { add => MauiObject.ParentChanging += value; remove => MauiObject.ParentChanging -= value; }
        public event System.EventHandler ParentChanged { add => MauiObject.ParentChanged += value; remove => MauiObject.ParentChanged -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.HandlerChangingEventArgs> HandlerChanging { add => MauiObject.HandlerChanging += value; remove => MauiObject.HandlerChanging -= value; }
        public event System.EventHandler HandlerChanged { add => MauiObject.HandlerChanged += value; remove => MauiObject.HandlerChanged -= value; }
        public Microsoft.Maui.Dispatching.IDispatcher Dispatcher { get => MauiObject.Dispatcher; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add => MauiObject.PropertyChanged += value; remove => MauiObject.PropertyChanged -= value; }
        public event Microsoft.Maui.Controls.PropertyChangingEventHandler PropertyChanging { add => MauiObject.PropertyChanging += value; remove => MauiObject.PropertyChanging -= value; }
        public event System.EventHandler BindingContextChanged { add => MauiObject.BindingContextChanged += value; remove => MauiObject.BindingContextChanged -= value; }
        // ----- binding context -----

        public object BindingContext
        {
            get => MauiObject.BindingContext;
            set
            {
                var mauiObject = MauiWrapper.GetObject<object>(value);
                MauiObject.BindingContext = mauiObject;
            }
        }
        

    }
}

#pragma warning restore CS8669
