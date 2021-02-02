namespace IndusMap
{
    partial class CNNTrainingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSymReg = new System.Windows.Forms.Button();
            this.buttonSealSymbol = new System.Windows.Forms.Button();
            this.buttonmirror = new System.Windows.Forms.Button();
            this.labelsymb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxsymbol = new System.Windows.Forms.PictureBox();
            this.labelsymbol = new System.Windows.Forms.Label();
            this.labelseal = new System.Windows.Forms.Label();
            this.buttonnextseal = new System.Windows.Forms.Button();
            this.pictureBoxseal = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxseal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSymReg);
            this.panel1.Controls.Add(this.buttonSealSymbol);
            this.panel1.Controls.Add(this.buttonmirror);
            this.panel1.Controls.Add(this.labelsymb);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelsymbol);
            this.panel1.Controls.Add(this.labelseal);
            this.panel1.Controls.Add(this.buttonnextseal);
            this.panel1.Controls.Add(this.pictureBoxseal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1837, 827);
            this.panel1.TabIndex = 0;
            // 
            // buttonSymReg
            // 
            this.buttonSymReg.Location = new System.Drawing.Point(1047, 764);
            this.buttonSymReg.Name = "buttonSymReg";
            this.buttonSymReg.Size = new System.Drawing.Size(255, 41);
            this.buttonSymReg.TabIndex = 10;
            this.buttonSymReg.Text = "Insert Symbol on Seals";
            this.buttonSymReg.UseVisualStyleBackColor = true;
            this.buttonSymReg.Click += new System.EventHandler(this.buttonSymReg_Click);
            // 
            // buttonSealSymbol
            // 
            this.buttonSealSymbol.Location = new System.Drawing.Point(1328, 764);
            this.buttonSealSymbol.Name = "buttonSealSymbol";
            this.buttonSealSymbol.Size = new System.Drawing.Size(255, 41);
            this.buttonSealSymbol.TabIndex = 9;
            this.buttonSealSymbol.Text = "View Symbol on Seals";
            this.buttonSealSymbol.UseVisualStyleBackColor = true;
            this.buttonSealSymbol.Click += new System.EventHandler(this.buttonSealSymbol_Click);
            // 
            // buttonmirror
            // 
            this.buttonmirror.Location = new System.Drawing.Point(243, 655);
            this.buttonmirror.Name = "buttonmirror";
            this.buttonmirror.Size = new System.Drawing.Size(189, 42);
            this.buttonmirror.TabIndex = 8;
            this.buttonmirror.Text = "Mirror Image";
            this.buttonmirror.UseVisualStyleBackColor = true;
            this.buttonmirror.Click += new System.EventHandler(this.buttonmirror_Click);
            // 
            // labelsymb
            // 
            this.labelsymb.AutoSize = true;
            this.labelsymb.Location = new System.Drawing.Point(994, 724);
            this.labelsymb.Name = "labelsymb";
            this.labelsymb.Size = new System.Drawing.Size(46, 17);
            this.labelsymb.TabIndex = 7;
            this.labelsymb.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBoxsymbol);
            this.panel2.Location = new System.Drawing.Point(653, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 586);
            this.panel2.TabIndex = 6;
            // 
            // pictureBoxsymbol
            // 
            this.pictureBoxsymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxsymbol.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxsymbol.Name = "pictureBoxsymbol";
            this.pictureBoxsymbol.Size = new System.Drawing.Size(1145, 580);
            this.pictureBoxsymbol.TabIndex = 2;
            this.pictureBoxsymbol.TabStop = false;
            this.pictureBoxsymbol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxsymbol_MouseDown);
            // 
            // labelsymbol
            // 
            this.labelsymbol.AutoSize = true;
            this.labelsymbol.Location = new System.Drawing.Point(928, 578);
            this.labelsymbol.Name = "labelsymbol";
            this.labelsymbol.Size = new System.Drawing.Size(46, 17);
            this.labelsymbol.TabIndex = 5;
            this.labelsymbol.Text = "label2";
            // 
            // labelseal
            // 
            this.labelseal.AutoSize = true;
            this.labelseal.Location = new System.Drawing.Point(220, 724);
            this.labelseal.Name = "labelseal";
            this.labelseal.Size = new System.Drawing.Size(46, 17);
            this.labelseal.TabIndex = 4;
            this.labelseal.Text = "label1";
            // 
            // buttonnextseal
            // 
            this.buttonnextseal.Location = new System.Drawing.Point(243, 607);
            this.buttonnextseal.Name = "buttonnextseal";
            this.buttonnextseal.Size = new System.Drawing.Size(189, 42);
            this.buttonnextseal.TabIndex = 1;
            this.buttonnextseal.Text = "Next Seal";
            this.buttonnextseal.UseVisualStyleBackColor = true;
            this.buttonnextseal.Click += new System.EventHandler(this.buttonnextseal_Click);
            // 
            // pictureBoxseal
            // 
            this.pictureBoxseal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxseal.Location = new System.Drawing.Point(74, 39);
            this.pictureBoxseal.Name = "pictureBoxseal";
            this.pictureBoxseal.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxseal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxseal.TabIndex = 0;
            this.pictureBoxseal.TabStop = false;
            this.pictureBoxseal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxseal_MouseDown);
            // 
            // CNNTrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1837, 827);
            this.Controls.Add(this.panel1);
            this.Name = "CNNTrainingForm";
            this.Text = "CNNTrainingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxseal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxsymbol;
        private System.Windows.Forms.Button buttonnextseal;
        private System.Windows.Forms.PictureBox pictureBoxseal;
        private System.Windows.Forms.Label labelsymbol;
        private System.Windows.Forms.Label labelseal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelsymb;
        private System.Windows.Forms.Button buttonmirror;
        private System.Windows.Forms.Button buttonSealSymbol;
        private System.Windows.Forms.Button buttonSymReg;
    }
}