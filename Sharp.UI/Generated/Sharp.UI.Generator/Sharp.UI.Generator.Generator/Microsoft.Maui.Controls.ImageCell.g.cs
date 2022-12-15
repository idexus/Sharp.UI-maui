﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ImageCellGeneratedExtension
    {
        public static T ImageSource<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource? imageSource)
            where T : Sharp.UI.IImageCell
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageCell>(obj);
            if (imageSource != null) mauiObject.ImageSource = (Microsoft.Maui.Controls.ImageSource)imageSource;
            return obj;
        }
        
        public static T ImageSource<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource? imageSource,
            System.Func<BindableDef<Microsoft.Maui.Controls.ImageSource>, BindableDef<Microsoft.Maui.Controls.ImageSource>> definition)
            where T : Sharp.UI.IImageCell
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageCell>(obj);         
            if (imageSource != null) mauiObject.ImageSource = (Microsoft.Maui.Controls.ImageSource)imageSource;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ImageSource>(mauiObject, Microsoft.Maui.Controls.ImageCell.ImageSourceProperty));
            if (def.ValueIsSet()) mauiObject.ImageSource = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ImageSource<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.ImageSource>, BindableDef<Microsoft.Maui.Controls.ImageSource>> definition)
            where T : Sharp.UI.IImageCell
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageCell>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ImageSource>(mauiObject, Microsoft.Maui.Controls.ImageCell.ImageSourceProperty));
            if (def.ValueIsSet()) mauiObject.ImageSource = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
