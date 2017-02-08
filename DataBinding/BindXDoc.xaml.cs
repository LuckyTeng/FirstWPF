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
using System.Xml.Linq;

namespace DataBinding
{
    /// <summary>
    /// BindXDoc.xaml 的互動邏輯
    /// </summary>
    public partial class BindXDoc :Window
    {
        public BindXDoc()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            XDocument planetsDoc = XDocument.Load("../../Planets.xml");
            stacky.DataContext = planetsDoc.Element("SolarSystemPlanets").Elements();
        }
    }
}
