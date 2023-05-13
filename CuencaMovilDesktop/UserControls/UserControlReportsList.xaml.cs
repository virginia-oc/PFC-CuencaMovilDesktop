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
        List<Report> reportsList;

        public UserControlReportsList()
        {
            InitializeComponent();          
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            reportsList = new List<Report>(await Gestion.GetAllReports());
            dgReports.DataContext = reportsList;
        }
    }
}
