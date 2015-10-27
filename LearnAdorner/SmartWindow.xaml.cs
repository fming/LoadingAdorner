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
using System.Windows.Shapes;

namespace LearnAdorner
{
    /// <summary>
    /// Interaction logic for SmartWindow.xaml
    /// </summary>
    public partial class SmartWindow : Window
    {
        public SmartWindow()
        {
            InitializeComponent();
            this.Loaded += SmartWindow_Loaded;
            m_adorner = new CoverAdorner(hello);

            this.MouseDoubleClick += SmartWindow_MouseDoubleClick;
        }

        void SmartWindow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //throw new NotImplementedException();

            Pen pen = new Pen();
            pen.StartLineCap = PenLineCap.Round;
        }

        void SmartWindow_Loaded(object sender, RoutedEventArgs e)
        {
           AdornerLayer.GetAdornerLayer(hello).Add(new FourBoxes(this));

            //AdornerLayer.GetAdornerLayer(hello).Add(new CoverAdorner(hello));
        }

        private bool m_show;
        private CoverAdorner m_adorner ;

        public bool ShowCover
        {
            get { 
                return m_show; 
            }
            set 
            { 
                m_show = value;
                if (value)
                {
                    AdornerLayer.GetAdornerLayer(hello).Add(m_adorner);
                }
                else
                {
                    AdornerLayer.GetAdornerLayer(hello).Remove(m_adorner);
                }

            }
        }
        
    }
}
