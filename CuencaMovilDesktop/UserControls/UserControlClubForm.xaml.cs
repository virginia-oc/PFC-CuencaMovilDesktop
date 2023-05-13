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
    /// Lógica de interacción para UserControlClubForm.xaml
    /// </summary>
    public partial class UserControlClubForm : UserControl
    {
        string messageInfoSucces = "Asociación guardada con éxito";
        string messageInfoError = "Se ha producido un error. \n" +
            "No se pudo guardar la asociación.";

        public UserControlClubForm()
        {
            InitializeComponent();
        }

        public UserControlClubForm(string idClub)
        {
            InitializeComponent();
        }

        private void BtnSaveData_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text; 
            string category = txtCategory.Text; 
            string phone = txtPhone.Text;
            string email = txtEmail.Text;   
            string description = tbDescription.Text;
            string website = txtWebsite.Text;
            byte[] photo = new byte[1];

            Club newClub = new(name, category, description, phone, website, email, photo);
            Gestion.AddNewClub(newClub);

            WinMessageInfo win = new WinMessageInfo(messageInfoSucces);
            win.ShowDialog();
        }
    }
}
