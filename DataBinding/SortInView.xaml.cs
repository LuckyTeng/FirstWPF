using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// SortInView.xaml 的互動邏輯
    /// </summary>
    public partial class SortInView :Window
    {
        public SortInView()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            myListBox.Items.SortDescriptions.Add(
          new SortDescription("Content", ListSortDirection.Descending));

        }
    }
}
