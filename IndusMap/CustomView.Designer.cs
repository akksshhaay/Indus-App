namespace IndusMap
{
    partial class CustomView
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
            this.comboboxsymbolicimage = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboboxsealtype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkboxbroken = new System.Windows.Forms.CheckBox();
            this.pictureBoxtime = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.indusDbDataSet1 = new IndusMap.IndusDbDataSet1();
            this.classTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTypeTableAdapter = new IndusMap.IndusDbDataSet1TableAdapters.ClassTypeTableAdapter();
            this.indusDbDataSet2 = new IndusMap.IndusDbDataSet2();
            this.motifMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motifMasterTableAdapter = new IndusMap.IndusDbDataSet2TableAdapters.MotifMasterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indusDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indusDbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motifMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboboxsymbolicimage
            // 
            this.comboboxsymbolicimage.DataSource = this.motifMasterBindingSource;
            this.comboboxsymbolicimage.DisplayMember = "motifName";
            this.comboboxsymbolicimage.FormattingEnabled = true;
            this.comboboxsymbolicimage.Location = new System.Drawing.Point(669, 56);
            this.comboboxsymbolicimage.Name = "comboboxsymbolicimage";
            this.comboboxsymbolicimage.Size = new System.Drawing.Size(121, 24);
            this.comboboxsymbolicimage.TabIndex = 28;
            this.comboboxsymbolicimage.ValueMember = "id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(521, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Symbolic Image Type";
            // 
            // comboboxsealtype
            // 
            this.comboboxsealtype.DataSource = this.classTypeBindingSource;
            this.comboboxsealtype.DisplayMember = "className";
            this.comboboxsealtype.FormattingEnabled = true;
            this.comboboxsealtype.Location = new System.Drawing.Point(318, 56);
            this.comboboxsealtype.Name = "comboboxsealtype";
            this.comboboxsealtype.Size = new System.Drawing.Size(121, 24);
            this.comboboxsealtype.TabIndex = 26;
            this.comboboxsealtype.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Seal Type";
            // 
            // chkboxbroken
            // 
            this.chkboxbroken.AutoSize = true;
            this.chkboxbroken.Location = new System.Drawing.Point(907, 59);
            this.chkboxbroken.Name = "chkboxbroken";
            this.chkboxbroken.Size = new System.Drawing.Size(79, 21);
            this.chkboxbroken.TabIndex = 29;
            this.chkboxbroken.Text = "Broken ";
            this.chkboxbroken.UseVisualStyleBackColor = true;
            // 
            // pictureBoxtime
            // 
            this.pictureBoxtime.Location = new System.Drawing.Point(71, 147);
            this.pictureBoxtime.Name = "pictureBoxtime";
            this.pictureBoxtime.Size = new System.Drawing.Size(764, 187);
            this.pictureBoxtime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxtime.TabIndex = 30;
            this.pictureBoxtime.TabStop = false;
            this.pictureBoxtime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxtime_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 41);
            this.button1.TabIndex = 31;
            this.button1.Text = "Show Seals";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // indusDbDataSet1
            // 
            this.indusDbDataSet1.DataSetName = "IndusDbDataSet1";
            this.indusDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classTypeBindingSource
            // 
            this.classTypeBindingSource.DataMember = "ClassType";
            this.classTypeBindingSource.DataSource = this.indusDbDataSet1;
            // 
            // classTypeTableAdapter
            // 
            this.classTypeTableAdapter.ClearBeforeFill = true;
            // 
            // indusDbDataSet2
            // 
            this.indusDbDataSet2.DataSetName = "IndusDbDataSet2";
            this.indusDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motifMasterBindingSource
            // 
            this.motifMasterBindingSource.DataMember = "MotifMaster";
            this.motifMasterBindingSource.DataSource = this.indusDbDataSet2;
            // 
            // motifMasterTableAdapter
            // 
            this.motifMasterTableAdapter.ClearBeforeFill = true;
            // 
            // CustomView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxtime);
            this.Controls.Add(this.chkboxbroken);
            this.Controls.Add(this.comboboxsymbolicimage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboboxsealtype);
            this.Controls.Add(this.label4);
            this.Name = "CustomView";
            this.Text = "CustomView";
            this.Load += new System.EventHandler(this.CustomView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indusDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indusDbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motifMasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboboxsymbolicimage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboboxsealtype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkboxbroken;
        public System.Windows.Forms.PictureBox pictureBoxtime;
        private System.Windows.Forms.Button button1;
        private IndusDbDataSet1 indusDbDataSet1;
        private System.Windows.Forms.BindingSource classTypeBindingSource;
        private IndusDbDataSet1TableAdapters.ClassTypeTableAdapter classTypeTableAdapter;
        private IndusDbDataSet2 indusDbDataSet2;
        private System.Windows.Forms.BindingSource motifMasterBindingSource;
        private IndusDbDataSet2TableAdapters.MotifMasterTableAdapter motifMasterTableAdapter;
    }
}