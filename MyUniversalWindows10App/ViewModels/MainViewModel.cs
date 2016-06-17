namespace MyUniversalWindows10App.ViewModels
{
	using System.Collections.Generic;

	using GalaSoft.MvvmLight;

	using Models;

	public class MainViewModel : ViewModelBase
	{
		private readonly ISNEKPrepService service;

		public MainViewModel(ISNEKPrepService service)
		{
			this.service = service;  // Dependency Injection
		}

		public async void Load()
		{
			Sessions = await service.Sessions.GetAsync();
		}

		public Session SelectedSession { get; set; }

		public IEnumerable<Session> Sessions { get; set; } 
	}
}

