
namespace GÖRSEL_FİNAL
{
    partial class Anasayfaa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.btnAracListele = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::GÖRSEL_FİNAL.Properties.Resources.akbuk_rent_a_car_didim;
            this.pictureBox1.Location = new System.Drawing.Point(117, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(774, 652);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Image = global::GÖRSEL_FİNAL.Properties.Resources.pngegg;
            this.btnMusteriEkle.Location = new System.Drawing.Point(12, 12);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(99, 92);
            this.btnMusteriEkle.TabIndex = 1;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.Image = global::GÖRSEL_FİNAL.Properties.Resources.pngegg__1_;
            this.btnMusteriListele.Location = new System.Drawing.Point(12, 110);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(99, 92);
            this.btnMusteriListele.TabIndex = 1;
            this.btnMusteriListele.Text = "Müşteri Listele";
            this.btnMusteriListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriListele.UseVisualStyleBackColor = true;
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Image = global::GÖRSEL_FİNAL.Properties.Resources.pngegg__2_;
            this.btnAracEkle.Location = new System.Drawing.Point(12, 208);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(99, 92);
            this.btnAracEkle.TabIndex = 1;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracEkle.UseVisualStyleBackColor = true;
            // 
            // btnAracListele
            // 
            this.btnAracListele.Image = global::GÖRSEL_FİNAL.Properties.Resources.pngegg__1_;
            this.btnAracListele.Location = new System.Drawing.Point(12, 306);
            this.btnAracListele.Name = "btnAracListele";
            this.btnAracListele.Size = new System.Drawing.Size(99, 92);
            this.btnAracListele.TabIndex = 1;
            this.btnAracListele.Text = "Araç Listele";
            this.btnAracListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracListele.UseVisualStyleBackColor = true;
            // 
            // btnSatis
            // 
            this.btnSatis.Image = global::GÖRSEL_FİNAL.Properties.Resources.pngegg__4_;
            this.btnSatis.Location = new System.Drawing.Point(12, 404);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(99, 92);
            this.btnSatis.TabIndex = 1;
            this.btnSatis.Text = "Satışlar";
            this.btnSatis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatis.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::GÖRSEL_FİNAL.Properties.Resources.pngegg__5_;
            this.btnExit.Location = new System.Drawing.Point(12, 557);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 92);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Çıkış";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Anasayfaa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(888, 661);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.btnAracListele);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.btnMusteriListele);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Anasayfaa";
            this.Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.Button btnAracListele;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnExit;
    }
}

