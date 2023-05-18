using Entidades;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace CuencaMovilDesktop.UserControls
{
    /// <summary>
    /// Lógica de interacción para UserControlReportsList.xaml
    /// </summary>
    public partial class UserControlReportsList : UserControl
    {
        List<Report> allReportsList;
        List<Report> incidentsList = new List<Report>();
        List<Report> requestsList = new List<Report>();
        private bool editableReport;

        public UserControlReportsList(bool editableReport)
        {
            InitializeComponent();
            allReportsList = new List<Report>(DashboardWin.allReportsList);
            this.editableReport = editableReport;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {           
            dgReports.DataContext = allReportsList;
          
            foreach (Report report in allReportsList)
            {
                if (report.IsIncident)
                    incidentsList.Add(report);
                else
                    requestsList.Add(report);
            }          
        }

        private void cbIncident_Checked(object sender, RoutedEventArgs e)
        {
            cbRequest.IsChecked = false;
            cbShowAll.IsChecked = false;
                     
            dgReports.DataContext = incidentsList;  
        }
      
        private void cbRequest_Checked(object sender, RoutedEventArgs e)
        {
            cbIncident.IsChecked = false;
            cbShowAll.IsChecked = false;

            dgReports.DataContext = requestsList;
        }

        private void cbShowAll_Checked(object sender, RoutedEventArgs e)
        {
            cbIncident.IsChecked = false;
            cbRequest.IsChecked = false;

            dgReports.DataContext = allReportsList;
        }

        private void ShowAllReports(object sender, RoutedEventArgs e)
        {
            dgReports.DataContext = allReportsList;
        }

        private void dgReports_MouseDoubleClick(object sender, 
            System.Windows.Input.MouseButtonEventArgs e)
        {
            panel.Children.Clear();
            panel.Children.Add(new UserControlReportForm(
                (Report)dgReports.SelectedItem, editableReport));
        }
    }
}
