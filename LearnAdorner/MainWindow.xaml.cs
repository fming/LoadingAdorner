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

namespace LearnAdorner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            this.Loaded += MainWindow_Loaded;
        }
        

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // put four boxes adorner
            AdornerLayer.GetAdornerLayer(Btn).Add(new FourBoxes(Btn));


            // put an button adorner 
            Button inAdorner = new Button()
            {
                HorizontalAlignment = HorizontalAlignment.Right,
                Content = "X",
            };

            inAdorner.Click += inAdorner_Click;
            ControlAdorner adorner = new ControlAdorner(Btn)
            {
                Child = inAdorner,
            };
            AdornerLayer.GetAdornerLayer(Btn).Add(adorner);
        }

        private SmartWindow window;

        void inAdorner_Click(object sender, RoutedEventArgs e)
        {
            window = new SmartWindow();
            window.ShowActivated = true;
            window.Show();
        }

        public string BadProperty 
        {
            get
            {
                return "Bad";
            }
            set
            {
                throw new Exception("Value must be \"Bad\"");
            }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            window.ShowCover = !window.ShowCover;
        }
    }
}
