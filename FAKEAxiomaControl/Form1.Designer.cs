namespace FAKEAxiomaControl
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private bool _buttonIsPressed = true;


        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelKnopkiControl = new System.Windows.Forms.Panel();
            this.NAZVANIEPROGI = new System.Windows.Forms.Label();
            this.ComboTypeMachine = new System.Windows.Forms.ComboBox();
            this.ComboNameMachine = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.namimg_of_machine = new System.Windows.Forms.Label();
            this.TypeMachine = new System.Windows.Forms.Label();
            this.NameMachine = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.XAXE = new System.Windows.Forms.Button();
            this.ROTATINGHEAD = new System.Windows.Forms.Button();
            this.SCHPU = new System.Windows.Forms.Button();
            this.SPINDEL = new System.Windows.Forms.Button();
            this.AMMO = new System.Windows.Forms.Button();
            this.TECHNOLOGY = new System.Windows.Forms.Button();
            this.CAXE = new System.Windows.Forms.Button();
            this.BAXE = new System.Windows.Forms.Button();
            this.ZAXE = new System.Windows.Forms.Button();
            this.YAXE = new System.Windows.Forms.Button();
            this.POWER = new System.Windows.Forms.Button();
            this.MACHINEREMOTE = new System.Windows.Forms.Button();
            this.ROTATETABLE = new System.Windows.Forms.Button();
            this.AAXE = new System.Windows.Forms.Button();
            this.ActiveMessagesLabel = new System.Windows.Forms.Label();
            this.CurrentCordLabel = new System.Windows.Forms.Label();
            this.drive = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataDrives = new System.Windows.Forms.DataGridView();
            this.DriveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriveState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataCords = new System.Windows.Forms.DataGridView();
            this.AxesColunm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMEOFAXIOMA = new System.Windows.Forms.Label();
            this.GraphLabel = new System.Windows.Forms.Label();
            this.backgroundpanel = new System.Windows.Forms.Panel();
            this.OPERATINGPANEL = new System.Windows.Forms.Button();
            this.drawGraph = new System.Windows.Forms.Button();
            this.ActiveMessages = new System.Windows.Forms.DataGridView();
            this.channelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Analize = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.Monitoring = new System.Windows.Forms.Button();
            this.Glavnaya = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MachinePicture = new System.Windows.Forms.PictureBox();
            this.Xbutton = new System.Windows.Forms.Button();
            this.Ybutton = new System.Windows.Forms.Button();
            this.Zbutton = new System.Windows.Forms.Button();
            this.Abutton = new System.Windows.Forms.Button();
            this.Bbutton = new System.Windows.Forms.Button();
            this.Cbutton = new System.Windows.Forms.Button();
            this.AUTObutton = new System.Windows.Forms.Button();
            this.panelKnopkiControl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDrives)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCords)).BeginInit();
            this.backgroundpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachinePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKnopkiControl
            // 
            this.panelKnopkiControl.Controls.Add(this.NAZVANIEPROGI);
            this.panelKnopkiControl.Controls.Add(this.Analize);
            this.panelKnopkiControl.Controls.Add(this.Report);
            this.panelKnopkiControl.Controls.Add(this.Monitoring);
            this.panelKnopkiControl.Controls.Add(this.Glavnaya);
            this.panelKnopkiControl.Location = new System.Drawing.Point(10, 10);
            this.panelKnopkiControl.Name = "panelKnopkiControl";
            this.panelKnopkiControl.Size = new System.Drawing.Size(216, 306);
            this.panelKnopkiControl.TabIndex = 0;
            // 
            // NAZVANIEPROGI
            // 
            this.NAZVANIEPROGI.AutoSize = true;
            this.NAZVANIEPROGI.BackColor = System.Drawing.Color.Transparent;
            this.NAZVANIEPROGI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NAZVANIEPROGI.Location = new System.Drawing.Point(-8, 0);
            this.NAZVANIEPROGI.Name = "NAZVANIEPROGI";
            this.NAZVANIEPROGI.Size = new System.Drawing.Size(224, 25);
            this.NAZVANIEPROGI.TabIndex = 7;
            this.NAZVANIEPROGI.Text = "FAKEAxiomaControl";
            // 
            // ComboTypeMachine
            // 
            this.ComboTypeMachine.BackColor = System.Drawing.SystemColors.Window;
            this.ComboTypeMachine.FormattingEnabled = true;
            this.ComboTypeMachine.Location = new System.Drawing.Point(24, 358);
            this.ComboTypeMachine.Name = "ComboTypeMachine";
            this.ComboTypeMachine.Size = new System.Drawing.Size(176, 21);
            this.ComboTypeMachine.TabIndex = 1;
            this.ComboTypeMachine.SelectedIndexChanged += new System.EventHandler(this.ComboTypeMachine_SelectedIndexChanged);
            // 
            // ComboNameMachine
            // 
            this.ComboNameMachine.FormattingEnabled = true;
            this.ComboNameMachine.Location = new System.Drawing.Point(24, 398);
            this.ComboNameMachine.Name = "ComboNameMachine";
            this.ComboNameMachine.Size = new System.Drawing.Size(176, 21);
            this.ComboNameMachine.TabIndex = 2;
            this.ComboNameMachine.SelectedIndexChanged += new System.EventHandler(this.ComboNameMachine_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MachinePicture);
            this.panel1.Controls.Add(this.namimg_of_machine);
            this.panel1.Controls.Add(this.AUTObutton);
            this.panel1.Controls.Add(this.Cbutton);
            this.panel1.Controls.Add(this.Bbutton);
            this.panel1.Controls.Add(this.Abutton);
            this.panel1.Controls.Add(this.Zbutton);
            this.panel1.Controls.Add(this.Ybutton);
            this.panel1.Controls.Add(this.Xbutton);
            this.panel1.Location = new System.Drawing.Point(10, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 324);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // namimg_of_machine
            // 
            this.namimg_of_machine.AutoSize = true;
            this.namimg_of_machine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namimg_of_machine.Location = new System.Drawing.Point(36, 179);
            this.namimg_of_machine.Name = "namimg_of_machine";
            this.namimg_of_machine.Size = new System.Drawing.Size(142, 24);
            this.namimg_of_machine.TabIndex = 1;
            this.namimg_of_machine.Text = "IMU-5XP 2518";
            this.namimg_of_machine.Click += new System.EventHandler(this.namimg_of_machine_Click);
            // 
            // TypeMachine
            // 
            this.TypeMachine.AutoSize = true;
            this.TypeMachine.BackColor = System.Drawing.Color.LavenderBlush;
            this.TypeMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeMachine.Location = new System.Drawing.Point(24, 342);
            this.TypeMachine.Name = "TypeMachine";
            this.TypeMachine.Size = new System.Drawing.Size(96, 16);
            this.TypeMachine.TabIndex = 4;
            this.TypeMachine.Text = "Тип Станка:";
            this.TypeMachine.Click += new System.EventHandler(this.TypeMachine_Click);
            // 
            // NameMachine
            // 
            this.NameMachine.AutoSize = true;
            this.NameMachine.BackColor = System.Drawing.Color.LavenderBlush;
            this.NameMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameMachine.Location = new System.Drawing.Point(24, 382);
            this.NameMachine.Name = "NameMachine";
            this.NameMachine.Size = new System.Drawing.Size(122, 16);
            this.NameMachine.TabIndex = 5;
            this.NameMachine.Text = "Наименование:";
            this.NameMachine.Click += new System.EventHandler(this.NameMachine_Click);
            // 
            // chart1
            // 
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.LavenderBlush;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Enabled = false;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackSecondaryColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.InterlacedRowsColor = System.Drawing.Color.Transparent;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 9F;
            legend1.Position.Width = 96F;
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(727, 66);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Частота вращения шпинедля, об/мин";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Температура шпинделя, ℃";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(512, 414);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // XAXE
            // 
            this.XAXE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XAXE.Location = new System.Drawing.Point(248, 314);
            this.XAXE.Name = "XAXE";
            this.XAXE.Size = new System.Drawing.Size(70, 50);
            this.XAXE.TabIndex = 8;
            this.XAXE.Text = "Ось Х";
            this.XAXE.UseVisualStyleBackColor = true;
            // 
            // ROTATINGHEAD
            // 
            this.ROTATINGHEAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ROTATINGHEAD.Location = new System.Drawing.Point(588, 419);
            this.ROTATINGHEAD.Name = "ROTATINGHEAD";
            this.ROTATINGHEAD.Size = new System.Drawing.Size(126, 50);
            this.ROTATINGHEAD.TabIndex = 10;
            this.ROTATINGHEAD.Text = "Поворотная голова";
            this.ROTATINGHEAD.UseVisualStyleBackColor = true;
            // 
            // SCHPU
            // 
            this.SCHPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SCHPU.Location = new System.Drawing.Point(400, 419);
            this.SCHPU.Name = "SCHPU";
            this.SCHPU.Size = new System.Drawing.Size(90, 50);
            this.SCHPU.TabIndex = 11;
            this.SCHPU.Text = "СЧПУ";
            this.SCHPU.UseVisualStyleBackColor = true;
            this.SCHPU.Click += new System.EventHandler(this.SCHPU_Click);
            // 
            // SPINDEL
            // 
            this.SPINDEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SPINDEL.Location = new System.Drawing.Point(492, 367);
            this.SPINDEL.Name = "SPINDEL";
            this.SPINDEL.Size = new System.Drawing.Size(90, 50);
            this.SPINDEL.TabIndex = 12;
            this.SPINDEL.Text = "Шпиндель";
            this.SPINDEL.UseVisualStyleBackColor = true;
            // 
            // AMMO
            // 
            this.AMMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AMMO.Location = new System.Drawing.Point(400, 367);
            this.AMMO.Name = "AMMO";
            this.AMMO.Size = new System.Drawing.Size(90, 50);
            this.AMMO.TabIndex = 13;
            this.AMMO.Text = "Магазин";
            this.AMMO.UseVisualStyleBackColor = true;
            // 
            // TECHNOLOGY
            // 
            this.TECHNOLOGY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TECHNOLOGY.Location = new System.Drawing.Point(588, 367);
            this.TECHNOLOGY.Name = "TECHNOLOGY";
            this.TECHNOLOGY.Size = new System.Drawing.Size(126, 50);
            this.TECHNOLOGY.TabIndex = 14;
            this.TECHNOLOGY.Text = "Технология";
            this.TECHNOLOGY.UseVisualStyleBackColor = true;
            // 
            // CAXE
            // 
            this.CAXE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CAXE.Location = new System.Drawing.Point(324, 419);
            this.CAXE.Name = "CAXE";
            this.CAXE.Size = new System.Drawing.Size(70, 50);
            this.CAXE.TabIndex = 15;
            this.CAXE.Text = "Ось С";
            this.CAXE.UseVisualStyleBackColor = true;
            // 
            // BAXE
            // 
            this.BAXE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAXE.Location = new System.Drawing.Point(324, 367);
            this.BAXE.Name = "BAXE";
            this.BAXE.Size = new System.Drawing.Size(70, 50);
            this.BAXE.TabIndex = 16;
            this.BAXE.Text = "Ось В";
            this.BAXE.UseVisualStyleBackColor = true;
            // 
            // ZAXE
            // 
            this.ZAXE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZAXE.Location = new System.Drawing.Point(248, 419);
            this.ZAXE.Name = "ZAXE";
            this.ZAXE.Size = new System.Drawing.Size(70, 50);
            this.ZAXE.TabIndex = 17;
            this.ZAXE.Text = "Ось Z";
            this.ZAXE.UseVisualStyleBackColor = true;
            // 
            // YAXE
            // 
            this.YAXE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YAXE.Location = new System.Drawing.Point(248, 367);
            this.YAXE.Name = "YAXE";
            this.YAXE.Size = new System.Drawing.Size(70, 50);
            this.YAXE.TabIndex = 18;
            this.YAXE.Text = "Ось Y";
            this.YAXE.UseVisualStyleBackColor = true;
            // 
            // POWER
            // 
            this.POWER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.POWER.Location = new System.Drawing.Point(492, 314);
            this.POWER.Name = "POWER";
            this.POWER.Size = new System.Drawing.Size(90, 50);
            this.POWER.TabIndex = 19;
            this.POWER.Text = "Питание";
            this.POWER.UseVisualStyleBackColor = true;
            // 
            // MACHINEREMOTE
            // 
            this.MACHINEREMOTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MACHINEREMOTE.Location = new System.Drawing.Point(400, 314);
            this.MACHINEREMOTE.Name = "MACHINEREMOTE";
            this.MACHINEREMOTE.Size = new System.Drawing.Size(90, 50);
            this.MACHINEREMOTE.TabIndex = 20;
            this.MACHINEREMOTE.Text = "Станочный пульт";
            this.MACHINEREMOTE.UseVisualStyleBackColor = true;
            // 
            // ROTATETABLE
            // 
            this.ROTATETABLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ROTATETABLE.Location = new System.Drawing.Point(588, 314);
            this.ROTATETABLE.Name = "ROTATETABLE";
            this.ROTATETABLE.Size = new System.Drawing.Size(126, 50);
            this.ROTATETABLE.TabIndex = 21;
            this.ROTATETABLE.Text = "Поворотный стол";
            this.ROTATETABLE.UseVisualStyleBackColor = true;
            this.ROTATETABLE.Click += new System.EventHandler(this.ROTATETABLE_Click);
            // 
            // AAXE
            // 
            this.AAXE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AAXE.Location = new System.Drawing.Point(324, 314);
            this.AAXE.Name = "AAXE";
            this.AAXE.Size = new System.Drawing.Size(70, 50);
            this.AAXE.TabIndex = 22;
            this.AAXE.Text = "Ось А";
            this.AAXE.UseVisualStyleBackColor = true;
            // 
            // ActiveMessagesLabel
            // 
            this.ActiveMessagesLabel.AutoSize = true;
            this.ActiveMessagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActiveMessagesLabel.Location = new System.Drawing.Point(369, 291);
            this.ActiveMessagesLabel.Name = "ActiveMessagesLabel";
            this.ActiveMessagesLabel.Size = new System.Drawing.Size(190, 20);
            this.ActiveMessagesLabel.TabIndex = 23;
            this.ActiveMessagesLabel.Text = "Активные сообщения";
            // 
            // CurrentCordLabel
            // 
            this.CurrentCordLabel.AutoSize = true;
            this.CurrentCordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentCordLabel.Location = new System.Drawing.Point(-4, 1);
            this.CurrentCordLabel.Name = "CurrentCordLabel";
            this.CurrentCordLabel.Size = new System.Drawing.Size(260, 20);
            this.CurrentCordLabel.TabIndex = 24;
            this.CurrentCordLabel.Text = "Текущие значения координат";
            this.CurrentCordLabel.Click += new System.EventHandler(this.CurrentCordLabel_Click);
            // 
            // drive
            // 
            this.drive.AutoSize = true;
            this.drive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drive.Location = new System.Drawing.Point(3, 7);
            this.drive.Name = "drive";
            this.drive.Size = new System.Drawing.Size(187, 20);
            this.drive.TabIndex = 25;
            this.drive.Text = "Состояние приводов";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DataDrives);
            this.panel2.Controls.Add(this.drive);
            this.panel2.Location = new System.Drawing.Point(505, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 202);
            this.panel2.TabIndex = 26;
            // 
            // DataDrives
            // 
            this.DataDrives.AllowUserToAddRows = false;
            this.DataDrives.AllowUserToDeleteRows = false;
            this.DataDrives.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.DataDrives.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataDrives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDrives.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriveColumn,
            this.DriveState});
            this.DataDrives.Enabled = false;
            this.DataDrives.Location = new System.Drawing.Point(0, 30);
            this.DataDrives.Name = "DataDrives";
            this.DataDrives.ReadOnly = true;
            this.DataDrives.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataDrives.Size = new System.Drawing.Size(196, 163);
            this.DataDrives.TabIndex = 26;
            this.DataDrives.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DriveColumn
            // 
            this.DriveColumn.DataPropertyName = "id_mtn";
            this.DriveColumn.HeaderText = "Привод";
            this.DriveColumn.Name = "DriveColumn";
            this.DriveColumn.ReadOnly = true;
            this.DriveColumn.Width = 60;
            // 
            // DriveState
            // 
            this.DriveState.DataPropertyName = "status";
            this.DriveState.HeaderText = "Состояние";
            this.DriveState.Name = "DriveState";
            this.DriveState.ReadOnly = true;
            this.DriveState.Width = 136;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataCords);
            this.panel3.Controls.Add(this.CurrentCordLabel);
            this.panel3.Location = new System.Drawing.Point(246, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 249);
            this.panel3.TabIndex = 27;
            // 
            // dataCords
            // 
            this.dataCords.AllowUserToAddRows = false;
            this.dataCords.AllowUserToDeleteRows = false;
            this.dataCords.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataCords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataCords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AxesColunm,
            this.CoordColumn});
            this.dataCords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataCords.Enabled = false;
            this.dataCords.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataCords.Location = new System.Drawing.Point(0, 24);
            this.dataCords.MultiSelect = false;
            this.dataCords.Name = "dataCords";
            this.dataCords.ReadOnly = true;
            this.dataCords.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataCords.ShowEditingIcon = false;
            this.dataCords.Size = new System.Drawing.Size(247, 175);
            this.dataCords.TabIndex = 25;
            this.dataCords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCords_CellContentClick);
            // 
            // AxesColunm
            // 
            this.AxesColunm.DataPropertyName = "Axe";
            this.AxesColunm.HeaderText = "Оси";
            this.AxesColunm.Name = "AxesColunm";
            this.AxesColunm.ReadOnly = true;
            this.AxesColunm.Width = 120;
            // 
            // CoordColumn
            // 
            this.CoordColumn.DataPropertyName = "Position";
            this.CoordColumn.HeaderText = "Координаты";
            this.CoordColumn.Name = "CoordColumn";
            this.CoordColumn.ReadOnly = true;
            this.CoordColumn.Width = 127;
            // 
            // NAMEOFAXIOMA
            // 
            this.NAMEOFAXIOMA.AutoSize = true;
            this.NAMEOFAXIOMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NAMEOFAXIOMA.Location = new System.Drawing.Point(425, 9);
            this.NAMEOFAXIOMA.Name = "NAMEOFAXIOMA";
            this.NAMEOFAXIOMA.Size = new System.Drawing.Size(530, 25);
            this.NAMEOFAXIOMA.TabIndex = 28;
            this.NAMEOFAXIOMA.Text = "Пятикоординатный станок с ЧПУ IMU-5XP 2518";
            this.NAMEOFAXIOMA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GraphLabel
            // 
            this.GraphLabel.AutoSize = true;
            this.GraphLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GraphLabel.Location = new System.Drawing.Point(743, 39);
            this.GraphLabel.Name = "GraphLabel";
            this.GraphLabel.Size = new System.Drawing.Size(465, 20);
            this.GraphLabel.TabIndex = 29;
            this.GraphLabel.Text = "График прогрева шпинделя после включения станка";
            // 
            // backgroundpanel
            // 
            this.backgroundpanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.backgroundpanel.Controls.Add(this.panelKnopkiControl);
            this.backgroundpanel.Controls.Add(this.panel1);
            this.backgroundpanel.Controls.Add(this.TypeMachine);
            this.backgroundpanel.Controls.Add(this.ComboTypeMachine);
            this.backgroundpanel.Controls.Add(this.ComboNameMachine);
            this.backgroundpanel.Controls.Add(this.NameMachine);
            this.backgroundpanel.Location = new System.Drawing.Point(-1, -2);
            this.backgroundpanel.Name = "backgroundpanel";
            this.backgroundpanel.Size = new System.Drawing.Size(235, 767);
            this.backgroundpanel.TabIndex = 30;
            // 
            // OPERATINGPANEL
            // 
            this.OPERATINGPANEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPERATINGPANEL.Location = new System.Drawing.Point(492, 419);
            this.OPERATINGPANEL.Name = "OPERATINGPANEL";
            this.OPERATINGPANEL.Size = new System.Drawing.Size(90, 50);
            this.OPERATINGPANEL.TabIndex = 31;
            this.OPERATINGPANEL.Text = "Панель оператора";
            this.OPERATINGPANEL.UseVisualStyleBackColor = true;
            // 
            // drawGraph
            // 
            this.drawGraph.BackColor = System.Drawing.Color.White;
            this.drawGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawGraph.Location = new System.Drawing.Point(704, 225);
            this.drawGraph.Name = "drawGraph";
            this.drawGraph.Size = new System.Drawing.Size(28, 86);
            this.drawGraph.TabIndex = 32;
            this.drawGraph.Text = "ГРАФИК";
            this.drawGraph.UseVisualStyleBackColor = false;
            this.drawGraph.Click += new System.EventHandler(this.drawGraph_Click);
            // 
            // ActiveMessages
            // 
            this.ActiveMessages.AllowUserToResizeColumns = false;
            this.ActiveMessages.AllowUserToResizeRows = false;
            this.ActiveMessages.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.ActiveMessages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ActiveMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.channelColumn,
            this.timeColumn,
            this.statusColumn,
            this.valueColumn,
            this.descriptionColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ActiveMessages.DefaultCellStyle = dataGridViewCellStyle1;
            this.ActiveMessages.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ActiveMessages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ActiveMessages.Location = new System.Drawing.Point(254, 506);
            this.ActiveMessages.Name = "ActiveMessages";
            this.ActiveMessages.ReadOnly = true;
            this.ActiveMessages.RowHeadersVisible = false;
            this.ActiveMessages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ActiveMessages.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ActiveMessages.Size = new System.Drawing.Size(985, 243);
            this.ActiveMessages.TabIndex = 7;
            // 
            // channelColumn
            // 
            this.channelColumn.DataPropertyName = "id";
            this.channelColumn.HeaderText = "Канал";
            this.channelColumn.Name = "channelColumn";
            this.channelColumn.ReadOnly = true;
            this.channelColumn.Width = 50;
            // 
            // timeColumn
            // 
            this.timeColumn.DataPropertyName = "worktime";
            this.timeColumn.HeaderText = "Время";
            this.timeColumn.Name = "timeColumn";
            this.timeColumn.ReadOnly = true;
            // 
            // statusColumn
            // 
            this.statusColumn.DataPropertyName = "status";
            this.statusColumn.HeaderText = "Статус";
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            // 
            // valueColumn
            // 
            this.valueColumn.DataPropertyName = "value";
            this.valueColumn.HeaderText = "Номер";
            this.valueColumn.Name = "valueColumn";
            this.valueColumn.ReadOnly = true;
            this.valueColumn.Width = 120;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.DataPropertyName = "description";
            this.descriptionColumn.HeaderText = "Текст";
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.ReadOnly = true;
            this.descriptionColumn.Width = 620;
            // 
            // Analize
            // 
            this.Analize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Analize.Image = ((System.Drawing.Image)(resources.GetObject("Analize.Image")));
            this.Analize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Analize.Location = new System.Drawing.Point(17, 172);
            this.Analize.Name = "Analize";
            this.Analize.Size = new System.Drawing.Size(188, 49);
            this.Analize.TabIndex = 6;
            this.Analize.Text = "Анализ";
            this.Analize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Analize.UseVisualStyleBackColor = true;
            this.Analize.Click += new System.EventHandler(this.Analize_Click);
            // 
            // Report
            // 
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report.Image = ((System.Drawing.Image)(resources.GetObject("Report.Image")));
            this.Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Report.Location = new System.Drawing.Point(17, 239);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(188, 49);
            this.Report.TabIndex = 5;
            this.Report.Text = "Отчет";
            this.Report.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // Monitoring
            // 
            this.Monitoring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Monitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Monitoring.Image = ((System.Drawing.Image)(resources.GetObject("Monitoring.Image")));
            this.Monitoring.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Monitoring.Location = new System.Drawing.Point(17, 101);
            this.Monitoring.Name = "Monitoring";
            this.Monitoring.Size = new System.Drawing.Size(188, 49);
            this.Monitoring.TabIndex = 3;
            this.Monitoring.Text = "Мониторинг";
            this.Monitoring.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Monitoring.UseVisualStyleBackColor = true;
            this.Monitoring.Click += new System.EventHandler(this.Monitoring_Click);
            // 
            // Glavnaya
            // 
            this.Glavnaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Glavnaya.Image = ((System.Drawing.Image)(resources.GetObject("Glavnaya.Image")));
            this.Glavnaya.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Glavnaya.Location = new System.Drawing.Point(17, 30);
            this.Glavnaya.Name = "Glavnaya";
            this.Glavnaya.Size = new System.Drawing.Size(188, 49);
            this.Glavnaya.TabIndex = 0;
            this.Glavnaya.Text = "Главная";
            this.Glavnaya.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Glavnaya.UseVisualStyleBackColor = true;
            this.Glavnaya.Click += new System.EventHandler(this.Glavnaya_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FAKEAxiomaControl.Properties.Resources.panel_element;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MachinePicture
            // 
            this.MachinePicture.Image = global::FAKEAxiomaControl.Properties.Resources.IMU_5XP_2518;
            this.MachinePicture.Location = new System.Drawing.Point(12, 3);
            this.MachinePicture.Name = "MachinePicture";
            this.MachinePicture.Size = new System.Drawing.Size(191, 173);
            this.MachinePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MachinePicture.TabIndex = 3;
            this.MachinePicture.TabStop = false;
            // 
            // Xbutton
            // 
            this.Xbutton.BackColor = System.Drawing.Color.LawnGreen;
            this.Xbutton.Location = new System.Drawing.Point(1, 264);
            this.Xbutton.Name = "Xbutton";
            this.Xbutton.Size = new System.Drawing.Size(27, 58);
            this.Xbutton.TabIndex = 5;
            this.Xbutton.Text = "X";
            this.Xbutton.UseVisualStyleBackColor = false;
            // 
            // Ybutton
            // 
            this.Ybutton.BackColor = System.Drawing.Color.LawnGreen;
            this.Ybutton.Location = new System.Drawing.Point(26, 264);
            this.Ybutton.Name = "Ybutton";
            this.Ybutton.Size = new System.Drawing.Size(27, 58);
            this.Ybutton.TabIndex = 6;
            this.Ybutton.Text = "Y";
            this.Ybutton.UseVisualStyleBackColor = false;
            // 
            // Zbutton
            // 
            this.Zbutton.BackColor = System.Drawing.Color.LawnGreen;
            this.Zbutton.Location = new System.Drawing.Point(52, 264);
            this.Zbutton.Name = "Zbutton";
            this.Zbutton.Size = new System.Drawing.Size(27, 58);
            this.Zbutton.TabIndex = 7;
            this.Zbutton.Text = "Z";
            this.Zbutton.UseVisualStyleBackColor = false;
            // 
            // Abutton
            // 
            this.Abutton.BackColor = System.Drawing.Color.LawnGreen;
            this.Abutton.Location = new System.Drawing.Point(79, 264);
            this.Abutton.Name = "Abutton";
            this.Abutton.Size = new System.Drawing.Size(27, 58);
            this.Abutton.TabIndex = 8;
            this.Abutton.Text = "A";
            this.Abutton.UseVisualStyleBackColor = false;
            // 
            // Bbutton
            // 
            this.Bbutton.BackColor = System.Drawing.Color.LawnGreen;
            this.Bbutton.Location = new System.Drawing.Point(106, 264);
            this.Bbutton.Name = "Bbutton";
            this.Bbutton.Size = new System.Drawing.Size(27, 58);
            this.Bbutton.TabIndex = 9;
            this.Bbutton.Text = "B";
            this.Bbutton.UseVisualStyleBackColor = false;
            // 
            // Cbutton
            // 
            this.Cbutton.BackColor = System.Drawing.Color.LawnGreen;
            this.Cbutton.Location = new System.Drawing.Point(133, 264);
            this.Cbutton.Name = "Cbutton";
            this.Cbutton.Size = new System.Drawing.Size(27, 58);
            this.Cbutton.TabIndex = 10;
            this.Cbutton.Text = "C";
            this.Cbutton.UseVisualStyleBackColor = false;
            // 
            // AUTObutton
            // 
            this.AUTObutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AUTObutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AUTObutton.Location = new System.Drawing.Point(160, 264);
            this.AUTObutton.Name = "AUTObutton";
            this.AUTObutton.Size = new System.Drawing.Size(51, 58);
            this.AUTObutton.TabIndex = 11;
            this.AUTObutton.Text = "AUTO";
            this.AUTObutton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.OPERATINGPANEL);
            this.Controls.Add(this.GraphLabel);
            this.Controls.Add(this.NAMEOFAXIOMA);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ActiveMessagesLabel);
            this.Controls.Add(this.AAXE);
            this.Controls.Add(this.ROTATETABLE);
            this.Controls.Add(this.MACHINEREMOTE);
            this.Controls.Add(this.POWER);
            this.Controls.Add(this.YAXE);
            this.Controls.Add(this.ZAXE);
            this.Controls.Add(this.BAXE);
            this.Controls.Add(this.CAXE);
            this.Controls.Add(this.TECHNOLOGY);
            this.Controls.Add(this.AMMO);
            this.Controls.Add(this.SPINDEL);
            this.Controls.Add(this.SCHPU);
            this.Controls.Add(this.ROTATINGHEAD);
            this.Controls.Add(this.XAXE);
            this.Controls.Add(this.ActiveMessages);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.backgroundpanel);
            this.Controls.Add(this.drawGraph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelKnopkiControl.ResumeLayout(false);
            this.panelKnopkiControl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDrives)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCords)).EndInit();
            this.backgroundpanel.ResumeLayout(false);
            this.backgroundpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachinePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelKnopkiControl;
        private System.Windows.Forms.ComboBox ComboTypeMachine;
        private System.Windows.Forms.ComboBox ComboNameMachine;
        private System.Windows.Forms.Button Glavnaya;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button Monitoring;
        private System.Windows.Forms.Button Analize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TypeMachine;
        private System.Windows.Forms.Label NameMachine;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button XAXE;
        private System.Windows.Forms.Button ROTATINGHEAD;
        private System.Windows.Forms.Button SCHPU;
        private System.Windows.Forms.Button SPINDEL;
        private System.Windows.Forms.Button AMMO;
        private System.Windows.Forms.Button TECHNOLOGY;
        private System.Windows.Forms.Button CAXE;
        private System.Windows.Forms.Button BAXE;
        private System.Windows.Forms.Button ZAXE;
        private System.Windows.Forms.Button YAXE;
        private System.Windows.Forms.Button POWER;
        private System.Windows.Forms.Button MACHINEREMOTE;
        private System.Windows.Forms.Button ROTATETABLE;
        private System.Windows.Forms.Button AAXE;
        private System.Windows.Forms.Label ActiveMessagesLabel;
        private System.Windows.Forms.Label CurrentCordLabel;
        private System.Windows.Forms.Label drive;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label NAMEOFAXIOMA;
        private System.Windows.Forms.DataGridView DataDrives;
        private System.Windows.Forms.DataGridView dataCords;
        private System.Windows.Forms.Label GraphLabel;
        private System.Windows.Forms.Panel backgroundpanel;
        private System.Windows.Forms.Button OPERATINGPANEL;
        private System.Windows.Forms.Label NAZVANIEPROGI;
        private System.Windows.Forms.Button drawGraph;
        private System.Windows.Forms.Label namimg_of_machine;
        private System.Windows.Forms.DataGridView ActiveMessages;
        private System.Windows.Forms.PictureBox MachinePicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriveState;
        private System.Windows.Forms.DataGridViewTextBoxColumn AxesColunm;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn channelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AUTObutton;
        private System.Windows.Forms.Button Cbutton;
        private System.Windows.Forms.Button Bbutton;
        private System.Windows.Forms.Button Abutton;
        private System.Windows.Forms.Button Zbutton;
        private System.Windows.Forms.Button Ybutton;
        private System.Windows.Forms.Button Xbutton;
    }
}

