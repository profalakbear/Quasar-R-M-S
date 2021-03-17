namespace Quasar1._0._1.BusinessLogicLayer
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ust_qida = new Quasar1._0._1.ust_qida();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masa1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quasarDataSet3 = new Quasar1._0._1.quasarDataSet3();
            this.masa1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quasarDataSet2 = new Quasar1._0._1.quasarDataSet2();
            this.quasarDataSet1 = new Quasar1._0._1.quasarDataSet1();
            this.masa1DataSet = new Quasar1._0._1.masa1DataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.qida_elave_etTableAdapter = new Quasar1._0._1.ust_qidaTableAdapters.qida_elave_etTableAdapter();
            this.masa1TableAdapter1 = new Quasar1._0._1.quasarDataSet1TableAdapters.masa1TableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.masa1TableAdapter = new Quasar1._0._1.quasarDataSet2TableAdapters.masa1TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.masa1TableAdapter2 = new Quasar1._0._1.quasarDataSet3TableAdapters.masa1TableAdapter();
            this.quasarDataSet31 = new Quasar1._0._1.quasarDataSet3();
            this.masa1TableAdapter3 = new Quasar1._0._1.quasarDataSet1TableAdapters.masa1TableAdapter();
            this.midDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qidaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qidaadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qiymetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ust_qida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quasarDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quasarDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quasarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quasarDataSet31)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(361, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ust_qida
            // 
            this.ust_qida.DataSetName = "ust_qida";
            this.ust_qida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "elave et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "masani bagla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.midDataGridViewTextBoxColumn,
            this.qidaidDataGridViewTextBoxColumn,
            this.qidaadiDataGridViewTextBoxColumn,
            this.qiymetDataGridViewTextBoxColumn,
            this.tarixDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.masa1BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(361, 249);
            this.dataGridView1.TabIndex = 7;
            // 
            // masa1BindingSource1
            // 
            this.masa1BindingSource1.DataMember = "masa1";
            this.masa1BindingSource1.DataSource = this.quasarDataSet3;
            // 
            // quasarDataSet3
            // 
            this.quasarDataSet3.DataSetName = "quasarDataSet3";
            this.quasarDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masa1BindingSource
            // 
            this.masa1BindingSource.DataMember = "masa1";
            this.masa1BindingSource.DataSource = this.quasarDataSet2;
            // 
            // quasarDataSet2
            // 
            this.quasarDataSet2.DataSetName = "quasarDataSet2";
            this.quasarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quasarDataSet1
            // 
            this.quasarDataSet1.DataSetName = "quasarDataSet1";
            this.quasarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masa1DataSet
            // 
            this.masa1DataSet.DataSetName = "masa1DataSet";
            this.masa1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(401, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // qida_elave_etTableAdapter
            // 
            this.qida_elave_etTableAdapter.ClearBeforeFill = true;
            // 
            // masa1TableAdapter1
            // 
            this.masa1TableAdapter1.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(401, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 41);
            this.button5.TabIndex = 9;
            this.button5.Text = "minimize";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // masa1TableAdapter
            // 
            this.masa1TableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // masa1TableAdapter2
            // 
            this.masa1TableAdapter2.ClearBeforeFill = true;
            // 
            // quasarDataSet31
            // 
            this.quasarDataSet31.DataSetName = "quasarDataSet3";
            this.quasarDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masa1TableAdapter3
            // 
            this.masa1TableAdapter3.ClearBeforeFill = true;
            // 
            // midDataGridViewTextBoxColumn
            // 
            this.midDataGridViewTextBoxColumn.DataPropertyName = "m_id";
            this.midDataGridViewTextBoxColumn.HeaderText = "m_id";
            this.midDataGridViewTextBoxColumn.Name = "midDataGridViewTextBoxColumn";
            this.midDataGridViewTextBoxColumn.ReadOnly = true;
            this.midDataGridViewTextBoxColumn.Width = 30;
            // 
            // qidaidDataGridViewTextBoxColumn
            // 
            this.qidaidDataGridViewTextBoxColumn.DataPropertyName = "qida_id";
            this.qidaidDataGridViewTextBoxColumn.HeaderText = "qida_id";
            this.qidaidDataGridViewTextBoxColumn.Name = "qidaidDataGridViewTextBoxColumn";
            this.qidaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.qidaidDataGridViewTextBoxColumn.Width = 30;
            // 
            // qidaadiDataGridViewTextBoxColumn
            // 
            this.qidaadiDataGridViewTextBoxColumn.DataPropertyName = "qida_adi";
            this.qidaadiDataGridViewTextBoxColumn.HeaderText = "qida_adi";
            this.qidaadiDataGridViewTextBoxColumn.Name = "qidaadiDataGridViewTextBoxColumn";
            this.qidaadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.qidaadiDataGridViewTextBoxColumn.Width = 120;
            // 
            // qiymetDataGridViewTextBoxColumn
            // 
            this.qiymetDataGridViewTextBoxColumn.DataPropertyName = "qiymet";
            this.qiymetDataGridViewTextBoxColumn.HeaderText = "qiymet";
            this.qiymetDataGridViewTextBoxColumn.Name = "qiymetDataGridViewTextBoxColumn";
            this.qiymetDataGridViewTextBoxColumn.ReadOnly = true;
            this.qiymetDataGridViewTextBoxColumn.Width = 40;
            // 
            // tarixDataGridViewTextBoxColumn
            // 
            this.tarixDataGridViewTextBoxColumn.DataPropertyName = "tarix";
            this.tarixDataGridViewTextBoxColumn.HeaderText = "tarix";
            this.tarixDataGridViewTextBoxColumn.Name = "tarixDataGridViewTextBoxColumn";
            this.tarixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(488, 363);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ust_qida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quasarDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quasarDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quasarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quasarDataSet31)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private masa1DataSet masa1DataSet;
        private ust_qida ust_qida;
        private ust_qidaTableAdapters.qida_elave_etTableAdapter qida_elave_etTableAdapter;
        private quasarDataSet1 quasarDataSet1;
        private quasarDataSet1TableAdapters.masa1TableAdapter masa1TableAdapter1;
        private System.Windows.Forms.Button button5;
        private quasarDataSet2 quasarDataSet2;
        private System.Windows.Forms.BindingSource masa1BindingSource;
        private quasarDataSet2TableAdapters.masa1TableAdapter masa1TableAdapter;
        private System.Windows.Forms.Label label2;
        private quasarDataSet3 quasarDataSet3;
        private System.Windows.Forms.BindingSource masa1BindingSource1;
        private quasarDataSet3TableAdapters.masa1TableAdapter masa1TableAdapter2;
        private quasarDataSet3 quasarDataSet31;
        private quasarDataSet1TableAdapters.masa1TableAdapter masa1TableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn midDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qidaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qidaadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qiymetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarixDataGridViewTextBoxColumn;

    }
}