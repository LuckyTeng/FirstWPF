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
    /// DataGridSql.xaml 的互動邏輯
    /// </summary>
    public partial class DataGridSql :Window
    {
        public DataGridSql()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var items = new[]
                {
                    new {Name = "Teng", Age = 18},
                    new {Name = "Hoa", Age = 22}
                };

            dataGrid1.ItemsSource = items;
        }
    }
}
