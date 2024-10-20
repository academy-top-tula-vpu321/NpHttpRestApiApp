namespace NpHttpClientApp
{
    partial class FlightsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listFlights = new ListBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // listFlights
            // 
            listFlights.Font = new Font("Segoe UI", 16F);
            listFlights.FormattingEnabled = true;
            listFlights.ItemHeight = 30;
            listFlights.Location = new Point(12, 12);
            listFlights.Name = "listFlights";
            listFlights.Size = new Size(863, 244);
            listFlights.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 16F);
            btnAdd.Location = new Point(12, 284);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(220, 70);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Flight";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 16F);
            btnEdit.Location = new Point(333, 284);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(220, 70);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit Flight";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 16F);
            btnDelete.Location = new Point(654, 284);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(220, 70);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete Flight";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 398);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(listFlights);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listFlights;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}
