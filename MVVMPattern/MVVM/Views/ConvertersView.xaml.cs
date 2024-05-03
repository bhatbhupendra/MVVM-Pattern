using MVVMPattern.MVVM.ViewModels;

namespace MVVMPattern.MVVM.Views;

public partial class ConvertersView : ContentPage
{
	public ConvertersView()
	{
		InitializeComponent();
		BindingContext = new ConvertersViewModel();
	}
}