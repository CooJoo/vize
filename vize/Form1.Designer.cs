
namespace vize
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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_saflık = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_adi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_alis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_satis = new System.Windows.Forms.TextBox();
            this.Tarih = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(50, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Altın Türü";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Saflık";
            // 
            // text_saflık
            // 
            this.text_saflık.Enabled = false;
            this.text_saflık.Location = new System.Drawing.Point(179, 118);
            this.text_saflık.Name = "text_saflık";
            this.text_saflık.Size = new System.Drawing.Size(121, 22);
            this.text_saflık.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Altının Adı";
            // 
            // text_adi
            // 
            this.text_adi.Enabled = false;
            this.text_adi.Location = new System.Drawing.Point(179, 164);
            this.text_adi.Name = "text_adi";
            this.text_adi.Size = new System.Drawing.Size(121, 22);
            this.text_adi.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alış Fiyatı";
            // 
            // text_alis
            // 
            this.text_alis.Enabled = false;
            this.text_alis.Location = new System.Drawing.Point(179, 208);
            this.text_alis.Name = "text_alis";
            this.text_alis.Size = new System.Drawing.Size(121, 22);
            this.text_alis.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Satış Fiyatı";
            // 
            // text_satis
            // 
            this.text_satis.Enabled = false;
            this.text_satis.Location = new System.Drawing.Point(179, 256);
            this.text_satis.Name = "text_satis";
            this.text_satis.Size = new System.Drawing.Size(121, 22);
            this.text_satis.TabIndex = 13;
            // 
            // Tarih
            // 
            this.Tarih.AutoSize = true;
            this.Tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tarih.Location = new System.Drawing.Point(50, 299);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(0, 25);
            this.Tarih.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tarih);
            this.Controls.Add(this.text_satis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_alis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_saflık);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Altın Piyasası";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_saflık;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_adi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_alis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_satis;
        private System.Windows.Forms.Label Tarih;
    }
}

