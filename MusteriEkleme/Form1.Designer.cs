
namespace MusteriEkleme
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
            this.lbxMusteriler = new System.Windows.Forms.ListBox();
            this.btnYeniMüsteriEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxMusteriler
            // 
            this.lbxMusteriler.FormattingEnabled = true;
            this.lbxMusteriler.Location = new System.Drawing.Point(39, 31);
            this.lbxMusteriler.Name = "lbxMusteriler";
            this.lbxMusteriler.Size = new System.Drawing.Size(252, 303);
            this.lbxMusteriler.TabIndex = 0;
            // 
            // btnYeniMüsteriEkle
            // 
            this.btnYeniMüsteriEkle.Location = new System.Drawing.Point(39, 356);
            this.btnYeniMüsteriEkle.Name = "btnYeniMüsteriEkle";
            this.btnYeniMüsteriEkle.Size = new System.Drawing.Size(252, 29);
            this.btnYeniMüsteriEkle.TabIndex = 1;
            this.btnYeniMüsteriEkle.Text = "Yeni Müşteri Ekle";
            this.btnYeniMüsteriEkle.UseVisualStyleBackColor = true;
            this.btnYeniMüsteriEkle.Click += new System.EventHandler(this.btnYeniMüsteriEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 429);
            this.Controls.Add(this.btnYeniMüsteriEkle);
            this.Controls.Add(this.lbxMusteriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnYeniMüsteriEkle;
        public System.Windows.Forms.ListBox lbxMusteriler;
    }
}

