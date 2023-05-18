using Entidades;
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

namespace CuencaMovilDesktop.UserControls
{
    /// <summary>
    /// Lógica de interacción para UserControlReportDetail.xaml
    /// </summary>
    public partial class UserControlReportForm : UserControl
    {
        Report report = new Report();
        private bool editable;

        public UserControlReportForm(Report report, bool editable)
        {
            InitializeComponent();
            this.editable = editable;
            this.report = report;
            form.DataContext = report;
            DisableFields(editable);
        }

        private void DisableFields(bool editable)
        {
            txtCategory.IsEnabled = false;
            txtAddress.IsEnabled = false;
            txtDatetime.IsEnabled = false;
            tbDescription.IsEnabled = false;

            if (editable)
            {
                comboStatus.IsEnabled = true;               
            }    
            else
            {
                comboStatus.IsEnabled = false;
                btnConfirmChanges.Visibility = Visibility.Hidden;
                gridButtons.ColumnDefinitions.Clear();
                btnBack.MaxWidth = 500;
            }
               
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            panel.Children.Clear();
            panel.Children.Add(new UserControlReportsList(editable));
        }

        private void btnConfirmChanges_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
