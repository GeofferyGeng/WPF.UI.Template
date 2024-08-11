using Wpf.Ui.Controls;
using WPF.UI.Compact.Template.ViewModels.Pages;

namespace WPF.UI.Compact.Template.Views.Pages
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
