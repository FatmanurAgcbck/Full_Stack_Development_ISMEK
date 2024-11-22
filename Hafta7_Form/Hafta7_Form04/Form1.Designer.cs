namespace Hafta7_Form04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbFiltre = new System.Windows.Forms.GroupBox();
            this.txtFiltFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbLatte = new System.Windows.Forms.GroupBox();
            this.txtLatFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbTurkKah = new System.Windows.Forms.GroupBox();
            this.txtTkFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFatura = new System.Windows.Forms.ListBox();
            this.SatinAl = new System.Windows.Forms.Button();
            this.cmbKahve = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFiltre.SuspendLayout();
            this.gbLatte.SuspendLayout();
            this.gbTurkKah.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltre
            // 
            this.gbFiltre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(172)))), ((int)(((byte)(160)))));
            this.gbFiltre.Controls.Add(this.txtFiltFiyat);
            this.gbFiltre.Controls.Add(this.label4);
            this.gbFiltre.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltre.Location = new System.Drawing.Point(588, 314);
            this.gbFiltre.Name = "gbFiltre";
            this.gbFiltre.Size = new System.Drawing.Size(256, 80);
            this.gbFiltre.TabIndex = 15;
            this.gbFiltre.TabStop = false;
            this.gbFiltre.Text = "Filtre";
            this.gbFiltre.Visible = false;
            // 
            // txtFiltFiyat
            // 
            this.txtFiltFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiltFiyat.Location = new System.Drawing.Point(79, 33);
            this.txtFiltFiyat.Name = "txtFiltFiyat";
            this.txtFiltFiyat.ReadOnly = true;
            this.txtFiltFiyat.Size = new System.Drawing.Size(160, 27);
            this.txtFiltFiyat.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fiyat: ";
            // 
            // gbLatte
            // 
            this.gbLatte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(172)))), ((int)(((byte)(160)))));
            this.gbLatte.Controls.Add(this.txtLatFiyat);
            this.gbLatte.Controls.Add(this.label3);
            this.gbLatte.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLatte.Location = new System.Drawing.Point(305, 314);
            this.gbLatte.Name = "gbLatte";
            this.gbLatte.Size = new System.Drawing.Size(256, 80);
            this.gbLatte.TabIndex = 14;
            this.gbLatte.TabStop = false;
            this.gbLatte.Text = "Latte";
            this.gbLatte.Visible = false;
            // 
            // txtLatFiyat
            // 
            this.txtLatFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLatFiyat.Location = new System.Drawing.Point(79, 33);
            this.txtLatFiyat.Name = "txtLatFiyat";
            this.txtLatFiyat.ReadOnly = true;
            this.txtLatFiyat.Size = new System.Drawing.Size(160, 27);
            this.txtLatFiyat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fiyat: ";
            // 
            // gbTurkKah
            // 
            this.gbTurkKah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(172)))), ((int)(((byte)(160)))));
            this.gbTurkKah.Controls.Add(this.txtTkFiyat);
            this.gbTurkKah.Controls.Add(this.label2);
            this.gbTurkKah.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTurkKah.Location = new System.Drawing.Point(22, 314);
            this.gbTurkKah.Name = "gbTurkKah";
            this.gbTurkKah.Size = new System.Drawing.Size(256, 80);
            this.gbTurkKah.TabIndex = 13;
            this.gbTurkKah.TabStop = false;
            this.gbTurkKah.Text = "Türk Kahvesi";
            this.gbTurkKah.Visible = false;
            // 
            // txtTkFiyat
            // 
            this.txtTkFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTkFiyat.Location = new System.Drawing.Point(79, 33);
            this.txtTkFiyat.Name = "txtTkFiyat";
            this.txtTkFiyat.ReadOnly = true;
            this.txtTkFiyat.Size = new System.Drawing.Size(160, 27);
            this.txtTkFiyat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat: ";
            // 
            // lbFatura
            // 
            this.lbFatura.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbFatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFatura.FormattingEnabled = true;
            this.lbFatura.ItemHeight = 16;
            this.lbFatura.Location = new System.Drawing.Point(529, 35);
            this.lbFatura.Name = "lbFatura";
            this.lbFatura.Size = new System.Drawing.Size(212, 240);
            this.lbFatura.TabIndex = 12;
            this.lbFatura.Visible = false;
            // 
            // SatinAl
            // 
            this.SatinAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(111)))), ((int)(((byte)(101)))));
            this.SatinAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SatinAl.ForeColor = System.Drawing.SystemColors.Control;
            this.SatinAl.Location = new System.Drawing.Point(335, 470);
            this.SatinAl.Name = "SatinAl";
            this.SatinAl.Size = new System.Drawing.Size(182, 80);
            this.SatinAl.TabIndex = 11;
            this.SatinAl.Text = "Satın Al";
            this.SatinAl.UseVisualStyleBackColor = false;
            this.SatinAl.Visible = false;
            this.SatinAl.Click += new System.EventHandler(this.SatinAl_Click);
            // 
            // cmbKahve
            // 
            this.cmbKahve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKahve.FormattingEnabled = true;
            this.cmbKahve.Items.AddRange(new object[] {
            "Filtre",
            "Latte",
            "Türk Kahvesi"});
            this.cmbKahve.Location = new System.Drawing.Point(213, 93);
            this.cmbKahve.Name = "cmbKahve";
            this.cmbKahve.Size = new System.Drawing.Size(160, 28);
            this.cmbKahve.TabIndex = 10;
            this.cmbKahve.SelectedIndexChanged += new System.EventHandler(this.cmbKahve_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(96, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kahveler: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(140)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(880, 580);
            this.Controls.Add(this.gbFiltre);
            this.Controls.Add(this.gbLatte);
            this.Controls.Add(this.gbTurkKah);
            this.Controls.Add(this.lbFatura);
            this.Controls.Add(this.SatinAl);
            this.Controls.Add(this.cmbKahve);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kahveci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFiltre.ResumeLayout(false);
            this.gbFiltre.PerformLayout();
            this.gbLatte.ResumeLayout(false);
            this.gbLatte.PerformLayout();
            this.gbTurkKah.ResumeLayout(false);
            this.gbTurkKah.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltre;
        private System.Windows.Forms.TextBox txtFiltFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbLatte;
        private System.Windows.Forms.TextBox txtLatFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbTurkKah;
        private System.Windows.Forms.TextBox txtTkFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbFatura;
        private System.Windows.Forms.Button SatinAl;
        private System.Windows.Forms.ComboBox cmbKahve;
        private System.Windows.Forms.Label label1;
    }
}

