namespace İLAÇ_TAKİP_SİSTEMİ
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iLAÇLARBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.İLAÇLARDataSet = new İLAÇ_TAKİP_SİSTEMİ.İLAÇLARDataSet();
            this.iLAÇLARBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.İLAÇLARDataSet3 = new İLAÇ_TAKİP_SİSTEMİ.İLAÇLARDataSet3();
            this.iLAÇLARBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iLAÇLARDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.iLAÇLARDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iLAÇLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iLAÇLARDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.İLAÇLARTableAdapter2 = new İLAÇ_TAKİP_SİSTEMİ.İLAÇLARDataSet3TableAdapters.İLAÇLARTableAdapter();
            this.İLAÇLARTableAdapter = new İLAÇ_TAKİP_SİSTEMİ.İLAÇLARDataSetTableAdapters.İLAÇLARTableAdapter();
            this.İLAÇLARDataSet2 = new İLAÇ_TAKİP_SİSTEMİ.İLAÇLARDataSet2();
            this.ıLACLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iLACLARTableAdapter = new İLAÇ_TAKİP_SİSTEMİ.İLAÇLARDataSet2TableAdapters.ILACLARTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.İLAÇLARDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.İLAÇLARDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.İLAÇLARDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıLACLARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::İLAÇ_TAKİP_SİSTEMİ.Properties.Resources.arrows_turn_backward_icon_2048x1756_3of0tkp2;
            this.pictureBox1.Location = new System.Drawing.Point(169, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ıLACLARBindingSource;
            this.comboBox1.DisplayMember = "ILAC_ADI";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(341, 37);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "ILAC_ADI";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // iLAÇLARBindingSource3
            // 
            this.iLAÇLARBindingSource3.DataMember = "İLAÇLAR";
            this.iLAÇLARBindingSource3.DataSource = this.İLAÇLARDataSet;
            // 
            // İLAÇLARDataSet
            // 
            this.İLAÇLARDataSet.DataSetName = "İLAÇLARDataSet";
            this.İLAÇLARDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iLAÇLARBindingSource2
            // 
            this.iLAÇLARBindingSource2.DataMember = "İLAÇLAR";
            this.iLAÇLARBindingSource2.DataSource = this.İLAÇLARDataSet3;
            // 
            // İLAÇLARDataSet3
            // 
            this.İLAÇLARDataSet3.DataSetName = "İLAÇLARDataSet3";
            this.İLAÇLARDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iLAÇLARBindingSource1
            // 
            this.iLAÇLARBindingSource1.DataMember = "İLAÇLAR";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "İLACI ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iLAÇLARBindingSource
            // 
            this.iLAÇLARBindingSource.DataMember = "İLAÇLAR";
            // 
            // İLAÇLARTableAdapter2
            // 
            this.İLAÇLARTableAdapter2.ClearBeforeFill = true;
            // 
            // İLAÇLARTableAdapter
            // 
            this.İLAÇLARTableAdapter.ClearBeforeFill = true;
            // 
            // İLAÇLARDataSet2
            // 
            this.İLAÇLARDataSet2.DataSetName = "İLAÇLARDataSet2";
            this.İLAÇLARDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ıLACLARBindingSource
            // 
            this.ıLACLARBindingSource.DataMember = "ILACLAR";
            this.ıLACLARBindingSource.DataSource = this.İLAÇLARDataSet2;
            // 
            // iLACLARTableAdapter
            // 
            this.iLACLARTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1016, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "İLAÇ ARA";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.İLAÇLARDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.İLAÇLARDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.İLAÇLARDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıLACLARBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource iLAÇLARDataSetBindingSource;
     
        private System.Windows.Forms.BindingSource iLAÇLARDataSetBindingSource1;
       
        private System.Windows.Forms.BindingSource iLAÇLARBindingSource;

        private System.Windows.Forms.BindingSource iLAÇLARBindingSource1;
        private System.Windows.Forms.BindingSource iLAÇLARDataSet2BindingSource;
        private İLAÇLARDataSet3 İLAÇLARDataSet3;
        private System.Windows.Forms.BindingSource iLAÇLARBindingSource2;
        private İLAÇLARDataSet3TableAdapters.İLAÇLARTableAdapter İLAÇLARTableAdapter2;
        private İLAÇLARDataSet İLAÇLARDataSet;
        private System.Windows.Forms.BindingSource iLAÇLARBindingSource3;
        private İLAÇLARDataSetTableAdapters.İLAÇLARTableAdapter İLAÇLARTableAdapter;
        private İLAÇLARDataSet2 İLAÇLARDataSet2;
        private System.Windows.Forms.BindingSource ıLACLARBindingSource;
        private İLAÇLARDataSet2TableAdapters.ILACLARTableAdapter iLACLARTableAdapter;
    }
}