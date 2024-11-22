namespace Hafta7_Form03
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.evli = new System.Windows.Forms.RadioButton();
            this.bekar = new System.Windows.Forms.RadioButton();
            this.a = new System.Windows.Forms.CheckBox();
            this.b = new System.Windows.Forms.CheckBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(103, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medeni Durum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(103, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ehliyet Sınıfı: ";
            // 
            // evli
            // 
            this.evli.AutoSize = true;
            this.evli.Location = new System.Drawing.Point(260, 54);
            this.evli.Name = "evli";
            this.evli.Size = new System.Drawing.Size(50, 20);
            this.evli.TabIndex = 2;
            this.evli.TabStop = true;
            this.evli.Text = "Evli";
            this.evli.UseVisualStyleBackColor = true;
            // 
            // bekar
            // 
            this.bekar.AutoSize = true;
            this.bekar.Location = new System.Drawing.Point(369, 53);
            this.bekar.Name = "bekar";
            this.bekar.Size = new System.Drawing.Size(64, 20);
            this.bekar.TabIndex = 2;
            this.bekar.TabStop = true;
            this.bekar.Text = "Bekar";
            this.bekar.UseVisualStyleBackColor = true;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(260, 120);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(38, 20);
            this.a.TabIndex = 3;
            this.a.Text = "A";
            this.a.UseVisualStyleBackColor = true;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(369, 118);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(38, 20);
            this.b.TabIndex = 3;
            this.b.Text = "B";
            this.b.UseVisualStyleBackColor = true;
            // 
            // kaydet
            // 
            this.kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet.Location = new System.Drawing.Point(202, 215);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(138, 48);
            this.kaydet.TabIndex = 4;
            this.kaydet.Text = "KAYDET";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(519, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 228);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.bekar);
            this.Controls.Add(this.evli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton evli;
        private System.Windows.Forms.RadioButton bekar;
        private System.Windows.Forms.CheckBox a;
        private System.Windows.Forms.CheckBox b;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.ListBox listBox1;
    }
}

