using Prism.Commands;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;

namespace Xamurai
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarView : ContentView
	{

		public ICommand ToggleCollapseCommand { get; }

		public CarView ()
		{
			ToggleCollapseCommand = new DelegateCommand(ToggleCollapse);
			InitializeComponent ();
		}

        private void ToggleCollapse() => MainExpander.IsExpanded = !MainExpander.IsExpanded;
	}
}