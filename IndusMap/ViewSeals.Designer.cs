namespace IndusMap
{
    partial class ViewSeals
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxsymbol = new System.Windows.Forms.PictureBox();
            this.comboBoxtype = new System.Windows.Forms.ComboBox();
            this.featureDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.indusDbDataSet6 = new IndusMap.IndusDbDataSet6();
            this.buttonCrop = new System.Windows.Forms.Button();
            this.pictureBoxseal = new System.Windows.Forms.PictureBox();
            this.indusDbDataSet5 = new IndusMap.IndusDbDataSet5();
            this.symbolDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.symbolDataTableAdapter = new IndusMap.IndusDbDataSet5TableAdapters.SymbolDataTableAdapter();
            this.featureDataTableAdapter = new IndusMap.IndusDbDataSet6TableAdapters.FeatureDataTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featureDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indusDbDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxseal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indusDbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBoxsymbol);
            this.panel1.Controls.Add(this.comboBoxtype);
            this.panel1.Controls.Add(this.buttonCrop);
            this.panel1.Controls.Add(this.pictureBoxseal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 620);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxsymbol
            // 
            this.pictureBoxsymbol.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxsymbol.Enabled = false;
            this.pictureBoxsymbol.Location = new System.Drawing.Point(952, 146);
            this.pictureBoxsymbol.Name = "pictureBoxsymbol";
            this.pictureBoxsymbol.Size = new System.Drawing.Size(331, 320);
            this.pictureBoxsymbol.TabIndex = 1;
            this.pictureBoxsymbol.TabStop = false;
            this.pictureBoxsymbol.Visible = false;
            this.pictureBoxsymbol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxsymbol_MouseDown);
            // 
            // comboBoxtype
            // 
            this.comboBoxtype.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxtype.DataSource = this.featureDataBindingSource;
            this.comboBoxtype.DisplayMember = "fname";
            this.comboBoxtype.Enabled = false;
            this.comboBoxtype.FormattingEnabled = true;
            this.comboBoxtype.Location = new System.Drawing.Point(1064, 521);
            this.comboBoxtype.Name = "comboBoxtype";
            this.comboBoxtype.Size = new System.Drawing.Size(121, 24);
            this.comboBoxtype.TabIndex = 3;
            this.comboBoxtype.ValueMember = "fno";
            this.comboBoxtype.Visible = false;
            // 
            // featureDataBindingSource
            // 
            this.featureDataBindingSource.DataMember = "FeatureData";
            this.featureDataBindingSource.DataSource = this.indusDbDataSet6;
            // 
            // indusDbDataSet6
            // 
            this.indusDbDataSet6.DataSetName = "IndusDbDataSet6";
            this.indusDbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonCrop
            // 
            this.buttonCrop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCrop.Enabled = false;
            this.buttonCrop.Location = new System.Drawing.Point(1027, 551);
            this.buttonCrop.Name = "buttonCrop";
            this.buttonCrop.Size = new System.Drawing.Size(203, 33);
            this.buttonCrop.TabIndex = 2;
            this.buttonCrop.Text = "Save Image";
            this.buttonCrop.UseVisualStyleBackColor = true;
            // 
            // pictureBoxseal
            // 
            this.pictureBoxseal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxseal.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxseal.Name = "pictureBoxseal";
            this.pictureBoxseal.Size = new System.Drawing.Size(120, 92);
            this.pictureBoxseal.TabIndex = 0;
            this.pictureBoxseal.TabStop = false;
            this.pictureBoxseal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // indusDbDataSet5
            // 
            this.indusDbDataSet5.DataSetName = "IndusDbDataSet5";
            this.indusDbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // symbolDataBindingSource
            // 
            this.symbolDataBindingSource.DataMember = "SymbolData";
            this.symbolDataBindingSource.DataSource = this.indusDbDataSet5;
            // 
            // symbolDataTableAdapter
            // 
            this.symbolDataTableAdapter.ClearBeforeFill = true;
            // 
            // featureDataTableAdapter
            // 
            this.featureDataTableAdapter.ClearBeforeFill = true;
            // 
            // ViewSeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 620);
            this.Controls.Add(this.panel1);
            this.Name = "ViewSeals";
            this.Text = "ViewSeals";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewSeals_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.featureDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indusDbDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxseal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indusDbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxseal;
        private System.Windows.Forms.PictureBox pictureBoxsymbol;
        private System.Windows.Forms.Button buttonCrop;
        private System.Windows.Forms.ComboBox comboBoxtype;
        private IndusDbDataSet5 indusDbDataSet5;
        private System.Windows.Forms.BindingSource symbolDataBindingSource;
        private IndusDbDataSet5TableAdapters.SymbolDataTableAdapter symbolDataTableAdapter;
        private IndusDbDataSet6 indusDbDataSet6;
        private System.Windows.Forms.BindingSource featureDataBindingSource;
        private IndusDbDataSet6TableAdapters.FeatureDataTableAdapter featureDataTableAdapter;
    }
}