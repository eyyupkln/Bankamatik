namespace Bankamatik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtşifre = new System.Windows.Forms.TextBox();
            this.mskhesapno = new System.Windows.Forms.MaskedTextBox();
            this.btngirişyap = new System.Windows.Forms.Button();
            this.lnkkayıtol = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txtşifre
            // 
            this.txtşifre.Location = new System.Drawing.Point(212, 198);
            this.txtşifre.Name = "txtşifre";
            this.txtşifre.Size = new System.Drawing.Size(193, 34);
            this.txtşifre.TabIndex = 2;
            this.txtşifre.UseSystemPasswordChar = true;
            // 
            // mskhesapno
            // 
            this.mskhesapno.Location = new System.Drawing.Point(212, 138);
            this.mskhesapno.Mask = "000000";
            this.mskhesapno.Name = "mskhesapno";
            this.mskhesapno.Size = new System.Drawing.Size(193, 34);
            this.mskhesapno.TabIndex = 1;
            // 
            // btngirişyap
            // 
            this.btngirişyap.BackColor = System.Drawing.Color.SkyBlue;
            this.btngirişyap.Location = new System.Drawing.Point(228, 238);
            this.btngirişyap.Name = "btngirişyap";
            this.btngirişyap.Size = new System.Drawing.Size(149, 42);
            this.btngirişyap.TabIndex = 4;
            this.btngirişyap.Text = "Giriş Yap";
            this.btngirişyap.UseVisualStyleBackColor = false;
            this.btngirişyap.Click += new System.EventHandler(this.btngirişyap_Click);
            // 
            // lnkkayıtol
            // 
            this.lnkkayıtol.AutoSize = true;
            this.lnkkayıtol.BackColor = System.Drawing.Color.Transparent;
            this.lnkkayıtol.Location = new System.Drawing.Point(425, 203);
            this.lnkkayıtol.Name = "lnkkayıtol";
            this.lnkkayıtol.Size = new System.Drawing.Size(96, 29);
            this.lnkkayıtol.TabIndex = 5;
            this.lnkkayıtol.TabStop = true;
            this.lnkkayıtol.Text = "Kayıt Ol";
            this.lnkkayıtol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkkayıtol_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 430);
            this.Controls.Add(this.lnkkayıtol);
            this.Controls.Add(this.btngirişyap);
            this.Controls.Add(this.mskhesapno);
            this.Controls.Add(this.txtşifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtşifre;
        private System.Windows.Forms.MaskedTextBox mskhesapno;
        private System.Windows.Forms.Button btngirişyap;
        private System.Windows.Forms.LinkLabel lnkkayıtol;
    }
}

