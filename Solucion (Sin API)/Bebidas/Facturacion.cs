using BebidasBack.Datos.DTOs;
using BebidasBack.Datos.Entidades;
using BebidasBack.Servicio.Implementacion;
using BebidasBack.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bebidas
{
    public partial class Facturacion : Form
    {
        List<DetalleFactura> detalleFactura;
        Factura factura;
        public Facturacion()
        {
            InitializeComponent();
            factura = new Factura();
            detalleFactura = new List<DetalleFactura>();
            factura.DetalleFactura = detalleFactura;
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtCodigo.Text != String.Empty)
                {
                    AgregarProducto(txtCodigo.Text);
                    txtCodigo.Text = String.Empty;
                }
                //MessageBox.Show("Pressed enter.");
            }
        }

        private void AgregarProducto(string id)
        {
            Bebida bebida = ServicioDAO.ObtenerServicio().GetBebida(Convert.ToInt32(id));

            if (bebida != null)
            {
                CargarDetalle(bebida);
                ActualizarDgv();
                ActualizarTotal();
            }
        }

        private void CargarDetalle(Bebida bebida)
        {
            bool existe = false;
            if (bebida != null)
            {
                foreach (DetalleFactura det in detalleFactura)
                {
                    if (bebida.Id == det.Bebida.Id)
                    {
                        det.Cantidad++;
                        existe = true;
                    }
                }

                if (!existe)
                {
                    detalleFactura.Add(new DetalleFactura()
                    {
                        Bebida = bebida,
                        Cantidad = 1,
                        Precio = bebida.Precio
                    });
                }
            }
        }

        private void ActualizarDgv()
        {
            dgvDetalle.Rows.Clear();
            foreach (DetalleFactura det in detalleFactura)
            {
                dgvDetalle.Rows.Add(new object[] {

                    det.Bebida.Id,
                    det.Bebida.Nombre,
                    det.Bebida.Precio,

                    det.Cantidad,

                    det.Precio * det.Cantidad
                });

            }
        }

        private void ActualizarTotal()
        {
            lblTotal.Text = factura.Total().ToString();
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalle.CurrentCell.ColumnIndex == 5)
            {
                factura.QuitarDetalleFactura(dgvDetalle.CurrentRow.Index);
                dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index);
                lblTotal.Text = factura.Total().ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cancelar la operacion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = string.Empty;
            nudCantidad.Value = 1;
            cboEmpleado.SelectedIndex = -1;
            cboSocio.SelectedIndex = -1;
            cboFormaPago.SelectedIndex = -1;
            dgvDetalle.Rows.Clear();
            factura = new Factura();
            detalleFactura = new List<DetalleFactura>();
            factura.DetalleFactura = detalleFactura;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            ActualizarFactura();

            FacturaDTO facturaDTO = new FacturaDTO();

            facturaDTO.Socio = factura.Socio.Id;
            facturaDTO.Empleado = factura.Empleado.Legajo;
            facturaDTO.Pago = factura.Pago.Id;

            List<DetalleDTO> listaDetalleDTO = new List<DetalleDTO>();

            foreach (DetalleFactura detalle in factura.DetalleFactura)
            {
                DetalleDTO detDTO = new DetalleDTO();

                detDTO.Bebida = detalle.Bebida.Id;
                detDTO.Cantidad = detalle.Cantidad;
                detDTO.Precio = detalle.Precio;

                listaDetalleDTO.Add(detDTO);
            }

            facturaDTO.DetalleFactura = listaDetalleDTO;

            bool aux = ServicioDAO.ObtenerServicio().PostFactura(facturaDTO);

            if (aux)
            {
                MessageBox.Show($"Factura {facturaDTO.Numero} creada con éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }

        private void ActualizarFactura()
        {
            factura.Socio = (Socio)cboSocio.SelectedItem;
            factura.Empleado = (Empleado)cboEmpleado.SelectedItem;
            factura.Pago = (FormaPago)cboFormaPago.SelectedItem;
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            cboSocio.Items.Clear();
            List<Socio> listaSocios = ServicioDAO.ObtenerServicio().GetSocios();
            foreach (Socio socio in listaSocios)
            {
                cboSocio.Items.Add(socio);
            }
            cboSocio.SelectedIndex = 0;
            cboSocio.DropDownStyle = ComboBoxStyle.DropDownList;

            cboEmpleado.Items.Clear();
            List<Empleado> listaEmpleados = ServicioDAO.ObtenerServicio().GetEmpleados();
            foreach (Empleado empleado in listaEmpleados)
            {
                cboEmpleado.Items.Add(empleado);
            }
            cboEmpleado.SelectedIndex = 0;
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;

            cboFormaPago.Items.Clear();
            List<FormaPago> listaFormaPago = ServicioDAO.ObtenerServicio().GetFormaPagos();
            foreach (FormaPago pago in listaFormaPago)
            {
                cboFormaPago.Items.Add(pago);
            }
            cboFormaPago.SelectedIndex = 0;
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
