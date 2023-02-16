﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class PathFigureGeneratedExtension
    {
        public static T Segments<T>(this T obj,
            Microsoft.Maui.Controls.Shapes.PathSegmentCollection segments)
            where T : Sharp.UI.IPathFigure
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.PathFigure>(obj);
            mauiObject.Segments = (Microsoft.Maui.Controls.Shapes.PathSegmentCollection)segments;
            return obj;
        }
        
        public static T Segments<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Shapes.PathSegmentCollection>, ValueBuilder<Microsoft.Maui.Controls.Shapes.PathSegmentCollection>> buildValue)
            where T : Sharp.UI.IPathFigure
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.PathFigure>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Shapes.PathSegmentCollection>());
            if (builder.ValueIsSet()) mauiObject.Segments = builder.GetValue();
            return obj;
        }
        
        public static T Segments<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Shapes.PathSegmentCollection>, BindingBuilder<Microsoft.Maui.Controls.Shapes.PathSegmentCollection>> buildBinding)
            where T : Sharp.UI.IPathFigure
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.PathFigure>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.Shapes.PathSegmentCollection>(mauiObject, Microsoft.Maui.Controls.Shapes.PathFigure.SegmentsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T StartPoint<T>(this T obj,
            Microsoft.Maui.Graphics.Point startPoint)
            where T : Sharp.UI.IPathFigure
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.PathFigure>(obj);
            mauiObject.StartPoint = (Microsoft.Maui.Graphics.Point)startPoint;
            return obj;
        }
        
        public static T StartPoint<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Point>, ValueBuilder<Microsoft.Maui.Graphics.Point>> buildValue)
            where T : Sharp.UI.IPathFigure
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.PathFigure>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Point>());
            if (builder.ValueIsSet()) mauiObject.StartPoint = builder.GetValue();
            return obj;
        }
        
        public static T StartPoint<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Point>, BindingBuilder<Microsoft.Maui.Graphics.Point>> buildBinding)
            where T : Sharp.UI.IPathFigure
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.PathFigure>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.Shapes.PathFigure.StartPointProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsClosed<T>(this T obj,
            bool isClosed)
            where T : Sharp.UI.IPathFigure
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.PathFigure>(obj);
            mauiObject.IsClosed = (bool)isClosed;
            return obj;
        }
        
        public static T IsClosed<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IPathFigure
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.PathFigure>(obj);
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.IsClosed = builder.GetValue();
            return obj;
        }
        
        public static T IsClosed<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Sharp.UI.IPathFigure
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.PathFigure>(obj);
            var builder = buildBinding(new BindingBuilder<bool>(mauiObject, Microsoft.Maui.Controls.Shapes.PathFigure.IsClosedProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsFilled<T>(this T obj,
            bool isFilled)
            where T : Sharp.UI.IPathFigure
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.PathFigure>(obj);
            mauiObject.IsFilled = (bool)isFilled;
            return obj;
        }
        
        public static T IsFilled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IPathFigure
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.PathFigure>(obj);
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.IsFilled = builder.GetValue();
            return obj;
        }
        
        public static T IsFilled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Sharp.UI.IPathFigure
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.PathFigure>(obj);
            var builder = buildBinding(new BindingBuilder<bool>(mauiObject, Microsoft.Maui.Controls.Shapes.PathFigure.IsFilledProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
