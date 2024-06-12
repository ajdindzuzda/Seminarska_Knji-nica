namespace Seminarska_knjižnica
{
    partial class Knjiga
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
            this.posodobi_gmb = new System.Windows.Forms.Button();
            this.dodaj_gmb = new System.Windows.Forms.Button();
            this.shrani_gmb = new System.Windows.Forms.Button();
            this.zanr_text = new System.Windows.Forms.TextBox();
            this.avtor_text = new System.Windows.Forms.TextBox();
            this.ime_text = new System.Windows.Forms.TextBox();
            this.id_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 99);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Knjiga";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.izbrisi_gmb);
            this.groupBox1.Controls.Add(this.prikaži_gmb);
            this.groupBox1.Controls.Add(this.posodobi_gmb);
            this.groupBox1.Controls.Add(this.dodaj_gmb);
            this.groupBox1.Controls.Add(this.shrani_gmb);
            this.groupBox1.Controls.Add(this.zanr_text);
            this.groupBox1.Controls.Add(this.avtor_text);
            this.groupBox1.Controls.Add(this.ime_text);
            this.groupBox1.Controls.Add(this.id_text);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.id_label);
            this.groupBox1.Location = new System.Drawing.Point(0, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 398);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Člani";
            // 
            // izbrisi_gmb
            // 
            this.izbrisi_gmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izbrisi_gmb.Location = new System.Drawing.Point(425, 320);
            this.izbrisi_gmb.Name = "izbrisi_gmb";
            this.izbrisi_gmb.Size = new System.Drawing.Size(99, 33);
            this.izbrisi_gmb.TabIndex = 14;
            this.izbrisi_gmb.Text = "Izbriši";
            this.izbrisi_gmb.UseVisualStyleBackColor = true;
            this.izbrisi_gmb.Click += new System.EventHandler(this.izbrisi_gmb_Click);
            // 
            // prikaži_gmb
            // 
            this.prikaži_gmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prikaži_gmb.Location = new System.Drawing.Point(321, 320);
            this.prikaži_gmb.Name = "prikaži_gmb";
            this.prikaži_gmb.Size = new System.Drawing.Size(99, 33);
            this.prikaži_gmb.TabIndex = 13;
            this.prikaži_gmb.Text = "Prikaži";
            this.prikaži_gmb.UseVisualStyleBackColor = true;
            this.prikaži_gmb.Click += new System.EventHandler(this.prikaži_gmb_Click);
            // 
            // posodobi_gmb
            // 
            this.posodobi_gmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posodobi_gmb.Location = new System.Drawing.Point(216, 320);
            this.posodobi_gmb.Name = "posodobi_gmb";
            this.posodobi_gmb.Size = new System.Drawing.Size(99, 33);
            this.posodobi_gmb.TabIndex = 12;
            this.posodobi_gmb.Text = "Posodobi";
            this.posodobi_gmb.UseVisualStyleBackColor = true;
            this.posodobi_gmb.Click += new System.EventHandler(this.posodobi_gmb_Click);
            // 
            // dodaj_gmb
            // 
            this.dodaj_gmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj_gmb.Location = new System.Drawing.Point(111, 320);
            this.dodaj_gmb.Name = "dodaj_gmb";
            this.dodaj_gmb.Size = new System.Drawing.Size(99, 33);
            this.dodaj_gmb.TabIndex = 11;
            this.dodaj_gmb.Text = "Dodaj";
            this.dodaj_gmb.UseVisualStyleBackColor = true;
            this.dodaj_gmb.Click += new System.EventHandler(this.dodaj_gmb_Click);
            // 
            // shrani_gmb
            // 
            this.shrani_gmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shrani_gmb.Location = new System.Drawing.Point(6, 320);
            this.shrani_gmb.Name = "shrani_gmb";
            this.shrani_gmb.Size = new System.Drawing.Size(99, 33);
            this.shrani_gmb.TabIndex = 10;
            this.shrani_gmb.Text = "Shrani";
            this.shrani_gmb.UseVisualStyleBackColor = true;
            this.shrani_gmb.Click += new System.EventHandler(this.shrani_gmb_Click);
            // 
            // zanr_text
            // 
            this.zanr_text.Location = new System.Drawing.Point(216, 247);
            this.zanr_text.Name = "zanr_text";
            this.zanr_text.Size = new System.Drawing.Size(174, 22);
            this.zanr_text.TabIndex = 8;
            // 
            // avtor_text
            // 
            this.avtor_text.Location = new System.Drawing.Point(216, 181);
            this.avtor_text.Name = "avtor_text";
            this.avtor_text.Size = new System.Drawing.Size(174, 22);
            this.avtor_text.TabIndex = 7;
            // 
            // ime_text
            // 
            this.ime_text.Location = new System.Drawing.Point(216, 112);
            this.ime_text.Name = "ime_text";
            this.ime_text.Size = new System.Drawing.Size(174, 22);
            this.ime_text.TabIndex = 6;
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(216, 51);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(174, 22);
            this.id_text.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Žanr";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Avtor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime knjige\r\n";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.Location = new System.Drawing.Point(32, 51);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(93, 25);
            this.id_label.TabIndex = 0;
            this.id_label.Text = "Id knjige";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 482);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1077, 236);
            this.dataGridView1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Seminarska_knjižnica.Properties.Resources.knjiga;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(530, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 392);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Knjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 717);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Knjiga";
            this.Text = "Knjiga";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button izbrisi_gmb;
        private System.Windows.Forms.Button prikaži_gmb;
        private System.Windows.Forms.Button posodobi_gmb;
        private System.Windows.Forms.Button dodaj_gmb;
        private System.Windows.Forms.Button shrani_gmb;
        private System.Windows.Forms.TextBox zanr_text;
        private System.Windows.Forms.TextBox avtor_text;
        private System.Windows.Forms.TextBox ime_text;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}