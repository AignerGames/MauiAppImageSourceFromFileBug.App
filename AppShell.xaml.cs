namespace MauiAppImageSourceFromFileBug;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		var viewModel = new DemoViewModel();

		BindingContext = viewModel;
	}
}
