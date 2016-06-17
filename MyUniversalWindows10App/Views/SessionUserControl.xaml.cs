using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace MyUniversalWindows10App
{
	using MyUniversalWindows10App.Models;

	public sealed partial class SessionUserControl : UserControl
	{


		public Session Session => this.DataContext as Session;

		public SessionUserControl()
		{
			this.InitializeComponent();
			this.DataContextChanged += (s, e) => Bindings.Update();
		}
	}
}
