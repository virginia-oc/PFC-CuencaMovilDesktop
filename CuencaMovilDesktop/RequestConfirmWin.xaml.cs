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
using System.Windows.Shapes;

namespace CuencaMovilDesktop
{
    /// <summary>
    /// Lógica de interacción para RequestConfirmWin.xaml
    /// </summary>
    public partial class RequestConfirmWin : Window
    {
        Report report = new Report();
        string newStatus;

        public RequestConfirmWin(Report report, string newStatus, string message)
        {
            InitializeComponent();
            this.report = report;
            this.newStatus = newStatus;
            lblMessage.Content = message;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            Gestion.UpdateReportStatus(report, newStatus);
            this.Close();
            WinMessageInfo winMessage = new WinMessageInfo("Reporte actualizado con éxito");
            winMessage.ShowDialog();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
