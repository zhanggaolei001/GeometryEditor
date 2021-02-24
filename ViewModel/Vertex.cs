using System.Windows;
using GalaSoft.MvvmLight;

namespace GeometryEditor.ViewModel
{
    public class VertexViewModel : ViewModelBase
    {
        private Point point;

        public Point Point
        {
            get { return point; }
            set
            {
                point = value;
                RaisePropertyChanged(nameof(Point));
                RaisePropertyChanged(nameof(X));
                RaisePropertyChanged(nameof(Y));
            }
        } 
        public double X
        {
            get => Point.X;
            set
            {
                point.X = value;
                RaisePropertyChanged(nameof(X));
                RaisePropertyChanged(nameof(Point));

            }
        }
        private double y;
        public double Y
        {
            get => Point.Y;
            set
            {
                point.Y = value;
                RaisePropertyChanged(nameof(Y));
                RaisePropertyChanged(nameof(Point));
            }
        }

    }
}