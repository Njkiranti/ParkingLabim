﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ParkingManagement.Forms
{
    /// <summary>
    /// Interaction logic for wVoucherSelect.xaml
    /// </summary>
    public partial class wVoucherSelect : Window
    {
        public wVoucherSelect()
        {
            InitializeComponent();            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    public class VoucherSelection
    {
        public int VNOFrom { get; set; }
        public int VNOTo { get; set; }
    }
}
