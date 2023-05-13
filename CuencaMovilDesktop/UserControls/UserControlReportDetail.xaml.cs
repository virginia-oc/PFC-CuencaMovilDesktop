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
    public partial class UserControlReportDetail : UserControl
    {
        Report report = new Report();

        //Borrar este constructor al final. Nunca voy a cargar un formulario de reporte vacio. 
        public UserControlReportDetail()
        {
            InitializeComponent();
        }

        public UserControlReportDetail(Report report)
        {
            InitializeComponent();
            this.report = report;
            form.DataContext = report;
        }
    }
}
