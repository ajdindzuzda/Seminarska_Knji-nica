namespace Seminarska_knjižnica
{
    partial class Izhod
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
            this.label1 = new System.Windows.Forms.Label();
            this.ja_button = new System.Windows.Forms.Button();
            this.ne_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ali ste prepričani da želite zapustiti aplikacijo?";
            // 
            // ja_button
            // 
            this.ja_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ja_button.Location = new System.Drawing.Point(132, 160);
            this.ja_button.Name = "ja_button";
            this.ja_button.Size = new System.Drawing.Size(118, 45);
            this.ja_button.TabIndex = 1;
            this.ja_button.Text = "Ja";
            this.ja_button.UseVisualStyleBackColor = true;
            this.ja_button.Click += new System.EventHandler(this.ja_button_Click);
            // 
            // ne_button
            // 
            this.ne_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ne_button.Location = new System.Drawing.Point(337, 160);
            this.ne_button.Name = "ne_button";
            this.ne_button.Size = new System.Drawing.Size(118, 45);
            this.ne_button.TabIndex = 2;
            this.ne_button.Text = "Ne";
            this.ne_button.UseVisualStyleBackColor = true;
            this.ne_button.Click += new System.EventHandler(this.ne_button_Click);
            // 
            // Izhod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 331);
            this.Controls.Add(this.ne_button);
            this.Controls.Add(this.ja_button);
            this.Controls.Add(this.label1);
            this.Name = "Izhod";
            this.Text = "Izhod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ja_button;
        private System.Windows.Forms.Button ne_button;
    }
}