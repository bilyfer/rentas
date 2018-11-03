using BL.Rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class FormReporteProductos : Form
    {
        public FormReporteProductos()
        {
            InitializeComponent();

            var _productoBL = new ProductosBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _productoBL.ObtenerProductos();

            var reporte = new ReporteProductos();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
