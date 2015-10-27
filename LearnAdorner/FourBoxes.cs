using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace LearnAdorner
{
    //http://www.nbdtech.com/Blog/archive/2010/07/05/wpf-adorners-part-3-ndash-adorners-and-validation.aspx
    public class FourBoxes : Adorner
    {
        public FourBoxes(UIElement adornedElement) :
            base(adornedElement)
        {
        }

        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            drawingContext.DrawRectangle(Brushes.Red, null, new System.Windows.Rect(0, 0, 5, 5));
            drawingContext.DrawRectangle(Brushes.Red, null, new System.Windows.Rect(0, ActualHeight - 5, 5, 5));
            drawingContext.DrawRectangle(Brushes.Red, null, new System.Windows.Rect(ActualWidth - 5, 0, 5, 5));
            drawingContext.DrawRectangle(Brushes.Red, null, new System.Windows.Rect(ActualWidth - 5, ActualHeight - 5, 5, 5));
        }

    }


    public class CoverAdorner : Adorner
    {
        public CoverAdorner(UIElement adornedElement) :
            base(adornedElement)
        {
            Color color = new Color();
            color.A = 50;
            color.B = 0;
            color.R = 0;
            color.G = 0;
            brush = new SolidColorBrush(color);
            brush.Freeze();
        }


        SolidColorBrush brush; 

        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            drawingContext.DrawRectangle(brush, null, new System.Windows.Rect(-10, -10, ActualWidth + 15, ActualHeight + 15));            
        }

    }


}
