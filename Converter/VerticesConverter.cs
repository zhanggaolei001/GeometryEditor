using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Media;
using GeometryEditor.ViewModel;

namespace GeometryEditor.Converter
{
    public class VerticesConverter : IValueConverter
    {
        public object Convert(
            object value, Type targetType, object parameter, CultureInfo culture)
        {
            var vertices = value as IEnumerable<VertexViewModel>;

            return vertices != null
                ? new PointCollection(vertices.Select(v => v.Point))
                : null;
        }

        public object ConvertBack(
            object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
    public class XY_5Converter : IValueConverter
    {
        public object Convert(
            object value, Type targetType, object parameter, CultureInfo culture)
        {
            var xy = double.Parse(value.ToString());
            return xy - 5;
        }

        public object ConvertBack(
            object value, Type targetType, object parameter, CultureInfo culture)
        {
            var m = double.Parse(value.ToString());
            return m + 5;
        }
    }
}
