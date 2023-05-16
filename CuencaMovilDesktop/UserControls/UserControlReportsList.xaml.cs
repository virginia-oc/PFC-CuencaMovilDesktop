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
        List<Report> allReportsList = new List<Report>();
        List<Report> incidentsList = new List<Report>();
        List<Report> requestsList = new List<Report>();

        public UserControlReportsList()
        {
            InitializeComponent();          
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            allReportsList = new List<Report>(await Gestion.GetAllReports());
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
    }
}
