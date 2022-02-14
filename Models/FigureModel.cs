using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Ver.Models
{
    public struct Point
    {
        public double x;
        public double y;
    }
    public interface IFigure
    {
        public string Name { get; }
        IEnumerable<Point> Points { get; }
        DrawParamsModel DrawParams { get; }
        //public void Move(double x, double y);
        //public void Rotate(double angle);
        //public void Scale(double x, double y);
        //public bool IsSelected(double x, double y);
    }
    public class Line : IFigure, INotifyPropertyChanged
    {
        public string Name => "Line";
        private static Point x;
        private static Point y;
        private static RGBA color;
        public Point X
        {
            get { return x; }
            set
            {
                x = value;
                OnPropertyChanged("X");
            }
        }
        public Point Y
        {
            get { return y; }
            set
            {
                y = value;
                OnPropertyChanged("Y");
            }
        }
        public RGBA Color
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged("Color");
            }
        }

        public Line(Point _x, Point _y, RGBA _color)
        {
            x = _x;
            y = _y;
            color = _color;
        }

        public IEnumerable<Point> Points { get; } = new[] { x, y };
        public DrawParamsModel DrawParams { get; } = new DrawParamsModel { RGBA = color };

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
    public class FigureModel
    {
    }
}
