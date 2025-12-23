using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collocLINQ
{
    public partial class Form1 : Form
    {
        CarFleet fleet;
        string filePath = "cars.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fleet = CarFleet.LoadFromFile(filePath);

            if (fleet == null)
            {
                fleet = new CarFleet("Городской автопарк");

                fleet.AddCar(new Car("A", 180, 120, BodyType.Sedan));
                fleet.AddCar(new Car("Toyota", 200, 150, BodyType.SUV));
            }

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridViewCars.DataSource = null;
            dataGridViewCars.DataSource = fleet.Cars;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fleet.SaveToFile(filePath);
            MessageBox.Show("Данные сохранены.");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            fleet = CarFleet.LoadFromFile(filePath);
            RefreshGrid();
            MessageBox.Show("Данные загружены.");
        }

        private void btnFilterByBrand_Click(object sender, EventArgs e)
        {
            string brand = txtBrandFilter.Text.Trim();

            var query = fleet.Cars
                .Where(c => c.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase));

            listBoxResults.Items.Clear();
            foreach (var car in query)
                listBoxResults.Items.Add($"{car.Brand} - {car.MaxSpeed} км/ч, {car.EnginePower} л.с.");
        }

        private void btnSortByPower_Click(object sender, EventArgs e)
        {
            var query = fleet.Cars.OrderBy(c => c.EnginePower);

            listBoxResults.Items.Clear();
            foreach (var car in query)
                listBoxResults.Items.Add($"{car.Brand} - {car.EnginePower} л.с.");
        }

        private void btnGroupByBodyType_Click(object sender, EventArgs e)
        {
            var query = fleet.Cars
                .GroupBy(c => c.BodyType)
                .Select(g => new { BodyType = g.Key, Count = g.Count() });

            listBoxResults.Items.Clear();
            foreach (var item in query)
                listBoxResults.Items.Add($"{item.BodyType}: {item.Count}");
        }
    }
}
//создана доп ветвь