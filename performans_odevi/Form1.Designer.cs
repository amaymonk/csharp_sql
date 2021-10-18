namespace performans_odevi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vericekmebutton = new performans_odevi.Yuvarlak_button();
            this.veriaktarmabutton = new performans_odevi.Yuvarlak_button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yapmak istediğiniz işlemi seçiniz";
            // 
            // vericekmebutton
            // 
            this.vericekmebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.vericekmebutton.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vericekmebutton.Location = new System.Drawing.Point(526, 284);
            this.vericekmebutton.Name = "vericekmebutton";
            this.vericekmebutton.Size = new System.Drawing.Size(172, 157);
            this.vericekmebutton.TabIndex = 5;
            this.vericekmebutton.Text = "Veri Çekme";
            this.vericekmebutton.UseVisualStyleBackColor = false;
            this.vericekmebutton.Click += new System.EventHandler(this.vericekmebutton_Click);
            // 
            // veriaktarmabutton
            // 
            this.veriaktarmabutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.veriaktarmabutton.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veriaktarmabutton.Location = new System.Drawing.Point(245, 284);
            this.veriaktarmabutton.Name = "veriaktarmabutton";
            this.veriaktarmabutton.Size = new System.Drawing.Size(172, 157);
            this.veriaktarmabutton.TabIndex = 4;
            this.veriaktarmabutton.Text = "Veri Aktama";
            this.veriaktarmabutton.UseVisualStyleBackColor = false;
            this.veriaktarmabutton.Click += new System.EventHandler(this.veriaktarmabutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::performans_odevi.Properties.Resources.sdfdsf;
            this.ClientSize = new System.Drawing.Size(970, 575);
            this.Controls.Add(this.vericekmebutton);
            this.Controls.Add(this.veriaktarmabutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Yuvarlak_button veriaktarmabutton;
        private Yuvarlak_button vericekmebutton;
    }
}

