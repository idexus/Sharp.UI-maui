﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class BezierSegment : Microsoft.Maui.Controls.Shapes.BezierSegment, Sharp.UI.IBezierSegment, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public BezierSegment() { }


        public BezierSegment(out BezierSegment bezierSegment) 
        {
            bezierSegment = this;
        }

        public BezierSegment(Action<BezierSegment> configure) 
        {
            configure(this);
        }

        public BezierSegment(out BezierSegment bezierSegment, Action<BezierSegment> configure) 
        {
            bezierSegment = this;
            configure(this);
        }

        // ----- binding context -----

        public new object BindingContext
        {
            get => base.BindingContext;
            set
            {
                var mauiObject = MauiWrapper.GetObject<object>(value);
                base.BindingContext = mauiObject;
            }
        }
        

    }
    
}

#pragma warning restore CS0108
#pragma warning restore CS8625
#pragma warning restore CS8669
