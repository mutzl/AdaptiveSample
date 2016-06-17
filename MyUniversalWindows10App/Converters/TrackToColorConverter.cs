namespace MyUniversalWindows10App.Converters
{
	using System;

	using Windows.UI;
	using Windows.UI.Xaml;
	using Windows.UI.Xaml.Data;
	using Windows.UI.Xaml.Media;
	using Windows.UI.Xaml.Media.Imaging;

	public class TrackToColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			if ((int)value == 0) return new SolidColorBrush(Colors.Brown);
			if ((int)value == 1) return new SolidColorBrush(Colors.Purple);
			return DependencyProperty.UnsetValue;
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new System.NotImplementedException();
		}
	}

	public class TrackToIconConverter : IValueConverter {
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			var url = $"ms-appx:///Assets/{(int)value}.png";
			return new BitmapImage(new Uri(url));
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}
}