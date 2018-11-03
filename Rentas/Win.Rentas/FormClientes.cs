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
    public partial class FormClientes : Form
    {
        ClientesBL _clientesBL;

        public FormClientes()
        {
            InitializeComponent();

            _clientesBL = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();
        }

        private void listaClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaClientesBindingSource.EndEdit();
            var cliente = (Cliente)listaClientesBindingSource.Current;

            var resultado = _clientesBL.GuardarCliente(cliente);

            if (resultado.Exitoso == true)
            {
                listaClientesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Cliente guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _clientesBL.EliminarCliente(id);

            if (resultado == true)
            {
                listaClientesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el Cliente");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _clientesBL.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _clientesBL.AgregarCliente();
            listaClientesBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }
    }
}
