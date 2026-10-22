using BLL;
using Entity;

namespace ParcialUnoGallino
{
    public partial class Form1 : Form
    {
        private AlquilerBusiness alquilerBusiness = new();
        private TipoBicicletaBusiness tipoBicicletaBusiness = new();

        private List<Alquiler> borrador = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDgv();
            actualizarCBs();
        }

        private void actualizarDgv()
        {
            dgvAlquileres.DataSource = null;
            dgvAlquileres.DataSource = alquilerBusiness.obtenerAlquileres();
        }

        private void actualizarCBs()
        {
            cbTipoAgregar.DataSource = null;
            cbIdEliminar.DataSource = null;
            cbIdModificar.DataSource = null;

            cbTipoAgregar.DataSource = tipoBicicletaBusiness.obtenerTipoBicicletas();
            cbIdEliminar.DataSource = alquilerBusiness.obtenerAlquileres();
            cbIdModificar.DataSource = alquilerBusiness.obtenerAlquileres();

            cbTipoAgregar.ValueMember = "IdTipoBicicleta";
            cbTipoAgregar.DisplayMember = "Descripcion";
            cbIdEliminar.ValueMember = "NumeroAlquiler";
            cbIdEliminar.DisplayMember = "NumeroAlquiler";
            cbIdModificar.ValueMember = "NumeroAlquiler";
            cbIdModificar.DisplayMember = "NumeroAlquiler";
        }

        private void btnAgregarAlquiler_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarDNI(tbDniAgregar.Text);
                ValidarFecha(dtFechaAlquilerAgregar.Value);
                ValidarTipoBicicleta(Convert.ToInt32(cbTipoAgregar.SelectedValue));
                if (!Double.TryParse(tbImporteAgregar.Text, out double number))
                {
                    throw new Exception("Formato de importe invalido");
                }
                ValidarImporte(number);

                Alquiler alquiler = new Alquiler(); 
                TipoBicicleta temp = new TipoBicicleta();
                alquiler.DniCliente = tbDniAgregar.Text;
                temp.IdTipoBicicleta = Convert.ToInt32(cbTipoAgregar.SelectedValue);
                alquiler.TipoBicicleta = temp;
                alquiler.FechaAlquiler = dtFechaAlquilerAgregar.Value;
                alquiler.ImporteTotal = Convert.ToDouble(tbImporteAgregar.Text);
                alquiler.FechaRegistro = DateTime.Now;

                borrador.Add(alquiler);

                MessageBox.Show("Agregado al borrador");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCargarDeLista_Click(object sender, EventArgs e)
        {

            try
            {
                alquilerBusiness.GuardarAlquileres(borrador);
                MessageBox.Show("Alquileres Agregados Correctametne");
                actualizarDgv();
                actualizarCBs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarAlquiler_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarFecha(dtFechaAlquilerModificar.Value);
                if (!Double.TryParse(tbImporteModificar.Text, out double number))
                {
                    throw new Exception("Formato de importe invalido");
                }
                ValidarImporte(number);

                alquilerBusiness.modificarAlquiler(Convert.ToInt32(cbIdModificar.SelectedValue), Convert.ToDouble(tbImporteModificar.Text), dtFechaAlquilerModificar.Value);
                MessageBox.Show("Alquiler Modificado Correctamente.");
                actualizarDgv();
                actualizarCBs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarAlquiler_Click(object sender, EventArgs e)
        {
            try
            {
                alquilerBusiness.eliminarAlquiler(Convert.ToInt32(cbIdEliminar.SelectedValue));
                MessageBox.Show("Alquiler Eliminado Correctamente.");
                actualizarDgv();
                actualizarCBs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // mismas validaciones que en la capa de negocio. seria mas prolijo ponerlo en una clase de utilidad

        public void ValidarDNI(string dni)
        {

            if (String.IsNullOrEmpty(dni))
            {
                throw new Exception("El numero de DNI no puede estar vacio.");
            }

            if (dni.Length < 5)
            {
                throw new Exception("El DNI debe tener mas de 5 caracteres.");
            }
        }

        public void ValidarFecha(DateTime fecha)
        {
            if (fecha.CompareTo(DateTime.Now) < 0)
            {
                throw new Exception("La fecha no puede ser menor a ala ctual.");
            }
        }

        public void ValidarTipoBicicleta(int tipo)
        {
            if (tipo == 0)
            {
                throw new Exception("Debe haber un tipo de bicicleta seleccionado");

            }
        }

        public void ValidarImporte(double importe)
        {
            if (importe <= 0)
            {
                throw new Exception("El importe debe ser mayor a 0");

            }
        }
    }
}
