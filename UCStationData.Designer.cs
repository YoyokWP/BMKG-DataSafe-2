
namespace BMKG_DataSafe_2
{
    partial class UCStationData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxJumlahStasiun = new System.Windows.Forms.TextBox();
            this.labelStationName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxStationName = new System.Windows.Forms.TextBox();
            this.labelWMOID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxWMOID = new System.Windows.Forms.TextBox();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.buttonAddStation = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(247)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(465, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD NEW STATION";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(37, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 431);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(247)))), ((int)(((byte)(182)))));
            this.label2.Location = new System.Drawing.Point(34, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "List of Station :";
            // 
            // textBoxJumlahStasiun
            // 
            this.textBoxJumlahStasiun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.textBoxJumlahStasiun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJumlahStasiun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(247)))), ((int)(((byte)(182)))));
            this.textBoxJumlahStasiun.Location = new System.Drawing.Point(142, 231);
            this.textBoxJumlahStasiun.Name = "textBoxJumlahStasiun";
            this.textBoxJumlahStasiun.Size = new System.Drawing.Size(41, 22);
            this.textBoxJumlahStasiun.TabIndex = 2;
            this.textBoxJumlahStasiun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelStationName
            // 
            this.labelStationName.AutoSize = true;
            this.labelStationName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStationName.ForeColor = System.Drawing.Color.White;
            this.labelStationName.Location = new System.Drawing.Point(168, 54);
            this.labelStationName.Name = "labelStationName";
            this.labelStationName.Size = new System.Drawing.Size(106, 20);
            this.labelStationName.TabIndex = 18;
            this.labelStationName.Text = "Station Name";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxStationName);
            this.panel2.Location = new System.Drawing.Point(154, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 51);
            this.panel2.TabIndex = 19;
            // 
            // textBoxStationName
            // 
            this.textBoxStationName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStationName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStationName.Location = new System.Drawing.Point(18, 13);
            this.textBoxStationName.Name = "textBoxStationName";
            this.textBoxStationName.Size = new System.Drawing.Size(314, 21);
            this.textBoxStationName.TabIndex = 0;
            this.textBoxStationName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxStationName.TextChanged += new System.EventHandler(this.textBoxStationName_TextChanged);
            // 
            // labelWMOID
            // 
            this.labelWMOID.AutoSize = true;
            this.labelWMOID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWMOID.ForeColor = System.Drawing.Color.White;
            this.labelWMOID.Location = new System.Drawing.Point(595, 54);
            this.labelWMOID.Name = "labelWMOID";
            this.labelWMOID.Size = new System.Drawing.Size(72, 20);
            this.labelWMOID.TabIndex = 20;
            this.labelWMOID.Text = "WMO ID";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxWMOID);
            this.panel3.Location = new System.Drawing.Point(581, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 51);
            this.panel3.TabIndex = 21;
            // 
            // textBoxWMOID
            // 
            this.textBoxWMOID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWMOID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWMOID.Location = new System.Drawing.Point(18, 13);
            this.textBoxWMOID.Name = "textBoxWMOID";
            this.textBoxWMOID.Size = new System.Drawing.Size(314, 21);
            this.textBoxWMOID.TabIndex = 0;
            this.textBoxWMOID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxWMOID.TextChanged += new System.EventHandler(this.textBoxWMOID_TextChanged);
            // 
            // labelLatitude
            // 
            this.labelLatitude.AutoSize = true;
            this.labelLatitude.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatitude.ForeColor = System.Drawing.Color.White;
            this.labelLatitude.Location = new System.Drawing.Point(168, 122);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(68, 20);
            this.labelLatitude.TabIndex = 22;
            this.labelLatitude.Text = "Latitude";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBoxLatitude);
            this.panel4.Location = new System.Drawing.Point(154, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(351, 51);
            this.panel4.TabIndex = 23;
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLatitude.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLatitude.Location = new System.Drawing.Point(18, 13);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(314, 21);
            this.textBoxLatitude.TabIndex = 0;
            this.textBoxLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLatitude.TextChanged += new System.EventHandler(this.textBoxLatitude_TextChanged);
            // 
            // labelLongitude
            // 
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLongitude.ForeColor = System.Drawing.Color.White;
            this.labelLongitude.Location = new System.Drawing.Point(595, 122);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(82, 20);
            this.labelLongitude.TabIndex = 24;
            this.labelLongitude.Text = "Longitude";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBoxLongitude);
            this.panel5.Location = new System.Drawing.Point(581, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(351, 51);
            this.panel5.TabIndex = 25;
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLongitude.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLongitude.Location = new System.Drawing.Point(18, 13);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(314, 21);
            this.textBoxLongitude.TabIndex = 0;
            this.textBoxLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLongitude.TextChanged += new System.EventHandler(this.textBoxLongitude_TextChanged);
            // 
            // buttonAddStation
            // 
            this.buttonAddStation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStation.Location = new System.Drawing.Point(467, 197);
            this.buttonAddStation.Name = "buttonAddStation";
            this.buttonAddStation.Size = new System.Drawing.Size(152, 28);
            this.buttonAddStation.TabIndex = 26;
            this.buttonAddStation.Text = "Add Station";
            this.buttonAddStation.UseVisualStyleBackColor = true;
            this.buttonAddStation.Click += new System.EventHandler(this.buttonAddStation_Click);
            // 
            // UCStationData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.buttonAddStation);
            this.Controls.Add(this.labelLongitude);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.labelLatitude);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelWMOID);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelStationName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxJumlahStasiun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UCStationData";
            this.Size = new System.Drawing.Size(1091, 719);
            this.Load += new System.EventHandler(this.UCStationData_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxJumlahStasiun;
        private System.Windows.Forms.Label labelStationName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxStationName;
        private System.Windows.Forms.Label labelWMOID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxWMOID;
        private System.Windows.Forms.Label labelLatitude;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxLatitude;
        private System.Windows.Forms.Label labelLongitude;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.Button buttonAddStation;
    }
}
