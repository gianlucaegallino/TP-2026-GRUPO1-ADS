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
            lblTitulo = new Label();
            pestanas = new TabControl();
            tabPais = new TabPage();
            lblPaisNombre = new Label();
            PaisNombre = new TextBox();
            btnPaisGuardar = new Button();
            btnPaisModificar = new Button();
            btnPaisEstado = new Button();
            btnPaisLimpiar = new Button();
            chkPaisInactivos = new CheckBox();
            gridPais = new DataGridView();
            tabEquipo = new TabPage();
            lblEquipoNombre = new Label();
            EquipoNombre = new TextBox();
            lblEquipoFechaFundacion = new Label();
            EquipoFechaFundacion = new DateTimePicker();
            btnEquipoGuardar = new Button();
            btnEquipoModificar = new Button();
            btnEquipoEstado = new Button();
            btnEquipoLimpiar = new Button();
            chkEquipoInactivos = new CheckBox();
            gridEquipo = new DataGridView();
            tabJugador = new TabPage();
            lblJugadorNombre = new Label();
            JugadorNombre = new TextBox();
            lblJugadorApellido = new Label();
            JugadorApellido = new TextBox();
            lblJugadorNumeroCamiseta = new Label();
            JugadorNumeroCamiseta = new NumericUpDown();
            lblJugadorIdEquipo = new Label();
            JugadorIdEquipo = new ComboBox();
            lblJugadorIdPais = new Label();
            JugadorIdPais = new ComboBox();
            btnJugadorGuardar = new Button();
            btnJugadorModificar = new Button();
            btnJugadorEstado = new Button();
            btnJugadorLimpiar = new Button();
            chkJugadorInactivos = new CheckBox();
            gridJugador = new DataGridView();
            tabTorneo = new TabPage();
            lblTorneoNombre = new Label();
            TorneoNombre = new TextBox();
            lblTorneoAño = new Label();
            TorneoAño = new NumericUpDown();
            btnTorneoGuardar = new Button();
            btnTorneoModificar = new Button();
            btnTorneoEstado = new Button();
            btnTorneoLimpiar = new Button();
            chkTorneoInactivos = new CheckBox();
            gridTorneo = new DataGridView();
            tabPartido = new TabPage();
            lblPartidoIdTorneo = new Label();
            PartidoIdTorneo = new ComboBox();
            lblPartidoIdEquipoLocal = new Label();
            PartidoIdEquipoLocal = new ComboBox();
            lblPartidoIdEquipoVisitante = new Label();
            PartidoIdEquipoVisitante = new ComboBox();
            lblPartidoFecha = new Label();
            PartidoFecha = new DateTimePicker();
            lblPartidoGolesLocal = new Label();
            PartidoGolesLocal = new NumericUpDown();
            lblPartidoGolesVisitante = new Label();
            PartidoGolesVisitante = new NumericUpDown();
            chkResultado = new CheckBox();
            btnPartidoGuardar = new Button();
            btnPartidoModificar = new Button();
            btnPartidoEstado = new Button();
            btnPartidoLimpiar = new Button();
            chkPartidoInactivos = new CheckBox();
            gridPartido = new DataGridView();
            lblEstado = new Label();
            pestanas.SuspendLayout();
            tabPais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPais).BeginInit();
            tabEquipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridEquipo).BeginInit();
            tabJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)JugadorNumeroCamiseta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridJugador).BeginInit();
            tabTorneo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TorneoAño).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridTorneo).BeginInit();
            tabPartido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PartidoGolesLocal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PartidoGolesVisitante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridPartido).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(900, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestor de Torneos y Equipos";
            // 
            // pestanas
            // 
            pestanas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pestanas.Controls.Add(tabPais);
            pestanas.Controls.Add(tabEquipo);
            pestanas.Controls.Add(tabJugador);
            pestanas.Controls.Add(tabTorneo);
            pestanas.Controls.Add(tabPartido);
            pestanas.Location = new Point(20, 65);
            pestanas.Name = "pestanas";
            pestanas.SelectedIndex = 0;
            pestanas.Size = new Size(940, 550);
            pestanas.TabIndex = 1;
            // 
            // tabPais
            // 
            tabPais.Controls.Add(lblPaisNombre);
            tabPais.Controls.Add(PaisNombre);
            tabPais.Controls.Add(btnPaisGuardar);
            tabPais.Controls.Add(btnPaisModificar);
            tabPais.Controls.Add(btnPaisEstado);
            tabPais.Controls.Add(btnPaisLimpiar);
            tabPais.Controls.Add(chkPaisInactivos);
            tabPais.Controls.Add(gridPais);
            tabPais.Location = new Point(4, 32);
            tabPais.Name = "tabPais";
            tabPais.Size = new Size(932, 514);
            tabPais.TabIndex = 0;
            tabPais.Text = "Países";
            tabPais.UseVisualStyleBackColor = true;
            // 
            // lblPaisNombre
            // 
            lblPaisNombre.Location = new Point(20, 20);
            lblPaisNombre.Name = "lblPaisNombre";
            lblPaisNombre.Size = new Size(270, 22);
            lblPaisNombre.TabIndex = 0;
            lblPaisNombre.Text = "Nombre";
            // 
            // PaisNombre
            // 
            PaisNombre.Location = new Point(20, 45);
            PaisNombre.MaxLength = 50;
            PaisNombre.Name = "PaisNombre";
            PaisNombre.Size = new Size(270, 30);
            PaisNombre.TabIndex = 1;
            // 
            // btnPaisGuardar
            // 
            btnPaisGuardar.Location = new Point(20, 200);
            btnPaisGuardar.Name = "btnPaisGuardar";
            btnPaisGuardar.Size = new Size(165, 34);
            btnPaisGuardar.TabIndex = 2;
            btnPaisGuardar.Text = "Guardar nuevo";
            btnPaisGuardar.UseVisualStyleBackColor = true;
            // 
            // btnPaisModificar
            // 
            btnPaisModificar.Location = new Point(195, 200);
            btnPaisModificar.Name = "btnPaisModificar";
            btnPaisModificar.Size = new Size(165, 34);
            btnPaisModificar.TabIndex = 3;
            btnPaisModificar.Text = "Modificar";
            btnPaisModificar.UseVisualStyleBackColor = true;
            // 
            // btnPaisEstado
            // 
            btnPaisEstado.Location = new Point(370, 200);
            btnPaisEstado.Name = "btnPaisEstado";
            btnPaisEstado.Size = new Size(165, 34);
            btnPaisEstado.TabIndex = 4;
            btnPaisEstado.Text = "Activar / Desactivar";
            btnPaisEstado.UseVisualStyleBackColor = true;
            // 
            // btnPaisLimpiar
            // 
            btnPaisLimpiar.Location = new Point(545, 200);
            btnPaisLimpiar.Name = "btnPaisLimpiar";
            btnPaisLimpiar.Size = new Size(165, 34);
            btnPaisLimpiar.TabIndex = 5;
            btnPaisLimpiar.Text = "Limpiar";
            btnPaisLimpiar.UseVisualStyleBackColor = true;
            // 
            // chkPaisInactivos
            // 
            chkPaisInactivos.Location = new Point(730, 205);
            chkPaisInactivos.Name = "chkPaisInactivos";
            chkPaisInactivos.Size = new Size(175, 25);
            chkPaisInactivos.TabIndex = 6;
            chkPaisInactivos.Text = "Mostrar inactivos";
            // 
            // gridPais
            // 
            gridPais.AllowUserToAddRows = false;
            gridPais.AllowUserToDeleteRows = false;
            gridPais.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridPais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridPais.BackgroundColor = Color.White;
            gridPais.ColumnHeadersHeight = 29;
            gridPais.Location = new Point(20, 250);
            gridPais.MultiSelect = false;
            gridPais.Name = "gridPais";
            gridPais.ReadOnly = true;
            gridPais.RowHeadersVisible = false;
            gridPais.RowHeadersWidth = 51;
            gridPais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPais.Size = new Size(885, 255);
            gridPais.TabIndex = 7;
            // 
            // tabEquipo
            // 
            tabEquipo.Controls.Add(lblEquipoNombre);
            tabEquipo.Controls.Add(EquipoNombre);
            tabEquipo.Controls.Add(lblEquipoFechaFundacion);
            tabEquipo.Controls.Add(EquipoFechaFundacion);
            tabEquipo.Controls.Add(btnEquipoGuardar);
            tabEquipo.Controls.Add(btnEquipoModificar);
            tabEquipo.Controls.Add(btnEquipoEstado);
            tabEquipo.Controls.Add(btnEquipoLimpiar);
            tabEquipo.Controls.Add(chkEquipoInactivos);
            tabEquipo.Controls.Add(gridEquipo);
            tabEquipo.Location = new Point(4, 32);
            tabEquipo.Name = "tabEquipo";
            tabEquipo.Size = new Size(932, 514);
            tabEquipo.TabIndex = 1;
            tabEquipo.Text = "Equipos";
            tabEquipo.UseVisualStyleBackColor = true;
            // 
            // lblEquipoNombre
            // 
            lblEquipoNombre.Location = new Point(20, 20);
            lblEquipoNombre.Name = "lblEquipoNombre";
            lblEquipoNombre.Size = new Size(270, 22);
            lblEquipoNombre.TabIndex = 0;
            lblEquipoNombre.Text = "Nombre";
            // 
            // EquipoNombre
            // 
            EquipoNombre.Location = new Point(20, 45);
            EquipoNombre.MaxLength = 50;
            EquipoNombre.Name = "EquipoNombre";
            EquipoNombre.Size = new Size(270, 30);
            EquipoNombre.TabIndex = 1;
            // 
            // lblEquipoFechaFundacion
            // 
            lblEquipoFechaFundacion.Location = new Point(320, 20);
            lblEquipoFechaFundacion.Name = "lblEquipoFechaFundacion";
            lblEquipoFechaFundacion.Size = new Size(270, 22);
            lblEquipoFechaFundacion.TabIndex = 2;
            lblEquipoFechaFundacion.Text = "Fecha de fundación";
            // 
            // EquipoFechaFundacion
            // 
            EquipoFechaFundacion.CustomFormat = "dd/MM/yyyy";
            EquipoFechaFundacion.Format = DateTimePickerFormat.Custom;
            EquipoFechaFundacion.Location = new Point(320, 45);
            EquipoFechaFundacion.Name = "EquipoFechaFundacion";
            EquipoFechaFundacion.Size = new Size(270, 30);
            EquipoFechaFundacion.TabIndex = 3;
            // 
            // btnEquipoGuardar
            // 
            btnEquipoGuardar.Location = new Point(20, 200);
            btnEquipoGuardar.Name = "btnEquipoGuardar";
            btnEquipoGuardar.Size = new Size(165, 34);
            btnEquipoGuardar.TabIndex = 4;
            btnEquipoGuardar.Text = "Guardar nuevo";
            btnEquipoGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEquipoModificar
            // 
            btnEquipoModificar.Location = new Point(195, 200);
            btnEquipoModificar.Name = "btnEquipoModificar";
            btnEquipoModificar.Size = new Size(165, 34);
            btnEquipoModificar.TabIndex = 5;
            btnEquipoModificar.Text = "Modificar";
            btnEquipoModificar.UseVisualStyleBackColor = true;
            // 
            // btnEquipoEstado
            // 
            btnEquipoEstado.Location = new Point(370, 200);
            btnEquipoEstado.Name = "btnEquipoEstado";
            btnEquipoEstado.Size = new Size(165, 34);
            btnEquipoEstado.TabIndex = 6;
            btnEquipoEstado.Text = "Activar / Desactivar";
            btnEquipoEstado.UseVisualStyleBackColor = true;
            // 
            // btnEquipoLimpiar
            // 
            btnEquipoLimpiar.Location = new Point(545, 200);
            btnEquipoLimpiar.Name = "btnEquipoLimpiar";
            btnEquipoLimpiar.Size = new Size(165, 34);
            btnEquipoLimpiar.TabIndex = 7;
            btnEquipoLimpiar.Text = "Limpiar";
            btnEquipoLimpiar.UseVisualStyleBackColor = true;
            // 
            // chkEquipoInactivos
            // 
            chkEquipoInactivos.Location = new Point(730, 205);
            chkEquipoInactivos.Name = "chkEquipoInactivos";
            chkEquipoInactivos.Size = new Size(175, 25);
            chkEquipoInactivos.TabIndex = 8;
            chkEquipoInactivos.Text = "Mostrar inactivos";
            // 
            // gridEquipo
            // 
            gridEquipo.AllowUserToAddRows = false;
            gridEquipo.AllowUserToDeleteRows = false;
            gridEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridEquipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridEquipo.BackgroundColor = Color.White;
            gridEquipo.ColumnHeadersHeight = 29;
            gridEquipo.Location = new Point(20, 250);
            gridEquipo.MultiSelect = false;
            gridEquipo.Name = "gridEquipo";
            gridEquipo.ReadOnly = true;
            gridEquipo.RowHeadersVisible = false;
            gridEquipo.RowHeadersWidth = 51;
            gridEquipo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEquipo.Size = new Size(885, 252);
            gridEquipo.TabIndex = 9;
            // 
            // tabJugador
            // 
            tabJugador.Controls.Add(lblJugadorNombre);
            tabJugador.Controls.Add(JugadorNombre);
            tabJugador.Controls.Add(lblJugadorApellido);
            tabJugador.Controls.Add(JugadorApellido);
            tabJugador.Controls.Add(lblJugadorNumeroCamiseta);
            tabJugador.Controls.Add(JugadorNumeroCamiseta);
            tabJugador.Controls.Add(lblJugadorIdEquipo);
            tabJugador.Controls.Add(JugadorIdEquipo);
            tabJugador.Controls.Add(lblJugadorIdPais);
            tabJugador.Controls.Add(JugadorIdPais);
            tabJugador.Controls.Add(btnJugadorGuardar);
            tabJugador.Controls.Add(btnJugadorModificar);
            tabJugador.Controls.Add(btnJugadorEstado);
            tabJugador.Controls.Add(btnJugadorLimpiar);
            tabJugador.Controls.Add(chkJugadorInactivos);
            tabJugador.Controls.Add(gridJugador);
            tabJugador.Location = new Point(4, 32);
            tabJugador.Name = "tabJugador";
            tabJugador.Size = new Size(932, 514);
            tabJugador.TabIndex = 2;
            tabJugador.Text = "Jugadores";
            tabJugador.UseVisualStyleBackColor = true;
            // 
            // lblJugadorNombre
            // 
            lblJugadorNombre.Location = new Point(20, 20);
            lblJugadorNombre.Name = "lblJugadorNombre";
            lblJugadorNombre.Size = new Size(270, 22);
            lblJugadorNombre.TabIndex = 0;
            lblJugadorNombre.Text = "Nombre";
            // 
            // JugadorNombre
            // 
            JugadorNombre.Location = new Point(20, 45);
            JugadorNombre.MaxLength = 50;
            JugadorNombre.Name = "JugadorNombre";
            JugadorNombre.Size = new Size(270, 30);
            JugadorNombre.TabIndex = 1;
            // 
            // lblJugadorApellido
            // 
            lblJugadorApellido.Location = new Point(320, 20);
            lblJugadorApellido.Name = "lblJugadorApellido";
            lblJugadorApellido.Size = new Size(270, 22);
            lblJugadorApellido.TabIndex = 2;
            lblJugadorApellido.Text = "Apellido";
            // 
            // JugadorApellido
            // 
            JugadorApellido.Location = new Point(320, 45);
            JugadorApellido.MaxLength = 50;
            JugadorApellido.Name = "JugadorApellido";
            JugadorApellido.Size = new Size(270, 30);
            JugadorApellido.TabIndex = 3;
            // 
            // lblJugadorNumeroCamiseta
            // 
            lblJugadorNumeroCamiseta.Location = new Point(620, 20);
            lblJugadorNumeroCamiseta.Name = "lblJugadorNumeroCamiseta";
            lblJugadorNumeroCamiseta.Size = new Size(270, 22);
            lblJugadorNumeroCamiseta.TabIndex = 4;
            lblJugadorNumeroCamiseta.Text = "Camiseta";
            // 
            // JugadorNumeroCamiseta
            // 
            JugadorNumeroCamiseta.Location = new Point(620, 45);
            JugadorNumeroCamiseta.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            JugadorNumeroCamiseta.Name = "JugadorNumeroCamiseta";
            JugadorNumeroCamiseta.Size = new Size(270, 30);
            JugadorNumeroCamiseta.TabIndex = 5;
            // 
            // lblJugadorIdEquipo
            // 
            lblJugadorIdEquipo.Location = new Point(20, 90);
            lblJugadorIdEquipo.Name = "lblJugadorIdEquipo";
            lblJugadorIdEquipo.Size = new Size(270, 22);
            lblJugadorIdEquipo.TabIndex = 6;
            lblJugadorIdEquipo.Text = "Equipo";
            // 
            // JugadorIdEquipo
            // 
            JugadorIdEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            JugadorIdEquipo.Location = new Point(20, 115);
            JugadorIdEquipo.Name = "JugadorIdEquipo";
            JugadorIdEquipo.Size = new Size(270, 31);
            JugadorIdEquipo.TabIndex = 7;
            // 
            // lblJugadorIdPais
            // 
            lblJugadorIdPais.Location = new Point(320, 90);
            lblJugadorIdPais.Name = "lblJugadorIdPais";
            lblJugadorIdPais.Size = new Size(270, 22);
            lblJugadorIdPais.TabIndex = 8;
            lblJugadorIdPais.Text = "País";
            // 
            // JugadorIdPais
            // 
            JugadorIdPais.DropDownStyle = ComboBoxStyle.DropDownList;
            JugadorIdPais.Location = new Point(320, 115);
            JugadorIdPais.Name = "JugadorIdPais";
            JugadorIdPais.Size = new Size(270, 31);
            JugadorIdPais.TabIndex = 9;
            // 
            // btnJugadorGuardar
            // 
            btnJugadorGuardar.Location = new Point(20, 200);
            btnJugadorGuardar.Name = "btnJugadorGuardar";
            btnJugadorGuardar.Size = new Size(165, 34);
            btnJugadorGuardar.TabIndex = 10;
            btnJugadorGuardar.Text = "Guardar nuevo";
            btnJugadorGuardar.UseVisualStyleBackColor = true;
            // 
            // btnJugadorModificar
            // 
            btnJugadorModificar.Location = new Point(195, 200);
            btnJugadorModificar.Name = "btnJugadorModificar";
            btnJugadorModificar.Size = new Size(165, 34);
            btnJugadorModificar.TabIndex = 11;
            btnJugadorModificar.Text = "Modificar";
            btnJugadorModificar.UseVisualStyleBackColor = true;
            // 
            // btnJugadorEstado
            // 
            btnJugadorEstado.Location = new Point(370, 200);
            btnJugadorEstado.Name = "btnJugadorEstado";
            btnJugadorEstado.Size = new Size(165, 34);
            btnJugadorEstado.TabIndex = 12;
            btnJugadorEstado.Text = "Activar / Desactivar";
            btnJugadorEstado.UseVisualStyleBackColor = true;
            // 
            // btnJugadorLimpiar
            // 
            btnJugadorLimpiar.Location = new Point(545, 200);
            btnJugadorLimpiar.Name = "btnJugadorLimpiar";
            btnJugadorLimpiar.Size = new Size(165, 34);
            btnJugadorLimpiar.TabIndex = 13;
            btnJugadorLimpiar.Text = "Limpiar";
            btnJugadorLimpiar.UseVisualStyleBackColor = true;
            // 
            // chkJugadorInactivos
            // 
            chkJugadorInactivos.Location = new Point(730, 205);
            chkJugadorInactivos.Name = "chkJugadorInactivos";
            chkJugadorInactivos.Size = new Size(175, 25);
            chkJugadorInactivos.TabIndex = 14;
            chkJugadorInactivos.Text = "Mostrar inactivos";
            // 
            // gridJugador
            // 
            gridJugador.AllowUserToAddRows = false;
            gridJugador.AllowUserToDeleteRows = false;
            gridJugador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridJugador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridJugador.BackgroundColor = Color.White;
            gridJugador.ColumnHeadersHeight = 29;
            gridJugador.Location = new Point(20, 250);
            gridJugador.MultiSelect = false;
            gridJugador.Name = "gridJugador";
            gridJugador.ReadOnly = true;
            gridJugador.RowHeadersVisible = false;
            gridJugador.RowHeadersWidth = 51;
            gridJugador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridJugador.Size = new Size(885, 252);
            gridJugador.TabIndex = 15;
            // 
            // tabTorneo
            // 
            tabTorneo.Controls.Add(lblTorneoNombre);
            tabTorneo.Controls.Add(TorneoNombre);
            tabTorneo.Controls.Add(lblTorneoAño);
            tabTorneo.Controls.Add(TorneoAño);
            tabTorneo.Controls.Add(btnTorneoGuardar);
            tabTorneo.Controls.Add(btnTorneoModificar);
            tabTorneo.Controls.Add(btnTorneoEstado);
            tabTorneo.Controls.Add(btnTorneoLimpiar);
            tabTorneo.Controls.Add(chkTorneoInactivos);
            tabTorneo.Controls.Add(gridTorneo);
            tabTorneo.Location = new Point(4, 32);
            tabTorneo.Name = "tabTorneo";
            tabTorneo.Size = new Size(932, 514);
            tabTorneo.TabIndex = 3;
            tabTorneo.Text = "Torneos";
            tabTorneo.UseVisualStyleBackColor = true;
            // 
            // lblTorneoNombre
            // 
            lblTorneoNombre.Location = new Point(20, 20);
            lblTorneoNombre.Name = "lblTorneoNombre";
            lblTorneoNombre.Size = new Size(270, 22);
            lblTorneoNombre.TabIndex = 0;
            lblTorneoNombre.Text = "Nombre";
            // 
            // TorneoNombre
            // 
            TorneoNombre.Location = new Point(20, 45);
            TorneoNombre.MaxLength = 50;
            TorneoNombre.Name = "TorneoNombre";
            TorneoNombre.Size = new Size(270, 30);
            TorneoNombre.TabIndex = 1;
            // 
            // lblTorneoAño
            // 
            lblTorneoAño.Location = new Point(320, 20);
            lblTorneoAño.Name = "lblTorneoAño";
            lblTorneoAño.Size = new Size(270, 22);
            lblTorneoAño.TabIndex = 2;
            lblTorneoAño.Text = "Año";
            // 
            // TorneoAño
            // 
            TorneoAño.Location = new Point(320, 45);
            TorneoAño.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            TorneoAño.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            TorneoAño.Name = "TorneoAño";
            TorneoAño.Size = new Size(270, 30);
            TorneoAño.TabIndex = 3;
            TorneoAño.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // btnTorneoGuardar
            // 
            btnTorneoGuardar.Location = new Point(20, 200);
            btnTorneoGuardar.Name = "btnTorneoGuardar";
            btnTorneoGuardar.Size = new Size(165, 34);
            btnTorneoGuardar.TabIndex = 4;
            btnTorneoGuardar.Text = "Guardar nuevo";
            btnTorneoGuardar.UseVisualStyleBackColor = true;
            // 
            // btnTorneoModificar
            // 
            btnTorneoModificar.Location = new Point(195, 200);
            btnTorneoModificar.Name = "btnTorneoModificar";
            btnTorneoModificar.Size = new Size(165, 34);
            btnTorneoModificar.TabIndex = 5;
            btnTorneoModificar.Text = "Modificar";
            btnTorneoModificar.UseVisualStyleBackColor = true;
            // 
            // btnTorneoEstado
            // 
            btnTorneoEstado.Location = new Point(370, 200);
            btnTorneoEstado.Name = "btnTorneoEstado";
            btnTorneoEstado.Size = new Size(165, 34);
            btnTorneoEstado.TabIndex = 6;
            btnTorneoEstado.Text = "Activar / Desactivar";
            btnTorneoEstado.UseVisualStyleBackColor = true;
            // 
            // btnTorneoLimpiar
            // 
            btnTorneoLimpiar.Location = new Point(545, 200);
            btnTorneoLimpiar.Name = "btnTorneoLimpiar";
            btnTorneoLimpiar.Size = new Size(165, 34);
            btnTorneoLimpiar.TabIndex = 7;
            btnTorneoLimpiar.Text = "Limpiar";
            btnTorneoLimpiar.UseVisualStyleBackColor = true;
            // 
            // chkTorneoInactivos
            // 
            chkTorneoInactivos.Location = new Point(730, 205);
            chkTorneoInactivos.Name = "chkTorneoInactivos";
            chkTorneoInactivos.Size = new Size(175, 25);
            chkTorneoInactivos.TabIndex = 8;
            chkTorneoInactivos.Text = "Mostrar inactivos";
            // 
            // gridTorneo
            // 
            gridTorneo.AllowUserToAddRows = false;
            gridTorneo.AllowUserToDeleteRows = false;
            gridTorneo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridTorneo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridTorneo.BackgroundColor = Color.White;
            gridTorneo.ColumnHeadersHeight = 29;
            gridTorneo.Location = new Point(20, 250);
            gridTorneo.MultiSelect = false;
            gridTorneo.Name = "gridTorneo";
            gridTorneo.ReadOnly = true;
            gridTorneo.RowHeadersVisible = false;
            gridTorneo.RowHeadersWidth = 51;
            gridTorneo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridTorneo.Size = new Size(885, 252);
            gridTorneo.TabIndex = 9;
            // 
            // tabPartido
            // 
            tabPartido.Controls.Add(lblPartidoIdTorneo);
            tabPartido.Controls.Add(PartidoIdTorneo);
            tabPartido.Controls.Add(lblPartidoIdEquipoLocal);
            tabPartido.Controls.Add(PartidoIdEquipoLocal);
            tabPartido.Controls.Add(lblPartidoIdEquipoVisitante);
            tabPartido.Controls.Add(PartidoIdEquipoVisitante);
            tabPartido.Controls.Add(lblPartidoFecha);
            tabPartido.Controls.Add(PartidoFecha);
            tabPartido.Controls.Add(lblPartidoGolesLocal);
            tabPartido.Controls.Add(PartidoGolesLocal);
            tabPartido.Controls.Add(lblPartidoGolesVisitante);
            tabPartido.Controls.Add(PartidoGolesVisitante);
            tabPartido.Controls.Add(chkResultado);
            tabPartido.Controls.Add(btnPartidoGuardar);
            tabPartido.Controls.Add(btnPartidoModificar);
            tabPartido.Controls.Add(btnPartidoEstado);
            tabPartido.Controls.Add(btnPartidoLimpiar);
            tabPartido.Controls.Add(chkPartidoInactivos);
            tabPartido.Controls.Add(gridPartido);
            tabPartido.Location = new Point(4, 32);
            tabPartido.Name = "tabPartido";
            tabPartido.Size = new Size(932, 514);
            tabPartido.TabIndex = 4;
            tabPartido.Text = "Partidos";
            tabPartido.UseVisualStyleBackColor = true;
            // 
            // lblPartidoIdTorneo
            // 
            lblPartidoIdTorneo.Location = new Point(20, 20);
            lblPartidoIdTorneo.Name = "lblPartidoIdTorneo";
            lblPartidoIdTorneo.Size = new Size(270, 22);
            lblPartidoIdTorneo.TabIndex = 0;
            lblPartidoIdTorneo.Text = "Torneo";
            // 
            // PartidoIdTorneo
            // 
            PartidoIdTorneo.DropDownStyle = ComboBoxStyle.DropDownList;
            PartidoIdTorneo.Location = new Point(20, 45);
            PartidoIdTorneo.Name = "PartidoIdTorneo";
            PartidoIdTorneo.Size = new Size(270, 31);
            PartidoIdTorneo.TabIndex = 1;
            // 
            // lblPartidoIdEquipoLocal
            // 
            lblPartidoIdEquipoLocal.Location = new Point(320, 20);
            lblPartidoIdEquipoLocal.Name = "lblPartidoIdEquipoLocal";
            lblPartidoIdEquipoLocal.Size = new Size(270, 22);
            lblPartidoIdEquipoLocal.TabIndex = 2;
            lblPartidoIdEquipoLocal.Text = "Local";
            // 
            // PartidoIdEquipoLocal
            // 
            PartidoIdEquipoLocal.DropDownStyle = ComboBoxStyle.DropDownList;
            PartidoIdEquipoLocal.Location = new Point(320, 45);
            PartidoIdEquipoLocal.Name = "PartidoIdEquipoLocal";
            PartidoIdEquipoLocal.Size = new Size(270, 31);
            PartidoIdEquipoLocal.TabIndex = 3;
            // 
            // lblPartidoIdEquipoVisitante
            // 
            lblPartidoIdEquipoVisitante.Location = new Point(620, 20);
            lblPartidoIdEquipoVisitante.Name = "lblPartidoIdEquipoVisitante";
            lblPartidoIdEquipoVisitante.Size = new Size(270, 22);
            lblPartidoIdEquipoVisitante.TabIndex = 4;
            lblPartidoIdEquipoVisitante.Text = "Visitante";
            // 
            // PartidoIdEquipoVisitante
            // 
            PartidoIdEquipoVisitante.DropDownStyle = ComboBoxStyle.DropDownList;
            PartidoIdEquipoVisitante.Location = new Point(620, 45);
            PartidoIdEquipoVisitante.Name = "PartidoIdEquipoVisitante";
            PartidoIdEquipoVisitante.Size = new Size(270, 31);
            PartidoIdEquipoVisitante.TabIndex = 5;
            // 
            // lblPartidoFecha
            // 
            lblPartidoFecha.Location = new Point(20, 90);
            lblPartidoFecha.Name = "lblPartidoFecha";
            lblPartidoFecha.Size = new Size(270, 22);
            lblPartidoFecha.TabIndex = 6;
            lblPartidoFecha.Text = "Fecha y hora";
            // 
            // PartidoFecha
            // 
            PartidoFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            PartidoFecha.Format = DateTimePickerFormat.Custom;
            PartidoFecha.Location = new Point(20, 115);
            PartidoFecha.Name = "PartidoFecha";
            PartidoFecha.Size = new Size(270, 30);
            PartidoFecha.TabIndex = 7;
            // 
            // lblPartidoGolesLocal
            // 
            lblPartidoGolesLocal.Location = new Point(320, 90);
            lblPartidoGolesLocal.Name = "lblPartidoGolesLocal";
            lblPartidoGolesLocal.Size = new Size(270, 22);
            lblPartidoGolesLocal.TabIndex = 8;
            lblPartidoGolesLocal.Text = "Goles local";
            // 
            // PartidoGolesLocal
            // 
            PartidoGolesLocal.Location = new Point(320, 115);
            PartidoGolesLocal.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            PartidoGolesLocal.Name = "PartidoGolesLocal";
            PartidoGolesLocal.Size = new Size(270, 30);
            PartidoGolesLocal.TabIndex = 9;
            // 
            // lblPartidoGolesVisitante
            // 
            lblPartidoGolesVisitante.Location = new Point(620, 90);
            lblPartidoGolesVisitante.Name = "lblPartidoGolesVisitante";
            lblPartidoGolesVisitante.Size = new Size(270, 22);
            lblPartidoGolesVisitante.TabIndex = 10;
            lblPartidoGolesVisitante.Text = "Goles visitante";
            // 
            // PartidoGolesVisitante
            // 
            PartidoGolesVisitante.Location = new Point(620, 115);
            PartidoGolesVisitante.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            PartidoGolesVisitante.Name = "PartidoGolesVisitante";
            PartidoGolesVisitante.Size = new Size(270, 30);
            PartidoGolesVisitante.TabIndex = 11;
            // 
            // chkResultado
            // 
            chkResultado.Location = new Point(20, 160);
            chkResultado.Name = "chkResultado";
            chkResultado.Size = new Size(270, 25);
            chkResultado.TabIndex = 12;
            chkResultado.Text = "Resultado cargado";
            // 
            // btnPartidoGuardar
            // 
            btnPartidoGuardar.Location = new Point(20, 200);
            btnPartidoGuardar.Name = "btnPartidoGuardar";
            btnPartidoGuardar.Size = new Size(165, 34);
            btnPartidoGuardar.TabIndex = 13;
            btnPartidoGuardar.Text = "Guardar nuevo";
            btnPartidoGuardar.UseVisualStyleBackColor = true;
            // 
            // btnPartidoModificar
            // 
            btnPartidoModificar.Location = new Point(195, 200);
            btnPartidoModificar.Name = "btnPartidoModificar";
            btnPartidoModificar.Size = new Size(165, 34);
            btnPartidoModificar.TabIndex = 14;
            btnPartidoModificar.Text = "Modificar";
            btnPartidoModificar.UseVisualStyleBackColor = true;
            // 
            // btnPartidoEstado
            // 
            btnPartidoEstado.Location = new Point(370, 200);
            btnPartidoEstado.Name = "btnPartidoEstado";
            btnPartidoEstado.Size = new Size(165, 34);
            btnPartidoEstado.TabIndex = 15;
            btnPartidoEstado.Text = "Activar / Desactivar";
            btnPartidoEstado.UseVisualStyleBackColor = true;
            // 
            // btnPartidoLimpiar
            // 
            btnPartidoLimpiar.Location = new Point(545, 200);
            btnPartidoLimpiar.Name = "btnPartidoLimpiar";
            btnPartidoLimpiar.Size = new Size(165, 34);
            btnPartidoLimpiar.TabIndex = 16;
            btnPartidoLimpiar.Text = "Limpiar";
            btnPartidoLimpiar.UseVisualStyleBackColor = true;
            // 
            // chkPartidoInactivos
            // 
            chkPartidoInactivos.Location = new Point(730, 205);
            chkPartidoInactivos.Name = "chkPartidoInactivos";
            chkPartidoInactivos.Size = new Size(175, 25);
            chkPartidoInactivos.TabIndex = 17;
            chkPartidoInactivos.Text = "Mostrar inactivos";
            // 
            // gridPartido
            // 
            gridPartido.AllowUserToAddRows = false;
            gridPartido.AllowUserToDeleteRows = false;
            gridPartido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridPartido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridPartido.BackgroundColor = Color.White;
            gridPartido.ColumnHeadersHeight = 29;
            gridPartido.Location = new Point(20, 250);
            gridPartido.MultiSelect = false;
            gridPartido.Name = "gridPartido";
            gridPartido.ReadOnly = true;
            gridPartido.RowHeadersVisible = false;
            gridPartido.RowHeadersWidth = 51;
            gridPartido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPartido.Size = new Size(885, 252);
            gridPartido.TabIndex = 18;
            // 
            // lblEstado
            // 
            lblEstado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEstado.Location = new Point(20, 630);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(940, 30);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Seleccioná una pestaña. Guardar crea un registro; Modificar actualiza el seleccionado.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 675);
            Controls.Add(lblTitulo);
            Controls.Add(pestanas);
            Controls.Add(lblEstado);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(996, 714);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GTE - Windows Forms simple";
            pestanas.ResumeLayout(false);
            tabPais.ResumeLayout(false);
            tabPais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridPais).EndInit();
            tabEquipo.ResumeLayout(false);
            tabEquipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridEquipo).EndInit();
            tabJugador.ResumeLayout(false);
            tabJugador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)JugadorNumeroCamiseta).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridJugador).EndInit();
            tabTorneo.ResumeLayout(false);
            tabTorneo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TorneoAño).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridTorneo).EndInit();
            tabPartido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PartidoGolesLocal).EndInit();
            ((System.ComponentModel.ISupportInitialize)PartidoGolesVisitante).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridPartido).EndInit();
            ResumeLayout(false);

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
