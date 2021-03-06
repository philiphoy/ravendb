﻿namespace Raven.Studio.Converters
{
	using System;
	using System.Globalization;
	using System.Windows.Data;
	using Framework;

	public class HowLongSinceConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var dt = System.Convert.ToDateTime(value);
			return dt.HowLongSince();
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}