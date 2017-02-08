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
using System.Windows.Navigation;
using System.Windows.Shapes;
using IdentityMine.Avalon.Controls;

namespace _3DGeometry
{
    /// <summary>
    /// sticky.xaml 的互動邏輯
    /// </summary>
    public partial class sticky :UserControl
    {
        private Trackball _track;

        public sticky()
        {
            InitializeComponent();
        }

        private void myViewport_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.OriginalSource is Viewport3D)
            {
                Viewport3D v3d = (Viewport3D)e.OriginalSource;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _track = new Trackball();
            _track.Attach(this);
            _track.Slaves.Add((Viewport3D) this.FindName("myViewport"));
            _track.Enabled = true;
        }
    }
}
