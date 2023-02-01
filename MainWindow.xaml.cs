using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace API
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }        

        private void txb_Loaded(object sender, RoutedEventArgs e)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=London&appid=1159d777a02680e5027860a016007cdf&units";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string response = reader.ReadToEnd();
            txb.Text = response;
            WeatherResponser wr = JsonConvert.DeserializeObject<WeatherResponser>(response);
            txtCity.Text = wr.Name;
            txbTemperature.Text = wr.Main.Temp.ToString();
        }
    }
}
