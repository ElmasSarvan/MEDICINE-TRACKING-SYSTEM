namespace İLAÇ_TAKİP_SİSTEMİ
{
    partial class Form8
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
            this.iLAÇLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.İLAÇLARDataSet1 = new İLAÇ_TAKİP_SİSTEMİ.İLAÇLARDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.İLAÇLARDataSet = new İLAÇ_TAKİP_SİSTEMİ.İLAÇLARDataSet();
            this.iLAÇLARDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iLAÇLARDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.İLAÇLARTableAdapter = new İLAÇ_TAKİP_SİSTEMİ.İLAÇLARDataSet1TableAdapters.İLAÇLARTableAdapter();
            this.İLAÇLARDataSet4 = new İLAÇ_TAKİP_SİSTEMİ.İLAÇLARDataSet4();
            this.ıLACLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iLACLARTableAdapter = new İLAÇ_TAKİP_SİSTEMİ.İLAÇLARDataSet4TableAdapters.ILACLARTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.İLAÇLARDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.İLAÇLARDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.İLAÇLARDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıLACLARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::İLAÇ_TAKİP_SİSTEMİ.Properties.Resources.arrows_turn_backward_icon_2048x1756_3of0tkp2;
            this.pictureBox1.Location = new System.Drawing.Point(341, 526);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ıLACLARBindingSource;
            this.comboBox1.DisplayMember = "ILAC_ADI";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(464, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(431, 37);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ILAC_ADI";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // iLAÇLARBindingSource
            // 
            this.iLAÇLARBindingSource.DataMember = "İLAÇLAR";
            this.iLAÇLARBindingSource.DataSource = this.İLAÇLARDataSet1;
            // 
            // İLAÇLARDataSet1
            // 
            this.İLAÇLARDataSet1.DataSetName = "İLAÇLARDataSet1";
            this.İLAÇLARDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 81);
            this.button1.TabIndex = 3;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 79);
            this.button2.TabIndex = 4;
            this.button2.Text = "TEMİZLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(520, 258);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(133, 34);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(341, 260);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 29);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "SABAH";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox2.Location = new System.Drawing.Point(341, 311);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 29);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "ÖĞLE";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox3.Location = new System.Drawing.Point(341, 360);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(107, 29);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "AKŞAM";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox2.Location = new System.Drawing.Point(520, 309);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(133, 34);
            this.maskedTextBox2.TabIndex = 9;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox3.Location = new System.Drawing.Point(520, 358);
            this.maskedTextBox3.Mask = "00:00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(133, 34);
            this.maskedTextBox3.TabIndex = 10;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(538, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(357, 34);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(538, 194);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(357, 34);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(336, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Başlangıç Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(336, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bitiş Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(336, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "İlaç Adı:";
            // 
            // İLAÇLARDataSet
            // 
            this.İLAÇLARDataSet.DataSetName = "İLAÇLARDataSet";
            this.İLAÇLARDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iLAÇLARDataSetBindingSource
            // 
            this.iLAÇLARDataSetBindingSource.DataSource = this.İLAÇLARDataSet;
            this.iLAÇLARDataSetBindingSource.Position = 0;
            // 
            // iLAÇLARDataSetBindingSource1
            // 
            this.iLAÇLARDataSetBindingSource1.DataSource = this.İLAÇLARDataSet;
            this.iLAÇLARDataSetBindingSource1.Position = 0;
            // 
            // İLAÇLARTableAdapter
            // 
            this.İLAÇLARTableAdapter.ClearBeforeFill = true;
            // 
            // İLAÇLARDataSet4
            // 
            this.İLAÇLARDataSet4.DataSetName = "İLAÇLARDataSet4";
            this.İLAÇLARDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ıLACLARBindingSource
            // 
            this.ıLACLARBindingSource.DataMember = "ILACLAR";
            this.ıLACLARBindingSource.DataSource = this.İLAÇLARDataSet4;
            // 
            // iLACLARTableAdapter
            // 
            this.iLACLARTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1028, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form8";
            this.Text = "İLAÇ TAKİBİ OLUŞTUR";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.İLAÇLARDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.İLAÇLARDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLAÇLARDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.İLAÇLARDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıLACLARBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource iLAÇLARDataSetBindingSource;
        private İLAÇLARDataSet İLAÇLARDataSet;
        private System.Windows.Forms.BindingSource iLAÇLARDataSetBindingSource1;
        private İLAÇLARDataSet1 İLAÇLARDataSet1;
        private System.Windows.Forms.BindingSource iLAÇLARBindingSource;
        private İLAÇLARDataSet1TableAdapters.İLAÇLARTableAdapter İLAÇLARTableAdapter;
        private İLAÇLARDataSet4 İLAÇLARDataSet4;
        private System.Windows.Forms.BindingSource ıLACLARBindingSource;
        private İLAÇLARDataSet4TableAdapters.ILACLARTableAdapter iLACLARTableAdapter;
    }
}