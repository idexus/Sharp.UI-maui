﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class GraphicsView : Microsoft.Maui.Controls.GraphicsView, Sharp.UI.IGraphicsView, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public GraphicsView() { }


        public GraphicsView(out GraphicsView graphicsView) 
        {
            graphicsView = this;
        }

        public GraphicsView(Action<GraphicsView> configure) 
        {
            configure(this);
        }

        public GraphicsView(out GraphicsView graphicsView, Action<GraphicsView> configure) 
        {
            graphicsView = this;
            configure(this);
        }

        public GraphicsView(Microsoft.Maui.Graphics.IDrawable drawable) 
        {  
            this.Drawable = drawable;
        }

        public GraphicsView(Microsoft.Maui.Graphics.IDrawable drawable, out GraphicsView graphicsView) 
        {  
            this.Drawable = drawable;;
            graphicsView = this;
        }

        public GraphicsView(Microsoft.Maui.Graphics.IDrawable drawable, Action<GraphicsView> configure) 
        {  
            this.Drawable = drawable;
            configure(this);
        }

        public GraphicsView(Microsoft.Maui.Graphics.IDrawable drawable, out GraphicsView graphicsView, Action<GraphicsView> configure) 
        {  
            this.Drawable = drawable;
            graphicsView = this;
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
