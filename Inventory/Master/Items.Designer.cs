﻿namespace Inventory
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.lblHeadingC = new System.Windows.Forms.Label();
            this.lblIBrandName = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnAddInventory = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.ddlBrandName = new System.Windows.Forms.ComboBox();
            this.tblBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet = new Inventory.InventoryDataSet();
            this.ddlCategoryName = new System.Windows.Forms.ComboBox();
            this.tblCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet1 = new Inventory.InventoryDataSet1();
            this.tblBrandTableAdapter = new Inventory.InventoryDataSetTableAdapters.tblBrandTableAdapter();
            this.tblCategoryTableAdapter = new Inventory.InventoryDataSet1TableAdapters.tblCategoryTableAdapter();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.ddlWarehouse = new System.Windows.Forms.ComboBox();
            this.inventoryDataSet11 = new Inventory.InventoryDataSet11();
            this.tblWarehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblWarehouseTableAdapter = new Inventory.InventoryDataSet11TableAdapters.tblWarehouseTableAdapter();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblBrandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWarehouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadingC
            // 
            this.lblHeadingC.AutoSize = true;
            this.lblHeadingC.Font = new System.Drawing.Font("Dubai Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingC.Location = new System.Drawing.Point(224, 9);
            this.lblHeadingC.Name = "lblHeadingC";
            this.lblHeadingC.Size = new System.Drawing.Size(120, 40);
            this.lblHeadingC.TabIndex = 0;
            this.lblHeadingC.Text = "Add Items";
            // 
            // lblIBrandName
            // 
            this.lblIBrandName.AutoSize = true;
            this.lblIBrandName.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIBrandName.Location = new System.Drawing.Point(31, 52);
            this.lblIBrandName.Name = "lblIBrandName";
            this.lblIBrandName.Size = new System.Drawing.Size(112, 32);
            this.lblIBrandName.TabIndex = 1;
            this.lblIBrandName.Text = "Brand Name";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(31, 84);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(137, 32);
            this.lblCategoryName.TabIndex = 4;
            this.lblCategoryName.Text = "Category Name";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(31, 124);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(101, 32);
            this.lblItem.TabIndex = 5;
            this.lblItem.Text = "Item Name";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(194, 131);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(331, 20);
            this.txtItem.TabIndex = 6;
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInventory.Location = new System.Drawing.Point(77, 332);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(136, 34);
            this.btnAddInventory.TabIndex = 7;
            this.btnAddInventory.Text = "Add Inventory";
            this.btnAddInventory.UseVisualStyleBackColor = true;
            this.btnAddInventory.Click += new System.EventHandler(this.btnAddInventory_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(396, 332);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 34);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // ddlBrandName
            // 
            this.ddlBrandName.DataSource = this.tblBrandBindingSource;
            this.ddlBrandName.DisplayMember = "BrandName";
            this.ddlBrandName.FormattingEnabled = true;
            this.ddlBrandName.Location = new System.Drawing.Point(194, 52);
            this.ddlBrandName.Name = "ddlBrandName";
            this.ddlBrandName.Size = new System.Drawing.Size(331, 21);
            this.ddlBrandName.TabIndex = 10;
            this.ddlBrandName.ValueMember = "BrandName";
            // 
            // tblBrandBindingSource
            // 
            this.tblBrandBindingSource.DataMember = "tblBrand";
            this.tblBrandBindingSource.DataSource = this.inventoryDataSet;
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "InventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ddlCategoryName
            // 
            this.ddlCategoryName.DataSource = this.tblCategoryBindingSource;
            this.ddlCategoryName.DisplayMember = "CategoryName";
            this.ddlCategoryName.FormattingEnabled = true;
            this.ddlCategoryName.Location = new System.Drawing.Point(194, 91);
            this.ddlCategoryName.Name = "ddlCategoryName";
            this.ddlCategoryName.Size = new System.Drawing.Size(331, 21);
            this.ddlCategoryName.TabIndex = 11;
            this.ddlCategoryName.ValueMember = "CategoryName";
            // 
            // tblCategoryBindingSource
            // 
            this.tblCategoryBindingSource.DataMember = "tblCategory";
            this.tblCategoryBindingSource.DataSource = this.inventoryDataSet1;
            // 
            // inventoryDataSet1
            // 
            this.inventoryDataSet1.DataSetName = "InventoryDataSet1";
            this.inventoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBrandTableAdapter
            // 
            this.tblBrandTableAdapter.ClearBeforeFill = true;
            // 
            // tblCategoryTableAdapter
            // 
            this.tblCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(37, 382);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(488, 150);
            this.dgvItems.TabIndex = 12;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(31, 288);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 32);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(194, 295);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(331, 20);
            this.txtPrice.TabIndex = 14;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(194, 171);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(331, 20);
            this.txtDescription.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Description";
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouse.Location = new System.Drawing.Point(31, 251);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(104, 32);
            this.lblWarehouse.TabIndex = 17;
            this.lblWarehouse.Text = "Warehouse";
            // 
            // ddlWarehouse
            // 
            this.ddlWarehouse.DataSource = this.tblWarehouseBindingSource;
            this.ddlWarehouse.DisplayMember = "WarehouseName";
            this.ddlWarehouse.FormattingEnabled = true;
            this.ddlWarehouse.Location = new System.Drawing.Point(194, 258);
            this.ddlWarehouse.Name = "ddlWarehouse";
            this.ddlWarehouse.Size = new System.Drawing.Size(331, 21);
            this.ddlWarehouse.TabIndex = 18;
            this.ddlWarehouse.ValueMember = "WarehouseName";
            // 
            // inventoryDataSet11
            // 
            this.inventoryDataSet11.DataSetName = "InventoryDataSet11";
            this.inventoryDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblWarehouseBindingSource
            // 
            this.tblWarehouseBindingSource.DataMember = "tblWarehouse";
            this.tblWarehouseBindingSource.DataSource = this.inventoryDataSet11;
            // 
            // tblWarehouseTableAdapter
            // 
            this.tblWarehouseTableAdapter.ClearBeforeFill = true;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(31, 208);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(60, 32);
            this.lblStock.TabIndex = 19;
            this.lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(194, 215);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(331, 20);
            this.txtStock.TabIndex = 20;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(565, 580);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.ddlWarehouse);
            this.Controls.Add(this.lblWarehouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.ddlCategoryName);
            this.Controls.Add(this.ddlBrandName);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAddInventory);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblIBrandName);
            this.Controls.Add(this.lblHeadingC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddItem";
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBrandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWarehouseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadingC;
        private System.Windows.Forms.Label lblIBrandName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnAddInventory;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox ddlBrandName;
        private System.Windows.Forms.ComboBox ddlCategoryName;
        private InventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource tblBrandBindingSource;
        private InventoryDataSetTableAdapters.tblBrandTableAdapter tblBrandTableAdapter;
        private InventoryDataSet1 inventoryDataSet1;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource;
        private InventoryDataSet1TableAdapters.tblCategoryTableAdapter tblCategoryTableAdapter;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.ComboBox ddlWarehouse;
        private InventoryDataSet11 inventoryDataSet11;
        private System.Windows.Forms.BindingSource tblWarehouseBindingSource;
        private InventoryDataSet11TableAdapters.tblWarehouseTableAdapter tblWarehouseTableAdapter;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
    }
}