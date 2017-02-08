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
    /// CodeBinding.xaml 的互動邏輯
    /// </summary>
    public partial class CodeBinding :Window
    {
        public CodeBinding()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MyData myDataObject = new MyData(DateTime.Now);
            Binding myBinding = new Binding("MyDataProperty");
            myBinding.Source = myDataObject;
            myText.SetBinding(TextBlock.TextProperty, myBinding);

        }
    }
}
