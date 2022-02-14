using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Ver.Models
{
    public class RectangleModel : INotifyPropertyChanged
    {
        private int width;
        private int height;
        private string? fill;
        private int? borderThickness;
        private string? borderColor;

        public int Width
        {
            get { return width; }
            set
            {
                width = value;
                OnPropertyChanged("Width");
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                height = value;
                OnPropertyChanged("Height");
            }
        }
        public string? Fill
        {
            get { return fill; }
            set
            {
                fill = value;
                OnPropertyChanged("Fill");
            }
        }
        public int? BorderThickness
        {
            get { return borderThickness; }
            set
            {
                borderThickness = value;
                OnPropertyChanged("BorderThickness");
            }
        }
        public string? BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                OnPropertyChanged("BorderColor");
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
