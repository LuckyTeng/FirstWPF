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
    /// DataTemplate.xaml 的互動邏輯
    /// </summary>
    public partial class DataTemplate :Window
    {
        public DataTemplate()
        {
            InitializeComponent();  
        }

        class MyClass
        {
            public string TaskName { get; set; }
            public string Description { get; set; }
            public int Priority { get; set; }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MyClass cls1 = new MyClass();

            cls1.TaskName = "Hello";
            cls1.Description = "hello kitty";
            cls1.Priority = 1;

            List<MyClass> _clss = new List<MyClass>();
            _clss.Add(cls1);

            listBox1.ItemsSource = _clss;

            button1.DataContext = "hello world";
        }

        private void myButtonSimple1_Tap(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Description", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
