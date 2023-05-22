using CuencaMovilDesktop.UserControls;
using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public partial class MainWin : Window
    {
        public static List<Report> allReportsList = new List<Report>();
        public static List<Club> allClubsList = new List<Club>();
      
        public MainWin()
        {
            InitializeComponent();
            panel.Children.Add(new UserControlDashboard());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadReports();
            LoadClubs();
        }

        private async void LoadReports()
        {
            allReportsList = new List<Report>(await Gestion.GetAllReports());

            foreach (Report report in allReportsList)
            {
                report.Address =
                    await Gestion.GetAddressFromCoordinates(report.Latitude, report.Longitude);
            }
        }

        private async void LoadClubs()
        {
            allClubsList = new List<Club>(await Gestion.GetAllClubs());
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

        private void home_Click(object sender, RoutedEventArgs e)
        {
            ShowDashboard();
            LoadReports();
            LoadClubs();
        }
      
        public void ShowDashboard()
        {
            panel.Children.Clear();
            panel.Children.Add(new UserControlDashboard());
        }

        private void showReportsClick(object sender, RoutedEventArgs e)
        {
            panel.Children.Clear();
            panel.Children.Add(new UserControlReportsList(this, false));
        }

        private void editReportClick(object sender, RoutedEventArgs e)
        {
            panel.Children.Clear();
            panel.Children.Add(new UserControlReportsList(this, true));
        }

        private void printReportClick(object sender, RoutedEventArgs e)
        {
            panel.Children.Clear();
            panel.Children.Add(new UserControlPrintReport());
        }

        private void addClubClick(object sender, RoutedEventArgs e)
        {
            panel.Children.Clear();
            panel.Children.Add(new UserControlClubForm());
        }

        private void editClubClick(object sender, RoutedEventArgs e)
        {
            panel.Children.Clear();
            panel.Children.Add(new UserControlClubsList(this));
        }
      
        private void newBroadcastClick(object sender, RoutedEventArgs e)
        {
            panel.Children.Clear();
            panel.Children.Add(new UserControlNewBroadcast());
        }

        private void ShowClubsClick(object sender, RoutedEventArgs e)
        {
            panel.Children.Clear();
            panel.Children.Add(new UserControlClubsList(this));
        }

        public void ClearPanel()
        {
            panel.Children.Clear();
        }      
    }
}
