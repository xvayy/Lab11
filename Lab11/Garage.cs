using System.Windows.Forms;

namespace Lab11
{
    public partial class Garage : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public Garage()
        {
            InitializeComponent();
        }

        private void Garage_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            btnShowInfo.Visible = false;
            dgvVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehicles.MultiSelect = false;

            vehicles.Add(new Car(12000, 200, 2017, "Petrol"));
            vehicles.Add(new Plane(850000, 850, 2010, 12000, 180));
            vehicles.Add(new Ship(400000, 70, 2005, 250, "Odesa"));
            vehicles.Add(new Car(2000, 180, 2009, "Diesel"));
            vehicles.Add(new Plane(550000, 550, 2016, 10000, 50));
            vehicles.Add(new Car(19000, 220, 2025, "Electricity"));


            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            dgvVehicles.Columns.Clear();
            dgvVehicles.Rows.Clear();
            dgvVehicles.AutoGenerateColumns = false;

            // Створюємо 4 колонки
            dgvVehicles.Columns.Add("Type", "Type");
            dgvVehicles.Columns.Add("Price", "Price");
            dgvVehicles.Columns.Add("Speed", "Speed");
            dgvVehicles.Columns.Add("Year", "Year");
            dgvVehicles.Columns.Add("Details", "Details");
            dgvVehicles.Columns["Details"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvVehicles.Columns["Details"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvVehicles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            foreach (var vehicle in vehicles)
            {
                string type = vehicle.GetType().Name;
                string details = "";

                if (vehicle is Car car)
                    details = $"Fuel: {car.FuelType}";
                else if (vehicle is Plane plane)
                    details = $"Height: {plane.Height} m\nPassengers: {plane.PassengerCount}";
                else if (vehicle is Ship ship)
                    details = $"Port: {ship.Port}\nPassengers: {ship.PassengerCount}";

                dgvVehicles.Rows.Add(type, vehicle.Price, vehicle.Speed, vehicle.Year, details);
            }

            bool hasData = vehicles.Count > 0;
            btnDelete.Visible = hasData;
            btnEdit.Visible = hasData;
            btnShowInfo.Visible = hasData;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddVehicle add = new AddVehicle();
            if (add.ShowDialog() == DialogResult.OK && add.NewVehicle != null)
            {
                vehicles.Add(add.NewVehicle);
                UpdateDataGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var row = dgvVehicles.CurrentRow;

            int index = row.Index;
            Vehicle selected = vehicles[index];

            EditVehicle edit = new EditVehicle(selected);
            if (edit.ShowDialog() == DialogResult.OK && edit.EditedVehicle != null)
            {
                vehicles[index] = edit.EditedVehicle;
                UpdateDataGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.CurrentRow != null && dgvVehicles.CurrentRow.Index >= 0)
            {
                int index = dgvVehicles.CurrentRow.Index;

                // Підтвердження користувача
                var result = MessageBox.Show("Are you sure you want to delete this vehicle?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (index < vehicles.Count)
                    {
                        vehicles.RemoveAt(index);
                        UpdateDataGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a vehicle to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            int index = dgvVehicles.CurrentRow.Index;
            Vehicle selected = vehicles[index];
            MessageBox.Show(selected.GetInfo(), "Vehicle Information", MessageBoxButtons.OK);
        }
    }
}
