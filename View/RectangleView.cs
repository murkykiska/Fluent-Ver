using Fluent_Ver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Fluent_Ver.View
{
    public class RectangleView
    {
        Canvas canvas;
        public RectangleView(Canvas canvas)
        {
            this.canvas = canvas;
        }
        public void DrawRectangle(RectangleModel r)
        {
            Rectangle rect = new Rectangle();

            rect.Width = r.Width;
            rect.Height = r.Height;
            rect.Fill = new SolidColorBrush(Color.FromRgb(100, 100, 100));

            canvas.Children.Add(rect);
        }
        
        public void DrawRectangle2(List<Point> points)
        {
            Polygon rectangle = new Polygon();
            rectangle.Fill = new SolidColorBrush(Color.FromRgb(100, 100, 100));

            int width = (int)Math.Abs(points[0].X - points[1].X);
            int height = (int)Math.Abs(points[0].Y - points[1].Y);

            rectangle.Points.Add(points[0]);
            rectangle.Points.Add(new Point(points[0].X + width, points[0].Y));
            rectangle.Points.Add(points[1]);
            rectangle.Points.Add(new Point(points[0].X, points[0].Y + height));            

            canvas.Children.Add(rectangle);
        }
    }
}
