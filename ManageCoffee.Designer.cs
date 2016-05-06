namespace CoffeeShopApp
{
    partial class ManageCoffee
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.csCoffeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopDbDataSet = new CoffeeShopApp.CoffeeShopDbDataSet();
            this.cs_CoffeeTableAdapter = new CoffeeShopApp.CoffeeShopDbDataSetTableAdapters.cs_CoffeeTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.stockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeGrindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeStrengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeImagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csCoffeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDbDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.priceDataGridViewTextBoxColumn,
            this.coffeeDescriptionDataGridViewTextBoxColumn,
            this.coffeeImagePathDataGridViewTextBoxColumn,
            this.coffeeStrengthDataGridViewTextBoxColumn,
            this.coffeeGrindDataGridViewTextBoxColumn,
            this.originDataGridViewTextBoxColumn,
            this.stockQuantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.csCoffeeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 261);
            this.dataGridView1.TabIndex = 0;
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
            // cs_CoffeeTableAdapter
            // 
            this.cs_CoffeeTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(579, 33);
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
            this.panel1.Size = new System.Drawing.Size(651, 261);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.lblMessage);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 68);
            this.panel2.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(3, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(3, 8);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(51, 20);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "label1";
            // 
            // stockQuantityDataGridViewTextBoxColumn
            // 
            this.stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "stockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.HeaderText = "stockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.DataPropertyName = "origin";
            this.originDataGridViewTextBoxColumn.HeaderText = "origin";
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            // 
            // coffeeGrindDataGridViewTextBoxColumn
            // 
            this.coffeeGrindDataGridViewTextBoxColumn.DataPropertyName = "coffeeGrind";
            this.coffeeGrindDataGridViewTextBoxColumn.HeaderText = "coffeeGrind";
            this.coffeeGrindDataGridViewTextBoxColumn.Name = "coffeeGrindDataGridViewTextBoxColumn";
            // 
            // coffeeStrengthDataGridViewTextBoxColumn
            // 
            this.coffeeStrengthDataGridViewTextBoxColumn.DataPropertyName = "coffeeStrength";
            this.coffeeStrengthDataGridViewTextBoxColumn.HeaderText = "coffeeStrength";
            this.coffeeStrengthDataGridViewTextBoxColumn.Name = "coffeeStrengthDataGridViewTextBoxColumn";
            // 
            // coffeeImagePathDataGridViewTextBoxColumn
            // 
            this.coffeeImagePathDataGridViewTextBoxColumn.DataPropertyName = "coffeeImagePath";
            this.coffeeImagePathDataGridViewTextBoxColumn.HeaderText = "coffeeImagePath";
            this.coffeeImagePathDataGridViewTextBoxColumn.Name = "coffeeImagePathDataGridViewTextBoxColumn";
            // 
            // coffeeDescriptionDataGridViewTextBoxColumn
            // 
            this.coffeeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "coffeeDescription";
            this.coffeeDescriptionDataGridViewTextBoxColumn.HeaderText = "coffeeDescription";
            this.coffeeDescriptionDataGridViewTextBoxColumn.Name = "coffeeDescriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // coffeeNameDataGridViewTextBoxColumn
            // 
            this.coffeeNameDataGridViewTextBoxColumn.DataPropertyName = "coffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.HeaderText = "coffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.Name = "coffeeNameDataGridViewTextBoxColumn";
            // 
            // coffeeIdDataGridViewTextBoxColumn
            // 
            this.coffeeIdDataGridViewTextBoxColumn.DataPropertyName = "coffeeId";
            this.coffeeIdDataGridViewTextBoxColumn.HeaderText = "coffeeId";
            this.coffeeIdDataGridViewTextBoxColumn.Name = "coffeeIdDataGridViewTextBoxColumn";
            this.coffeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ManageCoffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCoffee";
            this.ShowIcon = false;
            this.Text = "Manage Coffee";
            this.Load += new System.EventHandler(this.ManageCoffee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csCoffeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDbDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CoffeeShopDbDataSet coffeeShopDbDataSet;
        private System.Windows.Forms.BindingSource csCoffeeBindingSource;
        private CoffeeShopDbDataSetTableAdapters.cs_CoffeeTableAdapter cs_CoffeeTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeImagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeStrengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeGrindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
    }
}