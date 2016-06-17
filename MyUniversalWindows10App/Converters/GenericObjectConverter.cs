namespace MyUniversalWindows10App.Converters
{
	using System;

	using Windows.UI.Xaml.Data;

	public class GenericObjectConverter<T> : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			return (T)value;
		}
	}
}