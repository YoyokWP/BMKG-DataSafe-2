
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(247)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(465, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD NEW STATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(247)))), ((int)(((byte)(182)))));
            this.label2.Location = new System.Drawing.Point(34, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "List of Station :";
            // 
            // labelStationName
            // 
            this.labelStationName.AutoSize = true;
            this.labelStationName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStationName.ForeColor = System.Drawing.Color.White;
            this.labelStationName.Location = new System.Drawing.Point(168, 40);
            this.labelStationName.Name = "labelStationName";
            this.labelStationName.Size = new System.Drawing.Size(106, 20);
            this.labelStationName.TabIndex = 18;
            this.labelStationName.Text = "Station Name";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxStationName);
            this.panel2.Location = new System.Drawing.Point(154, 54);
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
            this.labelWMOID.Location = new System.Drawing.Point(595, 40);
            this.labelWMOID.Name = "labelWMOID";
            this.labelWMOID.Size = new System.Drawing.Size(72, 20);
            this.labelWMOID.TabIndex = 20;
            this.labelWMOID.Text = "WMO ID";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxWMOID);
            this.panel3.Location = new System.Drawing.Point(581, 54);
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
            this.labelLatitude.Location = new System.Drawing.Point(168, 108);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(68, 20);
            this.labelLatitude.TabIndex = 22;
            this.labelLatitude.Text = "Latitude";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBoxLatitude);
            this.panel4.Location = new System.Drawing.Point(154, 122);
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
            this.labelLongitude.Location = new System.Drawing.Point(595, 108);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(82, 20);
            this.labelLongitude.TabIndex = 24;
            this.labelLongitude.Text = "Longitude";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBoxLongitude);
            this.panel5.Location = new System.Drawing.Point(581, 122);
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
            this.buttonAddStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAddStation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(247)))), ((int)(((byte)(182)))));
            this.buttonAddStation.FlatAppearance.BorderSize = 0;
            this.buttonAddStation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(247)))), ((int)(((byte)(182)))));
            this.buttonAddStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStation.Location = new System.Drawing.Point(467, 184);
            this.buttonAddStation.Name = "buttonAddStation";
            this.buttonAddStation.Size = new System.Drawing.Size(152, 32);
            this.buttonAddStation.TabIndex = 26;
            this.buttonAddStation.Text = "Add Station";
            this.buttonAddStation.UseVisualStyleBackColor = false;
            this.buttonAddStation.Click += new System.EventHandler(this.buttonAddStation_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(37, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 433);
            this.dataGridView1.TabIndex = 27;
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(247)))), ((int)(((byte)(182)))));
            this.labelJumlah.Location = new System.Drawing.Point(140, 243);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(20, 18);
            this.labelJumlah.TabIndex = 28;
            this.labelJumlah.Text = " 0";
            this.labelJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(16, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1059, 1);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // UCStationData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddStation);
            this.Controls.Add(this.labelLongitude);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.labelLatitude);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelWMOID);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelStationName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
