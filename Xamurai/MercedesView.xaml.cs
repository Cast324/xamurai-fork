using System;
using System.Collections.Generic;
using System.Windows.Input;
using Prism.Commands;
using Xamarin.Forms;

namespace Xamurai
{
    public partial class MercedesView : ContentView
    {

        public ICommand ToggleCollapseCommand { get; }

        public MercedesView()
        {
            ToggleCollapseCommand = new DelegateCommand(ToggleCollapse);
            InitializeComponent();
        }

        private void ToggleCollapse() => MainExpander.IsExpanded = !MainExpander.IsExpanded;
    }
}

