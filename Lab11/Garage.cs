using System.Windows.Forms;

namespace Lab11
{
    public partial class Garage : Form
    {
        private Vehicle[] vehicles = new Vehicle[10]; // початковий розмір
        private int vehicleCount = 0;

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

            AddVehicleToArray(new Car(12000, 200, 2017, "Petrol"));
            AddVehicleToArray(new Plane(850000, 850, 2010, 12000, 180));
            AddVehicleToArray(new Ship(400000, 70, 2005, 250, "Odesa"));
            AddVehicleToArray(new Car(2000, 180, 2009, "Diesel"));
            AddVehicleToArray(new Plane(550000, 550, 2016, 10000, 50));
            AddVehicleToArray(new Car(19000, 220, 2025, "Electricity"));


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


            for (int i = 0; i < vehicleCount; i++)
            {
                Vehicle vehicle = vehicles[i];
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

            bool hasData = vehicleCount > 0;
            btnDelete.Visible = hasData;
            btnEdit.Visible = hasData;
            btnShowInfo.Visible = hasData;
        }

        private void AddVehicleToArray(Vehicle v)
        {
            if (vehicleCount >= vehicles.Length)
            {
                Vehicle[] newArray = new Vehicle[vehicles.Length * 2];
                for (int i = 0; i < vehicles.Length; i++)
                    newArray[i] = vehicles[i];
                vehicles = newArray;
            }

            vehicles[vehicleCount++] = v;
        }

        private void DeleteVehicleAt(int index)
        {
            for (int i = index; i < vehicleCount - 1; i++)
                vehicles[i] = vehicles[i + 1];
            vehicleCount--;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddVehicle add = new AddVehicle();
            if (add.ShowDialog() == DialogResult.OK && add.NewVehicle != null)
            {
                AddVehicleToArray(add.NewVehicle);
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
                    if (index < vehicleCount)
                    {
                        DeleteVehicleAt(index);
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
