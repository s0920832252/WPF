using System.Windows;
using Trying_Handy_Org_Custom_Controls.ViewModel;

namespace Trying_Handy_Org_Custom_Controls.View
{
    /// <summary>
    /// Interaction logic for LoadProgressBar.xaml
    /// </summary>
    public partial class LoadProgressBar : Window
    {
        public LoadProgressBar()
        {
            InitializeComponent();
            DataContext = new StartLoadViewModel()
            {
                Value = 0,
                MaxValue = 100,
            };
        }
    }
}
