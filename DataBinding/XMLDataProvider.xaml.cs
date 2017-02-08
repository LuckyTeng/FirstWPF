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

namespace DataBinding
{
    /// <summary>
    /// XMLDataProvider.xaml 的互動邏輯
    /// </summary>
    public partial class XMLDataProvider :Window
    {
        public XMLDataProvider()
        {
            InitializeComponent();
        }

        private void lb1_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            
        }

        private void Window_Activated(object sender, EventArgs e)
        {
          
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            cc1.Content = lb1.ItemsSource;
        }

        private void Window_Initialized(object sender, EventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

    }
}
