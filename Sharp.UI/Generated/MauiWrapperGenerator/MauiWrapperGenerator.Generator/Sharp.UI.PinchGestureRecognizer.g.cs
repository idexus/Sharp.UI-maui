﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class PinchGestureRecognizer : Sharp.UI.IPinchGestureRecognizer, ISealedMauiWrapper, IWrappedBindableObject
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.PinchGestureRecognizer MauiObject { get => (Microsoft.Maui.Controls.PinchGestureRecognizer)_maui_RawObject; set => _maui_RawObject = value; }

        // ----- constructors -----
        

        internal PinchGestureRecognizer(Microsoft.Maui.Controls.PinchGestureRecognizer pinchGestureRecognizer)
        {
            MauiObject = pinchGestureRecognizer;
        }

        public PinchGestureRecognizer()
        {
            MauiObject = new Microsoft.Maui.Controls.PinchGestureRecognizer();
        }


        public PinchGestureRecognizer(out PinchGestureRecognizer pinchGestureRecognizer) : this()
        {
            pinchGestureRecognizer = this;
        }

        public PinchGestureRecognizer(Action<PinchGestureRecognizer> configure) : this()
        {
            configure(this);
        }

        public PinchGestureRecognizer(out PinchGestureRecognizer pinchGestureRecognizer, Action<PinchGestureRecognizer> configure) : this()
        {
            pinchGestureRecognizer = this;
            configure(this);
        }

        // ----- operators -----

        public static implicit operator PinchGestureRecognizer(Microsoft.Maui.Controls.PinchGestureRecognizer mauiObject) => new PinchGestureRecognizer(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.PinchGestureRecognizer(PinchGestureRecognizer obj) => obj.MauiObject;

        // ----- bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty AutomationIdProperty => Microsoft.Maui.Controls.Element.AutomationIdProperty;
        public static Microsoft.Maui.Controls.BindableProperty ClassIdProperty => Microsoft.Maui.Controls.Element.ClassIdProperty;
        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public event System.EventHandler<Microsoft.Maui.Controls.PinchGestureUpdatedEventArgs> PinchUpdated { add => MauiObject.PinchUpdated += value; remove => MauiObject.PinchUpdated -= value; }
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

#pragma warning restore CS0108
#pragma warning restore CS8625
#pragma warning restore CS8669
