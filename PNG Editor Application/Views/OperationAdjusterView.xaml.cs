﻿using PNG_Editor_Application.ViewModels;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PNG_Editor_Application.Views
{
    /// <summary>
    /// Interaction logic for OperationAdjusterView.xaml
    /// </summary>
    public partial class OperationAdjusterView : UserControl
    {
        public OperationAdjusterView()
        {
            InitializeComponent();
            DataContext = new OperationAdjusterViewModel();
        }
    }
}
