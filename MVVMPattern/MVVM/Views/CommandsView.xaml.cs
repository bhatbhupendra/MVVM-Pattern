using MVVMPattern.MVVM.ViewModels;

namespace MVVMPattern.MVVM.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
		BindingContext = new CommandsViewModel();
	}
}