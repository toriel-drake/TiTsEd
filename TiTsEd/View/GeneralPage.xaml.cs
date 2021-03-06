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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TiTsEd.ViewModel;

namespace TiTsEd.View {
    /// <summary>
    /// Interaction logic for GeneralPage.xaml
    /// </summary>
    public partial class GeneralPage : UserControl {
        public GeneralPage() {
            InitializeComponent();
        }

        private void CopyToPC_Clicked(object sender, RoutedEventArgs e) {
            VM.Instance.Game.copyCharacterToPC();
            VM.Instance.Game.CharacterSelection = "PC";
        }
    }
}
