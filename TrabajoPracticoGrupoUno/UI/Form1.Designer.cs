namespace ParcialUnoGallino
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        #region Código generado para el diseñador de Windows Forms
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pestanas = new System.Windows.Forms.TabControl();
            this.tabPais = new System.Windows.Forms.TabPage();
            this.lblPaisNombre = new System.Windows.Forms.Label();
            this.PaisNombre = new System.Windows.Forms.TextBox();
            this.btnPaisGuardar = new System.Windows.Forms.Button();
            this.btnPaisModificar = new System.Windows.Forms.Button();
            this.btnPaisEstado = new System.Windows.Forms.Button();
            this.btnPaisLimpiar = new System.Windows.Forms.Button();
            this.chkPaisInactivos = new System.Windows.Forms.CheckBox();
            this.gridPais = new System.Windows.Forms.DataGridView();
            this.tabEquipo = new System.Windows.Forms.TabPage();
            this.lblEquipoNombre = new System.Windows.Forms.Label();
            this.EquipoNombre = new System.Windows.Forms.TextBox();
            this.lblEquipoFechaFundacion = new System.Windows.Forms.Label();
            this.EquipoFechaFundacion = new System.Windows.Forms.DateTimePicker();
            this.btnEquipoGuardar = new System.Windows.Forms.Button();
            this.btnEquipoModificar = new System.Windows.Forms.Button();
            this.btnEquipoEstado = new System.Windows.Forms.Button();
            this.btnEquipoLimpiar = new System.Windows.Forms.Button();
            this.chkEquipoInactivos = new System.Windows.Forms.CheckBox();
            this.gridEquipo = new System.Windows.Forms.DataGridView();
            this.tabJugador = new System.Windows.Forms.TabPage();
            this.lblJugadorNombre = new System.Windows.Forms.Label();
            this.JugadorNombre = new System.Windows.Forms.TextBox();
            this.lblJugadorApellido = new System.Windows.Forms.Label();
            this.JugadorApellido = new System.Windows.Forms.TextBox();
            this.lblJugadorNumeroCamiseta = new System.Windows.Forms.Label();
            this.JugadorNumeroCamiseta = new System.Windows.Forms.NumericUpDown();
            this.lblJugadorIdEquipo = new System.Windows.Forms.Label();
            this.JugadorIdEquipo = new System.Windows.Forms.ComboBox();
            this.lblJugadorIdPais = new System.Windows.Forms.Label();
            this.JugadorIdPais = new System.Windows.Forms.ComboBox();
            this.btnJugadorGuardar = new System.Windows.Forms.Button();
            this.btnJugadorModificar = new System.Windows.Forms.Button();
            this.btnJugadorEstado = new System.Windows.Forms.Button();
            this.btnJugadorLimpiar = new System.Windows.Forms.Button();
            this.chkJugadorInactivos = new System.Windows.Forms.CheckBox();
            this.gridJugador = new System.Windows.Forms.DataGridView();
            this.tabTorneo = new System.Windows.Forms.TabPage();
            this.lblTorneoNombre = new System.Windows.Forms.Label();
            this.TorneoNombre = new System.Windows.Forms.TextBox();
            this.lblTorneoAño = new System.Windows.Forms.Label();
            this.TorneoAño = new System.Windows.Forms.NumericUpDown();
            this.btnTorneoGuardar = new System.Windows.Forms.Button();
            this.btnTorneoModificar = new System.Windows.Forms.Button();
            this.btnTorneoEstado = new System.Windows.Forms.Button();
            this.btnTorneoLimpiar = new System.Windows.Forms.Button();
            this.chkTorneoInactivos = new System.Windows.Forms.CheckBox();
            this.gridTorneo = new System.Windows.Forms.DataGridView();
            this.tabPartido = new System.Windows.Forms.TabPage();
            this.lblPartidoIdTorneo = new System.Windows.Forms.Label();
            this.PartidoIdTorneo = new System.Windows.Forms.ComboBox();
            this.lblPartidoIdEquipoLocal = new System.Windows.Forms.Label();
            this.PartidoIdEquipoLocal = new System.Windows.Forms.ComboBox();
            this.lblPartidoIdEquipoVisitante = new System.Windows.Forms.Label();
            this.PartidoIdEquipoVisitante = new System.Windows.Forms.ComboBox();
            this.lblPartidoFecha = new System.Windows.Forms.Label();
            this.PartidoFecha = new System.Windows.Forms.DateTimePicker();
            this.lblPartidoGolesLocal = new System.Windows.Forms.Label();
            this.PartidoGolesLocal = new System.Windows.Forms.NumericUpDown();
            this.lblPartidoGolesVisitante = new System.Windows.Forms.Label();
            this.PartidoGolesVisitante = new System.Windows.Forms.NumericUpDown();
            this.chkResultado = new System.Windows.Forms.CheckBox();
            this.btnPartidoGuardar = new System.Windows.Forms.Button();
            this.btnPartidoModificar = new System.Windows.Forms.Button();
            this.btnPartidoEstado = new System.Windows.Forms.Button();
            this.btnPartidoLimpiar = new System.Windows.Forms.Button();
            this.chkPartidoInactivos = new System.Windows.Forms.CheckBox();
            this.gridPartido = new System.Windows.Forms.DataGridView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.pestanas.SuspendLayout();
            this.tabPais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPais)).BeginInit();
            this.tabEquipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipo)).BeginInit();
            this.tabJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JugadorNumeroCamiseta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridJugador)).BeginInit();
            this.tabTorneo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TorneoAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTorneo)).BeginInit();
            this.tabPartido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartidoGolesLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartidoGolesVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPartido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(900, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestor de Torneos y Equipos";

            // 
            // pestanas
            // 
            this.pestanas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pestanas.Controls.Add(this.tabPais);
            this.pestanas.Controls.Add(this.tabEquipo);
            this.pestanas.Controls.Add(this.tabJugador);
            this.pestanas.Controls.Add(this.tabTorneo);
            this.pestanas.Controls.Add(this.tabPartido);
            this.pestanas.Location = new System.Drawing.Point(20, 65);
            this.pestanas.Name = "pestanas";
            this.pestanas.SelectedIndex = 0;
            this.pestanas.Size = new System.Drawing.Size(940, 550);
            this.pestanas.TabIndex = 1;

            // 
            // tabPais
            // 
            this.tabPais.Controls.Add(this.lblPaisNombre);
            this.tabPais.Controls.Add(this.PaisNombre);
            this.tabPais.Controls.Add(this.btnPaisGuardar);
            this.tabPais.Controls.Add(this.btnPaisModificar);
            this.tabPais.Controls.Add(this.btnPaisEstado);
            this.tabPais.Controls.Add(this.btnPaisLimpiar);
            this.tabPais.Controls.Add(this.chkPaisInactivos);
            this.tabPais.Controls.Add(this.gridPais);
            this.tabPais.Location = new System.Drawing.Point(4, 26);
            this.tabPais.Name = "tabPais";
            this.tabPais.Size = new System.Drawing.Size(932, 520);
            this.tabPais.TabIndex = 0;
            this.tabPais.Text = "Países";
            this.tabPais.UseVisualStyleBackColor = true;
            // 
            // lblPaisNombre
            // 
            this.lblPaisNombre.Location = new System.Drawing.Point(20, 20);
            this.lblPaisNombre.Name = "lblPaisNombre";
            this.lblPaisNombre.Size = new System.Drawing.Size(270, 22);
            this.lblPaisNombre.TabIndex = 0;
            this.lblPaisNombre.Text = "Nombre";
            // 
            // PaisNombre
            // 
            this.PaisNombre.Location = new System.Drawing.Point(20, 45);
            this.PaisNombre.MaxLength = 50;
            this.PaisNombre.Name = "PaisNombre";
            this.PaisNombre.Size = new System.Drawing.Size(270, 25);
            this.PaisNombre.TabIndex = 1;
            // 
            // btnPaisGuardar
            // 
            this.btnPaisGuardar.Location = new System.Drawing.Point(20, 200);
            this.btnPaisGuardar.Name = "btnPaisGuardar";
            this.btnPaisGuardar.Size = new System.Drawing.Size(165, 34);
            this.btnPaisGuardar.TabIndex = 2;
            this.btnPaisGuardar.Text = "Guardar nuevo";
            this.btnPaisGuardar.UseVisualStyleBackColor = true;

            // 
            // btnPaisModificar
            // 
            this.btnPaisModificar.Location = new System.Drawing.Point(195, 200);
            this.btnPaisModificar.Name = "btnPaisModificar";
            this.btnPaisModificar.Size = new System.Drawing.Size(165, 34);
            this.btnPaisModificar.TabIndex = 3;
            this.btnPaisModificar.Text = "Modificar";
            this.btnPaisModificar.UseVisualStyleBackColor = true;

            // 
            // btnPaisEstado
            // 
            this.btnPaisEstado.Location = new System.Drawing.Point(370, 200);
            this.btnPaisEstado.Name = "btnPaisEstado";
            this.btnPaisEstado.Size = new System.Drawing.Size(165, 34);
            this.btnPaisEstado.TabIndex = 4;
            this.btnPaisEstado.Text = "Activar / Desactivar";
            this.btnPaisEstado.UseVisualStyleBackColor = true;

            // 
            // btnPaisLimpiar
            // 
            this.btnPaisLimpiar.Location = new System.Drawing.Point(545, 200);
            this.btnPaisLimpiar.Name = "btnPaisLimpiar";
            this.btnPaisLimpiar.Size = new System.Drawing.Size(165, 34);
            this.btnPaisLimpiar.TabIndex = 5;
            this.btnPaisLimpiar.Text = "Limpiar";
            this.btnPaisLimpiar.UseVisualStyleBackColor = true;

            // 
            // chkPaisInactivos
            // 
            this.chkPaisInactivos.Location = new System.Drawing.Point(730, 205);
            this.chkPaisInactivos.Name = "chkPaisInactivos";
            this.chkPaisInactivos.Size = new System.Drawing.Size(175, 25);
            this.chkPaisInactivos.TabIndex = 6;
            this.chkPaisInactivos.Text = "Mostrar inactivos";

            // 
            // gridPais
            // 
            this.gridPais.AllowUserToAddRows = false;
            this.gridPais.AllowUserToDeleteRows = false;
            this.gridPais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPais.BackgroundColor = System.Drawing.Color.White;
            this.gridPais.Location = new System.Drawing.Point(20, 250);
            this.gridPais.MultiSelect = false;
            this.gridPais.Name = "gridPais";
            this.gridPais.ReadOnly = true;
            this.gridPais.RowHeadersVisible = false;
            this.gridPais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPais.Size = new System.Drawing.Size(885, 255);
            this.gridPais.TabIndex = 7;

            // 
            // tabEquipo
            // 
            this.tabEquipo.Controls.Add(this.lblEquipoNombre);
            this.tabEquipo.Controls.Add(this.EquipoNombre);
            this.tabEquipo.Controls.Add(this.lblEquipoFechaFundacion);
            this.tabEquipo.Controls.Add(this.EquipoFechaFundacion);
            this.tabEquipo.Controls.Add(this.btnEquipoGuardar);
            this.tabEquipo.Controls.Add(this.btnEquipoModificar);
            this.tabEquipo.Controls.Add(this.btnEquipoEstado);
            this.tabEquipo.Controls.Add(this.btnEquipoLimpiar);
            this.tabEquipo.Controls.Add(this.chkEquipoInactivos);
            this.tabEquipo.Controls.Add(this.gridEquipo);
            this.tabEquipo.Location = new System.Drawing.Point(4, 26);
            this.tabEquipo.Name = "tabEquipo";
            this.tabEquipo.Size = new System.Drawing.Size(932, 520);
            this.tabEquipo.TabIndex = 1;
            this.tabEquipo.Text = "Equipos";
            this.tabEquipo.UseVisualStyleBackColor = true;
            // 
            // lblEquipoNombre
            // 
            this.lblEquipoNombre.Location = new System.Drawing.Point(20, 20);
            this.lblEquipoNombre.Name = "lblEquipoNombre";
            this.lblEquipoNombre.Size = new System.Drawing.Size(270, 22);
            this.lblEquipoNombre.TabIndex = 0;
            this.lblEquipoNombre.Text = "Nombre";
            // 
            // EquipoNombre
            // 
            this.EquipoNombre.Location = new System.Drawing.Point(20, 45);
            this.EquipoNombre.MaxLength = 50;
            this.EquipoNombre.Name = "EquipoNombre";
            this.EquipoNombre.Size = new System.Drawing.Size(270, 25);
            this.EquipoNombre.TabIndex = 1;
            // 
            // lblEquipoFechaFundacion
            // 
            this.lblEquipoFechaFundacion.Location = new System.Drawing.Point(320, 20);
            this.lblEquipoFechaFundacion.Name = "lblEquipoFechaFundacion";
            this.lblEquipoFechaFundacion.Size = new System.Drawing.Size(270, 22);
            this.lblEquipoFechaFundacion.TabIndex = 2;
            this.lblEquipoFechaFundacion.Text = "Fecha de fundación";
            // 
            // EquipoFechaFundacion
            // 
            this.EquipoFechaFundacion.CustomFormat = "dd/MM/yyyy";
            this.EquipoFechaFundacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EquipoFechaFundacion.Location = new System.Drawing.Point(320, 45);
            this.EquipoFechaFundacion.Name = "EquipoFechaFundacion";
            this.EquipoFechaFundacion.Size = new System.Drawing.Size(270, 25);
            this.EquipoFechaFundacion.TabIndex = 3;
            // 
            // btnEquipoGuardar
            // 
            this.btnEquipoGuardar.Location = new System.Drawing.Point(20, 200);
            this.btnEquipoGuardar.Name = "btnEquipoGuardar";
            this.btnEquipoGuardar.Size = new System.Drawing.Size(165, 34);
            this.btnEquipoGuardar.TabIndex = 4;
            this.btnEquipoGuardar.Text = "Guardar nuevo";
            this.btnEquipoGuardar.UseVisualStyleBackColor = true;

            // 
            // btnEquipoModificar
            // 
            this.btnEquipoModificar.Location = new System.Drawing.Point(195, 200);
            this.btnEquipoModificar.Name = "btnEquipoModificar";
            this.btnEquipoModificar.Size = new System.Drawing.Size(165, 34);
            this.btnEquipoModificar.TabIndex = 5;
            this.btnEquipoModificar.Text = "Modificar";
            this.btnEquipoModificar.UseVisualStyleBackColor = true;

            // 
            // btnEquipoEstado
            // 
            this.btnEquipoEstado.Location = new System.Drawing.Point(370, 200);
            this.btnEquipoEstado.Name = "btnEquipoEstado";
            this.btnEquipoEstado.Size = new System.Drawing.Size(165, 34);
            this.btnEquipoEstado.TabIndex = 6;
            this.btnEquipoEstado.Text = "Activar / Desactivar";
            this.btnEquipoEstado.UseVisualStyleBackColor = true;

            // 
            // btnEquipoLimpiar
            // 
            this.btnEquipoLimpiar.Location = new System.Drawing.Point(545, 200);
            this.btnEquipoLimpiar.Name = "btnEquipoLimpiar";
            this.btnEquipoLimpiar.Size = new System.Drawing.Size(165, 34);
            this.btnEquipoLimpiar.TabIndex = 7;
            this.btnEquipoLimpiar.Text = "Limpiar";
            this.btnEquipoLimpiar.UseVisualStyleBackColor = true;

            // 
            // chkEquipoInactivos
            // 
            this.chkEquipoInactivos.Location = new System.Drawing.Point(730, 205);
            this.chkEquipoInactivos.Name = "chkEquipoInactivos";
            this.chkEquipoInactivos.Size = new System.Drawing.Size(175, 25);
            this.chkEquipoInactivos.TabIndex = 8;
            this.chkEquipoInactivos.Text = "Mostrar inactivos";

            // 
            // gridEquipo
            // 
            this.gridEquipo.AllowUserToAddRows = false;
            this.gridEquipo.AllowUserToDeleteRows = false;
            this.gridEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEquipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEquipo.BackgroundColor = System.Drawing.Color.White;
            this.gridEquipo.Location = new System.Drawing.Point(20, 250);
            this.gridEquipo.MultiSelect = false;
            this.gridEquipo.Name = "gridEquipo";
            this.gridEquipo.ReadOnly = true;
            this.gridEquipo.RowHeadersVisible = false;
            this.gridEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEquipo.Size = new System.Drawing.Size(885, 255);
            this.gridEquipo.TabIndex = 9;

            // 
            // tabJugador
            // 
            this.tabJugador.Controls.Add(this.lblJugadorNombre);
            this.tabJugador.Controls.Add(this.JugadorNombre);
            this.tabJugador.Controls.Add(this.lblJugadorApellido);
            this.tabJugador.Controls.Add(this.JugadorApellido);
            this.tabJugador.Controls.Add(this.lblJugadorNumeroCamiseta);
            this.tabJugador.Controls.Add(this.JugadorNumeroCamiseta);
            this.tabJugador.Controls.Add(this.lblJugadorIdEquipo);
            this.tabJugador.Controls.Add(this.JugadorIdEquipo);
            this.tabJugador.Controls.Add(this.lblJugadorIdPais);
            this.tabJugador.Controls.Add(this.JugadorIdPais);
            this.tabJugador.Controls.Add(this.btnJugadorGuardar);
            this.tabJugador.Controls.Add(this.btnJugadorModificar);
            this.tabJugador.Controls.Add(this.btnJugadorEstado);
            this.tabJugador.Controls.Add(this.btnJugadorLimpiar);
            this.tabJugador.Controls.Add(this.chkJugadorInactivos);
            this.tabJugador.Controls.Add(this.gridJugador);
            this.tabJugador.Location = new System.Drawing.Point(4, 26);
            this.tabJugador.Name = "tabJugador";
            this.tabJugador.Size = new System.Drawing.Size(932, 520);
            this.tabJugador.TabIndex = 2;
            this.tabJugador.Text = "Jugadores";
            this.tabJugador.UseVisualStyleBackColor = true;
            // 
            // lblJugadorNombre
            // 
            this.lblJugadorNombre.Location = new System.Drawing.Point(20, 20);
            this.lblJugadorNombre.Name = "lblJugadorNombre";
            this.lblJugadorNombre.Size = new System.Drawing.Size(270, 22);
            this.lblJugadorNombre.TabIndex = 0;
            this.lblJugadorNombre.Text = "Nombre";
            // 
            // JugadorNombre
            // 
            this.JugadorNombre.Location = new System.Drawing.Point(20, 45);
            this.JugadorNombre.MaxLength = 50;
            this.JugadorNombre.Name = "JugadorNombre";
            this.JugadorNombre.Size = new System.Drawing.Size(270, 25);
            this.JugadorNombre.TabIndex = 1;
            // 
            // lblJugadorApellido
            // 
            this.lblJugadorApellido.Location = new System.Drawing.Point(320, 20);
            this.lblJugadorApellido.Name = "lblJugadorApellido";
            this.lblJugadorApellido.Size = new System.Drawing.Size(270, 22);
            this.lblJugadorApellido.TabIndex = 2;
            this.lblJugadorApellido.Text = "Apellido";
            // 
            // JugadorApellido
            // 
            this.JugadorApellido.Location = new System.Drawing.Point(320, 45);
            this.JugadorApellido.MaxLength = 50;
            this.JugadorApellido.Name = "JugadorApellido";
            this.JugadorApellido.Size = new System.Drawing.Size(270, 25);
            this.JugadorApellido.TabIndex = 3;
            // 
            // lblJugadorNumeroCamiseta
            // 
            this.lblJugadorNumeroCamiseta.Location = new System.Drawing.Point(620, 20);
            this.lblJugadorNumeroCamiseta.Name = "lblJugadorNumeroCamiseta";
            this.lblJugadorNumeroCamiseta.Size = new System.Drawing.Size(270, 22);
            this.lblJugadorNumeroCamiseta.TabIndex = 4;
            this.lblJugadorNumeroCamiseta.Text = "Camiseta";
            // 
            // JugadorNumeroCamiseta
            // 
            this.JugadorNumeroCamiseta.Location = new System.Drawing.Point(620, 45);
            this.JugadorNumeroCamiseta.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.JugadorNumeroCamiseta.Name = "JugadorNumeroCamiseta";
            this.JugadorNumeroCamiseta.Size = new System.Drawing.Size(270, 25);
            this.JugadorNumeroCamiseta.TabIndex = 5;
            // 
            // lblJugadorIdEquipo
            // 
            this.lblJugadorIdEquipo.Location = new System.Drawing.Point(20, 90);
            this.lblJugadorIdEquipo.Name = "lblJugadorIdEquipo";
            this.lblJugadorIdEquipo.Size = new System.Drawing.Size(270, 22);
            this.lblJugadorIdEquipo.TabIndex = 6;
            this.lblJugadorIdEquipo.Text = "Equipo";
            // 
            // JugadorIdEquipo
            // 
            this.JugadorIdEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JugadorIdEquipo.Location = new System.Drawing.Point(20, 115);
            this.JugadorIdEquipo.Name = "JugadorIdEquipo";
            this.JugadorIdEquipo.Size = new System.Drawing.Size(270, 25);
            this.JugadorIdEquipo.TabIndex = 7;
            // 
            // lblJugadorIdPais
            // 
            this.lblJugadorIdPais.Location = new System.Drawing.Point(320, 90);
            this.lblJugadorIdPais.Name = "lblJugadorIdPais";
            this.lblJugadorIdPais.Size = new System.Drawing.Size(270, 22);
            this.lblJugadorIdPais.TabIndex = 8;
            this.lblJugadorIdPais.Text = "País";
            // 
            // JugadorIdPais
            // 
            this.JugadorIdPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JugadorIdPais.Location = new System.Drawing.Point(320, 115);
            this.JugadorIdPais.Name = "JugadorIdPais";
            this.JugadorIdPais.Size = new System.Drawing.Size(270, 25);
            this.JugadorIdPais.TabIndex = 9;
            // 
            // btnJugadorGuardar
            // 
            this.btnJugadorGuardar.Location = new System.Drawing.Point(20, 200);
            this.btnJugadorGuardar.Name = "btnJugadorGuardar";
            this.btnJugadorGuardar.Size = new System.Drawing.Size(165, 34);
            this.btnJugadorGuardar.TabIndex = 10;
            this.btnJugadorGuardar.Text = "Guardar nuevo";
            this.btnJugadorGuardar.UseVisualStyleBackColor = true;

            // 
            // btnJugadorModificar
            // 
            this.btnJugadorModificar.Location = new System.Drawing.Point(195, 200);
            this.btnJugadorModificar.Name = "btnJugadorModificar";
            this.btnJugadorModificar.Size = new System.Drawing.Size(165, 34);
            this.btnJugadorModificar.TabIndex = 11;
            this.btnJugadorModificar.Text = "Modificar";
            this.btnJugadorModificar.UseVisualStyleBackColor = true;

            // 
            // btnJugadorEstado
            // 
            this.btnJugadorEstado.Location = new System.Drawing.Point(370, 200);
            this.btnJugadorEstado.Name = "btnJugadorEstado";
            this.btnJugadorEstado.Size = new System.Drawing.Size(165, 34);
            this.btnJugadorEstado.TabIndex = 12;
            this.btnJugadorEstado.Text = "Activar / Desactivar";
            this.btnJugadorEstado.UseVisualStyleBackColor = true;

            // 
            // btnJugadorLimpiar
            // 
            this.btnJugadorLimpiar.Location = new System.Drawing.Point(545, 200);
            this.btnJugadorLimpiar.Name = "btnJugadorLimpiar";
            this.btnJugadorLimpiar.Size = new System.Drawing.Size(165, 34);
            this.btnJugadorLimpiar.TabIndex = 13;
            this.btnJugadorLimpiar.Text = "Limpiar";
            this.btnJugadorLimpiar.UseVisualStyleBackColor = true;

            // 
            // chkJugadorInactivos
            // 
            this.chkJugadorInactivos.Location = new System.Drawing.Point(730, 205);
            this.chkJugadorInactivos.Name = "chkJugadorInactivos";
            this.chkJugadorInactivos.Size = new System.Drawing.Size(175, 25);
            this.chkJugadorInactivos.TabIndex = 14;
            this.chkJugadorInactivos.Text = "Mostrar inactivos";

            // 
            // gridJugador
            // 
            this.gridJugador.AllowUserToAddRows = false;
            this.gridJugador.AllowUserToDeleteRows = false;
            this.gridJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridJugador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridJugador.BackgroundColor = System.Drawing.Color.White;
            this.gridJugador.Location = new System.Drawing.Point(20, 250);
            this.gridJugador.MultiSelect = false;
            this.gridJugador.Name = "gridJugador";
            this.gridJugador.ReadOnly = true;
            this.gridJugador.RowHeadersVisible = false;
            this.gridJugador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridJugador.Size = new System.Drawing.Size(885, 255);
            this.gridJugador.TabIndex = 15;

            // 
            // tabTorneo
            // 
            this.tabTorneo.Controls.Add(this.lblTorneoNombre);
            this.tabTorneo.Controls.Add(this.TorneoNombre);
            this.tabTorneo.Controls.Add(this.lblTorneoAño);
            this.tabTorneo.Controls.Add(this.TorneoAño);
            this.tabTorneo.Controls.Add(this.btnTorneoGuardar);
            this.tabTorneo.Controls.Add(this.btnTorneoModificar);
            this.tabTorneo.Controls.Add(this.btnTorneoEstado);
            this.tabTorneo.Controls.Add(this.btnTorneoLimpiar);
            this.tabTorneo.Controls.Add(this.chkTorneoInactivos);
            this.tabTorneo.Controls.Add(this.gridTorneo);
            this.tabTorneo.Location = new System.Drawing.Point(4, 26);
            this.tabTorneo.Name = "tabTorneo";
            this.tabTorneo.Size = new System.Drawing.Size(932, 520);
            this.tabTorneo.TabIndex = 3;
            this.tabTorneo.Text = "Torneos";
            this.tabTorneo.UseVisualStyleBackColor = true;
            // 
            // lblTorneoNombre
            // 
            this.lblTorneoNombre.Location = new System.Drawing.Point(20, 20);
            this.lblTorneoNombre.Name = "lblTorneoNombre";
            this.lblTorneoNombre.Size = new System.Drawing.Size(270, 22);
            this.lblTorneoNombre.TabIndex = 0;
            this.lblTorneoNombre.Text = "Nombre";
            // 
            // TorneoNombre
            // 
            this.TorneoNombre.Location = new System.Drawing.Point(20, 45);
            this.TorneoNombre.MaxLength = 50;
            this.TorneoNombre.Name = "TorneoNombre";
            this.TorneoNombre.Size = new System.Drawing.Size(270, 25);
            this.TorneoNombre.TabIndex = 1;
            // 
            // lblTorneoAño
            // 
            this.lblTorneoAño.Location = new System.Drawing.Point(320, 20);
            this.lblTorneoAño.Name = "lblTorneoAño";
            this.lblTorneoAño.Size = new System.Drawing.Size(270, 22);
            this.lblTorneoAño.TabIndex = 2;
            this.lblTorneoAño.Text = "Año";
            // 
            // TorneoAño
            // 
            this.TorneoAño.Location = new System.Drawing.Point(320, 45);
            this.TorneoAño.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.TorneoAño.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.TorneoAño.Name = "TorneoAño";
            this.TorneoAño.Size = new System.Drawing.Size(270, 25);
            this.TorneoAño.TabIndex = 3;
            this.TorneoAño.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // btnTorneoGuardar
            // 
            this.btnTorneoGuardar.Location = new System.Drawing.Point(20, 200);
            this.btnTorneoGuardar.Name = "btnTorneoGuardar";
            this.btnTorneoGuardar.Size = new System.Drawing.Size(165, 34);
            this.btnTorneoGuardar.TabIndex = 4;
            this.btnTorneoGuardar.Text = "Guardar nuevo";
            this.btnTorneoGuardar.UseVisualStyleBackColor = true;

            // 
            // btnTorneoModificar
            // 
            this.btnTorneoModificar.Location = new System.Drawing.Point(195, 200);
            this.btnTorneoModificar.Name = "btnTorneoModificar";
            this.btnTorneoModificar.Size = new System.Drawing.Size(165, 34);
            this.btnTorneoModificar.TabIndex = 5;
            this.btnTorneoModificar.Text = "Modificar";
            this.btnTorneoModificar.UseVisualStyleBackColor = true;

            // 
            // btnTorneoEstado
            // 
            this.btnTorneoEstado.Location = new System.Drawing.Point(370, 200);
            this.btnTorneoEstado.Name = "btnTorneoEstado";
            this.btnTorneoEstado.Size = new System.Drawing.Size(165, 34);
            this.btnTorneoEstado.TabIndex = 6;
            this.btnTorneoEstado.Text = "Activar / Desactivar";
            this.btnTorneoEstado.UseVisualStyleBackColor = true;

            // 
            // btnTorneoLimpiar
            // 
            this.btnTorneoLimpiar.Location = new System.Drawing.Point(545, 200);
            this.btnTorneoLimpiar.Name = "btnTorneoLimpiar";
            this.btnTorneoLimpiar.Size = new System.Drawing.Size(165, 34);
            this.btnTorneoLimpiar.TabIndex = 7;
            this.btnTorneoLimpiar.Text = "Limpiar";
            this.btnTorneoLimpiar.UseVisualStyleBackColor = true;

            // 
            // chkTorneoInactivos
            // 
            this.chkTorneoInactivos.Location = new System.Drawing.Point(730, 205);
            this.chkTorneoInactivos.Name = "chkTorneoInactivos";
            this.chkTorneoInactivos.Size = new System.Drawing.Size(175, 25);
            this.chkTorneoInactivos.TabIndex = 8;
            this.chkTorneoInactivos.Text = "Mostrar inactivos";

            // 
            // gridTorneo
            // 
            this.gridTorneo.AllowUserToAddRows = false;
            this.gridTorneo.AllowUserToDeleteRows = false;
            this.gridTorneo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTorneo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTorneo.BackgroundColor = System.Drawing.Color.White;
            this.gridTorneo.Location = new System.Drawing.Point(20, 250);
            this.gridTorneo.MultiSelect = false;
            this.gridTorneo.Name = "gridTorneo";
            this.gridTorneo.ReadOnly = true;
            this.gridTorneo.RowHeadersVisible = false;
            this.gridTorneo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTorneo.Size = new System.Drawing.Size(885, 255);
            this.gridTorneo.TabIndex = 9;

            // 
            // tabPartido
            // 
            this.tabPartido.Controls.Add(this.lblPartidoIdTorneo);
            this.tabPartido.Controls.Add(this.PartidoIdTorneo);
            this.tabPartido.Controls.Add(this.lblPartidoIdEquipoLocal);
            this.tabPartido.Controls.Add(this.PartidoIdEquipoLocal);
            this.tabPartido.Controls.Add(this.lblPartidoIdEquipoVisitante);
            this.tabPartido.Controls.Add(this.PartidoIdEquipoVisitante);
            this.tabPartido.Controls.Add(this.lblPartidoFecha);
            this.tabPartido.Controls.Add(this.PartidoFecha);
            this.tabPartido.Controls.Add(this.lblPartidoGolesLocal);
            this.tabPartido.Controls.Add(this.PartidoGolesLocal);
            this.tabPartido.Controls.Add(this.lblPartidoGolesVisitante);
            this.tabPartido.Controls.Add(this.PartidoGolesVisitante);
            this.tabPartido.Controls.Add(this.chkResultado);
            this.tabPartido.Controls.Add(this.btnPartidoGuardar);
            this.tabPartido.Controls.Add(this.btnPartidoModificar);
            this.tabPartido.Controls.Add(this.btnPartidoEstado);
            this.tabPartido.Controls.Add(this.btnPartidoLimpiar);
            this.tabPartido.Controls.Add(this.chkPartidoInactivos);
            this.tabPartido.Controls.Add(this.gridPartido);
            this.tabPartido.Location = new System.Drawing.Point(4, 26);
            this.tabPartido.Name = "tabPartido";
            this.tabPartido.Size = new System.Drawing.Size(932, 520);
            this.tabPartido.TabIndex = 4;
            this.tabPartido.Text = "Partidos";
            this.tabPartido.UseVisualStyleBackColor = true;
            // 
            // lblPartidoIdTorneo
            // 
            this.lblPartidoIdTorneo.Location = new System.Drawing.Point(20, 20);
            this.lblPartidoIdTorneo.Name = "lblPartidoIdTorneo";
            this.lblPartidoIdTorneo.Size = new System.Drawing.Size(270, 22);
            this.lblPartidoIdTorneo.TabIndex = 0;
            this.lblPartidoIdTorneo.Text = "Torneo";
            // 
            // PartidoIdTorneo
            // 
            this.PartidoIdTorneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PartidoIdTorneo.Location = new System.Drawing.Point(20, 45);
            this.PartidoIdTorneo.Name = "PartidoIdTorneo";
            this.PartidoIdTorneo.Size = new System.Drawing.Size(270, 25);
            this.PartidoIdTorneo.TabIndex = 1;
            // 
            // lblPartidoIdEquipoLocal
            // 
            this.lblPartidoIdEquipoLocal.Location = new System.Drawing.Point(320, 20);
            this.lblPartidoIdEquipoLocal.Name = "lblPartidoIdEquipoLocal";
            this.lblPartidoIdEquipoLocal.Size = new System.Drawing.Size(270, 22);
            this.lblPartidoIdEquipoLocal.TabIndex = 2;
            this.lblPartidoIdEquipoLocal.Text = "Local";
            // 
            // PartidoIdEquipoLocal
            // 
            this.PartidoIdEquipoLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PartidoIdEquipoLocal.Location = new System.Drawing.Point(320, 45);
            this.PartidoIdEquipoLocal.Name = "PartidoIdEquipoLocal";
            this.PartidoIdEquipoLocal.Size = new System.Drawing.Size(270, 25);
            this.PartidoIdEquipoLocal.TabIndex = 3;
            // 
            // lblPartidoIdEquipoVisitante
            // 
            this.lblPartidoIdEquipoVisitante.Location = new System.Drawing.Point(620, 20);
            this.lblPartidoIdEquipoVisitante.Name = "lblPartidoIdEquipoVisitante";
            this.lblPartidoIdEquipoVisitante.Size = new System.Drawing.Size(270, 22);
            this.lblPartidoIdEquipoVisitante.TabIndex = 4;
            this.lblPartidoIdEquipoVisitante.Text = "Visitante";
            // 
            // PartidoIdEquipoVisitante
            // 
            this.PartidoIdEquipoVisitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PartidoIdEquipoVisitante.Location = new System.Drawing.Point(620, 45);
            this.PartidoIdEquipoVisitante.Name = "PartidoIdEquipoVisitante";
            this.PartidoIdEquipoVisitante.Size = new System.Drawing.Size(270, 25);
            this.PartidoIdEquipoVisitante.TabIndex = 5;
            // 
            // lblPartidoFecha
            // 
            this.lblPartidoFecha.Location = new System.Drawing.Point(20, 90);
            this.lblPartidoFecha.Name = "lblPartidoFecha";
            this.lblPartidoFecha.Size = new System.Drawing.Size(270, 22);
            this.lblPartidoFecha.TabIndex = 6;
            this.lblPartidoFecha.Text = "Fecha y hora";
            // 
            // PartidoFecha
            // 
            this.PartidoFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.PartidoFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PartidoFecha.Location = new System.Drawing.Point(20, 115);
            this.PartidoFecha.Name = "PartidoFecha";
            this.PartidoFecha.Size = new System.Drawing.Size(270, 25);
            this.PartidoFecha.TabIndex = 7;
            // 
            // lblPartidoGolesLocal
            // 
            this.lblPartidoGolesLocal.Location = new System.Drawing.Point(320, 90);
            this.lblPartidoGolesLocal.Name = "lblPartidoGolesLocal";
            this.lblPartidoGolesLocal.Size = new System.Drawing.Size(270, 22);
            this.lblPartidoGolesLocal.TabIndex = 8;
            this.lblPartidoGolesLocal.Text = "Goles local";
            // 
            // PartidoGolesLocal
            // 
            this.PartidoGolesLocal.Location = new System.Drawing.Point(320, 115);
            this.PartidoGolesLocal.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.PartidoGolesLocal.Name = "PartidoGolesLocal";
            this.PartidoGolesLocal.Size = new System.Drawing.Size(270, 25);
            this.PartidoGolesLocal.TabIndex = 9;
            // 
            // lblPartidoGolesVisitante
            // 
            this.lblPartidoGolesVisitante.Location = new System.Drawing.Point(620, 90);
            this.lblPartidoGolesVisitante.Name = "lblPartidoGolesVisitante";
            this.lblPartidoGolesVisitante.Size = new System.Drawing.Size(270, 22);
            this.lblPartidoGolesVisitante.TabIndex = 10;
            this.lblPartidoGolesVisitante.Text = "Goles visitante";
            // 
            // PartidoGolesVisitante
            // 
            this.PartidoGolesVisitante.Location = new System.Drawing.Point(620, 115);
            this.PartidoGolesVisitante.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.PartidoGolesVisitante.Name = "PartidoGolesVisitante";
            this.PartidoGolesVisitante.Size = new System.Drawing.Size(270, 25);
            this.PartidoGolesVisitante.TabIndex = 11;
            // 
            // chkResultado
            // 
            this.chkResultado.Location = new System.Drawing.Point(20, 160);
            this.chkResultado.Name = "chkResultado";
            this.chkResultado.Size = new System.Drawing.Size(270, 25);
            this.chkResultado.TabIndex = 12;
            this.chkResultado.Text = "Resultado cargado";

            // 
            // btnPartidoGuardar
            // 
            this.btnPartidoGuardar.Location = new System.Drawing.Point(20, 200);
            this.btnPartidoGuardar.Name = "btnPartidoGuardar";
            this.btnPartidoGuardar.Size = new System.Drawing.Size(165, 34);
            this.btnPartidoGuardar.TabIndex = 13;
            this.btnPartidoGuardar.Text = "Guardar nuevo";
            this.btnPartidoGuardar.UseVisualStyleBackColor = true;

            // 
            // btnPartidoModificar
            // 
            this.btnPartidoModificar.Location = new System.Drawing.Point(195, 200);
            this.btnPartidoModificar.Name = "btnPartidoModificar";
            this.btnPartidoModificar.Size = new System.Drawing.Size(165, 34);
            this.btnPartidoModificar.TabIndex = 14;
            this.btnPartidoModificar.Text = "Modificar";
            this.btnPartidoModificar.UseVisualStyleBackColor = true;

            // 
            // btnPartidoEstado
            // 
            this.btnPartidoEstado.Location = new System.Drawing.Point(370, 200);
            this.btnPartidoEstado.Name = "btnPartidoEstado";
            this.btnPartidoEstado.Size = new System.Drawing.Size(165, 34);
            this.btnPartidoEstado.TabIndex = 15;
            this.btnPartidoEstado.Text = "Activar / Desactivar";
            this.btnPartidoEstado.UseVisualStyleBackColor = true;

            // 
            // btnPartidoLimpiar
            // 
            this.btnPartidoLimpiar.Location = new System.Drawing.Point(545, 200);
            this.btnPartidoLimpiar.Name = "btnPartidoLimpiar";
            this.btnPartidoLimpiar.Size = new System.Drawing.Size(165, 34);
            this.btnPartidoLimpiar.TabIndex = 16;
            this.btnPartidoLimpiar.Text = "Limpiar";
            this.btnPartidoLimpiar.UseVisualStyleBackColor = true;

            // 
            // chkPartidoInactivos
            // 
            this.chkPartidoInactivos.Location = new System.Drawing.Point(730, 205);
            this.chkPartidoInactivos.Name = "chkPartidoInactivos";
            this.chkPartidoInactivos.Size = new System.Drawing.Size(175, 25);
            this.chkPartidoInactivos.TabIndex = 17;
            this.chkPartidoInactivos.Text = "Mostrar inactivos";

            // 
            // gridPartido
            // 
            this.gridPartido.AllowUserToAddRows = false;
            this.gridPartido.AllowUserToDeleteRows = false;
            this.gridPartido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPartido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPartido.BackgroundColor = System.Drawing.Color.White;
            this.gridPartido.Location = new System.Drawing.Point(20, 250);
            this.gridPartido.MultiSelect = false;
            this.gridPartido.Name = "gridPartido";
            this.gridPartido.ReadOnly = true;
            this.gridPartido.RowHeadersVisible = false;
            this.gridPartido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPartido.Size = new System.Drawing.Size(885, 255);
            this.gridPartido.TabIndex = 18;

            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.Location = new System.Drawing.Point(20, 630);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(940, 30);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Seleccioná una pestaña. Guardar crea un registro; Modificar actualiza el seleccio" +
    "nado.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 675);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pestanas);
            this.Controls.Add(this.lblEstado);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(996, 714);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GTE - Windows Forms simple";
            this.pestanas.ResumeLayout(false);
            this.tabPais.ResumeLayout(false);
            this.tabPais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPais)).EndInit();
            this.tabEquipo.ResumeLayout(false);
            this.tabEquipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipo)).EndInit();
            this.tabJugador.ResumeLayout(false);
            this.tabJugador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JugadorNumeroCamiseta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridJugador)).EndInit();
            this.tabTorneo.ResumeLayout(false);
            this.tabTorneo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TorneoAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTorneo)).EndInit();
            this.tabPartido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PartidoGolesLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartidoGolesVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPartido)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl pestanas;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TabPage tabPais;
        private System.Windows.Forms.Label lblPaisNombre;
        private System.Windows.Forms.TextBox PaisNombre;
        private System.Windows.Forms.Button btnPaisGuardar;
        private System.Windows.Forms.Button btnPaisModificar;
        private System.Windows.Forms.Button btnPaisEstado;
        private System.Windows.Forms.Button btnPaisLimpiar;
        private System.Windows.Forms.CheckBox chkPaisInactivos;
        private System.Windows.Forms.DataGridView gridPais;
        private System.Windows.Forms.TabPage tabEquipo;
        private System.Windows.Forms.Label lblEquipoNombre;
        private System.Windows.Forms.TextBox EquipoNombre;
        private System.Windows.Forms.Label lblEquipoFechaFundacion;
        private System.Windows.Forms.DateTimePicker EquipoFechaFundacion;
        private System.Windows.Forms.Button btnEquipoGuardar;
        private System.Windows.Forms.Button btnEquipoModificar;
        private System.Windows.Forms.Button btnEquipoEstado;
        private System.Windows.Forms.Button btnEquipoLimpiar;
        private System.Windows.Forms.CheckBox chkEquipoInactivos;
        private System.Windows.Forms.DataGridView gridEquipo;
        private System.Windows.Forms.TabPage tabJugador;
        private System.Windows.Forms.Label lblJugadorNombre;
        private System.Windows.Forms.TextBox JugadorNombre;
        private System.Windows.Forms.Label lblJugadorApellido;
        private System.Windows.Forms.TextBox JugadorApellido;
        private System.Windows.Forms.Label lblJugadorNumeroCamiseta;
        private System.Windows.Forms.NumericUpDown JugadorNumeroCamiseta;
        private System.Windows.Forms.Label lblJugadorIdEquipo;
        private System.Windows.Forms.ComboBox JugadorIdEquipo;
        private System.Windows.Forms.Label lblJugadorIdPais;
        private System.Windows.Forms.ComboBox JugadorIdPais;
        private System.Windows.Forms.Button btnJugadorGuardar;
        private System.Windows.Forms.Button btnJugadorModificar;
        private System.Windows.Forms.Button btnJugadorEstado;
        private System.Windows.Forms.Button btnJugadorLimpiar;
        private System.Windows.Forms.CheckBox chkJugadorInactivos;
        private System.Windows.Forms.DataGridView gridJugador;
        private System.Windows.Forms.TabPage tabTorneo;
        private System.Windows.Forms.Label lblTorneoNombre;
        private System.Windows.Forms.TextBox TorneoNombre;
        private System.Windows.Forms.Label lblTorneoAño;
        private System.Windows.Forms.NumericUpDown TorneoAño;
        private System.Windows.Forms.Button btnTorneoGuardar;
        private System.Windows.Forms.Button btnTorneoModificar;
        private System.Windows.Forms.Button btnTorneoEstado;
        private System.Windows.Forms.Button btnTorneoLimpiar;
        private System.Windows.Forms.CheckBox chkTorneoInactivos;
        private System.Windows.Forms.DataGridView gridTorneo;
        private System.Windows.Forms.TabPage tabPartido;
        private System.Windows.Forms.Label lblPartidoIdTorneo;
        private System.Windows.Forms.ComboBox PartidoIdTorneo;
        private System.Windows.Forms.Label lblPartidoIdEquipoLocal;
        private System.Windows.Forms.ComboBox PartidoIdEquipoLocal;
        private System.Windows.Forms.Label lblPartidoIdEquipoVisitante;
        private System.Windows.Forms.ComboBox PartidoIdEquipoVisitante;
        private System.Windows.Forms.Label lblPartidoFecha;
        private System.Windows.Forms.DateTimePicker PartidoFecha;
        private System.Windows.Forms.Label lblPartidoGolesLocal;
        private System.Windows.Forms.NumericUpDown PartidoGolesLocal;
        private System.Windows.Forms.Label lblPartidoGolesVisitante;
        private System.Windows.Forms.NumericUpDown PartidoGolesVisitante;
        private System.Windows.Forms.CheckBox chkResultado;
        private System.Windows.Forms.Button btnPartidoGuardar;
        private System.Windows.Forms.Button btnPartidoModificar;
        private System.Windows.Forms.Button btnPartidoEstado;
        private System.Windows.Forms.Button btnPartidoLimpiar;
        private System.Windows.Forms.CheckBox chkPartidoInactivos;
        private System.Windows.Forms.DataGridView gridPartido;
    }
}
