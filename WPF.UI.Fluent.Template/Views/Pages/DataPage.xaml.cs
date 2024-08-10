using Wpf.Ui.Controls;
using WPF.UI.Fluent.Template.ViewModels.Pages;

namespace WPF.UI.Fluent.Template.Views.Pages
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
