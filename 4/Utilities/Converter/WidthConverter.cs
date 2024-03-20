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
				Console.WriteLine(containerWidth);

				double desiredWidth = 0;

				if (containerWidth >= 1150)
				{
					desiredWidth = containerWidth * 0.24 - 1; // 4
				}
				else if(containerWidth >= 700)
				{
					desiredWidth = containerWidth * 0.3 - 1; // 3
				}
				else if(containerWidth >= 350)
				{
					desiredWidth = containerWidth * 0.48 - 1; // 2
				}
				else
				{
					desiredWidth = containerWidth - 1; // 1
				}

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


//using System;
//using System.Globalization;
//using System.Windows;
//using System.Windows.Data;

//namespace _4.Utilities
//{
//	public class WidthConverter : IValueConverter
//	{
//		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
//		{
//			if (value is double containerWidth)
//			{
//				int maxColumns = 4; // Максимальное количество колонок
//				double desiredWidth = containerWidth / maxColumns - 1; // Вычисление желаемой ширины элемента
//				return desiredWidth;
//			}

//			return DependencyProperty.UnsetValue;
//		}

//		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
//		{
//			throw new NotImplementedException();
//		}
//	}
//}