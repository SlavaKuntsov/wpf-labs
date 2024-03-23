using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows;

using static _4.Abstractions.ProductAbstraction;

namespace _4.Utilities.Converter
{
	public class SizeToBooleanConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is PizzaSizes selectedSize && parameter is string sizeName)
			{
				return selectedSize.ToString() == sizeName;
			}
			return false;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if ((bool)value && parameter is string sizeName)
			{
				if (Enum.TryParse(sizeName, out PizzaSizes size))
				{
					return size;
				}
			}
			return DependencyProperty.UnsetValue;
		}
	}
}
