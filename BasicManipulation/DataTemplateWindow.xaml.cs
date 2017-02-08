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
using System.Xml;

namespace BasicManipulation
{
    /// <summary>
    /// DataTemplateWindow.xaml 的互動邏輯
    /// </summary>
    public partial class DataTemplateWindow :Window
    {
        public DataTemplateWindow()
        {
            InitializeComponent();
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;

            var item = (XmlLinkedNode)listbox1.SelectedItem;

            var sb = new StringBuilder(2048);

            foreach (XmlAttribute a in item.Attributes)
            {
                sb.Append(
                    a.Name + ":" + a.Value + "\t");
            }

            MessageBox.Show(sb.ToString());
        }
    }
}
