﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class wrapping the sealed <c>Microsoft.Maui.Controls.VisualState</c> class.
    /// Use the <value>MauiObject</value> property to get the raw Maui object.
    /// </summary>
    public partial class VisualState : Sharp.UI.IVisualState, IMauiWrapper, ISealedMauiWrapper, IList<Microsoft.Maui.Controls.Setter>
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.VisualState MauiObject { get => (Microsoft.Maui.Controls.VisualState)_maui_RawObject; protected set => _maui_RawObject = value; }

        // ----- constructors -----

        public VisualState(Microsoft.Maui.Controls.VisualState visualState)
        {
            MauiObject = visualState;
        }

        // ----- operators -----

        public static implicit operator VisualState(Microsoft.Maui.Controls.VisualState mauiObject) => new VisualState(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.VisualState(VisualState obj) => obj.MauiObject;

        // ----- collection container -----

        public int Count => this.MauiObject.Setters.Count;
        public Microsoft.Maui.Controls.Setter this[int index] { get => this.MauiObject.Setters[index]; set => this.MauiObject.Setters[index] = value; }
        public bool IsReadOnly => false;
        public void Clear() => this.MauiObject.Setters.Clear();
        public bool Contains(Microsoft.Maui.Controls.Setter item) => this.MauiObject.Setters.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.Setter[] array, int arrayIndex) => this.MauiObject.Setters.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.Setter> GetEnumerator() => this.MauiObject.Setters.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.Setter item) => this.MauiObject.Setters.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.Setter item) => this.MauiObject.Setters.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.Setter item) => this.MauiObject.Setters.Remove(item);
        public void RemoveAt(int index) => this.MauiObject.Setters.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.MauiObject.Setters.GetEnumerator();

        public void Add(Func<Sharp.UI.VisualState, Sharp.UI.VisualState> configure) { configure(this); }

        public void Add(Microsoft.Maui.Controls.Setter setter) => this.MauiObject.Setters.Add(setter);

        public void Add(Action<IList<Microsoft.Maui.Controls.Setter>> builder)
        {
            List<Microsoft.Maui.Controls.Setter> items = new List<Microsoft.Maui.Controls.Setter>();
            builder(items);
            foreach (var item in items)
                this.MauiObject.Setters.Add(item);
        }

        // ----- properties / events -----

        public string Name { get => MauiObject.Name; set => MauiObject.Name = value; }
        public System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter> Setters { get => MauiObject.Setters; }
        public System.Collections.Generic.IList<Microsoft.Maui.Controls.StateTriggerBase> StateTriggers { get => MauiObject.StateTriggers; }
        public System.Type TargetType { get => MauiObject.TargetType; set => MauiObject.TargetType = value; }

    }
}

#pragma warning restore CS8669
