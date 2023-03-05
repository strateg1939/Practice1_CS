using DateCheck.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DateCheck.Views
{

    
    public partial class DateInputView : UserControl
    {

        private DateInputViewModel _viewModel;
        public DateInputView()
        {
            InitializeComponent();
            DataContext = _viewModel = new DateInputViewModel();
        }
    }
}
