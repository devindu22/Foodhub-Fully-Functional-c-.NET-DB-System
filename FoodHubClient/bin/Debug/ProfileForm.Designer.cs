namespace FoodHubClient
{
    partial class ProfileForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodhubDataSet14 = new FoodHubClient.FoodhubDataSet14();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatchtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodhubDataSet17 = new FoodHubClient.FoodhubDataSet17();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.customerTableAdapter = new FoodHubClient.FoodhubDataSet14TableAdapters.CustomerTableAdapter();
            this.foodhubDataSet15 = new FoodHubClient.FoodhubDataSet15();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationTableAdapter = new FoodHubClient.FoodhubDataSet15TableAdapters.LocationTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.locationnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.foodhubDataSet16 = new FoodHubClient.FoodhubDataSet16();
            this.locationTableAdapter1 = new FoodHubClient.FoodhubDataSet16TableAdapters.LocationTableAdapter();
            this.ordersTableAdapter = new FoodHubClient.FoodhubDataSet17TableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodhubDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodhubDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodhubDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodhubDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 47);
            this.button1.TabIndex = 23;
            this.button1.Text = "🔙 ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::FoodHubClient.Properties.Resources.White___Grey_Clean_Grid_Personal_Moodboard_Photo_Collage;
            this.pictureBox1.Location = new System.Drawing.Point(354, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.contactnoDataGridViewTextBoxColumn,
            this.nicDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(52, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(359, 66);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customer_name";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            // 
            // contactnoDataGridViewTextBoxColumn
            // 
            this.contactnoDataGridViewTextBoxColumn.DataPropertyName = "contact_no";
            this.contactnoDataGridViewTextBoxColumn.HeaderText = "contact_no";
            this.contactnoDataGridViewTextBoxColumn.Name = "contactnoDataGridViewTextBoxColumn";
            // 
            // nicDataGridViewTextBoxColumn
            // 
            this.nicDataGridViewTextBoxColumn.DataPropertyName = "nic";
            this.nicDataGridViewTextBoxColumn.HeaderText = "nic";
            this.nicDataGridViewTextBoxColumn.Name = "nicDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.foodhubDataSet14;
            // 
            // foodhubDataSet14
            // 
            this.foodhubDataSet14.DataSetName = "FoodhubDataSet14";
            this.foodhubDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderdateDataGridViewTextBoxColumn,
            this.ordertimeDataGridViewTextBoxColumn,
            this.orderamountDataGridViewTextBoxColumn,
            this.paymentmethodDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dispatchtimeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ordersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(114, 442);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(645, 131);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "order_date";
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            // 
            // ordertimeDataGridViewTextBoxColumn
            // 
            this.ordertimeDataGridViewTextBoxColumn.DataPropertyName = "order_time";
            this.ordertimeDataGridViewTextBoxColumn.HeaderText = "order_time";
            this.ordertimeDataGridViewTextBoxColumn.Name = "ordertimeDataGridViewTextBoxColumn";
            // 
            // orderamountDataGridViewTextBoxColumn
            // 
            this.orderamountDataGridViewTextBoxColumn.DataPropertyName = "order_amount";
            this.orderamountDataGridViewTextBoxColumn.HeaderText = "order_amount";
            this.orderamountDataGridViewTextBoxColumn.Name = "orderamountDataGridViewTextBoxColumn";
            // 
            // paymentmethodDataGridViewTextBoxColumn
            // 
            this.paymentmethodDataGridViewTextBoxColumn.DataPropertyName = "payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.HeaderText = "payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.Name = "paymentmethodDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // dispatchtimeDataGridViewTextBoxColumn
            // 
            this.dispatchtimeDataGridViewTextBoxColumn.DataPropertyName = "dispatch_time";
            this.dispatchtimeDataGridViewTextBoxColumn.HeaderText = "dispatch_time";
            this.dispatchtimeDataGridViewTextBoxColumn.Name = "dispatchtimeDataGridViewTextBoxColumn";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.foodhubDataSet17;
            // 
            // foodhubDataSet17
            // 
            this.foodhubDataSet17.DataSetName = "FoodhubDataSet17";
            this.foodhubDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 34);
            this.label4.TabIndex = 29;
            this.label4.Text = "Profile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 34);
            this.label5.TabIndex = 30;
            this.label5.Text = "Order History";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 343);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 32);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(114, 384);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(119, 32);
            this.dateTimePicker2.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pending",
            "In Transit",
            "Delivered",
            "Cancelled"});
            this.comboBox1.Location = new System.Drawing.Point(114, 301);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 32);
            this.comboBox1.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(671, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 47);
            this.button2.TabIndex = 34;
            this.button2.Text = "🔄";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(732, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 47);
            this.button3.TabIndex = 35;
            this.button3.Text = "🖨";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(793, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 47);
            this.button4.TabIndex = 36;
            this.button4.Text = "📉";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(256, 336);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 47);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "🔎 ";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // foodhubDataSet15
            // 
            this.foodhubDataSet15.DataSetName = "FoodhubDataSet15";
            this.foodhubDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.foodhubDataSet15;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationnoDataGridViewTextBoxColumn,
            this.laneDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.locationBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(456, 203);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(354, 131);
            this.dataGridView3.TabIndex = 38;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // locationnoDataGridViewTextBoxColumn
            // 
            this.locationnoDataGridViewTextBoxColumn.DataPropertyName = "location_no";
            this.locationnoDataGridViewTextBoxColumn.HeaderText = "location_no";
            this.locationnoDataGridViewTextBoxColumn.Name = "locationnoDataGridViewTextBoxColumn";
            // 
            // laneDataGridViewTextBoxColumn
            // 
            this.laneDataGridViewTextBoxColumn.DataPropertyName = "lane";
            this.laneDataGridViewTextBoxColumn.HeaderText = "lane";
            this.laneDataGridViewTextBoxColumn.Name = "laneDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // locationBindingSource1
            // 
            this.locationBindingSource1.DataMember = "Location";
            this.locationBindingSource1.DataSource = this.foodhubDataSet16;
            // 
            // foodhubDataSet16
            // 
            this.foodhubDataSet16.DataSetName = "FoodhubDataSet16";
            this.foodhubDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationTableAdapter1
            // 
            this.locationTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(861, 615);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProfileForm";
            this.Text = "Profile & History";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodhubDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodhubDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodhubDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodhubDataSet16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSearch;
        private FoodhubDataSet14 foodhubDataSet14;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private FoodhubDataSet14TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private FoodhubDataSet15 foodhubDataSet15;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private FoodhubDataSet15TableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private FoodhubDataSet16 foodhubDataSet16;
        private System.Windows.Forms.BindingSource locationBindingSource1;
        private FoodhubDataSet16TableAdapters.LocationTableAdapter locationTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private FoodhubDataSet17 foodhubDataSet17;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private FoodhubDataSet17TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatchtimeDataGridViewTextBoxColumn;

    }
}