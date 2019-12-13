using PenseBem.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PenseBem.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PenseBemView : ContentPage
	{
		public PenseBemView ()
		{
			InitializeComponent ();
            BindingContext = new PenseBemViewModel();
		}
	}
}