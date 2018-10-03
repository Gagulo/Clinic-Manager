using ClinicManager.Utilities;
using ClinicManager.ViewModel;
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
using System.Windows.Shapes;

namespace ClinicManager
{
    /// <summary>
    /// Interaction logic for PatientDetailView.xaml
    /// </summary>
    public partial class PatientDetailView : Window
    {

        public PatientDetailView()
        {
            InitializeComponent();
            DataContext = ViewModelLocator.PatientDetailViewModel;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AgeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
