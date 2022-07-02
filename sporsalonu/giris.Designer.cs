namespace sporsalonu
{
    partial class giris
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
            this.components = new System.ComponentModel.Container();
            this.dataSet1 = new System.Data.DataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_giris = new System.Windows.Forms.Button();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button_giris);
            this.groupBox1.Controls.Add(this.textBox_pw);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(25, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Girişi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::sporsalonu.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(9, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(23, 29);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            // 
            // button_giris
            // 
            this.button_giris.BackColor = System.Drawing.Color.White;
            this.button_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_giris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_giris.Image = global::sporsalonu.Properties.Resources.enter;
            this.button_giris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_giris.Location = new System.Drawing.Point(124, 78);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(100, 60);
            this.button_giris.TabIndex = 3;
            this.button_giris.Text = "Giriş";
            this.button_giris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_giris.UseVisualStyleBackColor = false;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click_1);
            this.button_giris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pw_KeyPress);
            // 
            // textBox_pw
            // 
            this.textBox_pw.BackColor = System.Drawing.Color.Black;
            this.textBox_pw.ForeColor = System.Drawing.Color.White;
            this.textBox_pw.Location = new System.Drawing.Point(124, 52);
            this.textBox_pw.MaxLength = 6;
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.PasswordChar = '*';
            this.textBox_pw.Size = new System.Drawing.Size(100, 22);
            this.textBox_pw.TabIndex = 2;
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.Color.Black;
            this.textBox_id.ForeColor = System.Drawing.Color.White;
            this.textBox_id.Location = new System.Drawing.Point(124, 29);
            this.textBox_id.MaxLength = 3;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // uyeBindingSource
            // 
            this.uyeBindingSource.DataMember = "uye";
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(299, 205);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.BindingSource uyeBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

