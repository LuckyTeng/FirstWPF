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

namespace AnimatedButton
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow :Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            button1.Style = (Style)this.Resources["MyButtonStyle"];

            ((DependencyObject) button1).CheckAccess();

      
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            // prevent bubble up
            e.Handled = true;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.DragMove();
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void button2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Image_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void CheckBox_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }
    }
}
