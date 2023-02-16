﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class wrapping the sealed <c>Microsoft.Maui.Controls.PointerGestureRecognizer</c> class.
    /// Use the <value>MauiObject</value> property to get the raw Maui object.
    /// </summary>
    public partial class PointerGestureRecognizer : Sharp.UI.IPointerGestureRecognizer, IMauiWrapper, ISealedMauiWrapper
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.PointerGestureRecognizer MauiObject { get => (Microsoft.Maui.Controls.PointerGestureRecognizer)_maui_RawObject; protected set => _maui_RawObject = value; }

        // ----- constructors -----

        public PointerGestureRecognizer(Microsoft.Maui.Controls.PointerGestureRecognizer pointerGestureRecognizer)
        {
            MauiObject = pointerGestureRecognizer;
        }

        public PointerGestureRecognizer()
        {
            MauiObject = new Microsoft.Maui.Controls.PointerGestureRecognizer();
        }

        // ----- operators -----

        public static implicit operator PointerGestureRecognizer(Microsoft.Maui.Controls.PointerGestureRecognizer mauiObject) => new PointerGestureRecognizer(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.PointerGestureRecognizer(PointerGestureRecognizer obj) => obj.MauiObject;

        // ----- sealed bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty PointerEnteredCommandProperty => Microsoft.Maui.Controls.PointerGestureRecognizer.PointerEnteredCommandProperty;
        public static Microsoft.Maui.Controls.BindableProperty PointerEnteredCommandParameterProperty => Microsoft.Maui.Controls.PointerGestureRecognizer.PointerEnteredCommandParameterProperty;
        public static Microsoft.Maui.Controls.BindableProperty PointerExitedCommandProperty => Microsoft.Maui.Controls.PointerGestureRecognizer.PointerExitedCommandProperty;
        public static Microsoft.Maui.Controls.BindableProperty PointerExitedCommandParameterProperty => Microsoft.Maui.Controls.PointerGestureRecognizer.PointerExitedCommandParameterProperty;
        public static Microsoft.Maui.Controls.BindableProperty PointerMovedCommandProperty => Microsoft.Maui.Controls.PointerGestureRecognizer.PointerMovedCommandProperty;
        public static Microsoft.Maui.Controls.BindableProperty PointerMovedCommandParameterProperty => Microsoft.Maui.Controls.PointerGestureRecognizer.PointerMovedCommandParameterProperty;
        public static Microsoft.Maui.Controls.BindableProperty AutomationIdProperty => Microsoft.Maui.Controls.Element.AutomationIdProperty;
        public static Microsoft.Maui.Controls.BindableProperty ClassIdProperty => Microsoft.Maui.Controls.Element.ClassIdProperty;
        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public System.Windows.Input.ICommand PointerEnteredCommand { get => MauiObject.PointerEnteredCommand; set => MauiObject.PointerEnteredCommand = value; }
        public System.Windows.Input.ICommand PointerEnteredCommandParameter { get => MauiObject.PointerEnteredCommandParameter; set => MauiObject.PointerEnteredCommandParameter = value; }
        public System.Windows.Input.ICommand PointerExitedCommand { get => MauiObject.PointerExitedCommand; set => MauiObject.PointerExitedCommand = value; }
        public System.Windows.Input.ICommand PointerExitedCommandParameter { get => MauiObject.PointerExitedCommandParameter; set => MauiObject.PointerExitedCommandParameter = value; }
        public System.Windows.Input.ICommand PointerMovedCommand { get => MauiObject.PointerMovedCommand; set => MauiObject.PointerMovedCommand = value; }
        public System.Windows.Input.ICommand PointerMovedCommandParameter { get => MauiObject.PointerMovedCommandParameter; set => MauiObject.PointerMovedCommandParameter = value; }
        public string AutomationId { get => MauiObject.AutomationId; set => MauiObject.AutomationId = value; }
        public string ClassId { get => MauiObject.ClassId; set => MauiObject.ClassId = value; }
        public System.Collections.Generic.IList<Microsoft.Maui.Controls.Effect> Effects { get => MauiObject.Effects; }
        public System.Guid Id { get => MauiObject.Id; }
        public string StyleId { get => MauiObject.StyleId; set => MauiObject.StyleId = value; }
        public Microsoft.Maui.Controls.Element RealParent { get => MauiObject.RealParent; }
        public Microsoft.Maui.Controls.Element Parent { get => MauiObject.Parent; set => MauiObject.Parent = value; }
        public Microsoft.Maui.Controls.IEffectControlProvider EffectControlProvider { get => MauiObject.EffectControlProvider; set => MauiObject.EffectControlProvider = value; }
        public Microsoft.Maui.Dispatching.IDispatcher Dispatcher { get => MauiObject.Dispatcher; }
        public object BindingContext { get => MauiObject.BindingContext; set => MauiObject.BindingContext = MauiWrapper.Value<object>(value); }
        public event System.EventHandler<Microsoft.Maui.Controls.PointerEventArgs>? PointerEntered { add => MauiObject.PointerEntered += value; remove => MauiObject.PointerEntered -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.PointerEventArgs>? PointerExited { add => MauiObject.PointerExited += value; remove => MauiObject.PointerExited -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.PointerEventArgs>? PointerMoved { add => MauiObject.PointerMoved += value; remove => MauiObject.PointerMoved -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> ChildAdded { add => MauiObject.ChildAdded += value; remove => MauiObject.ChildAdded -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> ChildRemoved { add => MauiObject.ChildRemoved += value; remove => MauiObject.ChildRemoved -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> DescendantAdded { add => MauiObject.DescendantAdded += value; remove => MauiObject.DescendantAdded -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> DescendantRemoved { add => MauiObject.DescendantRemoved += value; remove => MauiObject.DescendantRemoved -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ParentChangingEventArgs> ParentChanging { add => MauiObject.ParentChanging += value; remove => MauiObject.ParentChanging -= value; }
        public event System.EventHandler ParentChanged { add => MauiObject.ParentChanged += value; remove => MauiObject.ParentChanged -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.HandlerChangingEventArgs> HandlerChanging { add => MauiObject.HandlerChanging += value; remove => MauiObject.HandlerChanging -= value; }
        public event System.EventHandler HandlerChanged { add => MauiObject.HandlerChanged += value; remove => MauiObject.HandlerChanged -= value; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add => MauiObject.PropertyChanged += value; remove => MauiObject.PropertyChanged -= value; }
        public event Microsoft.Maui.Controls.PropertyChangingEventHandler PropertyChanging { add => MauiObject.PropertyChanging += value; remove => MauiObject.PropertyChanging -= value; }
        public event System.EventHandler BindingContextChanged { add => MauiObject.BindingContextChanged += value; remove => MauiObject.BindingContextChanged -= value; }

        // ----- set value method -----

        public void SetValue(Microsoft.Maui.Controls.BindableProperty property, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            MauiObject.SetValue(property, mauiValue);
        }

        public void SetValue(Microsoft.Maui.Controls.BindablePropertyKey propertyKey, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            MauiObject.SetValue(propertyKey, mauiValue);
        }
    }
}

#pragma warning restore CS8669
