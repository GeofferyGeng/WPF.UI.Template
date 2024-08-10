using Wpf.Ui.Controls;
using WPF.UI.Fluent.Template.ViewModels.Pages;

namespace WPF.UI.Fluent.Template.Views.Pages
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
