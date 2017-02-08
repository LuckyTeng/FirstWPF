using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
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

namespace DataBinding
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
            string mdbFile = Path.Combine(Environment.CurrentDirectory, "BookData.mdb");
            string connString = string.Format(
                "Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0}", mdbFile);
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM BookTable;", conn);

            var myDataSet = new DataSet();
            adapter.Fill(myDataSet, "BookTable");

            // myListBox is a ListBox control.

            // Set the DataContext of the ListBox to myDataSet

        }

        
    }
}
