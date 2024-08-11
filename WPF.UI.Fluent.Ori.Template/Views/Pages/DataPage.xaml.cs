using Wpf.Ui.Controls;
using WPF.UI.Fluent.Ori.Template.ViewModels.Pages;

namespace WPF.UI.Fluent.Ori.Template.Views.Pages
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
