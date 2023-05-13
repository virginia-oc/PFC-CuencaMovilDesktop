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
        List<Report> reportsList = new List<Report>();

        public UserControlReportsList()
        {
            InitializeComponent();
            //reportsList = new List<Report>(Gestion.GetAllReports());
            reportsList = Gestion.GetAllReports();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dgReports.DataContext = reportsList;
        }
    }
}
