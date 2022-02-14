using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Ver.Models
{
    public struct RGBA
    {
        public byte R, G, B, A;
    }
    public class DrawParamsModel : INotifyPropertyChanged
    {
        private RGBA rgba;
        private RGBA borderRgba;
        private int borderThickness;
        private int zLevel;
        
        public RGBA RGBA
        {
            get { return rgba; }
            set
            {
                rgba = value;
                OnPropertyChanged("RGBA");
            }
        }
        public RGBA BorderRGBA
        {
            get { return borderRgba; }
            set
            {
                borderRgba = value;
                OnPropertyChanged("BorderRGBA");
            }
        }
        public int ZLevel
        {
            get { return zLevel; }
            set
            {
                zLevel = value;
                OnPropertyChanged("ZLevel");
            }
        }
        public int BorderThickness
        {
            get { return borderThickness; }
            set 
            { 
                borderThickness = value;
                OnPropertyChanged("BorderThickness");
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
