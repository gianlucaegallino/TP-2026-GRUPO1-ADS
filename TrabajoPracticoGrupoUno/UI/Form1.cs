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
            // TODO T09: cargar gridPais (getActivos o getAll según chkPaisInactivos)
        }

        private void btnPaisGuardar_Click(object? sender, EventArgs e)
        {
            // TODO T09
        }

        private void btnPaisModificar_Click(object? sender, EventArgs e)
        {
            // TODO T09
        }

        private void btnPaisEstado_Click(object? sender, EventArgs e)
        {
            // TODO T09
        }

        private void btnPaisLimpiar_Click(object? sender, EventArgs e)
        {
            // TODO T09
        }

        private void chkPaisInactivos_CheckedChanged(object? sender, EventArgs e)
        {
            // TODO T09
        }

        private void gridPais_SelectionChanged(object? sender, EventArgs e)
        {
            // TODO T09: pasar la fila seleccionada a los controles
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

        private void ConectarEventosJugador()
        {
            btnJugadorGuardar.Click += btnJugadorGuardar_Click;
            btnJugadorModificar.Click += btnJugadorModificar_Click;
            btnJugadorEstado.Click += btnJugadorEstado_Click;
            btnJugadorLimpiar.Click += btnJugadorLimpiar_Click;
            chkJugadorInactivos.CheckedChanged += chkJugadorInactivos_CheckedChanged;
            gridJugador.SelectionChanged += gridJugador_SelectionChanged;
        }

        private void CargarPestanaJugador()
        {
            // TODO T12: cargar combos de Equipo y País + gridJugador
        }

        private void btnJugadorGuardar_Click(object? sender, EventArgs e)
        {
            // TODO T12
        }

        private void btnJugadorModificar_Click(object? sender, EventArgs e)
        {
            // TODO T12
        }

        private void btnJugadorEstado_Click(object? sender, EventArgs e)
        {
            // TODO T12
        }

        private void btnJugadorLimpiar_Click(object? sender, EventArgs e)
        {
            // TODO T12
        }

        private void chkJugadorInactivos_CheckedChanged(object? sender, EventArgs e)
        {
            // TODO T12
        }

        private void gridJugador_SelectionChanged(object? sender, EventArgs e)
        {
            // TODO T12
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
            // TODO T13: cargar combos de Torneo, Local y Visitante + gridPartido
        }

        private void btnPartidoGuardar_Click(object? sender, EventArgs e)
        {
            // TODO T13
        }

        private void btnPartidoModificar_Click(object? sender, EventArgs e)
        {
            // TODO T13
        }

        private void btnPartidoEstado_Click(object? sender, EventArgs e)
        {
            // TODO T13
        }

        private void btnPartidoLimpiar_Click(object? sender, EventArgs e)
        {
            // TODO T13
        }

        private void chkPartidoInactivos_CheckedChanged(object? sender, EventArgs e)
        {
            // TODO T13
        }

        private void chkResultado_CheckedChanged(object? sender, EventArgs e)
        {
            // TODO T13: habilitar/deshabilitar PartidoGolesLocal y PartidoGolesVisitante
        }

        private void gridPartido_SelectionChanged(object? sender, EventArgs e)
        {
            // TODO T13
        }

        #endregion
    }
}