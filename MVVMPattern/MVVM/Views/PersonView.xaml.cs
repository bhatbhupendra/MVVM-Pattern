using MVVMPattern.MVVM.Models;
using MVVMPattern.MVVM.ViewModels;

namespace MVVMPattern.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		BindingContext = new PersonViewModel();
	}
}