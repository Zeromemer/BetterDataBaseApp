﻿namespace DataBaseApp
{
    partial class ManualAditionForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.cb_products_Category = new System.Windows.Forms.ComboBox();
            this.btRegistrationProducts = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_products_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_products_ProductID = new System.Windows.Forms.TextBox();
            this.tb_products_QuantityInStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_products_SupplierID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_products_Price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_customers_CustomerID = new System.Windows.Forms.TextBox();
            this.gbCustomers = new System.Windows.Forms.GroupBox();
            this.btRegistrationCustomers = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_customers_LastName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_customers_Address = new System.Windows.Forms.TextBox();
            this.tb_customers_Email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_customers_FirstName = new System.Windows.Forms.TextBox();
            this.tb_customers_Phone = new System.Windows.Forms.TextBox();
            this.gbOrders = new System.Windows.Forms.GroupBox();
            this.btGetCurrentTime = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.cb_orders_Status = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_orders_OrderDate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_orders_Quantity = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_orders_ProductID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_orders_CustomerID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_orders_OrderID = new System.Windows.Forms.TextBox();
            this.btRegistrationOrders = new System.Windows.Forms.Button();
            this.tb_suppliers_SupplierID = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gbSuppliers = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btRegistrationSuppliers = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_suppliers_Name = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_suppliers_ContactEmail = new System.Windows.Forms.TextBox();
            this.tb_suppliers_Phone = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbProducts.SuspendLayout();
            this.gbCustomers.SuspendLayout();
            this.gbOrders.SuspendLayout();
            this.gbSuppliers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(999, 669);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 49);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(997, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Таблица";
            // 
            // gbProducts
            // 
            this.gbProducts.Controls.Add(this.cb_products_Category);
            this.gbProducts.Controls.Add(this.btRegistrationProducts);
            this.gbProducts.Controls.Add(this.label4);
            this.gbProducts.Controls.Add(this.label6);
            this.gbProducts.Controls.Add(this.label3);
            this.gbProducts.Controls.Add(this.tb_products_Name);
            this.gbProducts.Controls.Add(this.label2);
            this.gbProducts.Controls.Add(this.tb_products_ProductID);
            this.gbProducts.Controls.Add(this.tb_products_QuantityInStock);
            this.gbProducts.Controls.Add(this.label7);
            this.gbProducts.Controls.Add(this.tb_products_SupplierID);
            this.gbProducts.Controls.Add(this.label5);
            this.gbProducts.Controls.Add(this.tb_products_Price);
            this.gbProducts.Enabled = false;
            this.gbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbProducts.Location = new System.Drawing.Point(1026, 92);
            this.gbProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProducts.Size = new System.Drawing.Size(300, 668);
            this.gbProducts.TabIndex = 5;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "products";
            // 
            // cb_products_Category
            // 
            this.cb_products_Category.FormattingEnabled = true;
            this.cb_products_Category.Items.AddRange(new object[] {
            "Desktop",
            "Laptop",
            "Server"});
            this.cb_products_Category.Location = new System.Drawing.Point(9, 229);
            this.cb_products_Category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_products_Category.Name = "cb_products_Category";
            this.cb_products_Category.Size = new System.Drawing.Size(148, 37);
            this.cb_products_Category.TabIndex = 30;
            // 
            // btRegistrationProducts
            // 
            this.btRegistrationProducts.Location = new System.Drawing.Point(9, 620);
            this.btRegistrationProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRegistrationProducts.Name = "btRegistrationProducts";
            this.btRegistrationProducts.Size = new System.Drawing.Size(150, 38);
            this.btRegistrationProducts.TabIndex = 6;
            this.btRegistrationProducts.Text = "Записване";
            this.btRegistrationProducts.UseVisualStyleBackColor = true;
            this.btRegistrationProducts.Click += new System.EventHandler(this.btRegistrationProducts_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 357);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "QuantityInStock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // tb_products_Name
            // 
            this.tb_products_Name.Location = new System.Drawing.Point(9, 149);
            this.tb_products_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_products_Name.Name = "tb_products_Name";
            this.tb_products_Name.Size = new System.Drawing.Size(274, 35);
            this.tb_products_Name.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "ProductID";
            // 
            // tb_products_ProductID
            // 
            this.tb_products_ProductID.Enabled = false;
            this.tb_products_ProductID.Location = new System.Drawing.Point(9, 69);
            this.tb_products_ProductID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_products_ProductID.Name = "tb_products_ProductID";
            this.tb_products_ProductID.Size = new System.Drawing.Size(274, 35);
            this.tb_products_ProductID.TabIndex = 0;
            // 
            // tb_products_QuantityInStock
            // 
            this.tb_products_QuantityInStock.Location = new System.Drawing.Point(9, 392);
            this.tb_products_QuantityInStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_products_QuantityInStock.Name = "tb_products_QuantityInStock";
            this.tb_products_QuantityInStock.Size = new System.Drawing.Size(274, 35);
            this.tb_products_QuantityInStock.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 437);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "SupplierID";
            // 
            // tb_products_SupplierID
            // 
            this.tb_products_SupplierID.Location = new System.Drawing.Point(9, 472);
            this.tb_products_SupplierID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_products_SupplierID.Name = "tb_products_SupplierID";
            this.tb_products_SupplierID.Size = new System.Drawing.Size(274, 35);
            this.tb_products_SupplierID.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // tb_products_Price
            // 
            this.tb_products_Price.Location = new System.Drawing.Point(9, 309);
            this.tb_products_Price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_products_Price.Name = "tb_products_Price";
            this.tb_products_Price.Size = new System.Drawing.Size(274, 35);
            this.tb_products_Price.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "CustomerID";
            // 
            // tb_customers_CustomerID
            // 
            this.tb_customers_CustomerID.Enabled = false;
            this.tb_customers_CustomerID.Location = new System.Drawing.Point(9, 68);
            this.tb_customers_CustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_customers_CustomerID.Name = "tb_customers_CustomerID";
            this.tb_customers_CustomerID.Size = new System.Drawing.Size(274, 35);
            this.tb_customers_CustomerID.TabIndex = 9;
            // 
            // gbCustomers
            // 
            this.gbCustomers.Controls.Add(this.btRegistrationCustomers);
            this.gbCustomers.Controls.Add(this.label8);
            this.gbCustomers.Controls.Add(this.label10);
            this.gbCustomers.Controls.Add(this.tb_customers_LastName);
            this.gbCustomers.Controls.Add(this.label13);
            this.gbCustomers.Controls.Add(this.label11);
            this.gbCustomers.Controls.Add(this.tb_customers_CustomerID);
            this.gbCustomers.Controls.Add(this.tb_customers_Address);
            this.gbCustomers.Controls.Add(this.tb_customers_Email);
            this.gbCustomers.Controls.Add(this.label9);
            this.gbCustomers.Controls.Add(this.label12);
            this.gbCustomers.Controls.Add(this.tb_customers_FirstName);
            this.gbCustomers.Controls.Add(this.tb_customers_Phone);
            this.gbCustomers.Enabled = false;
            this.gbCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbCustomers.Location = new System.Drawing.Point(1335, 94);
            this.gbCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCustomers.Name = "gbCustomers";
            this.gbCustomers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCustomers.Size = new System.Drawing.Size(300, 666);
            this.gbCustomers.TabIndex = 11;
            this.gbCustomers.TabStop = false;
            this.gbCustomers.Text = "customers";
            // 
            // btRegistrationCustomers
            // 
            this.btRegistrationCustomers.Location = new System.Drawing.Point(9, 618);
            this.btRegistrationCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRegistrationCustomers.Name = "btRegistrationCustomers";
            this.btRegistrationCustomers.Size = new System.Drawing.Size(150, 38);
            this.btRegistrationCustomers.TabIndex = 6;
            this.btRegistrationCustomers.Text = "Записване";
            this.btRegistrationCustomers.UseVisualStyleBackColor = true;
            this.btRegistrationCustomers.Click += new System.EventHandler(this.btRegistrationCustomers_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 29);
            this.label10.TabIndex = 6;
            this.label10.Text = "LastName";
            // 
            // tb_customers_LastName
            // 
            this.tb_customers_LastName.Location = new System.Drawing.Point(9, 228);
            this.tb_customers_LastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_customers_LastName.Name = "tb_customers_LastName";
            this.tb_customers_LastName.Size = new System.Drawing.Size(274, 35);
            this.tb_customers_LastName.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(3, 435);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 29);
            this.label13.TabIndex = 16;
            this.label13.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 272);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 29);
            this.label11.TabIndex = 12;
            this.label11.Text = "Email";
            // 
            // tb_customers_Address
            // 
            this.tb_customers_Address.Location = new System.Drawing.Point(9, 471);
            this.tb_customers_Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_customers_Address.Name = "tb_customers_Address";
            this.tb_customers_Address.Size = new System.Drawing.Size(274, 35);
            this.tb_customers_Address.TabIndex = 15;
            // 
            // tb_customers_Email
            // 
            this.tb_customers_Email.Location = new System.Drawing.Point(9, 308);
            this.tb_customers_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_customers_Email.Name = "tb_customers_Email";
            this.tb_customers_Email.Size = new System.Drawing.Size(274, 35);
            this.tb_customers_Email.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "FirstName";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 355);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 29);
            this.label12.TabIndex = 14;
            this.label12.Text = "Phone";
            // 
            // tb_customers_FirstName
            // 
            this.tb_customers_FirstName.Location = new System.Drawing.Point(9, 148);
            this.tb_customers_FirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_customers_FirstName.Name = "tb_customers_FirstName";
            this.tb_customers_FirstName.Size = new System.Drawing.Size(274, 35);
            this.tb_customers_FirstName.TabIndex = 7;
            // 
            // tb_customers_Phone
            // 
            this.tb_customers_Phone.Location = new System.Drawing.Point(9, 391);
            this.tb_customers_Phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_customers_Phone.Name = "tb_customers_Phone";
            this.tb_customers_Phone.Size = new System.Drawing.Size(274, 35);
            this.tb_customers_Phone.TabIndex = 13;
            // 
            // gbOrders
            // 
            this.gbOrders.Controls.Add(this.btGetCurrentTime);
            this.gbOrders.Controls.Add(this.label24);
            this.gbOrders.Controls.Add(this.cb_orders_Status);
            this.gbOrders.Controls.Add(this.label19);
            this.gbOrders.Controls.Add(this.label18);
            this.gbOrders.Controls.Add(this.tb_orders_OrderDate);
            this.gbOrders.Controls.Add(this.label17);
            this.gbOrders.Controls.Add(this.tb_orders_Quantity);
            this.gbOrders.Controls.Add(this.label16);
            this.gbOrders.Controls.Add(this.tb_orders_ProductID);
            this.gbOrders.Controls.Add(this.label15);
            this.gbOrders.Controls.Add(this.tb_orders_CustomerID);
            this.gbOrders.Controls.Add(this.label14);
            this.gbOrders.Controls.Add(this.tb_orders_OrderID);
            this.gbOrders.Controls.Add(this.btRegistrationOrders);
            this.gbOrders.Enabled = false;
            this.gbOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbOrders.Location = new System.Drawing.Point(1644, 95);
            this.gbOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOrders.Name = "gbOrders";
            this.gbOrders.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOrders.Size = new System.Drawing.Size(300, 665);
            this.gbOrders.TabIndex = 11;
            this.gbOrders.TabStop = false;
            this.gbOrders.Text = "orders";
            // 
            // btGetCurrentTime
            // 
            this.btGetCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btGetCurrentTime.Location = new System.Drawing.Point(68, 469);
            this.btGetCurrentTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGetCurrentTime.Name = "btGetCurrentTime";
            this.btGetCurrentTime.Size = new System.Drawing.Size(150, 55);
            this.btGetCurrentTime.TabIndex = 31;
            this.btGetCurrentTime.Text = "Сегашното време";
            this.btGetCurrentTime.UseVisualStyleBackColor = true;
            this.btGetCurrentTime.Click += new System.EventHandler(this.btGetCurrentTime_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(45, 434);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(206, 20);
            this.label24.TabIndex = 30;
            this.label24.Text = "YYYY-MM-DD HH:MM:SS";
            // 
            // cb_orders_Status
            // 
            this.cb_orders_Status.FormattingEnabled = true;
            this.cb_orders_Status.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Delivered",
            "Cancelled"});
            this.cb_orders_Status.Location = new System.Drawing.Point(9, 565);
            this.cb_orders_Status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_orders_Status.Name = "cb_orders_Status";
            this.cb_orders_Status.Size = new System.Drawing.Size(148, 37);
            this.cb_orders_Status.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(9, 529);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 29);
            this.label19.TabIndex = 28;
            this.label19.Text = "Status";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(3, 354);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 29);
            this.label18.TabIndex = 26;
            this.label18.Text = "OrderDate";
            // 
            // tb_orders_OrderDate
            // 
            this.tb_orders_OrderDate.Location = new System.Drawing.Point(9, 389);
            this.tb_orders_OrderDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_orders_OrderDate.Name = "tb_orders_OrderDate";
            this.tb_orders_OrderDate.Size = new System.Drawing.Size(274, 35);
            this.tb_orders_OrderDate.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(3, 271);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 29);
            this.label17.TabIndex = 24;
            this.label17.Text = "Quantity";
            // 
            // tb_orders_Quantity
            // 
            this.tb_orders_Quantity.Location = new System.Drawing.Point(9, 306);
            this.tb_orders_Quantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_orders_Quantity.Name = "tb_orders_Quantity";
            this.tb_orders_Quantity.Size = new System.Drawing.Size(274, 35);
            this.tb_orders_Quantity.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(3, 191);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 29);
            this.label16.TabIndex = 22;
            this.label16.Text = "ProductID";
            // 
            // tb_orders_ProductID
            // 
            this.tb_orders_ProductID.Location = new System.Drawing.Point(9, 226);
            this.tb_orders_ProductID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_orders_ProductID.Name = "tb_orders_ProductID";
            this.tb_orders_ProductID.Size = new System.Drawing.Size(274, 35);
            this.tb_orders_ProductID.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(3, 111);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 29);
            this.label15.TabIndex = 20;
            this.label15.Text = "CustomerID";
            // 
            // tb_orders_CustomerID
            // 
            this.tb_orders_CustomerID.Location = new System.Drawing.Point(9, 146);
            this.tb_orders_CustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_orders_CustomerID.Name = "tb_orders_CustomerID";
            this.tb_orders_CustomerID.Size = new System.Drawing.Size(274, 35);
            this.tb_orders_CustomerID.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(3, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 29);
            this.label14.TabIndex = 18;
            this.label14.Text = "OrderID";
            // 
            // tb_orders_OrderID
            // 
            this.tb_orders_OrderID.Enabled = false;
            this.tb_orders_OrderID.Location = new System.Drawing.Point(9, 66);
            this.tb_orders_OrderID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_orders_OrderID.Name = "tb_orders_OrderID";
            this.tb_orders_OrderID.Size = new System.Drawing.Size(274, 35);
            this.tb_orders_OrderID.TabIndex = 17;
            // 
            // btRegistrationOrders
            // 
            this.btRegistrationOrders.Location = new System.Drawing.Point(9, 617);
            this.btRegistrationOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRegistrationOrders.Name = "btRegistrationOrders";
            this.btRegistrationOrders.Size = new System.Drawing.Size(150, 38);
            this.btRegistrationOrders.TabIndex = 6;
            this.btRegistrationOrders.Text = "Записване";
            this.btRegistrationOrders.UseVisualStyleBackColor = true;
            this.btRegistrationOrders.Click += new System.EventHandler(this.btRegistrationOrders_Click);
            // 
            // tb_suppliers_SupplierID
            // 
            this.tb_suppliers_SupplierID.Enabled = false;
            this.tb_suppliers_SupplierID.Location = new System.Drawing.Point(9, 66);
            this.tb_suppliers_SupplierID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_suppliers_SupplierID.Name = "tb_suppliers_SupplierID";
            this.tb_suppliers_SupplierID.Size = new System.Drawing.Size(274, 35);
            this.tb_suppliers_SupplierID.TabIndex = 27;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(1026, 49);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(164, 33);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Свързване";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gbSuppliers
            // 
            this.gbSuppliers.Controls.Add(this.label23);
            this.gbSuppliers.Controls.Add(this.btRegistrationSuppliers);
            this.gbSuppliers.Controls.Add(this.tb_suppliers_SupplierID);
            this.gbSuppliers.Controls.Add(this.label20);
            this.gbSuppliers.Controls.Add(this.tb_suppliers_Name);
            this.gbSuppliers.Controls.Add(this.label21);
            this.gbSuppliers.Controls.Add(this.label22);
            this.gbSuppliers.Controls.Add(this.tb_suppliers_ContactEmail);
            this.gbSuppliers.Controls.Add(this.tb_suppliers_Phone);
            this.gbSuppliers.Enabled = false;
            this.gbSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSuppliers.Location = new System.Drawing.Point(1953, 95);
            this.gbSuppliers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSuppliers.Name = "gbSuppliers";
            this.gbSuppliers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSuppliers.Size = new System.Drawing.Size(300, 665);
            this.gbSuppliers.TabIndex = 17;
            this.gbSuppliers.TabStop = false;
            this.gbSuppliers.Text = "suppliers";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(3, 271);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 29);
            this.label23.TabIndex = 18;
            this.label23.Text = "Phone";
            // 
            // btRegistrationSuppliers
            // 
            this.btRegistrationSuppliers.Location = new System.Drawing.Point(9, 617);
            this.btRegistrationSuppliers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRegistrationSuppliers.Name = "btRegistrationSuppliers";
            this.btRegistrationSuppliers.Size = new System.Drawing.Size(150, 38);
            this.btRegistrationSuppliers.TabIndex = 6;
            this.btRegistrationSuppliers.Text = "Записване";
            this.btRegistrationSuppliers.UseVisualStyleBackColor = true;
            this.btRegistrationSuppliers.Click += new System.EventHandler(this.btRegistrationSuppliers_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Enabled = false;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(3, 31);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 29);
            this.label20.TabIndex = 6;
            this.label20.Text = "SupplierID";
            // 
            // tb_suppliers_Name
            // 
            this.tb_suppliers_Name.Location = new System.Drawing.Point(9, 146);
            this.tb_suppliers_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_suppliers_Name.Name = "tb_suppliers_Name";
            this.tb_suppliers_Name.Size = new System.Drawing.Size(274, 35);
            this.tb_suppliers_Name.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(3, 114);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 29);
            this.label21.TabIndex = 12;
            this.label21.Text = "Name";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(3, 191);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(155, 29);
            this.label22.TabIndex = 16;
            this.label22.Text = "ContactEmail";
            // 
            // tb_suppliers_ContactEmail
            // 
            this.tb_suppliers_ContactEmail.Location = new System.Drawing.Point(9, 226);
            this.tb_suppliers_ContactEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_suppliers_ContactEmail.Name = "tb_suppliers_ContactEmail";
            this.tb_suppliers_ContactEmail.Size = new System.Drawing.Size(274, 35);
            this.tb_suppliers_ContactEmail.TabIndex = 15;
            // 
            // tb_suppliers_Phone
            // 
            this.tb_suppliers_Phone.Location = new System.Drawing.Point(9, 306);
            this.tb_suppliers_Phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_suppliers_Phone.Name = "tb_suppliers_Phone";
            this.tb_suppliers_Phone.Size = new System.Drawing.Size(274, 35);
            this.tb_suppliers_Phone.TabIndex = 11;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(1202, 49);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(347, 33);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Прекратяване на връзката";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.SystemColors.Control;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Location = new System.Drawing.Point(18, 769);
            this.btBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(150, 66);
            this.btBack.TabIndex = 31;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // ManualAditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2278, 844);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.gbSuppliers);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.gbCustomers);
            this.Controls.Add(this.gbOrders);
            this.Controls.Add(this.gbProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManualAditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManualAditionForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbProducts.ResumeLayout(false);
            this.gbProducts.PerformLayout();
            this.gbCustomers.ResumeLayout(false);
            this.gbCustomers.PerformLayout();
            this.gbOrders.ResumeLayout(false);
            this.gbOrders.PerformLayout();
            this.gbSuppliers.ResumeLayout(false);
            this.gbSuppliers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.Button btRegistrationProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_products_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_products_ProductID;
        private System.Windows.Forms.GroupBox gbCustomers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_customers_Phone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_customers_Email;
        private System.Windows.Forms.Button btRegistrationCustomers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_products_QuantityInStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_products_SupplierID;
        private System.Windows.Forms.GroupBox gbOrders;
        private System.Windows.Forms.Button btRegistrationOrders;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_customers_CustomerID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_customers_FirstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_customers_LastName;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_orders_CustomerID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_orders_OrderID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_customers_Address;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_suppliers_SupplierID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_orders_Quantity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_orders_ProductID;
        private System.Windows.Forms.GroupBox gbSuppliers;
        private System.Windows.Forms.Button btRegistrationSuppliers;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_suppliers_Name;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tb_suppliers_ContactEmail;
        private System.Windows.Forms.TextBox tb_suppliers_Phone;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_products_Price;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cb_orders_Status;
        private System.Windows.Forms.ComboBox cb_products_Category;
        private System.Windows.Forms.TextBox tb_orders_OrderDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btGetCurrentTime;
        private System.Windows.Forms.Button btBack;
    }
}

