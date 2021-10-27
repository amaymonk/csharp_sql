
namespace sql_odev
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vericekme_listbox = new System.Windows.Forms.ListBox();
            this.vericekme_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sql_odev.Properties.Resources.user_3296__5_;
            this.pictureBox1.Location = new System.Drawing.Point(293, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // vericekme_listbox
            // 
            this.vericekme_listbox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vericekme_listbox.FormattingEnabled = true;
            this.vericekme_listbox.ItemHeight = 16;
            this.vericekme_listbox.Location = new System.Drawing.Point(125, 152);
            this.vericekme_listbox.Name = "vericekme_listbox";
            this.vericekme_listbox.Size = new System.Drawing.Size(534, 356);
            this.vericekme_listbox.TabIndex = 1;
            // 
            // vericekme_button
            // 
            this.vericekme_button.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vericekme_button.Location = new System.Drawing.Point(266, 543);
            this.vericekme_button.Name = "vericekme_button";
            this.vericekme_button.Size = new System.Drawing.Size(202, 61);
            this.vericekme_button.TabIndex = 2;
            this.vericekme_button.Text = "Veri Çekmek için tıklayınız";
            this.vericekme_button.UseVisualStyleBackColor = true;
            this.vericekme_button.Click += new System.EventHandler(this.vericekme_button_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(759, 640);
            this.Controls.Add(this.vericekme_button);
            this.Controls.Add(this.vericekme_listbox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox vericekme_listbox;
        private System.Windows.Forms.Button vericekme_button;
    }
}