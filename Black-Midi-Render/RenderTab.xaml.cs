﻿using Microsoft.Win32;
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
using Zenith.Models;

namespace Zenith
{
    /// <summary>
    /// Interaction logic for RenderTab.xaml
    /// </summary>
    public partial class RenderTab : UserControl
    {
        public RenderTab()
        {
            InitializeComponent();
        }

        public BaseModel Data
        {
            get
            {
                var data = DataContext as BaseModel;
                if (data == null) throw new Exception("Data context must be set correctly");
                return data;
            }
        }

        private void browseOutputButton_Click(object sender, RoutedEventArgs e)
        {
            var save = new SaveFileDialog();
            save.OverwritePrompt = true;
            save.Filter = "H.264 video (*.mp4)|*.mp4|All types|*.*";
            if ((bool)save.ShowDialog())
            {
                Data.OutputOptions.OutputLocation = save.FileName;
            }
        }

        private void browseMaskButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void browseAudioButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
