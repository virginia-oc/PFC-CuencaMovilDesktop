///<author>Virginia Ojeda Corona</author>
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;
using Datos;

namespace CuencaMovilDesktop.UserControls
{
    /// <summary>
    /// Lógica de interacción para UserControlDashboard.xaml
    /// </summary>
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
            DibujarGraficas();
            MostrarEstadisticas();

            Gestion.GetAllReports();
        }

        /// <summary>
        /// Dibuja las gráficas que aparecen en el dashboard
        /// </summary>
        public void DibujarGraficas()
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            Dictionary<string, int> pairsPedidosCliente = new Dictionary<string, int>();

            //using (Gestion gest = new Gestion())
            //{
            //    dictionary = gest.ObtenerTotalProductosPorCategorias();
            //    pairsPedidosCliente = gest.ObtenerCantidadPedidosClientes();
            //}

            /////Gráfica de pastel
            //SeriesCollection seriesPieChart = new SeriesCollection();

            //int i = 0;
            //foreach (KeyValuePair<int, int> catProductos in dictionary)
            //{
            //    i++;
            //    string color = "color" + i;
            //    if (i > 10) i = 1;
            //    seriesPieChart.Add(new PieSeries
            //    {
            //        Title = Gestion.ObtenerNombreCategoria(catProductos.Key),
            //        Values = new ChartValues<int> { catProductos.Value },
            //        Stroke = Application.Current.TryFindResource(color) as Brush,
            //        Fill = Application.Current.TryFindResource(color) as Brush,
            //        DataLabels = true
            //    });
            //}
            //pieChart.Series = seriesPieChart;


            /////Gráfica de barras
            //SeriesCollection seriesColumnChart = new SeriesCollection();

            //i = 0;
            //foreach (KeyValuePair<string, int> pair in pairsPedidosCliente)
            //{
            //    i++;
            //    string color = "color" + i;
            //    if (i > 10) i = 1;

            //    string nombreCliente;
            //    using (CustomerADO emp = new CustomerADO())
            //    {
            //        nombreCliente = emp.Listar(pair.Key).ContactName;
            //    }

            //    seriesColumnChart.Add(new ColumnSeries
            //    {
            //        Title = nombreCliente,
            //        Values = new ChartValues<int> { pair.Value },
            //        Stroke = Application.Current.TryFindResource(color) as Brush,
            //        Fill = Application.Current.TryFindResource(color) as Brush
            //    });
            //}
            //columnChart.Series = seriesColumnChart;
        }

        /// <summary>
        /// Calcula y muestra las estadísticas de los 4 paneles superiores
        /// del dashboard
        /// </summary>
        public void MostrarEstadisticas()
        {
            //int empId = 1;
            //string updates = "Actualizado " +
            //    DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            //lblUpdate1.Content = updates;
            //lblUpdate2.Content = updates;
            //lblUpdate3.Content = updates;
            //lblUpdate4.Content = updates;

            //using (Gestion gest = new Gestion())
            //{
            //    lblTotalPedidos.Content = gest.ListarPedidosEmpleado(empId).Count;              
            //}
            //lblTotalProductos.Content = Gestion.ObtenerProductosMenos10Uni().Count;
            //lblEurosPedidos.Content = 
            //    Gestion.ObtenerEurosPedidosHoy().ToString("0.00") + " €";
            //lblEurosUsuario.Content = 
            //    Gestion.ObtenerEurosPedidosHoyEmpleado(empId).ToString("0.00") + " €";
        }
    }    
}
