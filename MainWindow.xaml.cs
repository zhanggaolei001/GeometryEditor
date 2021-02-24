using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GeometryEditor.ViewModel;

namespace GeometryEditor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ThumbDragDelta(object sender, DragDeltaEventArgs e)
        {
            var vertex = (VertexViewModel)((Thumb)sender).DataContext;
            vertex.X += e.HorizontalChange;
            vertex.Y += e.VerticalChange;
            Polyline.Points = new PointCollection(((MainViewModel)this.DataContext).Vertices.Select(v => v.Point));
        }
    }
}
