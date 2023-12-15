namespace TasKagitMakas
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbKagit = new System.Windows.Forms.RadioButton();
            this.rdbTas = new System.Windows.Forms.RadioButton();
            this.rdbMakas = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKullaniciPuan = new System.Windows.Forms.Label();
            this.lblPcPuan = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAŞ KAĞIT MAKAS";
            // 
            // rdbKagit
            // 
            this.rdbKagit.AutoSize = true;
            this.rdbKagit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbKagit.Location = new System.Drawing.Point(23, 87);
            this.rdbKagit.Name = "rdbKagit";
            this.rdbKagit.Size = new System.Drawing.Size(61, 20);
            this.rdbKagit.TabIndex = 1;
            this.rdbKagit.TabStop = true;
            this.rdbKagit.Text = "Kağıt";
            this.rdbKagit.UseVisualStyleBackColor = true;
            this.rdbKagit.CheckedChanged += new System.EventHandler(this.rdbKagit_CheckedChanged);
            // 
            // rdbTas
            // 
            this.rdbTas.AutoSize = true;
            this.rdbTas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbTas.Location = new System.Drawing.Point(23, 61);
            this.rdbTas.Name = "rdbTas";
            this.rdbTas.Size = new System.Drawing.Size(53, 20);
            this.rdbTas.TabIndex = 2;
            this.rdbTas.TabStop = true;
            this.rdbTas.Text = "Taş";
            this.rdbTas.UseVisualStyleBackColor = true;
            this.rdbTas.CheckedChanged += new System.EventHandler(this.rdbTas_CheckedChanged);
            // 
            // rdbMakas
            // 
            this.rdbMakas.AutoSize = true;
            this.rdbMakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbMakas.Location = new System.Drawing.Point(23, 113);
            this.rdbMakas.Name = "rdbMakas";
            this.rdbMakas.Size = new System.Drawing.Size(72, 20);
            this.rdbMakas.TabIndex = 3;
            this.rdbMakas.TabStop = true;
            this.rdbMakas.Text = "Makas";
            this.rdbMakas.UseVisualStyleBackColor = true;
            this.rdbMakas.CheckedChanged += new System.EventHandler(this.rdbMakas_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPcPuan);
            this.groupBox1.Controls.Add(this.lblKullaniciPuan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(136, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 116);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bilgisayar:";
            // 
            // lblKullaniciPuan
            // 
            this.lblKullaniciPuan.AutoSize = true;
            this.lblKullaniciPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciPuan.Location = new System.Drawing.Point(103, 30);
            this.lblKullaniciPuan.Name = "lblKullaniciPuan";
            this.lblKullaniciPuan.Size = new System.Drawing.Size(0, 18);
            this.lblKullaniciPuan.TabIndex = 6;
            // 
            // lblPcPuan
            // 
            this.lblPcPuan.AutoSize = true;
            this.lblPcPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPcPuan.Location = new System.Drawing.Point(103, 72);
            this.lblPcPuan.Name = "lblPcPuan";
            this.lblPcPuan.Size = new System.Drawing.Size(0, 18);
            this.lblPcPuan.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 214);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbMakas);
            this.Controls.Add(this.rdbTas);
            this.Controls.Add(this.rdbKagit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbKagit;
        private System.Windows.Forms.RadioButton rdbTas;
        private System.Windows.Forms.RadioButton rdbMakas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPcPuan;
        private System.Windows.Forms.Label lblKullaniciPuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

