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
    /// CompositedButton.xaml 的互動邏輯
    /// </summary>
    public partial class CompositedButton :Window
    {
        public CompositedButton()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            meWild.LoadedBehavior = MediaState.Manual;
            meWild.Stop();
            MessageBox.Show("You stop the media.");
        }
    }
}
