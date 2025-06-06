namespace Lab11
{
    partial class AddVehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVehicle));
            btnCancel = new Button();
            btnSave = new Button();
            labelPrice = new Label();
            labelSpeed = new Label();
            labelYear = new Label();
            textPrice = new TextBox();
            textSpeed = new TextBox();
            textYear = new TextBox();
            labelType = new Label();
            comboBoxType = new ComboBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(258, 433);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(97, 433);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelPrice.Location = new Point(36, 105);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(44, 21);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Price";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelSpeed.Location = new Point(36, 165);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(52, 21);
            labelSpeed.TabIndex = 3;
            labelSpeed.Text = "Speed";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelYear.Location = new Point(36, 227);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(42, 21);
            labelYear.TabIndex = 4;
            labelYear.Text = "Year";
            // 
            // textPrice
            // 
            textPrice.Location = new Point(36, 129);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(100, 23);
            textPrice.TabIndex = 5;
            // 
            // textSpeed
            // 
            textSpeed.Location = new Point(36, 189);
            textSpeed.Name = "textSpeed";
            textSpeed.Size = new Size(100, 23);
            textSpeed.TabIndex = 6;
            // 
            // textYear
            // 
            textYear.Location = new Point(36, 251);
            textYear.Name = "textYear";
            textYear.Size = new Size(100, 23);
            textYear.TabIndex = 7;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelType.ForeColor = Color.FromArgb(128, 128, 255);
            labelType.Location = new Point(32, 38);
            labelType.Name = "labelType";
            labelType.Size = new Size(100, 21);
            labelType.TabIndex = 8;
            labelType.Text = "Vehicle type";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(36, 68);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(121, 23);
            comboBoxType.TabIndex = 9;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(36, 291);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 124);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Additional characteristics";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(236, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // AddVehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 483);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(comboBoxType);
            Controls.Add(labelType);
            Controls.Add(textYear);
            Controls.Add(textSpeed);
            Controls.Add(textPrice);
            Controls.Add(labelYear);
            Controls.Add(labelSpeed);
            Controls.Add(labelPrice);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "AddVehicle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddVehicle";
            Load += AddVehicle_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label labelPrice;
        private Label labelSpeed;
        private Label labelYear;
        private TextBox textPrice;
        private TextBox textSpeed;
        private TextBox textYear;
        private Label labelType;
        private ComboBox comboBoxType;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}