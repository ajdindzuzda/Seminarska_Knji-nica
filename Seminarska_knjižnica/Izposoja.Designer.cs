namespace Seminarska_knjižnica
{
    partial class Izposoja
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.izbrisi_gmb = new System.Windows.Forms.Button();
            this.prikaži_gmb = new System.Windows.Forms.Button();
            this.dodaj_gmb = new System.Windows.Forms.Button();
            this.shrani_gmb = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerPrevzema = new System.Windows.Forms.DateTimePicker();
            this.comboBoxIdClana = new System.Windows.Forms.ComboBox();
            this.comboBoxIdKnjige = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePickerVracila = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIdIzposoje = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 90);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "IZPOSOJA";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.textBoxIdIzposoje);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePickerVracila);
            this.groupBox1.Controls.Add(this.comboBoxIdKnjige);
            this.groupBox1.Controls.Add(this.comboBoxIdClana);
            this.groupBox1.Controls.Add(this.dateTimePickerPrevzema);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.izbrisi_gmb);
            this.groupBox1.Controls.Add(this.prikaži_gmb);
            this.groupBox1.Controls.Add(this.dodaj_gmb);
            this.groupBox1.Controls.Add(this.shrani_gmb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 408);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // izbrisi_gmb
            // 
            this.izbrisi_gmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izbrisi_gmb.Location = new System.Drawing.Point(271, 320);
            this.izbrisi_gmb.Name = "izbrisi_gmb";
            this.izbrisi_gmb.Size = new System.Drawing.Size(106, 33);
            this.izbrisi_gmb.TabIndex = 14;
            this.izbrisi_gmb.Text = "Izbriši";
            this.izbrisi_gmb.UseVisualStyleBackColor = true;
            this.izbrisi_gmb.Click += new System.EventHandler(this.izbrisi_gmb_Click);
            // 
            // prikaži_gmb
            // 
            this.prikaži_gmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prikaži_gmb.Location = new System.Drawing.Point(396, 320);
            this.prikaži_gmb.Name = "prikaži_gmb";
            this.prikaži_gmb.Size = new System.Drawing.Size(115, 33);
            this.prikaži_gmb.TabIndex = 13;
            this.prikaži_gmb.Text = "Prikaži";
            this.prikaži_gmb.UseVisualStyleBackColor = true;
            this.prikaži_gmb.Click += new System.EventHandler(this.prikaži_gmb_Click);
            // 
            // dodaj_gmb
            // 
            this.dodaj_gmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj_gmb.Location = new System.Drawing.Point(140, 320);
            this.dodaj_gmb.Name = "dodaj_gmb";
            this.dodaj_gmb.Size = new System.Drawing.Size(107, 33);
            this.dodaj_gmb.TabIndex = 11;
            this.dodaj_gmb.Text = "Dodaj";
            this.dodaj_gmb.UseVisualStyleBackColor = true;
            this.dodaj_gmb.Click += new System.EventHandler(this.dodaj_gmb_Click);
            // 
            // shrani_gmb
            // 
            this.shrani_gmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shrani_gmb.Location = new System.Drawing.Point(17, 320);
            this.shrani_gmb.Name = "shrani_gmb";
            this.shrani_gmb.Size = new System.Drawing.Size(108, 33);
            this.shrani_gmb.TabIndex = 10;
            this.shrani_gmb.Text = "Shrani";
            this.shrani_gmb.UseVisualStyleBackColor = true;
            this.shrani_gmb.Click += new System.EventHandler(this.shrani_gmb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum prevzema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ime člana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime knjige";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Datum vračila";
            // 
            // dateTimePickerPrevzema
            // 
            this.dateTimePickerPrevzema.Location = new System.Drawing.Point(188, 182);
            this.dateTimePickerPrevzema.Name = "dateTimePickerPrevzema";
            this.dateTimePickerPrevzema.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerPrevzema.TabIndex = 16;
            // 
            // comboBoxIdClana
            // 
            this.comboBoxIdClana.FormattingEnabled = true;
            this.comboBoxIdClana.Location = new System.Drawing.Point(188, 125);
            this.comboBoxIdClana.Name = "comboBoxIdClana";
            this.comboBoxIdClana.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIdClana.TabIndex = 18;
            // 
            // comboBoxIdKnjige
            // 
            this.comboBoxIdKnjige.FormattingEnabled = true;
            this.comboBoxIdKnjige.Location = new System.Drawing.Point(188, 79);
            this.comboBoxIdKnjige.Name = "comboBoxIdKnjige";
            this.comboBoxIdKnjige.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIdKnjige.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 500);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1077, 216);
            this.dataGridView1.TabIndex = 4;
            // 
            // dateTimePickerVracila
            // 
            this.dateTimePickerVracila.Location = new System.Drawing.Point(188, 241);
            this.dateTimePickerVracila.Name = "dateTimePickerVracila";
            this.dateTimePickerVracila.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerVracila.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Id izposoje (izbriši)";
            // 
            // textBoxIdIzposoje
            // 
            this.textBoxIdIzposoje.Location = new System.Drawing.Point(188, 36);
            this.textBoxIdIzposoje.Name = "textBoxIdIzposoje";
            this.textBoxIdIzposoje.Size = new System.Drawing.Size(121, 22);
            this.textBoxIdIzposoje.TabIndex = 22;
            // 
            // Izposoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1077, 717);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Izposoja";
            this.Text = "Izposoja";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button izbrisi_gmb;
        private System.Windows.Forms.Button prikaži_gmb;
        private System.Windows.Forms.Button dodaj_gmb;
        private System.Windows.Forms.Button shrani_gmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxIdClana;
        private System.Windows.Forms.DateTimePicker dateTimePickerPrevzema;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxIdKnjige;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePickerVracila;
        private System.Windows.Forms.TextBox textBoxIdIzposoje;
        private System.Windows.Forms.Label label6;
    }
}