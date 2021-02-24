using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using GalaSoft.MvvmLight;

namespace GeometryEditor.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Vertices=new ObservableCollection<VertexViewModel>()
            {
                new VertexViewModel(){Point = new Point(1.1,258.5)},
                new VertexViewModel(){Point = new Point(144.1,112.5)},
                new VertexViewModel(){Point = new Point(44.1,72.5)},
                new VertexViewModel(){Point = new Point(61.1,25.5)}
            };
            Vertices.CollectionChanged += VerticesCollectionChanged;
        }

        public ObservableCollection<VertexViewModel> Vertices { get; }
            = new ObservableCollection<VertexViewModel>();

        private void VerticesCollectionChanged(
            object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems.OfType<INotifyPropertyChanged>())
                {
                    item.PropertyChanged += VertexPropertyChanged;
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (var item in e.OldItems.OfType<INotifyPropertyChanged>())
                {
                    item.PropertyChanged -= VertexPropertyChanged;
                }
            }

            RaisePropertyChanged(nameof(Vertices));
        }

        private void VertexPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            RaisePropertyChanged(nameof(Vertices));
        }
    }
}