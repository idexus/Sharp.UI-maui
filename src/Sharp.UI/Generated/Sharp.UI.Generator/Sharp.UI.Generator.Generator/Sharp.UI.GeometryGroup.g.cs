﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.Shapes.GeometryGroup</c> class.
    /// </summary>
    public partial class GeometryGroup : Microsoft.Maui.Controls.Shapes.GeometryGroup, Sharp.UI.IGeometryGroup, IMauiWrapper, IList<Microsoft.Maui.Controls.Shapes.Geometry>
    {
        // ----- constructors -----

        public GeometryGroup() { }

        public GeometryGroup(out GeometryGroup geometryGroup) 
        {
            geometryGroup = this;
        }

        [Obsolete("This constructor is deprecated, use e=>e.FluentMethod(), inside curly braces.")]
        public GeometryGroup(System.Action<GeometryGroup> configure) 
        {
            configure(this);
        }

        [Obsolete("This constructor is deprecated, use e=>e.Assign(out symbol).OtherFluentMethod(), inside curly braces.")]
        public GeometryGroup(out GeometryGroup geometryGroup, System.Action<GeometryGroup> configure) 
        {
            geometryGroup = this;
            configure(this);
        }

        // ----- collection container -----

        public int Count => this.Children.Count;
        public Microsoft.Maui.Controls.Shapes.Geometry this[int index] { get => this.Children[index]; set => this.Children[index] = value; }
        public bool IsReadOnly => false;
        public void Clear() => this.Children.Clear();
        public bool Contains(Microsoft.Maui.Controls.Shapes.Geometry item) => this.Children.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.Shapes.Geometry[] array, int arrayIndex) => this.Children.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.Shapes.Geometry> GetEnumerator() => this.Children.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.Shapes.Geometry item) => this.Children.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.Shapes.Geometry item) => this.Children.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.Shapes.Geometry item) => this.Children.Remove(item);
        public void RemoveAt(int index) => this.Children.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.Children.GetEnumerator();

        public void Add(Func<Sharp.UI.GeometryGroup, Sharp.UI.GeometryGroup> configure) { configure(this); }

        public void Add(Microsoft.Maui.Controls.Shapes.Geometry geometry) => this.Children.Add(geometry);

        public void Add(Action<IList<Microsoft.Maui.Controls.Shapes.Geometry>> builder)
        {
            List<Microsoft.Maui.Controls.Shapes.Geometry> items = new List<Microsoft.Maui.Controls.Shapes.Geometry>();
            builder(items);
            foreach (var item in items)
                this.Children.Add(item);
        }

        // ----- properties / events -----

        public new object BindingContext { get => base.BindingContext; set => base.BindingContext = MauiWrapper.Value<object>(value); }

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
