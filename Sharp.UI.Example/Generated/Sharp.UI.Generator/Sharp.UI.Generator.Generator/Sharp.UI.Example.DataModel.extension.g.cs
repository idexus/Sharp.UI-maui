﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI.Example
{
    using Sharp.UI;

    public static class DataModelGeneratedExtension
    {
        public static T SimpleData<T>(this T obj,
            System.Collections.Generic.List<Sharp.UI.Example.DataModel> simpleData)
            where T : Sharp.UI.Example.DataModel
        {
            var mauiObject = MauiWrapper.GetObject<Sharp.UI.Example.DataModel>(obj);
            foreach (var item in simpleData) Sharp.UI.Example.DataModel.SimpleData.Add(item);
            return obj;
        }

        public static T SimpleData<T>(this T obj,
            params Sharp.UI.Example.DataModel[] simpleData)
            where T : Sharp.UI.Example.DataModel
        {
            var mauiObject = MauiWrapper.GetObject<Sharp.UI.Example.DataModel>(obj);
            foreach (var item in simpleData) Sharp.UI.Example.DataModel.SimpleData.Add(item);
            return obj;
        }

        public static T SimpleData<T>(this T obj,
            System.Func<Def<System.Collections.Generic.List<Sharp.UI.Example.DataModel>>, Def<System.Collections.Generic.List<Sharp.UI.Example.DataModel>>> definition)
            where T : Sharp.UI.Example.DataModel
        {
            var mauiObject = MauiWrapper.GetObject<Sharp.UI.Example.DataModel>(obj);
            var def = definition(new Def<System.Collections.Generic.List<Sharp.UI.Example.DataModel>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) Sharp.UI.Example.DataModel.SimpleData.Add(item);
            }
            return obj;
        }
        
        public static T Id<T>(this T obj,
            int? id)
            where T : Sharp.UI.Example.DataModel
        {
            var mauiObject = MauiWrapper.GetObject<Sharp.UI.Example.DataModel>(obj);
            if (id != null) mauiObject.SetValue(Sharp.UI.Example.DataModel.IdProperty, (int)id);
            return obj;
        }
        
        public static T Id<T>(this T obj,
            int? id,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.Example.DataModel
        {
            var mauiObject = MauiWrapper.GetObject<Sharp.UI.Example.DataModel>(obj);
            if (id != null) mauiObject.SetValue(Sharp.UI.Example.DataModel.IdProperty, (int)id);
            var def = definition(new BindableDef<int>(mauiObject, Sharp.UI.Example.DataModel.IdProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Sharp.UI.Example.DataModel.IdProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T Id<T>(this T obj,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.Example.DataModel
        {
            var mauiObject = MauiWrapper.GetObject<Sharp.UI.Example.DataModel>(obj);
            var def = definition(new BindableDef<int>(mauiObject, Sharp.UI.Example.DataModel.IdProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Sharp.UI.Example.DataModel.IdProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T Name<T>(this T obj,
            string? name)
            where T : Sharp.UI.Example.DataModel
        {
            var mauiObject = MauiWrapper.GetObject<Sharp.UI.Example.DataModel>(obj);
            if (name != null) mauiObject.SetValue(Sharp.UI.Example.DataModel.NameProperty, (string)name);
            return obj;
        }
        
        public static T Name<T>(this T obj,
            string? name,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.Example.DataModel
        {
            var mauiObject = MauiWrapper.GetObject<Sharp.UI.Example.DataModel>(obj);
            if (name != null) mauiObject.SetValue(Sharp.UI.Example.DataModel.NameProperty, (string)name);
            var def = definition(new BindableDef<string>(mauiObject, Sharp.UI.Example.DataModel.NameProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Sharp.UI.Example.DataModel.NameProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T Name<T>(this T obj,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.Example.DataModel
        {
            var mauiObject = MauiWrapper.GetObject<Sharp.UI.Example.DataModel>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Sharp.UI.Example.DataModel.NameProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Sharp.UI.Example.DataModel.NameProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T Admin<T>(this T obj,
            bool? admin)
            where T : Sharp.UI.Example.DataModel
        {
            var mauiObject = MauiWrapper.GetObject<Sharp.UI.Example.DataModel>(obj);
            if (admin != null) mauiObject.SetValue(Sharp.UI.Example.DataModel.AdminProperty, (bool)admin);
            return obj;
        }
        
        public static T Admin<T>(this T obj,
            bool? admin,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.Example.DataModel
        {
            var mauiObject = MauiWrapper.GetObject<Sharp.UI.Example.DataModel>(obj);
            if (admin != null) mauiObject.SetValue(Sharp.UI.Example.DataModel.AdminProperty, (bool)admin);
            var def = definition(new BindableDef<bool>(mauiObject, Sharp.UI.Example.DataModel.AdminProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Sharp.UI.Example.DataModel.AdminProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T Admin<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.Example.DataModel
        {
            var mauiObject = MauiWrapper.GetObject<Sharp.UI.Example.DataModel>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Sharp.UI.Example.DataModel.AdminProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Sharp.UI.Example.DataModel.AdminProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
