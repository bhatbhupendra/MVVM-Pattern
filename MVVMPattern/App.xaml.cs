using MVVMPattern.MVVM.Views;

namespace MVVMPattern
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new CommandsView();
		}
	}
}
