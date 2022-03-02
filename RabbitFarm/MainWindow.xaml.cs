using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Threading;

namespace RabbitFarm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        static Farm farm = new Farm();
        public MainWindow()
        {
            
            InitializeComponent();
            Style = (Style)FindResource(typeof(Window));

            var timer = new DispatcherTimer { };
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(3.5);
            timer.Start();
            

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            farm.UpdateRabbitPopulation();

        }

        private void addRabbitButton_Click(object sender, RoutedEventArgs e)
        {
            farm.AddBunny();
        }
    }
}
