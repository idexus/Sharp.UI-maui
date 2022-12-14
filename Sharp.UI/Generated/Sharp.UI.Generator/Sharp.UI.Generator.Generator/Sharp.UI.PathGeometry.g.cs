﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class PathGeometry : Sharp.UI.IPathGeometry, ISealedMauiWrapper, IList<Microsoft.Maui.Controls.Shapes.PathFigure>, IWrappedBindableObject
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.Shapes.PathGeometry MauiObject { get => (Microsoft.Maui.Controls.Shapes.PathGeometry)_maui_RawObject; set => _maui_RawObject = value; }

        // ----- constructors -----

        protected PathGeometry(Microsoft.Maui.Controls.Shapes.PathGeometry pathGeometry)
        {
            MauiObject = pathGeometry;
        }

        public PathGeometry()
        {
            MauiObject = new Microsoft.Maui.Controls.Shapes.PathGeometry();
        }

        public PathGeometry(out PathGeometry pathGeometry) : this()
        {
            pathGeometry = this;
        }

        public PathGeometry(System.Action<PathGeometry> configure) : this()
        {
            configure(this);
        }

        public PathGeometry(out PathGeometry pathGeometry, System.Action<PathGeometry> configure) : this()
        {
            pathGeometry = this;
            configure(this);
        }

        // ----- operators -----

        public static implicit operator PathGeometry(Microsoft.Maui.Controls.Shapes.PathGeometry mauiObject) => new PathGeometry(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.Shapes.PathGeometry(PathGeometry obj) => obj.MauiObject;

        // ----- collection container -----

        public int Count => this.MauiObject.Figures.Count;
        public Microsoft.Maui.Controls.Shapes.PathFigure this[int index] { get => this.MauiObject.Figures[index]; set => this.MauiObject.Figures[index] = value; }
        public bool IsReadOnly => false;
        public void Add(Microsoft.Maui.Controls.Shapes.PathFigure item) => this.MauiObject.Figures.Add(item);
        public void Clear() => this.MauiObject.Figures.Clear();
        public bool Contains(Microsoft.Maui.Controls.Shapes.PathFigure item) => this.MauiObject.Figures.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.Shapes.PathFigure[] array, int arrayIndex) => this.MauiObject.Figures.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.Shapes.PathFigure> GetEnumerator() => this.MauiObject.Figures.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.Shapes.PathFigure item) => this.MauiObject.Figures.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.Shapes.PathFigure item) => this.MauiObject.Figures.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.Shapes.PathFigure item) => this.MauiObject.Figures.Remove(item);
        public void RemoveAt(int index) => this.MauiObject.Figures.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.MauiObject.Figures.GetEnumerator();

        // ----- bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty FiguresProperty => Microsoft.Maui.Controls.Shapes.PathGeometry.FiguresProperty;
        public static Microsoft.Maui.Controls.BindableProperty FillRuleProperty => Microsoft.Maui.Controls.Shapes.PathGeometry.FillRuleProperty;
        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public Microsoft.Maui.Controls.Shapes.PathFigureCollection Figures { get => MauiObject.Figures; set => MauiObject.Figures = value; }
        public Microsoft.Maui.Controls.Shapes.FillRule FillRule { get => MauiObject.FillRule; set => MauiObject.FillRule = value; }
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
