﻿using System;
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
    /// BindMethod.xaml 的互動邏輯
    /// </summary>
    public partial class BindMethod :Window
    {
        public BindMethod()
        {
            InitializeComponent();
        }

        private void OnTargetUpdated(object sender, DataTransferEventArgs e)
        {
            
        }
    }
}
