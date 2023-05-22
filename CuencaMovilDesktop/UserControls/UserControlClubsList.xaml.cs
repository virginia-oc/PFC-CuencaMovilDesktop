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
    /// Lógica de interacción para UserControlClubsList.xaml
    /// </summary>
    public partial class UserControlClubsList : UserControl
    {
        List<Club> allClubsList;
        MainWin mainWin;

        public UserControlClubsList(MainWin mainWin)
        {
            InitializeComponent();
            allClubsList = new List<Club>(MainWin.allClubsList);
            this.mainWin = mainWin;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {            
            dgClubs.DataContext = allClubsList;
        }

        private void tbBuscador_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgClubs.DataContext = Gestion.FilterClubsByText(allClubsList, tbBuscador.Text);
        }
    }
}
