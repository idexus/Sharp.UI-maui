﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class AdaptiveTrigger : Sharp.UI.IAdaptiveTrigger, ISealedMauiWrapper, IWrappedBindableObject
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.AdaptiveTrigger MauiObject { get => (Microsoft.Maui.Controls.AdaptiveTrigger)_maui_RawObject; set => _maui_RawObject = value; }

        // ----- constructors -----

        protected AdaptiveTrigger(Microsoft.Maui.Controls.AdaptiveTrigger adaptiveTrigger)
        {
            MauiObject = adaptiveTrigger;
        }

        public AdaptiveTrigger()
        {
            MauiObject = new Microsoft.Maui.Controls.AdaptiveTrigger();
        }

        public AdaptiveTrigger(out AdaptiveTrigger adaptiveTrigger) : this()
        {
            adaptiveTrigger = this;
        }

        public AdaptiveTrigger(System.Action<AdaptiveTrigger> configure) : this()
        {
            configure(this);
        }

        public AdaptiveTrigger(out AdaptiveTrigger adaptiveTrigger, System.Action<AdaptiveTrigger> configure) : this()
        {
            adaptiveTrigger = this;
            configure(this);
        }

        // ----- operators -----

        public static implicit operator AdaptiveTrigger(Microsoft.Maui.Controls.AdaptiveTrigger mauiObject) => new AdaptiveTrigger(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.AdaptiveTrigger(AdaptiveTrigger obj) => obj.MauiObject;

        // ----- bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty MinWindowHeightProperty => Microsoft.Maui.Controls.AdaptiveTrigger.MinWindowHeightProperty;
        public static Microsoft.Maui.Controls.BindableProperty MinWindowWidthProperty => Microsoft.Maui.Controls.AdaptiveTrigger.MinWindowWidthProperty;
        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public double MinWindowHeight { get => MauiObject.MinWindowHeight; set => MauiObject.MinWindowHeight = value; }
        public double MinWindowWidth { get => MauiObject.MinWindowWidth; set => MauiObject.MinWindowWidth = value; }
        public bool IsActive { get => MauiObject.IsActive; }
        public bool IsAttached { get => MauiObject.IsAttached; }
        public event System.EventHandler IsActiveChanged { add => MauiObject.IsActiveChanged += value; remove => MauiObject.IsActiveChanged -= value; }
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
