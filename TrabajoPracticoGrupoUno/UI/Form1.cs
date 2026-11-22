using BLL;
using Entity;

namespace UI
{
    public partial class Form1 : Form
    {
        // ====================================================================
        // COMÚN (T08) - No modificar sin avisar al grupo
        // ====================================================================
        private readonly PaisBusiness paisBusiness = new();
        private readonly EquipoBusiness equipoBusiness = new();
        private readonly JugadorBusiness jugadorBusiness = new();
        private readonly TorneoBusiness torneoBusiness = new();
        private readonly PartidoBusiness partidoBusiness = new();

        public Form1()
        {
            InitializeComponent();

            // Cada pestaña conecta sus propios eventos en su bloque.
            ConectarEventosPais();
            ConectarEventosEquipo();
            ConectarEventosJugador();
            ConectarEventosTorneo();
            ConectarEventosPartido();

            Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            CargarPestanaPais();
            CargarPestanaEquipo();
            CargarPestanaJugador();
            CargarPestanaTorneo();
            CargarPestanaPartido();
            ConfigurarGrillaPartido();
            LimpiarPartido();
        }

        // Muestra cualquier error de validación o de base de datos.
        private void MostrarError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MostrarOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ====================================================================
        // PESTAÑA PAÍSES (T09) - Responsable: ________
        // Controles: PaisNombre, gridPais, chkPaisInactivos,
        //            btnPaisGuardar, btnPaisModificar, btnPaisEstado, btnPaisLimpiar
        // Negocio:   paisBusiness.add / update / cambiarEstado / getAll / getActivos / getById
        // ====================================================================

        #region Pestaña Países

        private int idPaisSeleccionado = 0;

        private void ConectarEventosPais()
        {
            btnPaisGuardar.Click += btnPaisGuardar_Click;
            btnPaisModificar.Click += btnPaisModificar_Click;
            btnPaisEstado.Click += btnPaisEstado_Click;
            btnPaisLimpiar.Click += btnPaisLimpiar_Click;
            chkPaisInactivos.CheckedChanged += chkPaisInactivos_CheckedChanged;
            gridPais.SelectionChanged += gridPais_SelectionChanged;
        }

        private void CargarPestanaPais()
        {
            try
            {
                idPaisSeleccionado = 0;

                gridPais.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                gridPais.MultiSelect = false;
                gridPais.ReadOnly = true;

                gridPais.DataSource = null;

                if (chkPaisInactivos.Checked)
                    gridPais.DataSource = paisBusiness.getAll();
                else
                    gridPais.DataSource = paisBusiness.getActivos();

                LimpiarPais();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnPaisGuardar_Click(object? sender, EventArgs e)
        {
            try
            {
                PaisEntity pais = new PaisEntity();
                pais.Nombre = PaisNombre.Text;

                paisBusiness.add(pais);

                CargarPestanaPais();

                MostrarOk("País guardado correctamente");
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnPaisModificar_Click(object? sender, EventArgs e)
        {
            try
            {
                PaisEntity pais = new PaisEntity();

                pais.IdPais = idPaisSeleccionado;
                pais.Nombre = PaisNombre.Text;

                paisBusiness.update(pais);

                CargarPestanaPais();

                MostrarOk("País modificado correctamente");
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnPaisEstado_Click(object? sender, EventArgs e)
        {
            try
            {
                paisBusiness.cambiarEstado(idPaisSeleccionado);

                CargarPestanaPais();

                MostrarOk("Estado actualizado correctamente");
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnPaisLimpiar_Click(object? sender, EventArgs e)
        {
            LimpiarPais();
        }

        private void chkPaisInactivos_CheckedChanged(
            object? sender, EventArgs e)
        {
            CargarPestanaPais();
        }

        private void gridPais_SelectionChanged(
            object? sender, EventArgs e)
        {
            if (gridPais.SelectedRows.Count > 0 &&
                gridPais.SelectedRows[0].DataBoundItem is PaisEntity pais)
            {
                idPaisSeleccionado = pais.IdPais;
                PaisNombre.Text = pais.Nombre;
            }
            else
            {
                idPaisSeleccionado = 0;
            }
        }

        private void LimpiarPais()
        {
            gridPais.ClearSelection();
            idPaisSeleccionado = 0;
            PaisNombre.Clear();
            PaisNombre.Focus();
        }

        #endregion

        // ====================================================================
        // PESTAÑA EQUIPOS (T11) - Responsable: ________
        // Controles: EquipoNombre, EquipoFechaFundacion, gridEquipo, chkEquipoInactivos,
        //            btnEquipoGuardar, btnEquipoModificar, btnEquipoEstado, btnEquipoLimpiar
        // Negocio:   equipoBusiness.add / update / cambiarEstado / getAll / getActivos / getById
        // ====================================================================
        #region Pestaña Equipos

        private void ConectarEventosEquipo()
        {
            btnEquipoGuardar.Click += btnEquipoGuardar_Click;
            btnEquipoModificar.Click += btnEquipoModificar_Click;
            btnEquipoEstado.Click += btnEquipoEstado_Click;
            btnEquipoLimpiar.Click += btnEquipoLimpiar_Click;
            chkEquipoInactivos.CheckedChanged += chkEquipoInactivos_CheckedChanged;
            gridEquipo.SelectionChanged += gridEquipo_SelectionChanged;
        }

        private void CargarPestanaEquipo()
        {
            // TODO T11
        }

        private void btnEquipoGuardar_Click(object? sender, EventArgs e)
        {
            // TODO T11
        }

        private void btnEquipoModificar_Click(object? sender, EventArgs e)
        {
            // TODO T11
        }

        private void btnEquipoEstado_Click(object? sender, EventArgs e)
        {
            // TODO T11
        }

        private void btnEquipoLimpiar_Click(object? sender, EventArgs e)
        {
            // TODO T11
        }

        private void chkEquipoInactivos_CheckedChanged(object? sender, EventArgs e)
        {
            // TODO T11
        }

        private void gridEquipo_SelectionChanged(object? sender, EventArgs e)
        {
            // TODO T11
        }

        #endregion

        // ====================================================================
        // PESTAÑA JUGADORES (T12) - Responsable: ________
        // Controles: JugadorNombre, JugadorApellido, JugadorNumeroCamiseta (NumericUpDown),
        //            JugadorIdEquipo (ComboBox), JugadorIdPais (ComboBox),
        //            gridJugador, chkJugadorInactivos,
        //            btnJugadorGuardar, btnJugadorModificar, btnJugadorEstado, btnJugadorLimpiar
        // Negocio:   jugadorBusiness.add / update / cambiarEstado / getAll / getActivos / getById
        //            combos: equipoBusiness.getActivos(), paisBusiness.getActivos()
        // ====================================================================
        #region Pestaña Jugadores

        private int idJugadorSeleccionado = 0;

        private void ConectarEventosJugador()
        {
            btnJugadorGuardar.Click += btnJugadorGuardar_Click;
            btnJugadorModificar.Click += btnJugadorModificar_Click;
            btnJugadorEstado.Click += btnJugadorEstado_Click;
            btnJugadorLimpiar.Click += btnJugadorLimpiar_Click;
            chkJugadorInactivos.CheckedChanged += chkJugadorInactivos_CheckedChanged;
            gridJugador.SelectionChanged += gridJugador_SelectionChanged;

            // Al entrar a la pestaña Jugadores se recargan los combos,
            // por si en Equipos o Países se agregó o desactivó algo.
            pestanas.SelectedIndexChanged += pestanas_SelectedIndexChanged_Jugador;
        }

        private void CargarPestanaJugador()
        {
            try
            {
                idJugadorSeleccionado = 0;

                gridJugador.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                gridJugador.MultiSelect = false;
                gridJugador.ReadOnly = true;

                CargarCombosJugador();

                gridJugador.DataSource = null;

                if (chkJugadorInactivos.Checked)
                    gridJugador.DataSource = jugadorBusiness.getAll();
                else
                    gridJugador.DataSource = jugadorBusiness.getActivos();

                LimpiarJugador();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        // Llena los combos solo con equipos y países activos.
        private void CargarCombosJugador()
        {
            JugadorIdEquipo.DataSource = null;
            JugadorIdEquipo.DataSource = equipoBusiness.getActivos();
            JugadorIdEquipo.DisplayMember = "Nombre";
            JugadorIdEquipo.ValueMember = "IdEquipo";

            JugadorIdPais.DataSource = null;
            JugadorIdPais.DataSource = paisBusiness.getActivos();
            JugadorIdPais.DisplayMember = "Nombre";
            JugadorIdPais.ValueMember = "IdPais";
        }

        private void btnJugadorGuardar_Click(object? sender, EventArgs e)
        {
            try
            {
                JugadorEntity jugador = LeerJugadorDeControles();

                jugadorBusiness.add(jugador);

                CargarPestanaJugador();

                MostrarOk("Jugador guardado correctamente");
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnJugadorModificar_Click(object? sender, EventArgs e)
        {
            try
            {
                JugadorEntity jugador = LeerJugadorDeControles();
                jugador.IdJugador = idJugadorSeleccionado;

                jugadorBusiness.update(jugador);

                CargarPestanaJugador();

                MostrarOk("Jugador modificado correctamente");
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnJugadorEstado_Click(object? sender, EventArgs e)
        {
            try
            {
                jugadorBusiness.cambiarEstado(idJugadorSeleccionado);

                CargarPestanaJugador();

                MostrarOk("Estado actualizado correctamente");
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnJugadorLimpiar_Click(object? sender, EventArgs e)
        {
            LimpiarJugador();
        }

        private void chkJugadorInactivos_CheckedChanged(
            object? sender, EventArgs e)
        {
            CargarPestanaJugador();
        }

        private void gridJugador_SelectionChanged(
            object? sender, EventArgs e)
        {
            if (gridJugador.SelectedRows.Count > 0 &&
                gridJugador.SelectedRows[0].DataBoundItem is JugadorEntity jugador)
            {
                idJugadorSeleccionado = jugador.IdJugador;
                JugadorNombre.Text = jugador.Nombre;
                JugadorApellido.Text = jugador.Apellido;
                JugadorNumeroCamiseta.Value = jugador.NumeroCamiseta;
                JugadorIdEquipo.SelectedValue = jugador.IdEquipo;
                JugadorIdPais.SelectedValue = jugador.IdPais;
            }
            else
            {
                idJugadorSeleccionado = 0;
            }
        }

        private void pestanas_SelectedIndexChanged_Jugador(
            object? sender, EventArgs e)
        {
            if (pestanas.SelectedTab == tabJugador)
                CargarPestanaJugador();
        }

        // Arma un JugadorEntity con lo que el usuario cargó en pantalla.
        private JugadorEntity LeerJugadorDeControles()
        {
            JugadorEntity jugador = new JugadorEntity();

            jugador.Nombre = JugadorNombre.Text;
            jugador.Apellido = JugadorApellido.Text;
            jugador.NumeroCamiseta = (int)JugadorNumeroCamiseta.Value;

            // Si no hay nada elegido en el combo, queda en 0
            // y la BLL muestra "Debe seleccionar un equipo/país".
            jugador.IdEquipo = JugadorIdEquipo.SelectedValue is int idEquipo ? idEquipo : 0;
            jugador.IdPais = JugadorIdPais.SelectedValue is int idPais ? idPais : 0;

            return jugador;
        }

        private void LimpiarJugador()
        {
            gridJugador.ClearSelection();
            idJugadorSeleccionado = 0;
            JugadorNombre.Clear();
            JugadorApellido.Clear();
            JugadorNumeroCamiseta.Value = JugadorNumeroCamiseta.Minimum;
            JugadorIdEquipo.SelectedIndex = -1;
            JugadorIdPais.SelectedIndex = -1;
            JugadorNombre.Focus();
        }

        #endregion

        // ====================================================================
        // PESTAÑA TORNEOS (T10) - Responsable: ________
        // Controles: TorneoNombre, TorneoAño (NumericUpDown), gridTorneo, chkTorneoInactivos,
        //            btnTorneoGuardar, btnTorneoModificar, btnTorneoEstado, btnTorneoLimpiar
        // Negocio:   torneoBusiness.add / update / cambiarEstado / getAll / getActivos / getById
        // ====================================================================
        #region Pestaña Torneos

        private void ConectarEventosTorneo()
        {
            btnTorneoGuardar.Click += btnTorneoGuardar_Click;
            btnTorneoModificar.Click += btnTorneoModificar_Click;
            btnTorneoEstado.Click += btnTorneoEstado_Click;
            btnTorneoLimpiar.Click += btnTorneoLimpiar_Click;
            chkTorneoInactivos.CheckedChanged += chkTorneoInactivos_CheckedChanged;
            gridTorneo.SelectionChanged += gridTorneo_SelectionChanged;
        }

        private void CargarPestanaTorneo()
        {
            // TODO T10
        }

        private void btnTorneoGuardar_Click(object? sender, EventArgs e)
        {
            // TODO T10
        }

        private void btnTorneoModificar_Click(object? sender, EventArgs e)
        {
            // TODO T10
        }

        private void btnTorneoEstado_Click(object? sender, EventArgs e)
        {
            // TODO T10
        }

        private void btnTorneoLimpiar_Click(object? sender, EventArgs e)
        {
            // TODO T10
        }

        private void chkTorneoInactivos_CheckedChanged(object? sender, EventArgs e)
        {
            // TODO T10
        }

        private void gridTorneo_SelectionChanged(object? sender, EventArgs e)
        {
            // TODO T10
        }

        #endregion

        // ====================================================================
        // PESTAÑA PARTIDOS (T13) - Responsable: ________
        // Controles: PartidoIdTorneo, PartidoIdEquipoLocal, PartidoIdEquipoVisitante (ComboBox),
        //            PartidoFecha (DateTimePicker), PartidoGolesLocal, PartidoGolesVisitante (NumericUpDown),
        //            chkResultado, gridPartido, chkPartidoInactivos,
        //            btnPartidoGuardar, btnPartidoModificar, btnPartidoEstado, btnPartidoLimpiar
        // Negocio:   partidoBusiness.add(entity, resultadoCargado) / update(entity, resultadoCargado)
        //            / cambiarEstado / getAll / getActivos / getById / getIdsConResultado
        //            combos: torneoBusiness.getActivos(), equipoBusiness.getActivos()
        // ====================================================================
        #region Pestaña Partidos
        private int idPartidoSeleccionado = 0;
        private void ConectarEventosPartido()
        {
            btnPartidoGuardar.Click += btnPartidoGuardar_Click;
            btnPartidoModificar.Click += btnPartidoModificar_Click;
            btnPartidoEstado.Click += btnPartidoEstado_Click;
            btnPartidoLimpiar.Click += btnPartidoLimpiar_Click;
            chkPartidoInactivos.CheckedChanged += chkPartidoInactivos_CheckedChanged;
            chkResultado.CheckedChanged += chkResultado_CheckedChanged;
            gridPartido.SelectionChanged += gridPartido_SelectionChanged;
        }


        private void CargarPestanaPartido()
        {
            try
            {
                idPartidoSeleccionado = 0;

                // Cargar torneos activos
                PartidoIdTorneo.DataSource = null;
                PartidoIdTorneo.DisplayMember = "Nombre";
                PartidoIdTorneo.ValueMember = "IdTorneo";
                PartidoIdTorneo.DataSource = torneoBusiness.getActivos();

                // Cargar equipos locales activos
                PartidoIdEquipoLocal.DataSource = null;
                PartidoIdEquipoLocal.DisplayMember = "Nombre";
                PartidoIdEquipoLocal.ValueMember = "IdEquipo";
                PartidoIdEquipoLocal.DataSource = equipoBusiness.getActivos();

                // Cargar equipos visitantes activos
                PartidoIdEquipoVisitante.DataSource = null;
                PartidoIdEquipoVisitante.DisplayMember = "Nombre";
                PartidoIdEquipoVisitante.ValueMember = "IdEquipo";
                PartidoIdEquipoVisitante.DataSource = equipoBusiness.getActivos();

                // Cargar partidos
                gridPartido.DataSource = null;

                if (chkPartidoInactivos.Checked)
                    gridPartido.DataSource = partidoBusiness.getAll();
                else
                    gridPartido.DataSource = partidoBusiness.getActivos();

                LimpiarPartido();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }


        private PartidoEntity LeerPartidoDeControles()
        {
            PartidoEntity partido = new PartidoEntity();

            partido.IdTorneo = PartidoIdTorneo.SelectedValue is int idTorneo
                ? idTorneo : 0;

            partido.IdEquipoLocal = PartidoIdEquipoLocal.SelectedValue is int idLocal
                ? idLocal : 0;

            partido.IdEquipoVisitante = PartidoIdEquipoVisitante.SelectedValue is int idVisitante
                ? idVisitante : 0;

            partido.Fecha = PartidoFecha.Value;

            partido.GolesLocal = (int)PartidoGolesLocal.Value;
            partido.GolesVisitante = (int)PartidoGolesVisitante.Value;

            return partido;
        }



        private void btnPartidoGuardar_Click(object? sender, EventArgs e)
        {
            try
            {
                PartidoEntity partido = LeerPartidoDeControles();

                partidoBusiness.add(partido, chkResultado.Checked);

                CargarPestanaPartido();

                MostrarOk("Partido guardado correctamente");
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }



        private void btnPartidoModificar_Click(object? sender, EventArgs e)
        {
            try
            {
                PartidoEntity partido = LeerPartidoDeControles();

                partido.IdPartido = idPartidoSeleccionado;

                partidoBusiness.update(partido, chkResultado.Checked);

                CargarPestanaPartido();

                MostrarOk("Partido modificado correctamente");
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }



        private void btnPartidoEstado_Click(object? sender, EventArgs e)
        {
            try
            {
                partidoBusiness.cambiarEstado(idPartidoSeleccionado);

                CargarPestanaPartido();

                MostrarOk("Estado del partido actualizado correctamente");
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }



        private void btnPartidoLimpiar_Click(object? sender, EventArgs e)
        {
            try
            {
                LimpiarPartido();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void LimpiarPartido()
        {
            try
            {
                idPartidoSeleccionado = 0;

                PartidoIdTorneo.SelectedIndex = -1;
                PartidoIdEquipoLocal.SelectedIndex = -1;
                PartidoIdEquipoVisitante.SelectedIndex = -1;

                PartidoFecha.Value = DateTime.Now;

                chkResultado.Checked = false;

                PartidoGolesLocal.Value = 0;
                PartidoGolesVisitante.Value = 0;

                gridPartido.ClearSelection();
            }
            catch (Exception ex) 
            {
                MostrarError(ex);
            }
        }



        private void chkPartidoInactivos_CheckedChanged(object? sender, EventArgs e)
        {
            try
            {
                CargarPestanaPartido();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }



        private void chkResultado_CheckedChanged(object? sender, EventArgs e)
        {
            PartidoGolesLocal.Enabled = chkResultado.Checked;
            PartidoGolesVisitante.Enabled = chkResultado.Checked;

            if (!chkResultado.Checked)
            {
                PartidoGolesLocal.Value = 0;
                PartidoGolesVisitante.Value = 0;
            }
        }


        private void ConfigurarGrillaPartido()
        {
            gridPartido.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            gridPartido.MultiSelect = false;
            gridPartido.ReadOnly = true;
            gridPartido.AllowUserToAddRows = false;

            gridPartido.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            gridPartido.ClearSelection();
        }



        private void gridPartido_SelectionChanged(object? sender, EventArgs e)
        {
            try
            {
                if (gridPartido.SelectedRows.Count > 0 &&
                    gridPartido.SelectedRows[0].DataBoundItem is PartidoEntity partido)
                {
                    idPartidoSeleccionado = partido.IdPartido;

                    PartidoIdTorneo.SelectedValue = partido.IdTorneo;
                    PartidoIdEquipoLocal.SelectedValue = partido.IdEquipoLocal;
                    PartidoIdEquipoVisitante.SelectedValue = partido.IdEquipoVisitante;

                    PartidoFecha.Value = partido.Fecha;

                    chkResultado.Checked = partido.FechaFinPartido.HasValue;

                    PartidoGolesLocal.Value = partido.GolesLocal;
                    PartidoGolesVisitante.Value = partido.GolesVisitante;
                }
                else
                {
                    idPartidoSeleccionado = 0;
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        #endregion
    }
}