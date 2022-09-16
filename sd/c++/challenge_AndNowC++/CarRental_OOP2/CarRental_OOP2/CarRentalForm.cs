using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental_OOP2
{
    public partial class CarRentalForm : Form
    {
        private bool firstLine = true;
        private RentalAdministration administration = null;

        public CarRentalForm()
        {
            InitializeComponent();
            AddTestDataToAdministration();
            UpdateDropDownList();
        }

        private void AddTestDataToAdministration()
        {
            string[] licencePlates = {"SD-001", "SD-002", "SD-003", "SD-004", "LM-001", "LM-002"};
            administration = new RentalAdministration();
            for (int i = 0; i < 4; i++)
            {
                Car sedan = new Sedan("BMW", "535d", 2012 + i, licencePlates[i], false);
                administration.Add(sedan);
            }
            for (int i = 4; i < 6; i++)
            {
                Car limousine = new Limousine("Rolls Roys", "Phantom Extended Wheelbase", 2015, licencePlates[i], true);
                administration.Add(limousine);
            }
        }

        private void UpdateDropDownList()
        {
            cbCarType.Items.Clear();
            foreach (Car car in administration.Cars)
            {
                cbCarType.Items.Add(car);
            }
            cbCarType.SelectedIndex = 0;
            UpdateSelectedCarProperties();
        }

        private void UpdateSelectedCarProperties()
        {
            Car car = administration.Cars[cbCarType.SelectedIndex];
            nudKilometers.Value = Convert.ToDecimal(car.Kilometers);
            cbNeedsCleaning.Checked = car.NeedsCleaning;
        }

        private void Log(string Line)
        {
            if (!firstLine)
            {
                txtResult.Text += System.Environment.NewLine;
            }
            txtResult.Text += Line;
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
            firstLine = false;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Car car = administration.Cars[cbCarType.SelectedIndex];
            if (administration.RentCar(car.LicencePlate))
            {
                Log("Car " + car + " rented");
            }
            else
            {
                Log("ERROR: car " + car + " is not available!");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Car car = administration.Cars[cbCarType.SelectedIndex];
            try
            {
                Decimal costs = administration.ReturnCar(car.LicencePlate, Convert.ToInt32(nudKilometers.Value));
                Log("Car " + car + " returned, price: " + costs.ToString("C"));
                UpdateSelectedCarProperties();
            }
            catch (ArgumentException exception)
            {
                Log("ERROR: car " + car + " - " + exception.Message.Split('\n')[0]);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Car car = administration.Cars[cbCarType.SelectedIndex];
            administration.CleanCar(car.LicencePlate);
            UpdateSelectedCarProperties();
        }

        private void cbCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedCarProperties();
        }
    }
}
