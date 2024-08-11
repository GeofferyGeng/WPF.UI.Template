using Wpf.Ui.Controls;
using WPF.UI.Compact.Template.ViewModels.Pages;

namespace WPF.UI.Compact.Template.Views.Pages
{
    public partial class DataPage : INavigableView<DataViewModel>
    {
        public DataViewModel ViewModel { get; }

        public DataPage(DataViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
