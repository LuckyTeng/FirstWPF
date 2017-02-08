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

namespace BasicManipulation
{
    /// <summary>
    /// ControlTemplate.xaml 的互動邏輯
    /// </summary>
    public partial class ControlTemplate :Window
    {
        public ControlTemplate()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello world");
        }
    }
}
