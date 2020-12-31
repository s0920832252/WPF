using System.Windows;
using Trying_Handy_Org_Custom_Controls.ViewModel;

namespace Trying_Handy_Org_Custom_Controls.View
{
    /// <summary>
    /// Interaction logic for LoadWaveProgressBar.xaml
    /// </summary>
    public partial class LoadWaveProgressBar : Window
    {
        public LoadWaveProgressBar()
        {
            InitializeComponent();
            DataContext=new StartLoadViewModel()
            {
                Value = 0,
                MaxValue = 100, 
            };
        }
    }
}
