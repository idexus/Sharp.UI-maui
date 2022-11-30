﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class QuadraticBezierSegment : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment, Sharp.UI.IQuadraticBezierSegment, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public QuadraticBezierSegment() { }


        public QuadraticBezierSegment(out QuadraticBezierSegment quadraticBezierSegment) 
        {
            quadraticBezierSegment = this;
        }

        public QuadraticBezierSegment(Action<QuadraticBezierSegment> configure) 
        {
            configure(this);
        }

        public QuadraticBezierSegment(out QuadraticBezierSegment quadraticBezierSegment, Action<QuadraticBezierSegment> configure) 
        {
            quadraticBezierSegment = this;
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
