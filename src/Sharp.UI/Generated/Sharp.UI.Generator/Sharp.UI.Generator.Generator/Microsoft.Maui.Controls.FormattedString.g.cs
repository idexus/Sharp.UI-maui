﻿//
// <auto-generated>
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class FormattedStringExtension
    {
        public static T Spans<T>(this T obj,
            IList<Microsoft.Maui.Controls.Span> spans)
            where T : Microsoft.Maui.Controls.FormattedString
        {
            foreach (var item in spans)
                obj.Spans.Add(item);
            return obj;
        }

        public static T Spans<T>(this T obj,
            params Microsoft.Maui.Controls.Span[] spans)
            where T : Microsoft.Maui.Controls.FormattedString
        {
            foreach (var item in spans)
                obj.Spans.Add(item);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
