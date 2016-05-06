namespace CoffeeShopApp
{
    partial class ManageStock
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.csCoffeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csCoffeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopDbDataSet = new CoffeeShopApp.CoffeeShopDbDataSet();
            this.coffeeShopDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cs_CoffeeTableAdapter = new CoffeeShopApp.CoffeeShopDbDataSetTableAdapters.cs_CoffeeTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csCoffeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csCoffeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(3, 19);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(51, 20);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMessage);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 42);
            this.panel2.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(534, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 229);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coffeeIdDataGridViewTextBoxColumn,
            this.coffeeNameDataGridViewTextBoxColumn,
            this.stockQuantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.csCoffeeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // csCoffeeBindingSource1
            // 
            this.csCoffeeBindingSource1.DataMember = "cs_Coffee";
            this.csCoffeeBindingSource1.DataSource = this.coffeeShopDbDataSetBindingSource;
            // 
            // coffeeIdDataGridViewTextBoxColumn
            // 
            this.coffeeIdDataGridViewTextBoxColumn.DataPropertyName = "coffeeId";
            this.coffeeIdDataGridViewTextBoxColumn.HeaderText = "coffeeId";
            this.coffeeIdDataGridViewTextBoxColumn.Name = "coffeeIdDataGridViewTextBoxColumn";
            this.coffeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coffeeNameDataGridViewTextBoxColumn
            // 
            this.coffeeNameDataGridViewTextBoxColumn.DataPropertyName = "coffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.HeaderText = "coffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.Name = "coffeeNameDataGridViewTextBoxColumn";
            this.coffeeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockQuantityDataGridViewTextBoxColumn
            // 
            this.stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "stockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.HeaderText = "stockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
            // 
            // csCoffeeBindingSource
            // 
            this.csCoffeeBindingSource.DataMember = "cs_Coffee";
            this.csCoffeeBindingSource.DataSource = this.coffeeShopDbDataSet;
            // 
            // coffeeShopDbDataSet
            // 
            this.coffeeShopDbDataSet.DataSetName = "CoffeeShopDbDataSet";
            this.coffeeShopDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coffeeShopDbDataSetBindingSource
            // 
            this.coffeeShopDbDataSetBindingSource.DataSource = this.coffeeShopDbDataSet;
            this.coffeeShopDbDataSetBindingSource.Position = 0;
            // 
            // cs_CoffeeTableAdapter
            // 
            this.cs_CoffeeTableAdapter.ClearBeforeFill = true;
            // 
            // ManageStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 229);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageStock";
            this.ShowIcon = false;
            this.Text = "Manage Stock";
            this.Load += new System.EventHandler(this.ManageStock_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csCoffeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csCoffeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource csCoffeeBindingSource;
        private CoffeeShopDbDataSet coffeeShopDbDataSet;
        private CoffeeShopDbDataSetTableAdapters.cs_CoffeeTableAdapter cs_CoffeeTableAdapter;
        private System.Windows.Forms.BindingSource coffeeShopDbDataSetBindingSource;
        private System.Windows.Forms.BindingSource csCoffeeBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
    }
}