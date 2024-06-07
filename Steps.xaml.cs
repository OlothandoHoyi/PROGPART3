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

namespace Prog6221_POE
{
    /// <summary>
    /// Interaction logic for Steps.xaml
    /// </summary>
    public partial class Steps : Window
    {
        public Steps()
        {
            InitializeComponent();
        }
        private void btnAddSteps_Click(object sender, RoutedEventArgs e)
        {
            string steps, description;

            steps = txtBoxNoOfSteps.Text;
            description = txtBoxDescription.Text;

            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                // Call the AddItemToListBox method to add items to the ListBox in MainWindow
                mainWindow.AddItems("\nSteps: " + steps);
                mainWindow.AddItems("Description: " + description);
            }

            txtBoxNoOfSteps.Clear();
            txtBoxDescription.Clear();
            
        }

        private void btnMain_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
