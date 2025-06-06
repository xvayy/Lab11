using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class EditVehicle : Form
    {
        public Vehicle EditedVehicle { get; private set; }
        public EditVehicle(Vehicle selected)
        {
            InitializeComponent();
            // Загальні поля
            textPrice.Text = selected.Price.ToString();
            textSpeed.Text = selected.Speed.ToString();
            textYear.Text = selected.Year.ToString();

            // Очистити і створити додаткові поля
            groupBox1.Controls.Clear();

            if (selected is Car car)
            {
                var lblFuel = new Label() { Text = "Fuel Type", Top = 25, Left = 10 };
                var txtFuel = new TextBox() { Name = "textFuelType", Top = 50, Left = 10, Width = 150 };
                txtFuel.Text = car.FuelType;
                groupBox1.Controls.Add(lblFuel);
                groupBox1.Controls.Add(txtFuel);
            }
            else if (selected is Plane plane)
            {
                var lblHeight = new Label() { Text = "Height", Top = 25, Left = 10 };
                var txtHeight = new TextBox() { Name = "textHeight", Top = 50, Left = 10, Width = 150 };
                txtHeight.Text = plane.Height.ToString();

                var lblPassengers = new Label() { Text = "Passengers", Top = 25, Left = 200 };
                var txtPassengers = new TextBox() { Name = "textPassengers", Top = 50, Left = 200, Width = 150 };
                txtPassengers.Text = plane.PassengerCount.ToString();

                groupBox1.Controls.Add(lblHeight);
                groupBox1.Controls.Add(txtHeight);
                groupBox1.Controls.Add(lblPassengers);
                groupBox1.Controls.Add(txtPassengers);
            }
            else if (selected is Ship ship)
            {
                var lblPort = new Label() { Text = "Port", Top = 25, Left = 10 };
                var txtPort = new TextBox() { Name = "textPort", Top = 50, Left = 10, Width = 150 };
                txtPort.Text = ship.Port;

                var lblPassengers = new Label() { Text = "Passengers", Top = 25, Left = 200 };
                var txtPassengers = new TextBox() { Name = "textPassengers", Top = 50, Left = 200, Width = 150 };
                txtPassengers.Text = ship.PassengerCount.ToString();

                groupBox1.Controls.Add(lblPort);
                groupBox1.Controls.Add(txtPort);
                groupBox1.Controls.Add(lblPassengers);
                groupBox1.Controls.Add(txtPassengers);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(textPrice.Text, out double price))
                    throw new Exception("Invalid price");
                if (!double.TryParse(textSpeed.Text, out double speed))
                    throw new Exception("Invalid speed");
                if (!int.TryParse(textYear.Text, out int year))
                    throw new Exception("Invalid year");

                // Динамічне визначення типу з наявних полів
                if (groupBox1.Controls["textFuelType"] != null)
                {
                    string fuel = groupBox1.Controls["textFuelType"].Text;
                    EditedVehicle = new Car(price, speed, year, fuel);
                }
                else if (groupBox1.Controls["textHeight"] != null)
                {
                    double height = double.Parse(groupBox1.Controls["textHeight"].Text);
                    int passengers = int.Parse(groupBox1.Controls["textPassengers"].Text);
                    EditedVehicle = new Plane(price, speed, year, height, passengers);
                }
                else if (groupBox1.Controls["textPort"] != null)
                {
                    string port = groupBox1.Controls["textPort"].Text;
                    int passengers = int.Parse(groupBox1.Controls["textPassengers"].Text);
                    EditedVehicle = new Ship(price, speed, year, passengers, port);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
