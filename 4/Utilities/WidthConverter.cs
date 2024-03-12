using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace _4.Utilities
{
	public class WidthConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is double containerWidth)
			{
				double desiredWidth = containerWidth * 0.3 - 1; // 30% от ширины контейнера
				return desiredWidth;
			}

			return DependencyProperty.UnsetValue;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}