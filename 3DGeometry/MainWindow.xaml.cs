using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3DGeometry
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow :Window
    {
        private Geometry3D old_3d;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var vp = sticky1.FindName("myViewport") as Viewport3D;

            var sl = vp.FindName("stickyL") as GeometryModel3D;

            if (old_3d == null)
            {
                old_3d = sl.Geometry.Clone();

                sl.Geometry = null;
            }
            else
            {
                sl.Geometry = old_3d;
                old_3d = null;
            }
        }
    }
}
