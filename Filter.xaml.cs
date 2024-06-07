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
    /// Interaction logic for Filter.xaml
    /// </summary>
    public partial class Filter : Window
    {
        public string IngredientName { get; private set; }
        public string FoodGroups { get; private set; }
        public double Calories { get; private set; }

        public Filter()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow main = new MainWindow();
                main.recipes.Where(r => r.IngredientName == IngredientName);

                IngredientName = txtFilterIngredient.Text;
                //if(IngredientName == )
                FoodGroups = FoodGroup.SelectedItem?.ToString();
                Calories = string.IsNullOrEmpty(txtFilterCalories.Text) ? double.MaxValue : Convert.ToDouble(txtFilterCalories.Text);

                /*foreach (var recipe in recipes)
                {
                    Console.WriteLine(recipe.Name);
                }*/

                DialogResult = true;
            }
            catch
            {
                MessageBox.Show("Enter correct details of recipe to filter");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
