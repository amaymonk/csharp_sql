
namespace sql_odev
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yuvarlak_button2 = new sql_odev.Yuvarlak_button();
            this.yuvarlak_button1 = new sql_odev.Yuvarlak_button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sql_odev.Properties.Resources.left_arrow_7344;
            this.pictureBox2.Location = new System.Drawing.Point(138, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sql_odev.Properties.Resources.right_arrow_7343;
            this.pictureBox1.Location = new System.Drawing.Point(349, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "SQL VERİ AKTARMA - ÇEKME İŞLEMİ";
            // 
            // yuvarlak_button2
            // 
            this.yuvarlak_button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yuvarlak_button2.Location = new System.Drawing.Point(351, 302);
            this.yuvarlak_button2.Name = "yuvarlak_button2";
            this.yuvarlak_button2.Size = new System.Drawing.Size(135, 119);
            this.yuvarlak_button2.TabIndex = 3;
            this.yuvarlak_button2.Text = "Veri Aktarma";
            this.yuvarlak_button2.UseVisualStyleBackColor = true;
            this.yuvarlak_button2.Click += new System.EventHandler(this.yuvarlak_button2_Click);
            // 
            // yuvarlak_button1
            // 
            this.yuvarlak_button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yuvarlak_button1.Location = new System.Drawing.Point(138, 302);
            this.yuvarlak_button1.Name = "yuvarlak_button1";
            this.yuvarlak_button1.Size = new System.Drawing.Size(135, 119);
            this.yuvarlak_button1.TabIndex = 2;
            this.yuvarlak_button1.Text = "Veri Çekme";
            this.yuvarlak_button1.UseVisualStyleBackColor = true;
            this.yuvarlak_button1.Click += new System.EventHandler(this.yuvarlak_button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(661, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yuvarlak_button2);
            this.Controls.Add(this.yuvarlak_button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Yuvarlak_button yuvarlak_button1;
        private Yuvarlak_button yuvarlak_button2;
        private System.Windows.Forms.Label label1;
    }
}

