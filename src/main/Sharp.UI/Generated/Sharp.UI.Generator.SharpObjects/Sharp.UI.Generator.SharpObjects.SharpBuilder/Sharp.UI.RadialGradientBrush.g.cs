﻿//
// <auto-generated>
//

#nullable enable


using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace Sharp.UI
{
	using Sharp.UI;

    public partial class RadialGradientBrush : IList<Microsoft.Maui.Controls.GradientStop>
	{

        // ----- constructors -----

        public RadialGradientBrush() { }

        public RadialGradientBrush(out RadialGradientBrush radialGradientBrush) 
        {
            radialGradientBrush = this;
        }

        public RadialGradientBrush(System.Func<RadialGradientBrush, RadialGradientBrush> configure) 
        {
            configure(this);
        }

        public RadialGradientBrush(out RadialGradientBrush radialGradientBrush, System.Func<RadialGradientBrush, RadialGradientBrush> configure) 
        {
            radialGradientBrush = this;
            configure(this);
        }

        public RadialGradientBrush(Microsoft.Maui.Graphics.Point center, out RadialGradientBrush radialGradientBrush) : this(center)
        {
            radialGradientBrush = this;
        }

        public RadialGradientBrush(Microsoft.Maui.Graphics.Point center, System.Func<RadialGradientBrush, RadialGradientBrush> configure) : this(center)
        {
            configure(this);
        }

        public RadialGradientBrush(Microsoft.Maui.Graphics.Point center, out RadialGradientBrush radialGradientBrush, System.Func<RadialGradientBrush, RadialGradientBrush> configure) : this(center)
        {
            radialGradientBrush = this;
            configure(this);
        }

        // ----- collection container -----

        public int Count => this.GradientStops.Count;
        public Microsoft.Maui.Controls.GradientStop this[int index] { get => this.GradientStops[index]; set => this.GradientStops[index] = value; }
        public bool IsReadOnly => false;
        public void Clear() => this.GradientStops.Clear();
        public bool Contains(Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.GradientStop[] array, int arrayIndex) => this.GradientStops.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.GradientStop> GetEnumerator() => this.GradientStops.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.Remove(item);
        public void RemoveAt(int index) => this.GradientStops.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.GradientStops.GetEnumerator();
        public void Add(Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.Add(item);

    }
}

#nullable restore
