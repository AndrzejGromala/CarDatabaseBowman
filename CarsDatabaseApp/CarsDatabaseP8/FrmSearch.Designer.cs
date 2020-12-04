namespace CarsDatabaseP8
{
   partial class FrmSearch
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.tblCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.hireDataSet = new CarsDatabaseP8.HireDataSet();
         this.btnClose = new System.Windows.Forms.Button();
         this.btnRun = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.cboOperator = new System.Windows.Forms.ComboBox();
         this.cboField = new System.Windows.Forms.ComboBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txtSearchValue = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.tblCarTableAdapter = new CarsDatabaseP8.HireDataSetTableAdapters.tblCarTableAdapter();
         this.tableAdapterManager = new CarsDatabaseP8.HireDataSetTableAdapters.TableAdapterManager();
         this.vehicleRegNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.engineSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dateRegisteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.rentalPerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.availableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // dataGridView1
         // 
         this.dataGridView1.AutoGenerateColumns = false;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleRegNoDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.engineSizeDataGridViewTextBoxColumn,
            this.dateRegisteredDataGridViewTextBoxColumn,
            this.rentalPerDayDataGridViewTextBoxColumn,
            this.availableDataGridViewCheckBoxColumn});
         this.dataGridView1.DataSource = this.tblCarBindingSource;
         this.dataGridView1.Location = new System.Drawing.Point(23, 159);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(633, 210);
         this.dataGridView1.TabIndex = 15;
         // 
         // tblCarBindingSource
         // 
         this.tblCarBindingSource.DataMember = "tblCar";
         this.tblCarBindingSource.DataSource = this.hireDataSet;
         // 
         // hireDataSet
         // 
         this.hireDataSet.DataSetName = "HireDataSet";
         this.hireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // btnClose
         // 
         this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnClose.Location = new System.Drawing.Point(507, 89);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(93, 46);
         this.btnClose.TabIndex = 14;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = true;
         this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
         // 
         // btnRun
         // 
         this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnRun.Location = new System.Drawing.Point(507, 37);
         this.btnRun.Name = "btnRun";
         this.btnRun.Size = new System.Drawing.Size(93, 46);
         this.btnRun.TabIndex = 13;
         this.btnRun.Text = "Run";
         this.btnRun.UseVisualStyleBackColor = true;
         this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.cboOperator);
         this.groupBox1.Controls.Add(this.cboField);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.txtSearchValue);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Location = new System.Drawing.Point(44, 26);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(424, 109);
         this.groupBox1.TabIndex = 12;
         this.groupBox1.TabStop = false;
         // 
         // cboOperator
         // 
         this.cboOperator.FormattingEnabled = true;
         this.cboOperator.Items.AddRange(new object[] {
            "=",
            "<>",
            "<",
            ">",
            "<=",
            ">="});
         this.cboOperator.Location = new System.Drawing.Point(164, 63);
         this.cboOperator.Name = "cboOperator";
         this.cboOperator.Size = new System.Drawing.Size(121, 21);
         this.cboOperator.TabIndex = 6;
         // 
         // cboField
         // 
         this.cboField.FormattingEnabled = true;
         this.cboField.Items.AddRange(new object[] {
            "Make ",
            "EngineSize",
            "RentalPerDay",
            "Available"});
         this.cboField.Location = new System.Drawing.Point(25, 63);
         this.cboField.Name = "cboField";
         this.cboField.Size = new System.Drawing.Size(121, 21);
         this.cboField.TabIndex = 5;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(315, 27);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(43, 16);
         this.label3.TabIndex = 4;
         this.label3.Text = "Value";
         // 
         // txtSearchValue
         // 
         this.txtSearchValue.Location = new System.Drawing.Point(299, 63);
         this.txtSearchValue.Name = "txtSearchValue";
         this.txtSearchValue.Size = new System.Drawing.Size(100, 20);
         this.txtSearchValue.TabIndex = 3;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(175, 27);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(61, 16);
         this.label2.TabIndex = 2;
         this.label2.Text = "Operator";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(32, 27);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(38, 16);
         this.label1.TabIndex = 0;
         this.label1.Text = "Field";
         // 
         // tblCarTableAdapter
         // 
         this.tblCarTableAdapter.ClearBeforeFill = true;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.tblCarTableAdapter = this.tblCarTableAdapter;
         this.tableAdapterManager.UpdateOrder = CarsDatabaseP8.HireDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         // 
         // vehicleRegNoDataGridViewTextBoxColumn
         // 
         this.vehicleRegNoDataGridViewTextBoxColumn.DataPropertyName = "VehicleRegNo";
         this.vehicleRegNoDataGridViewTextBoxColumn.HeaderText = "VehicleRegNo";
         this.vehicleRegNoDataGridViewTextBoxColumn.Name = "vehicleRegNoDataGridViewTextBoxColumn";
         // 
         // makeDataGridViewTextBoxColumn
         // 
         this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
         this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
         this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
         // 
         // engineSizeDataGridViewTextBoxColumn
         // 
         this.engineSizeDataGridViewTextBoxColumn.DataPropertyName = "EngineSize";
         this.engineSizeDataGridViewTextBoxColumn.HeaderText = "EngineSize";
         this.engineSizeDataGridViewTextBoxColumn.Name = "engineSizeDataGridViewTextBoxColumn";
         // 
         // dateRegisteredDataGridViewTextBoxColumn
         // 
         this.dateRegisteredDataGridViewTextBoxColumn.DataPropertyName = "DateRegistered";
         this.dateRegisteredDataGridViewTextBoxColumn.HeaderText = "DateRegistered";
         this.dateRegisteredDataGridViewTextBoxColumn.Name = "dateRegisteredDataGridViewTextBoxColumn";
         // 
         // rentalPerDayDataGridViewTextBoxColumn
         // 
         this.rentalPerDayDataGridViewTextBoxColumn.DataPropertyName = "RentalPerDay";
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
         dataGridViewCellStyle1.Format = "C2";
         dataGridViewCellStyle1.NullValue = null;
         this.rentalPerDayDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
         this.rentalPerDayDataGridViewTextBoxColumn.HeaderText = "RentalPerDay";
         this.rentalPerDayDataGridViewTextBoxColumn.Name = "rentalPerDayDataGridViewTextBoxColumn";
         // 
         // availableDataGridViewCheckBoxColumn
         // 
         this.availableDataGridViewCheckBoxColumn.DataPropertyName = "Available";
         this.availableDataGridViewCheckBoxColumn.HeaderText = "Available";
         this.availableDataGridViewCheckBoxColumn.Name = "availableDataGridViewCheckBoxColumn";
         // 
         // FrmSearch
         // 
         this.AcceptButton = this.btnRun;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(688, 397);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.btnRun);
         this.Controls.Add(this.groupBox1);
         this.Name = "FrmSearch";
         this.Text = "Task A Andrzej Gromala 10/10/2018";
         this.Load += new System.EventHandler(this.FrmSearch_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Button btnRun;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.ComboBox cboOperator;
      private System.Windows.Forms.ComboBox cboField;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtSearchValue;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private HireDataSet hireDataSet;
      private System.Windows.Forms.BindingSource tblCarBindingSource;
      private HireDataSetTableAdapters.tblCarTableAdapter tblCarTableAdapter;
      private HireDataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private System.Windows.Forms.DataGridViewTextBoxColumn vehicleRegNoDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn engineSizeDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn dateRegisteredDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn rentalPerDayDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewCheckBoxColumn availableDataGridViewCheckBoxColumn;
   }
}