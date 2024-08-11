using Wpf.Ui.Controls;
using WPF.UI.Fluent.Ori.Template.ViewModels.Pages;

namespace WPF.UI.Fluent.Ori.Template.Views.Pages
{
    public partial class SettingsPage : INavigableView<SettingsViewModel>
    {
        public SettingsViewModel ViewModel { get; }

        public SettingsPage(SettingsViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
