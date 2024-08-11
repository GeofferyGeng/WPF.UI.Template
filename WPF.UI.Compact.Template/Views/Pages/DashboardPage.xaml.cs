using Wpf.Ui.Controls;
using WPF.UI.Compact.Template.ViewModels.Pages;

namespace WPF.UI.Compact.Template.Views.Pages
{
    public partial class DashboardPage : INavigableView<DashboardViewModel>
    {
        public DashboardViewModel ViewModel { get; }

        public DashboardPage(DashboardViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
