using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public enum VehicleType
    {
        Car,
        Plane,
        Ship
    }

    partial class AddVehicle : Form
    {
        public Vehicle NewVehicle { get; private set; }

        public AddVehicle()
        {
            InitializeComponent();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            if (comboBoxType.SelectedItem == null)
                return;
            string type = comboBoxType.SelectedItem.ToString();

            //string path = @"C:\Users\User\university\2курс\2семестр\OOP\Lab11\Lab11\bin\Debug\" + type.ToLower() + ".png";
            pictureBox1.Image = Image.FromFile(type.ToLower() + ".png");
            

            if (type == "Car")
            {
                var lblFuel = new Label() { Text = "Fuel Type", Top = 25, Left = 10 };
                var txtFuel = new TextBox() { Name = "textFuelType", Top = 50, Left = 10, Width = 150 };
                groupBox1.Controls.Add(lblFuel);
                groupBox1.Controls.Add(txtFuel);
            }
            else if (type == "Plane")
            {
                var lblHeight = new Label() { Text = "Height", Top = 25, Left = 10 };
                var txtHeight = new TextBox() { Name = "textHeight", Top = 50, Left = 10, Width = 150 };

                var lblPassengers = new Label() { Text = "Passengers", Top = 25, Left = 200 };
                var txtPassengers = new TextBox() { Name = "textPassengers", Top = 50, Left = 200, Width = 150 };

                groupBox1.Controls.Add(lblHeight);
                groupBox1.Controls.Add(txtHeight);
                groupBox1.Controls.Add(lblPassengers);
                groupBox1.Controls.Add(txtPassengers);
            }
            else if (type == "Ship")
            {
                var lblPort = new Label() { Text = "Port", Top = 25, Left = 10 };
                var txtPort = new TextBox() { Name = "textPort", Top = 50, Left = 10, Width = 150 };

                var lblPassengers = new Label() { Text = "Passengers", Top = 25, Left = 200 };
                var txtPassengers = new TextBox() { Name = "textPassengers", Top = 50, Left = 200, Width = 150 };

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
                    throw new Exception("Invalid value for Price (must be a number).");

                if (!double.TryParse(textSpeed.Text, out double speed))
                    throw new Exception("Invalid value for Speed (must be a number).");

                if (!int.TryParse(textYear.Text, out int year))
                    throw new Exception("Invalid value for Year (must be an integer).");

                string type = comboBoxType.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(type))
                    throw new Exception("Please select a vehicle type.");

                if (type == "Car")
                {
                    string fuel = groupBox1.Controls["textFuelType"].Text;
                    if (string.IsNullOrWhiteSpace(fuel))
                        throw new Exception("Fuel type cannot be empty.");

                    NewVehicle = new Car(price, speed, year, fuel);
                }
                else if (type == "Plane")
                {
                    if (!double.TryParse(groupBox1.Controls["textHeight"].Text, out double height))
                        throw new Exception("Invalid value for Height (must be a number).");

                    if (!int.TryParse(groupBox1.Controls["textPassengers"].Text, out int passengers))
                        throw new Exception("Invalid value for Passengers (must be an integer).");

                    NewVehicle = new Plane(price, speed, year, height, passengers);
                }
                else if (type == "Ship")
                {
                    string port = groupBox1.Controls["textPort"].Text;
                    if (string.IsNullOrWhiteSpace(port))
                        throw new Exception("Port cannot be empty.");

                    if (!int.TryParse(groupBox1.Controls["textPassengers"].Text, out int passengers))
                        throw new Exception("Invalid value for Passengers (must be an integer).");

                    NewVehicle = new Ship(price, speed, year, passengers, port);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void AddVehicle_Load(object sender, EventArgs e)
        {
            comboBoxType.DataSource = Enum.GetValues(typeof(VehicleType));
        }
    }
}
