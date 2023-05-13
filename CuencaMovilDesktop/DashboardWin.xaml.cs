using CuencaMovilDesktop.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CuencaMovilDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DashboardWin : Window
    {
        public DashboardWin()
        {
            InitializeComponent();
            panel.Children.Add(new UserControlDashboard());
        }

        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            WinAskCloseApp win = new WinAskCloseApp();
            win.ShowDialog();
        }

        private void dashboardClick(object sender, RoutedEventArgs e)
        {
            ShowDashboard();
        }
      
        public void ShowDashboard()
        {
            panel.Children.Clear();
            panel.Children.Add(new UserControlDashboard());
        }

        private void showReportsClick(object sender, RoutedEventArgs e)
        {
            panel.Children.Clear();
            panel.Children.Add(new UserControlReportsList());
        }

        private void editReportClick(object sender, RoutedEventArgs e)
        {
            panel.Children.Clear();
            panel.Children.Add(new UserControlReportDetail());
        }

        private void printReportClick(object sender, RoutedEventArgs e)
        {

        }

        private void addClubClick(object sender, RoutedEventArgs e)
        {
            panel.Children.Clear();
            panel.Children.Add(new UserControlClubForm());
        }

        private void editClubClick(object sender, RoutedEventArgs e)
        {
            panel.Children.Clear();
            panel.Children.Add(new UserControlClubForm());
        }
      
        private void newBroadcastClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
