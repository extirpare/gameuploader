﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace GameUploader.Converters
{
    static class Helpers
    {
        public static Style FetchStyle(string styleName)
        {
            return Application.Current.Resources.MergedDictionaries[0][styleName] as Style;
        }
    }

    public class BoolToBackgroundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valAsBool = (bool)value;
            if (valAsBool)
                return "#0800ff00";
            else
                return "#08ff0000";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("Only one way bindings are supported with this converter");
        }
    }

    public class BoolToForegroundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valAsBool = (bool)value;
            if (valAsBool)
                return "#8800ff00";
            else
                return "#88ff0000";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("Only one way bindings are supported with this converter");
        }
    }

    public class IsToggledStyleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valAsBool = (bool)value;
            Style ret;
            if (valAsBool)
                ret = Helpers.FetchStyle("DarkButton_On");
            else
                ret = Helpers.FetchStyle("DarkButton");
            return ret;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("Only one way bindings are supported with this converter");
        }
    }

    public class IsPasswordShownStyleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valAsBool = (bool)value;
            Style ret;
            if (valAsBool)
                ret = Helpers.FetchStyle("DarkTextBox");
            else
                ret = Helpers.FetchStyle("DarkPasswordBox");
            return ret;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("Only one way bindings are supported with this converter");
        }
    }

    public class BoolToOpacityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valAsBool = (bool)value;
            if (valAsBool)
                return 1.0;
            else
                return 0.5;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("Only one way bindings are supported with this converter");
        }
    }
}
