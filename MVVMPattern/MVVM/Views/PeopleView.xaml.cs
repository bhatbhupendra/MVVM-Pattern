using MVVMPattern.MVVM.ViewModels;

namespace MVVMPattern.MVVM.Views;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();

		BindingContext = new PeopleViewModel();
	}
}