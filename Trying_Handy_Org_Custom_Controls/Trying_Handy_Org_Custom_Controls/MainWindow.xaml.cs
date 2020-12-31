using System.Windows;
using Trying_Handy_Org_Custom_Controls.View;

namespace Trying_Handy_Org_Custom_Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadWaveProgressBarBtn_OnClick(object sender, RoutedEventArgs e)
        {
            new LoadWaveProgressBar().Show();
        }

        private void LoadCircleProgressBarBtn_OnClick(object sender, RoutedEventArgs e)
        {
            new LoadCircleProgressBar().Show();
        }

        private void LoadGravatarBtn_OnClick(object sender, RoutedEventArgs e)
        {
            new LoadGravatar().Show();
        }

        private void LoadProgressBtn_OnClick(object sender, RoutedEventArgs e)
        {
            new LoadProgressBar().Show();
        }

        private void CloseBtn_OnClick(object sender, RoutedEventArgs e)
        {
            foreach (Window currentWindow in Application.Current.Windows)
            {
                if (currentWindow != this)
                {
                    currentWindow.Close();
                } 
            }
        }
    }
}
