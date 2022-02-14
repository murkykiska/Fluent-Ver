using Fluent_Ver.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Color = System.Windows.Media.Color;
using Point = Fluent_Ver.Models.Point;

namespace Fluent_Ver.View
{
    public interface IGraphic
    {
        void DrawPolyline(List<Point> points, DrawParamsModel drawParams);
        void DrawPolygon(List<Point> points, DrawParamsModel drawParams);
        void DrawEllipse(List<Point> points, DrawParamsModel drawParams);
    }
    public class Graphic : IGraphic
    {
        public Canvas canvas;
        public Graphic(Canvas canvas)
        {
            this.canvas = canvas;
        }

        public void DrawPolyline(List<Point> points, DrawParamsModel drawParams)
        {
            Polyline polyline = new Polyline();

            polyline.Stroke = new SolidColorBrush(Color.FromArgb(drawParams.RGBA.A, drawParams.RGBA.R, drawParams.RGBA.G, drawParams.RGBA.B));
            polyline.StrokeThickness = drawParams.BorderThickness;

            foreach (Point point in points)
            {
                polyline.Points.Add(new System.Windows.Point(point.x, point.y));
            }

            canvas.Children.Add(polyline);
        }

        public void DrawPolygon(List<Point> points, DrawParamsModel drawParams)
        {
            throw new NotImplementedException();
        }

        public void DrawEllipse(List<Point> points, DrawParamsModel drawParams)
        {
            throw new NotImplementedException();
        }
    }
}
