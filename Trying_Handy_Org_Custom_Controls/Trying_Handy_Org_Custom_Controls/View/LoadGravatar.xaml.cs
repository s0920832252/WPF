using System.Windows;
using Trying_Handy_Org_Custom_Controls.ViewModel;

namespace Trying_Handy_Org_Custom_Controls.View
{
    /// <summary>
    /// Interaction logic for LoadGravatar.xaml
    /// </summary>
    public partial class LoadGravatar : Window
    {
        public LoadGravatar()
        {
            InitializeComponent();
            DataContext= new StartLoadViewModel()
            {
                Value = 20,
                MaxValue = 50, 
            };
        }
    }
}
