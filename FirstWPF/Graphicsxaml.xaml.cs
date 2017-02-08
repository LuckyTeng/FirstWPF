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
using System.Windows.Shapes;

namespace FirstWPF
{
    /// <summary>
    /// Graphicsxaml.xaml 的互動邏輯
    /// </summary>
    public partial class Graphicsxaml :Window
    {
        public Graphicsxaml()
        {
            InitializeComponent();
        }

        private void Path_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("you cilck me", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Path_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("you cilck me", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
