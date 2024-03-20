using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

using static _4.Abstractions.ProductAbstraction;

namespace _4.Utilities
{
	public class CategoryToBooleanConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is PizzaCategories selectedCategory && parameter is string categoryName)
			{
				return selectedCategory.ToString() == categoryName;
			}
			return false;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if ((bool)value && parameter is string categoryName)
			{
				if (Enum.TryParse(categoryName, out PizzaCategories category))
				{
					return category;
				}
			}
			return DependencyProperty.UnsetValue;
		}
	}
}
