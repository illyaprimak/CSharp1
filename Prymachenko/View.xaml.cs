using System.Windows.Controls;

namespace Prymachenko
{
    public partial class View : UserControl
    {
        public View()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }
    }
}