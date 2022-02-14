using Fluent_Ver.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Ver.ViewModels
{
    public class RectangleViewModel : INotifyPropertyChanged
    {
        private RectangleModel? selectedRectangle;
        public ObservableCollection<RectangleModel> Rectangles { get; set; }
        public RectangleModel? SelectedRectangle
        {
            get { return selectedRectangle; }
            set
            {
                selectedRectangle = value;
                OnPropertyChanged("SelectedRectangle");
            }
        }
        private FlopCommand addCommand;
        public FlopCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new FlopCommand(obj =>
                    {
                        RectangleModel rectangle = new RectangleModel();
                        Rectangles.Insert(0, rectangle);
                        SelectedRectangle = rectangle;
                    }));
            }
        }
        public RectangleViewModel()
        {
            Rectangles = new ObservableCollection<RectangleModel>
            {
                new RectangleModel{ Width=200, Height=200, Fill="Blue", BorderThickness=3, BorderColor="Black"},
                new RectangleModel{ Width=20, Height=20, Fill="Red", BorderThickness=0, BorderColor=""}
            };
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
