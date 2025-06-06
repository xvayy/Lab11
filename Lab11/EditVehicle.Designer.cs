namespace Lab11
{
    partial class EditVehicle
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
            btnCancel = new Button();
            groupBox1 = new GroupBox();
            textYear = new TextBox();
            textSpeed = new TextBox();
            textPrice = new TextBox();
            labelYear = new Label();
            labelSpeed = new Label();
            labelPrice = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(245, 294);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 124);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Additional characteristics";
            // 
            // textYear
            // 
            textYear.Location = new Point(283, 82);
            textYear.Name = "textYear";
            textYear.Size = new Size(100, 23);
            textYear.TabIndex = 18;
            // 
            // textSpeed
            // 
            textSpeed.Location = new Point(148, 82);
            textSpeed.Name = "textSpeed";
            textSpeed.Size = new Size(100, 23);
            textSpeed.TabIndex = 17;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(12, 82);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(100, 23);
            textPrice.TabIndex = 16;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelYear.Location = new Point(312, 58);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(42, 21);
            labelYear.TabIndex = 15;
            labelYear.Text = "Year";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelSpeed.Location = new Point(169, 58);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(52, 21);
            labelSpeed.TabIndex = 14;
            labelSpeed.Text = "Speed";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelPrice.Location = new Point(35, 58);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(44, 21);
            labelPrice.TabIndex = 13;
            labelPrice.Text = "Price";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(50, 294);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditVehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 344);
            Controls.Add(groupBox1);
            Controls.Add(textYear);
            Controls.Add(textSpeed);
            Controls.Add(textPrice);
            Controls.Add(labelYear);
            Controls.Add(labelSpeed);
            Controls.Add(labelPrice);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "EditVehicle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditVehicle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private GroupBox groupBox1;
        private TextBox textYear;
        private TextBox textSpeed;
        private TextBox textPrice;
        private Label labelYear;
        private Label labelSpeed;
        private Label labelPrice;
        private Button btnSave;
    }
}