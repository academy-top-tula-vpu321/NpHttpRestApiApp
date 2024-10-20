namespace NpHttpClientApp
{
    partial class EditForm
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
            txtTitle = new TextBox();
            lblTitle = new Label();
            txtToCity = new TextBox();
            lblToCity = new Label();
            pickerDate = new DateTimePicker();
            pickerTime = new DateTimePicker();
            lblDate = new Label();
            lblTime = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 16F);
            txtTitle.Location = new Point(38, 56);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(332, 36);
            txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(38, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(54, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            // 
            // txtToCity
            // 
            txtToCity.Font = new Font("Segoe UI", 16F);
            txtToCity.Location = new Point(442, 56);
            txtToCity.Name = "txtToCity";
            txtToCity.Size = new Size(332, 36);
            txtToCity.TabIndex = 0;
            // 
            // lblToCity
            // 
            lblToCity.AutoSize = true;
            lblToCity.Font = new Font("Segoe UI", 16F);
            lblToCity.Location = new Point(442, 23);
            lblToCity.Name = "lblToCity";
            lblToCity.Size = new Size(79, 30);
            lblToCity.TabIndex = 1;
            lblToCity.Text = "To City";
            // 
            // pickerDate
            // 
            pickerDate.CalendarFont = new Font("Segoe UI", 16F);
            pickerDate.Location = new Point(38, 148);
            pickerDate.Name = "pickerDate";
            pickerDate.Size = new Size(200, 23);
            pickerDate.TabIndex = 2;
            // 
            // pickerTime
            // 
            pickerTime.CalendarFont = new Font("Segoe UI", 16F);
            pickerTime.Format = DateTimePickerFormat.Time;
            pickerTime.Location = new Point(442, 148);
            pickerTime.Name = "pickerTime";
            pickerTime.Size = new Size(200, 23);
            pickerTime.TabIndex = 2;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 16F);
            lblDate.Location = new Point(38, 115);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(58, 30);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 16F);
            lblTime.Location = new Point(442, 115);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(61, 30);
            lblTime.TabIndex = 1;
            lblTime.Text = "Time";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 16F);
            btnSave.Location = new Point(137, 283);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(206, 76);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 16F);
            btnCancel.Location = new Point(436, 283);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(206, 76);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pickerTime);
            Controls.Add(pickerDate);
            Controls.Add(lblToCity);
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(lblTitle);
            Controls.Add(txtToCity);
            Controls.Add(txtTitle);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Label lblTitle;
        private TextBox txtToCity;
        private Label lblToCity;
        private DateTimePicker pickerDate;
        private DateTimePicker pickerTime;
        private Label lblDate;
        private Label lblTime;
        private Button btnSave;
        private Button btnCancel;
    }
}