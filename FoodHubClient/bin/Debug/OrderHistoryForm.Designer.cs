namespace FoodHubClient
{
    partial class OrderHistoryForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatchtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodhubDataSet4 = new FoodHubClient.FoodhubDataSet4();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ordersTableAdapter = new FoodHubClient.FoodhubDataSet4TableAdapters.OrdersTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodhubDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 47);
            this.button1.TabIndex = 25;
            this.button1.Text = "🔙 ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordernoDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.employeenoDataGridViewTextBoxColumn,
            this.orderdateDataGridViewTextBoxColumn,
            this.ordertimeDataGridViewTextBoxColumn,
            this.orderamountDataGridViewTextBoxColumn,
            this.paymentmethodDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.locationidDataGridViewTextBoxColumn,
            this.dispatchtimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 376);
            this.dataGridView1.TabIndex = 26;
            // 
            // ordernoDataGridViewTextBoxColumn
            // 
            this.ordernoDataGridViewTextBoxColumn.DataPropertyName = "order_no";
            this.ordernoDataGridViewTextBoxColumn.HeaderText = "order_no";
            this.ordernoDataGridViewTextBoxColumn.Name = "ordernoDataGridViewTextBoxColumn";
            this.ordernoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            // 
            // employeenoDataGridViewTextBoxColumn
            // 
            this.employeenoDataGridViewTextBoxColumn.DataPropertyName = "employee_no";
            this.employeenoDataGridViewTextBoxColumn.HeaderText = "employee_no";
            this.employeenoDataGridViewTextBoxColumn.Name = "employeenoDataGridViewTextBoxColumn";
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
            // locationidDataGridViewTextBoxColumn
            // 
            this.locationidDataGridViewTextBoxColumn.DataPropertyName = "location_id";
            this.locationidDataGridViewTextBoxColumn.HeaderText = "location_id";
            this.locationidDataGridViewTextBoxColumn.Name = "locationidDataGridViewTextBoxColumn";
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
            this.ordersBindingSource.DataSource = this.foodhubDataSet4;
            // 
            // foodhubDataSet4
            // 
            this.foodhubDataSet4.DataSetName = "FoodhubDataSet4";
            this.foodhubDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(879, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 47);
            this.button4.TabIndex = 39;
            this.button4.Text = "📉";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(879, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 47);
            this.button3.TabIndex = 38;
            this.button3.Text = "🖨";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(879, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 47);
            this.button2.TabIndex = 37;
            this.button2.Text = "🔄";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 34);
            this.label1.TabIndex = 40;
            this.label1.Text = "Order Summary";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::FoodHubClient.Properties.Resources.White___Grey_Clean_Grid_Personal_Moodboard_Photo_Collage;
            this.pictureBox1.Location = new System.Drawing.Point(392, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // OrderHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 685);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OrderHistoryForm";
            this.Text = "Order History";
            this.Load += new System.EventHandler(this.OrderHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodhubDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private FoodhubDataSet4 foodhubDataSet4;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private FoodhubDataSet4TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatchtimeDataGridViewTextBoxColumn;
    }
}