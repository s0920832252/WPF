using System.Windows;
using Trying_Handy_Org_Custom_Controls.ViewModel;

namespace Trying_Handy_Org_Custom_Controls.View
{
    /// <summary>
    /// Interaction logic for LoadCircleProgressBar.xaml
    /// </summary>
    public partial class LoadCircleProgressBar : Window
    {
        public LoadCircleProgressBar()
        {
            InitializeComponent();
            DataContext = new StartLoadViewModel()
            {
                MaxValue = 100,
                MinValue = 0,
                Value = 0,
            };
        }
    }
}
