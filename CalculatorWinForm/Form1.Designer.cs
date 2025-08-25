namespace CalculatorWinForm
{
    partial class Form1
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
            this.btnSimpan = new System.Windows.Forms.Button();
            this.inputBilKedua = new System.Windows.Forms.TextBox();
            this.inputBilPertama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelHasil = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(304, 239);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(175, 41);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputBilKedua
            // 
            this.inputBilKedua.Location = new System.Drawing.Point(277, 179);
            this.inputBilKedua.Name = "inputBilKedua";
            this.inputBilKedua.Size = new System.Drawing.Size(240, 26);
            this.inputBilKedua.TabIndex = 1;
            // 
            // inputBilPertama
            // 
            this.inputBilPertama.Location = new System.Drawing.Point(277, 105);
            this.inputBilPertama.Name = "inputBilPertama";
            this.inputBilPertama.Size = new System.Drawing.Size(240, 26);
            this.inputBilPertama.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Masukkan Bilangan Pertama :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Masukkan Bilangan Kedua :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasil";
            // 
            // panelHasil
            // 
            this.panelHasil.Location = new System.Drawing.Point(277, 330);
            this.panelHasil.Name = "panelHasil";
            this.panelHasil.Size = new System.Drawing.Size(239, 38);
            this.panelHasil.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.panelHasil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBilPertama);
            this.Controls.Add(this.inputBilKedua);
            this.Controls.Add(this.btnSimpan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox inputBilKedua;
        private System.Windows.Forms.TextBox inputBilPertama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelHasil;
    }
}

