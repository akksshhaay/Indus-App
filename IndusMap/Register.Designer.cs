namespace IndusMap
{
    partial class Register
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxqual = new System.Windows.Forms.TextBox();
            this.textBoxwork = new System.Windows.Forms.TextBox();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.buttonreg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qualification :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Working at :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email ID :";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(235, 30);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(250, 22);
            this.textBoxname.TabIndex = 5;
            // 
            // textBoxqual
            // 
            this.textBoxqual.Location = new System.Drawing.Point(235, 74);
            this.textBoxqual.Name = "textBoxqual";
            this.textBoxqual.Size = new System.Drawing.Size(250, 22);
            this.textBoxqual.TabIndex = 6;
            // 
            // textBoxwork
            // 
            this.textBoxwork.Location = new System.Drawing.Point(235, 119);
            this.textBoxwork.Name = "textBoxwork";
            this.textBoxwork.Size = new System.Drawing.Size(250, 22);
            this.textBoxwork.TabIndex = 7;
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(235, 161);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(250, 22);
            this.textBoxemail.TabIndex = 8;
            // 
            // textBoxpass
            // 
            this.textBoxpass.Location = new System.Drawing.Point(235, 208);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(250, 22);
            this.textBoxpass.TabIndex = 9;
            // 
            // buttonreg
            // 
            this.buttonreg.Location = new System.Drawing.Point(223, 280);
            this.buttonreg.Name = "buttonreg";
            this.buttonreg.Size = new System.Drawing.Size(156, 39);
            this.buttonreg.TabIndex = 10;
            this.buttonreg.Text = "Register";
            this.buttonreg.UseVisualStyleBackColor = true;
            this.buttonreg.Click += new System.EventHandler(this.buttonreg_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 346);
            this.Controls.Add(this.buttonreg);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.textBoxwork);
            this.Controls.Add(this.textBoxqual);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxqual;
        private System.Windows.Forms.TextBox textBoxwork;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.Button buttonreg;
    }
}