using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LinqFormsLab {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private readonly List<Car> CarList = new List<Car>();

        private void AddToListOnClick(object sender, EventArgs e) {
            // Reset Background Color of textbox
            CarName.BackColor = Color.White;
            CarColor.BackColor = Color.White;
            Price.BackColor = Color.White;

            // Check if textbox are emty. Show error Message
            // and change background color of textbox if empty
            if (String.IsNullOrEmpty(CarName.Text) || String.IsNullOrEmpty(CarColor.Text) || String.IsNullOrEmpty(Price.Text)) {
                MessageBox.Show("Please make sure that all fields are not empty");
                if (String.IsNullOrEmpty(CarName.Text)) {
                    CarName.BackColor = Color.PaleVioletRed;
                }
                else if (String.IsNullOrEmpty(CarColor.Text)) {
                    CarColor.BackColor = Color.PaleVioletRed;
                }
                else {
                    Price.BackColor = Color.PaleVioletRed;
                }
                return;
            }

            // Check if numeric values are entered in the "Price" field
            // If not, show message and change background color of textbox
            if (!decimal.TryParse(Price.Text, out decimal parsedDecimal)) {
                MessageBox.Show(@"Please enter only numbers in the ""Price"" Field");
                Price.BackColor = Color.PaleVioletRed;
                return;
            }

            // Add information to CarList
            Car car = new Car {
                Name = CarName.Text,
                Color = CarColor.Text,
                Price = parsedDecimal
            };
            CarList.Add(car);

            // Clear textboxes and dropdown
            CarName.Clear();
            CarColor.ResetText();
            Price.Clear();

            // Add the last item (the newest item) to the ListBox
            MyCarsList.Items.Add(String.Format(" - {0}, {1}, {2}\r\n", CarList[CarList.Count - 1].Name, CarList[CarList.Count - 1].Color, CarList[CarList.Count - 1].Price));
        }

        private void GetRedOnClick(object sender, EventArgs e) {
            // Select the first Red Car of the list
            Car redCar = CarList.Where(x => x.Color.Equals("red", StringComparison.OrdinalIgnoreCase)).First();

            // Clear the Filtered ListBox and add the Red Car
            FilteredList.Items.Clear();
            FilteredList.Items.Add(String.Format(" - {0}, {1}, {2}", redCar.Name, redCar.Color, redCar.Price));
        }

        private void SortByPriceOnClick(object sender, EventArgs e) {
            // Order the list by it's price (Ascending)
            Car[] sortCar = CarList.OrderBy(x => x.Price).ToArray();
            
            // Clear the Filtered ListBox and print the ordered list
            FilteredList.Items.Clear();
            foreach (var item in sortCar) {
                FilteredList.Items.Add(String.Format(" - {0}, {1}, {2}", item.Name, item.Color, item.Price));
            }
        }

        private void AverageOnClick(object sender, EventArgs e) {
            // Compute the average of the CarList
            decimal average = CarList.Select(x => x.Price).Average();

            // Clear the Filtered ListBox and add the average
            FilteredList.Items.Clear();
            FilteredList.Items.Add("Average of the price: $" + Math.Round(average, 2)); // Round the decimal to 2 decimals
        }

        private void DistinctColorsOnClick(object sender, EventArgs e) {
            // Get the distinct car colors
            var uniqueColor = CarList.Select(x => x.Color).Distinct().ToList();

            // Clear the Filtered ListBox and add the distinct car colors
            FilteredList.Items.Clear();
            foreach (var item in uniqueColor) {
                FilteredList.Items.Add(" - " + item);
            }
        }

        private void MostExpensiveOnClick(object sender, EventArgs e) {
            // Get the most expensive car of the list
            Car expensiveCar = CarList.OrderByDescending(x => x.Price).First();

            // Clear the Filtered ListBox and add the most expensive car
            FilteredList.Items.Clear();
            FilteredList.Items.Add(String.Format(" - {0}, {1}, {2}", expensiveCar.Name, expensiveCar.Color, expensiveCar.Price));
        }

        private void TestDataOnClick(object sender, EventArgs e) {
            // Add the test data to the list
            CarList.AddRange(
                new Car[] {
                    new Car { Name = "Honda1", Color = "Red", Price = 44999.99M },
                    new Car { Name = "Honda2", Color = "Red", Price = 49999.97M },
                    new Car { Name = "Toyota1", Color = "Blue", Price = 12000.00M },
                    new Car { Name = "Toyota2", Color = "Green", Price = 60000.00M },
                    new Car { Name = "Toyota3", Color = "Red", Price = 33333.33M },
                    new Car { Name = "Honda3", Color = "red", Price = 12000.00M}
                });

            // Add the test data to ListBox
            foreach (var item in CarList) {
                MyCarsList.Items.Add(String.Format(" - {0}, {1}, {2}", item.Name, item.Color, item.Price));
            }
        }
        
        private void ExitOnClick(object sender, EventArgs e) {
            // Close the form
            Application.Exit();
        }
    }
}
