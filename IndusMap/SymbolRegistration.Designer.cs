namespace IndusMap
{
    partial class SymbolRegistration
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
            this.buttonAddSymbol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxsymno = new System.Windows.Forms.TextBox();
            this.pictureBoxsymimg = new System.Windows.Forms.PictureBox();
            this.buttonselectimg = new System.Windows.Forms.Button();
            this.button_addall = new System.Windows.Forms.Button();
            this.button_excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsymimg)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddSymbol
            // 
            this.buttonAddSymbol.Enabled = false;
            this.buttonAddSymbol.Location = new System.Drawing.Point(319, 419);
            this.buttonAddSymbol.Name = "buttonAddSymbol";
            this.buttonAddSymbol.Size = new System.Drawing.Size(187, 58);
            this.buttonAddSymbol.TabIndex = 0;
            this.buttonAddSymbol.Text = "Add Symbol";
            this.buttonAddSymbol.UseVisualStyleBackColor = true;
            this.buttonAddSymbol.Click += new System.EventHandler(this.buttonAddSymbol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(219, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Symbol No.";
            // 
            // textBoxsymno
            // 
            this.textBoxsymno.Enabled = false;
            this.textBoxsymno.Location = new System.Drawing.Point(326, 359);
            this.textBoxsymno.Name = "textBoxsymno";
            this.textBoxsymno.Size = new System.Drawing.Size(198, 22);
            this.textBoxsymno.TabIndex = 2;
            // 
            // pictureBoxsymimg
            // 
            this.pictureBoxsymimg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxsymimg.Enabled = false;
            this.pictureBoxsymimg.Location = new System.Drawing.Point(279, 25);
            this.pictureBoxsymimg.Name = "pictureBoxsymimg";
            this.pictureBoxsymimg.Size = new System.Drawing.Size(257, 223);
            this.pictureBoxsymimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxsymimg.TabIndex = 3;
            this.pictureBoxsymimg.TabStop = false;
            // 
            // buttonselectimg
            // 
            this.buttonselectimg.Enabled = false;
            this.buttonselectimg.Location = new System.Drawing.Point(326, 273);
            this.buttonselectimg.Name = "buttonselectimg";
            this.buttonselectimg.Size = new System.Drawing.Size(163, 49);
            this.buttonselectimg.TabIndex = 4;
            this.buttonselectimg.Text = "Open Image";
            this.buttonselectimg.UseVisualStyleBackColor = true;
            this.buttonselectimg.Click += new System.EventHandler(this.buttonselectimg_Click);
            // 
            // button_addall
            // 
            this.button_addall.Location = new System.Drawing.Point(670, 143);
            this.button_addall.Name = "button_addall";
            this.button_addall.Size = new System.Drawing.Size(132, 191);
            this.button_addall.TabIndex = 5;
            this.button_addall.Text = "Add All Symbols";
            this.button_addall.UseVisualStyleBackColor = true;
            this.button_addall.Click += new System.EventHandler(this.button_addall_Click);
            // 
            // button_excel
            // 
            this.button_excel.Location = new System.Drawing.Point(38, 143);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(119, 192);
            this.button_excel.TabIndex = 6;
            this.button_excel.Text = "Create Excel File";
            this.button_excel.UseVisualStyleBackColor = true;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // SymbolRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 489);
            this.Controls.Add(this.button_excel);
            this.Controls.Add(this.button_addall);
            this.Controls.Add(this.buttonselectimg);
            this.Controls.Add(this.pictureBoxsymimg);
            this.Controls.Add(this.textBoxsymno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddSymbol);
            this.Name = "SymbolRegistration";
            this.Text = "SymbolRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsymimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddSymbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxsymno;
        private System.Windows.Forms.PictureBox pictureBoxsymimg;
        private System.Windows.Forms.Button buttonselectimg;
        private System.Windows.Forms.Button button_addall;
        private System.Windows.Forms.Button button_excel;
    }
}