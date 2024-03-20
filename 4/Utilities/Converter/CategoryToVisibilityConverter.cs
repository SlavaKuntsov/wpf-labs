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
	public class CategoryToVisibilityConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			PizzaCategories category = (PizzaCategories)value;

			// Возвращаем Visibility.Visible, если категория равна PizzaCategories.Pizza, иначе - Visibility.Collapsed
			return category == PizzaCategories.Pizza ? Visibility.Visible : Visibility.Collapsed;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
