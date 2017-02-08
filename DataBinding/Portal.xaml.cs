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
    /// Portal.xaml 的互動邏輯
    /// </summary>
    public partial class Portal :Window
    {
        public Portal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            CompositeCollection wnd = new CompositeCollection();
            wnd.Show();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            BaseOnSelection wnd = new BaseOnSelection();
            wnd.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Convert wnd = new Convert();
            wnd.Show();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            CodeBinding wnd = new CodeBinding();
            wnd.Show();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            BindingToEnum wnd = new BindingToEnum();
            wnd.Show();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            DefaultView wnd = new DefaultView();
            wnd.Show();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            SortInView wnd = new SortInView();
            wnd.Show();
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            SortGroup wnd = new SortGroup();
            wnd.Show();
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            MasDtlHierXML wnd = new MasDtlHierXML();
            wnd.Show();
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            MasDtlHier wnd = new MasDtlHier();
            wnd.Show();
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            MultiBinding wnd = new MultiBinding();
            wnd.Show();
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            PriorityBinding wnd = new PriorityBinding();
            wnd.Show();
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            ImageProgress wnd = new ImageProgress();
            wnd.Show();
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            XMLDataProvider wnd = new XMLDataProvider();
            wnd.Show();
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            BindMethod wnd = new BindMethod();
            wnd.Show();
        }
    }
}
