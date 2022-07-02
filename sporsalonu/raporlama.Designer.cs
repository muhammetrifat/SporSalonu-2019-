namespace sporsalonu
{
    partial class raporlama
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
            this.Button1 = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.White;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Button1.Image = global::sporsalonu.Properties.Resources.anasayfa;
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button1.Location = new System.Drawing.Point(376, 362);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 50);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "Anasayfa";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridView1.Location = new System.Drawing.Point(2, 5);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(840, 343);
            this.DataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // raporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::sporsalonu.Properties.Resources.arkaplanbuyuk_kucuk;
            this.ClientSize = new System.Drawing.Size(844, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "raporlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncel Rapor";
            this.Load += new System.EventHandler(this.raporlama_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label label1;
    }
}