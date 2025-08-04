using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FAKEAxiomaControl
{
    public partial class Form1 : Form
    {
        private Database DB;
        private DataTable table;
        private MySqlDataAdapter adapter;

        class Database
        {
            MySqlConnection connection = new MySqlConnection("Server = localhost; Database = dashboard;" +
                " User ID = root; Password = PLAVNIK184");
        
            public void openConnection()
            {
                if (connection.State == System.Data.ConnectionState.Closed) connection.Open();
            }
            public void closeConnection()
            {
                if (connection.State == System.Data.ConnectionState.Open) connection.Close();
            }
            public MySqlConnection GetConnection()
            { return connection; }
        
        
        }

        public Form1()
        {
            InitializeComponent();
            DB = new Database();
            table = new DataTable();
            adapter = new MySqlDataAdapter();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DB.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT type FROM dashboard.machine_tool_type WHERE id_mt > 8", DB.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ComboTypeMachine.Items.Add((string)(row.ItemArray[0]));//заполняет комбобокс типами 
            }
            DB.closeConnection();
        }

        private void ComboTypeMachine_SelectedIndexChanged(object sender, EventArgs e)//заполняет второй комбобокс именами и обновляет
        {
            FillHeader();
            string mt_type = ComboTypeMachine.Text;
            DB.openConnection();
            DataTable dt2 = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT machine_tool_name FROM machine_tool_name WHERE id_mt = " +
                "(SELECT id_mt FROM machine_tool_type WHERE type = '" + mt_type + "');", DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(dt2);
            ComboNameMachine.Items.Clear();//очистиили предыдущий вариант

            foreach (DataRow row in dt2.Rows)
            {
                ComboNameMachine.Items.Add((string)(row.ItemArray[0]));
            }
            DB.closeConnection();
        }

        private void ComboNameMachine_SelectedIndexChanged(object sender, EventArgs e)//изменение картинки
        {
            namimg_of_machine.Text = (sender as ComboBox).Text;//поле название станка под картинкой 
            switch (namimg_of_machine.Text)
            {
                case "DMG MORI CL2000":
                    MachinePicture.Image = Properties.Resources.DMG_MORI_CL2000; // Замените Properties.Resources.DMG_MORI_CL2000 на правильное имя ресурса
                    break;
                case "Haas UMC-750":
                    MachinePicture.Image = Properties.Resources.Haas_IMC_750; // Замените Properties.Resources.Haas_IMC_750 на правильное имя ресурса
                    break;
                case "Haas ST-10":
                    MachinePicture.Image = Properties.Resources.Haas_ST_10; // Замените Properties.Resources.Haas_ST_10 на правильное имя ресурса
                    break;
                case "IMU-5XP 2518":
                    MachinePicture.Image = Properties.Resources.IMU_5XP_2518; // Замените Properties.Resources.IMU_5XP_2518 на правильное имя ресурса
                    break;
                case "IRONMAC IT-560":
                    MachinePicture.Image = Properties.Resources.IRONMAC_IT_560; // Замените Properties.Resources.IRONMAC_IT_560 на правильное имя ресурса
                    break;
                case "SPECTR TH-2500":
                    MachinePicture.Image = Properties.Resources.SPECTR_TH_2500; // Замените Properties.Resources.SPECTRE_TH_2500 на правильное имя ресурса
                    break;
                default:
                    MachinePicture.Image = null; // Если имя не совпадает ни с одним из случаев, уберите изображение
                    break;
            }
            FillHeader();
        }

        private void FillHeader()
        {
            NAMEOFAXIOMA.Text = ComboTypeMachine.Text + " " + ComboNameMachine.Text;
            int mid_text = NAMEOFAXIOMA.Location.X + NAMEOFAXIOMA.Size.Width / 2;//сдвиг в цент 
            if (mid_text > 690)
            {
               // NAMEOFAXIOMA.Location.X = (mid_text - 690);
            }
        }
        private void Report_Click(object sender, EventArgs e)
        {

        }

        private void Monitoring_Click(object sender, EventArgs e)
        {
            // _buttonIsPressed = 
        }

        private void Glavnaya_Click(object sender, EventArgs e)
        {

        }

        private void Analize_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CurrentCordLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void TypeMachine_Click(object sender, EventArgs e)
        {

        }

        private void NameMachine_Click(object sender, EventArgs e)
        {

        }

        private void ROTATETABLE_Click(object sender, EventArgs e)
        {

        }

        private void SCHPU_Click(object sender, EventArgs e)
        {
            string mt_name = ComboNameMachine.Text;
            table.Clear();
            DB.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT id, worktime, machine_tool_state.status, value, description from machine_tool_state WHERE (select id_mtn=(SELECT id_mtn FROM machine_tool_name WHERE machine_tool_name='" + mt_name +"'));", DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            ActiveMessages.DataSource = table;
            DB.closeConnection();
            //ActiveMessages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


            foreach (DataGridViewRow row in ActiveMessages.Rows)//для цвета текста 
            {
                // Проверяем, что строка не является строкой для добавления новых данных
                if (!row.IsNewRow)
                {
                    // Проверяем, что ячейка "status" не является null
                    if (row.Cells["statusColumn"].Value != null)
                    {
                        // Получаем значение ячейки "status" как строку
                        string status = row.Cells["statusColumn"].Value.ToString();

                        // Сравниваем значение со строкой "high"
                        if (status == "high")
                        {
                            // Устанавливаем цвет шрифта для ячейки в столбце с индексом 2
                            row.Cells[2].Style.ForeColor = Color.Red;
                        }
                        if (status == "common")
                        {
                            // Устанавливаем цвет шрифта для ячейки в столбце с индексом 2
                            row.Cells[2].Style.ForeColor = Color.Green;
                        }
                        if (status == "medium")
                        {
                            // Устанавливаем цвет шрифта для ячейки в столбце с индексом 2
                            row.Cells[2].Style.ForeColor = Color.Orange;
                        }

                    }
                }
            }

        }
        private void InitializeChart()
        {
            // Создание серий (если они еще не существуют)
            if (chart1.Series.FindByName("Частота вращения шпинделя, об/мин") == null)
            {
                chart1.Series.Add("Частота вращения шпинделя, об/мин");
            }

            if (chart1.Series.FindByName("Температура шпинделя, °C") == null)
            {
                chart1.Series.Add("Температура шпинделя, °C");
                chart1.Series["Температура шпинделя, °C"].YAxisType = AxisType.Secondary; // Assign Series2 to AxisY2
            }
        }
        private void drawGraph_Click(object sender, EventArgs e)
        {

        // ----------------------- Оси ------------------------------------------------


            string mt_name = ComboNameMachine.Text;
            dataCords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;//таблица текущие координаты
            dataCords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataCords.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataCords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataCords.ColumnHeadersHeight = 30;
            dataCords.Font = new Font("Microsoft Sans Serif; 9pt; style=Bold", 12);

            dataCords.RowHeadersVisible = false;
            
            DataDrives.RowHeadersVisible = false;
           

            DataTable tablePositionsData = new DataTable();
            DB.openConnection();
            MySqlCommand commandB = new MySqlCommand("select Axe, position from machine_tool_position WHERE id_mtn = (SELECT id_mtn FROM machine_tool_name WHERE machine_tool_name = '" + mt_name + "');", DB.GetConnection());
            adapter.SelectCommand = commandB;
            adapter.Fill(tablePositionsData);
            dataCords.DataSource = tablePositionsData;
            dataCords.RowHeadersVisible = false;
            dataCords.CurrentCell = null;

            // ----------------------- Приводы --------------------------------------------


            DataDrives.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataDrives.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataDrives.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataDrives.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataDrives.ColumnHeadersHeight = 28;
            DataDrives.Font = new Font("Microsoft Sans Serif; 9pt; style=Bold", 12);


            DataDrives.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataTable tableDriveData = new DataTable();
            DB.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT id_mtn, machine_tool_load.status  FROM machine_tool_load WHERE id_mtn =(SELECT id_mtn FROM machine_tool_name WHERE machine_tool_name = '" + mt_name+"');", DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(tableDriveData); //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // 2. Подготовка алфавита
            char[] alphabet = { 'X', 'Y', 'Z', 'A', 'B', 'C' };

            // 3. Привязка данных к DataGridView
            DataDrives.DataSource = tableDriveData;

            // 4. Форматирование столбцов

            // Отключаем автоматическую генерацию столбцов, чтобы настроить их вручную
            DataDrives.AutoGenerateColumns = false;

            // Очищаем старые столбцы
            DataDrives.Columns.Clear();

            // Создаем столбец "Привод"
            DataGridViewTextBoxColumn driveColumn = new DataGridViewTextBoxColumn();
            driveColumn.Name = "driveColumn";
            driveColumn.HeaderText = "Привод";
            DataDrives.Columns.Add(driveColumn);

            // Создаем столбец "Состояние"
            DataGridViewTextBoxColumn statusColumn = new DataGridViewTextBoxColumn();
            statusColumn.Name = "status";
            statusColumn.HeaderText = "Состояние";
            DataDrives.Columns.Add(statusColumn);

            // Проходим по каждой строке и настраиваем отображение
            for (int i = 0; i < tableDriveData.Rows.Count; i++)
            {
                // Отображение букв английского алфавита в столбце "Привод"
                DataDrives.Rows[i].Cells["driveColumn"].Value = alphabet[i]; // Циклический обход алфавита

                // Отображение цвета в столбце "Состояние"
                string status = tableDriveData.Rows[i]["status"].ToString();
                Color cellColor;
                switch (status.ToLower())
                {
                    case "on":
                        cellColor = Color.LightGreen;
                        break;
                    case "load":
                        cellColor = Color.Orange;
                        break;
                    case "off":
                        cellColor = Color.Salmon;
                        break;
                    default:
                        cellColor = Color.White; // Цвет по умолчанию, если статус неизвестен
                        break;
                }
                DataDrives.Rows[i].Cells["status"].Style.BackColor = cellColor;
            }

            // 5. Настройка DataDrives
            DataDrives.RowHeadersVisible = false;
            DataDrives.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataDrives.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataDrives.Font = new Font("Arial", 12);
            DataDrives.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataDrives.ColumnHeadersHeight = 30;
            DataDrives.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataDrives.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataDrives.CurrentCell = null;
        

            // ----------------------- График --------------------------------------------

            DataTable dtt = new DataTable();
            MySqlCommand commanda = new MySqlCommand("SELECT rpm, temperature, warmtime FROM machine_spindel_warmup WHERE idmn = (SELECT id_mtn FROM machine_tool_name WHERE machine_tool_name = '" + mt_name + "');", DB.GetConnection());
            adapter.SelectCommand = commanda;
            adapter.Fill(dtt);
            DB.closeConnection();
            

            InitializeChart();
            chart1.Series["Частота вращения шпинедля, об/мин"].Points.Clear();
            chart1.Series["Температура шпинделя, ℃"].Points.Clear();


            foreach (DataRow dr in dtt.Rows)
            {
                ChartArea chartArea = chart1.ChartAreas[0];

                // Устанавливаем InnerPlotPosition.
                // Параметры: X, Y, Width, Height (в процентах от ChartArea)
                // Чтобы растянуть график по ширине, уменьшаем X и Width.
                chartArea.InnerPlotPosition = new ElementPosition(7,5, 85, 85); // Пример: X = 7%, Width = 85%
                chart1.Series["Температура шпинделя, ℃"].ChartType = SeriesChartType.Spline;

                int RPM = (int)(dr["rpm"]);
                double Tempe = (double)(dr["temperature"]);
                int Timing = (int)(dr["warmtime"]) ;

                chart1.Series["Частота вращения шпинедля, об/мин"].Points.AddXY(Timing, RPM);
                chart1.Series["Температура шпинделя, ℃"].Points.AddXY(Timing, Tempe);


                //chart1.Series["Series2"].IsValueShownAsLabel = true; // while debug
                //chart1.Series["Series1"].IsValueShownAsLabel = true; // while debug

                // визуальная настройка графика
                chart1.ChartAreas[0].AxisX.Title = "секунды";
                chart1.ChartAreas[0].AxisY.Title = "обороты / мин";
                chart1.ChartAreas[0].AxisY2.Title = "температура в ℃";

                chart1.Series["Частота вращения шпинедля, об/мин"].Color = Color.Blue; 
                chart1.Series["Частота вращения шпинедля, об/мин"].BorderWidth = 2;     

                // Изменение цвета и толщины линий для Series2
                chart1.Series["Температура шпинделя, ℃"].Color = Color.LightGreen; 
                chart1.Series["Температура шпинделя, ℃"].BorderWidth = 3;     

                // для графика температуры
                chart1.ChartAreas[0].AxisY2.Maximum = 100;
                chart1.ChartAreas[0].AxisY2.Minimum = 0;
                chart1.ChartAreas[0].AxisY2.Interval = 10;
                
                // для графика оборотов
                chart1.ChartAreas[0].AxisX.Maximum = 480;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Interval = 60;
                chart1.ChartAreas[0].AxisY.Maximum = 8000;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Interval = 1000;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            }

           
        }

        private void namimg_of_machine_Click(object sender, EventArgs e)
        {

        }

        private void dataCords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
