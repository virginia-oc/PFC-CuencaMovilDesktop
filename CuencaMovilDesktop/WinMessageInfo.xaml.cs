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
    /// Lógica de interacción para MessageInfo.xaml
    /// </summary>
    public partial class WinMessageInfo : Window
    {
        string message; 

        public WinMessageInfo(string message)
        {
            InitializeComponent();
            this.message = message;
            lblMessage.Content= message;    
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
