using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;
using MySql.Data.MySqlClient;


namespace FakeAxioma3
{
    using LiveCharts.Defaults;
    using LiveCharts.Wpf;
    using System.Windows;
    using System.Windows.Controls.Primitives;

    public class DBDataViewModel : INotifyPropertyChanged//vm
    {
        private readonly string _connectionString;
        private string _mtName; // Изменили на приватное поле с подчеркиванием (текущее название)

        public string MtName
        {
            get => _mtName;
            set
            {
                if (_mtName != value)//Если новое значение отличается от текущего
                {
                    _mtName = value;//обновляет поле
                    OnPropertyChanged(nameof(MtName)); //сообщает UI, что свойство изменилось
                    LoadData(); // Автоматически загружаем данные при изменении имени
                }
            }
        }

        public SeriesCollection SeriesCollection { get; set; }//model
        public Func<double, string> TimeFormatter { get; set; }//model

        public event PropertyChangedEventHandler PropertyChanged;

        public DBDataViewModel(string connectionString, string initialName)
        {
            
            _connectionString = connectionString;
            MtName = initialName; // Используем свойство вместо поля
            InitializeChart();
            LoadData();
        }


        private void InitializeChart()
        {
            SeriesCollection = new SeriesCollection
    {
        new LineSeries
        {
            Title = "Температура (°C)",
            Values = new ChartValues<ObservablePoint>(), // Изменили на ObservablePoint
            Stroke = Brushes.LightGreen,
            StrokeThickness = 3,
            Fill = Brushes.Transparent,
            PointGeometry = null,
            ScalesYAt = 0
        },
        new LineSeries
        {
            Title = "Обороты (RPM)",
            Values = new ChartValues<ObservablePoint>(), // Изменили на ObservablePoint
            Stroke = Brushes.Blue,
            Fill = Brushes.Transparent,
            StrokeThickness = 3,
            PointGeometry = null,
            ScalesYAt = 1
        }
    };
        }

        public void LoadData()
        {
            if (string.IsNullOrEmpty(MtName)) return;

            try
            {
                using (var connection = new MySqlConnection(_connectionString))//Открываем соединение с базой MySQL
                {
                    // Исправленный SQL-запрос с параметром (защита от SQL-инъекций)
                    var query = @"SELECT warmtime, temperature, rpm 
                         FROM machine_spindel_warmup 
                         WHERE idmn = (SELECT id_mtn FROM machine_tool_name WHERE machine_tool_name = @name)
                         ORDER BY warmtime";

                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", MtName);//создаём команду с параметром @name,
                                                                         //равным текущему MtName.

                        using (var reader = command.ExecuteReader())
                        {
                            var tempPoints = new ChartValues<ObservablePoint>();//Создаём две коллекции точек для графика
                            var rpmPoints = new ChartValues<ObservablePoint>();
                            var timeValues = new List<double>();//список времени 

                            while (reader.Read())
                            {
                                var time = reader.GetInt32(0); // warmtime
                                var temp = reader.GetDouble(1); // temperature
                                var rpm = reader.GetDouble(2);  // rpm

                                tempPoints.Add(new ObservablePoint(time, temp));
                                rpmPoints.Add(new ObservablePoint(time, rpm));
                                timeValues.Add(time);
                            }

                            Application.Current.Dispatcher.Invoke(() =>//чтобы обновить UI-поток
                            {
                                SeriesCollection[0].Values = tempPoints;//Обновляем данные в SeriesCollection —
                                                                        //коллекции серий графика
                                SeriesCollection[1].Values = rpmPoints;

                                // Настройка оси X
                                var axisX = new Axis//Создаём новую ось X с заголовком, метками и настройками
                                {
                                    Title = "Время (сек)",
                                    Labels = timeValues.ConvertAll(x => x.ToString()),
                                    MinValue = 0, // Минимальное значение
                                    MaxValue = timeValues.LastOrDefault(), // Максимальное значение
                                    Separator = new Separator { Step = CalculateStep(timeValues) }
                                };

                                // Получаем ссылку на chart
                                if (Application.Current.MainWindow.FindName("LiveChart") is CartesianChart chart)
                                {
                                    chart.AxisX.Clear();//Очищаем ось X и добавляем новую
                                    chart.AxisX.Add(axisX);
                                }

                                OnPropertyChanged(nameof(SeriesCollection));//Генерируем событие OnPropertyChanged для обновления UI.

                            });
                        }
                    }
                }
            }
            catch (Exception ex)// Выводим окно с сообщением об ошибке.
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        private double CalculateStep(List<double> values)
        {
            if (values.Count < 2) return 1;
            double range = values.Last() - values.First();
            return Math.Max(1, Math.Round(range / 10));
        }
        protected virtual void OnPropertyChanged(string propertyName)// Генерирует событие, которое сообщает
                                                                     // UI (View), что свойство с именем propertyName изменилось.
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));// проверка, есть ли подписчики на событие.
        }
    }


    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Database DB;
        private DataTable table;
        private MySqlDataAdapter adapter;

        class Database
        {
            MySqlConnection connection = new MySqlConnection("Server = localhost; Database = dashboard; User ID = root; Password= PLAVNIK184");
            public void openConnection()
            {
                if (connection.State == System.Data.ConnectionState.Closed) { connection.Open(); }
            }
            public void closeConnection()
            {
                if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
            }
            public MySqlConnection GetConnection()
            {
                return connection;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DB = new Database();
            table = new DataTable();
            adapter = new MySqlDataAdapter();

            var connectionString = "Server=localhost; Database=dashboard;" +
                "User ID = root; Password=PLAVNIK184";
            string n = "IMU-5XP 2518";
            DataContext = new DBDataViewModel(connectionString, "IMU-5XP 2518");
        }
        private void OnMachineNameChanged(string newName)
        {
            if (DataContext is DBDataViewModel vm)
            {
                vm.MtName = newName;
            }
        }

        public void window_load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DB.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT type FROM dashboard.machine_tool_type WHERE id_mt > 8", DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                mt_type.Items.Add((string)(row.ItemArray[0]));//заполняет комбобокс типами 
            }
            DB.closeConnection();
        }
        private void type_mtDDClosed(object sender, EventArgs e)//по типу станка - названия и заполнить след комбобокс
        {
            string type_mt = mt_type.Text;
            DataTable dt_name = new DataTable();
            DB.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT machine_tool_name FROM machine_tool_name WHERE id_mt = (SELECT id_mt FROM machine_tool_type WHERE type ='" + type_mt + "');", DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(dt_name);
            mt_name.Items.Clear();
            foreach (DataRow dr in dt_name.Rows)
            {
                mt_name.Items.Add((string)dr.ItemArray[0]);
            }
            DB.closeConnection();
        }

        private void name_mtDDClosed(object sender, EventArgs e)//заголовок имя + тип 
        {
            string name_mt = mt_name.Text;
            OnMachineNameChanged(name_mt);
            if ((mt_type != null) && (mt_name != null) && (Headerr != null))
            {


                Headerr.Content = mt_type.Text + " " + mt_name.Text;
                string imagePath = @"C:\Users\permi\source\repos\FakeAxioma3\Properties\" + name_mt + ".png";
                Nazvanie.Content = name_mt;

                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(imagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.EndInit();

                Image_machine.Source = bitmap;
            }

        }


        private void SCHPU_Click(object sender, EventArgs e)
        {
            string name_mt = mt_name.Text;
            table.Clear();
            DB.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT id, worktime, machine_tool_state.status, value, description from machine_tool_state WHERE (select id_mtn=(SELECT id_mtn FROM machine_tool_name WHERE machine_tool_name='" + name_mt + "'));", DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            ActiveM.ItemsSource = table.DefaultView;
            /* var result = command.ExecuteScalar();
             System.Windows.MessageBox.Show($"{result}");*/
            DB.closeConnection();

        }

        private void DrawGraph_click(object sender, EventArgs e)
        {
            string name_mt = mt_name.Text;
            DataTable tablePositionsData = new DataTable();
            DB.openConnection();
            MySqlCommand commandB = new MySqlCommand("select Axe, position from machine_tool_position WHERE id_mtn = (SELECT id_mtn FROM machine_tool_name WHERE machine_tool_name = '" + name_mt + "');", DB.GetConnection());
            adapter.SelectCommand = commandB;
            adapter.Fill(tablePositionsData);
            Coords.ItemsSource = tablePositionsData.DefaultView;


            DataTable tableDriveData = new DataTable();
            DB.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT id_mtn, machine_tool_load.status  FROM machine_tool_load WHERE id_mtn =(SELECT id_mtn FROM machine_tool_name WHERE machine_tool_name = '" + name_mt + "');", DB.GetConnection());
            adapter.SelectCommand = command;

            adapter.Fill(tableDriveData); //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Добавляем новый столбец для букв, если его нет
            if (!tableDriveData.Columns.Contains("driveLetter"))
            {
                tableDriveData.Columns.Add("driveLetter", typeof(string));
            }

            char[] alphabet = { 'X', 'Y', 'Z', 'A', 'B', 'C' };

            for (int i = 0; i < tableDriveData.Rows.Count; i++)
            {
                    tableDriveData.Rows[i]["driveLetter"] = alphabet[i].ToString();
                  
                
            }

            Drives.ItemsSource = tableDriveData.DefaultView;
            DB.closeConnection();
        }

        
    }
}
