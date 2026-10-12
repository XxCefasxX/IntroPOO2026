using Core.clases;
using Core.repositorios;

namespace TeindaWinforms
{
    public partial class Form1 : Form
    {
        Venta venta = new Venta(new Empleado { ID = 1 });
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_guardar_venta_Click(object sender, EventArgs e)
        {
            RepositorioProductos repoProductos = new RepositorioProductos();
            int idProd = Convert.ToInt32(tb_id_producto.Text);
            int cantidad = Convert.ToInt32(tb_cantidad.Text);

            var response = repoProductos.GetById(idProd);
            if (response.Code == 1)
            {
                Producto producInfo = response.Data;

                venta.AgregarProducto(producInfo, cantidad);

                dgv_lista.DataSource = venta.productos;
               
                lb_total.Text = venta.total.ToString();
            }
            else if (response.Code == 2)
            {
                MessageBox.Show("El codigo del producto no se encontro");
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }

            tb_id_producto.Text = "";
            tb_cantidad.Text = "";
        }

  
        private void PagarCuenta(object sender, EventArgs e)
        {
            ResitorioVentas repoVenta = new ResitorioVentas();
            repoVenta.RegistraVenta(venta);
            dgv_lista.DataSource = null;
            lb_total.Text = "";
            MessageBox.Show("Venta copletada");
            //rear su rama y trabajar ahi
        }
    }
}
