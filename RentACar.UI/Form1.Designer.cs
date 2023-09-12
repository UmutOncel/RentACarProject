namespace RentACar.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCars = new DataGridView();
            dgvCustomers = new DataGridView();
            dgvCarParks = new DataGridView();
            dgvCarParkFloors = new DataGridView();
            dgvCarCustomers = new DataGridView();
            btnCarCreate = new Button();
            btnCarUpdate = new Button();
            btnCarDelete = new Button();
            btnCustomerCreate = new Button();
            btnCustomerUpdate = new Button();
            btnCustomerDelete = new Button();
            btnCarParkCreate = new Button();
            btnCarParkUpdate = new Button();
            btnCarParkDelete = new Button();
            btnCarParkFloorCreate = new Button();
            btnCarParkFloorUpdate = new Button();
            btnCarParkFloorDelete = new Button();
            btnCarCustomerCreate = new Button();
            btnCarCustomerUpdate = new Button();
            btnCarCustomerDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCustomerFirstname = new TextBox();
            label8 = new Label();
            txtCustomerLastname = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            dtpPickUpDate = new DateTimePicker();
            label12 = new Label();
            dtpDeliveryDate = new DateTimePicker();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            cbCarModel = new ComboBox();
            nudCarParkNo = new NumericUpDown();
            nudCarkParkFloorNo = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarParks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarParkFloors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCarParkNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCarkParkFloorNo).BeginInit();
            SuspendLayout();
            // 
            // dgvCars
            // 
            dgvCars.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(8, 78);
            dgvCars.Margin = new Padding(4, 3, 4, 3);
            dgvCars.Name = "dgvCars";
            dgvCars.RowTemplate.Height = 25;
            dgvCars.Size = new Size(220, 322);
            dgvCars.TabIndex = 0;
            dgvCars.CellClick += dgvCars_CellClick;
            // 
            // dgvCustomers
            // 
            dgvCustomers.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(236, 78);
            dgvCustomers.Margin = new Padding(4, 3, 4, 3);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowTemplate.Height = 25;
            dgvCustomers.Size = new Size(220, 322);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // dgvCarParks
            // 
            dgvCarParks.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvCarParks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarParks.Location = new Point(462, 78);
            dgvCarParks.Margin = new Padding(4, 3, 4, 3);
            dgvCarParks.Name = "dgvCarParks";
            dgvCarParks.RowTemplate.Height = 25;
            dgvCarParks.Size = new Size(220, 322);
            dgvCarParks.TabIndex = 0;
            dgvCarParks.CellClick += dgvCarParks_CellClick;
            // 
            // dgvCarParkFloors
            // 
            dgvCarParkFloors.BackgroundColor = Color.FromArgb(192, 255, 255);
            dgvCarParkFloors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarParkFloors.Location = new Point(688, 78);
            dgvCarParkFloors.Margin = new Padding(4, 3, 4, 3);
            dgvCarParkFloors.Name = "dgvCarParkFloors";
            dgvCarParkFloors.RowTemplate.Height = 25;
            dgvCarParkFloors.Size = new Size(220, 322);
            dgvCarParkFloors.TabIndex = 0;
            dgvCarParkFloors.CellClick += dgvCarParkFloors_CellClick;
            // 
            // dgvCarCustomers
            // 
            dgvCarCustomers.BackgroundColor = Color.FromArgb(255, 192, 255);
            dgvCarCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarCustomers.Location = new Point(916, 78);
            dgvCarCustomers.Margin = new Padding(4, 3, 4, 3);
            dgvCarCustomers.Name = "dgvCarCustomers";
            dgvCarCustomers.RowTemplate.Height = 25;
            dgvCarCustomers.Size = new Size(220, 322);
            dgvCarCustomers.TabIndex = 0;
            dgvCarCustomers.CellClick += dgvCarCustomers_CellClick;
            // 
            // btnCarCreate
            // 
            btnCarCreate.BackColor = Color.FromArgb(192, 255, 192);
            btnCarCreate.Enabled = false;
            btnCarCreate.FlatStyle = FlatStyle.Popup;
            btnCarCreate.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarCreate.ForeColor = Color.Black;
            btnCarCreate.Location = new Point(8, 520);
            btnCarCreate.Margin = new Padding(4, 3, 4, 3);
            btnCarCreate.Name = "btnCarCreate";
            btnCarCreate.Size = new Size(94, 31);
            btnCarCreate.TabIndex = 1;
            btnCarCreate.Text = "Create";
            btnCarCreate.UseVisualStyleBackColor = false;
            btnCarCreate.Click += btnCarCreate_Click;
            // 
            // btnCarUpdate
            // 
            btnCarUpdate.BackColor = Color.FromArgb(192, 255, 192);
            btnCarUpdate.Enabled = false;
            btnCarUpdate.FlatStyle = FlatStyle.Popup;
            btnCarUpdate.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarUpdate.ForeColor = Color.Black;
            btnCarUpdate.Location = new Point(8, 557);
            btnCarUpdate.Margin = new Padding(4, 3, 4, 3);
            btnCarUpdate.Name = "btnCarUpdate";
            btnCarUpdate.Size = new Size(94, 31);
            btnCarUpdate.TabIndex = 1;
            btnCarUpdate.Text = "Update";
            btnCarUpdate.UseVisualStyleBackColor = false;
            btnCarUpdate.Click += btnCarUpdate_Click;
            // 
            // btnCarDelete
            // 
            btnCarDelete.BackColor = Color.FromArgb(192, 255, 192);
            btnCarDelete.Enabled = false;
            btnCarDelete.FlatStyle = FlatStyle.Popup;
            btnCarDelete.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarDelete.ForeColor = Color.Black;
            btnCarDelete.Location = new Point(8, 594);
            btnCarDelete.Margin = new Padding(4, 3, 4, 3);
            btnCarDelete.Name = "btnCarDelete";
            btnCarDelete.Size = new Size(94, 31);
            btnCarDelete.TabIndex = 1;
            btnCarDelete.Text = "Delete";
            btnCarDelete.UseVisualStyleBackColor = false;
            btnCarDelete.Click += btnCarDelete_Click;
            // 
            // btnCustomerCreate
            // 
            btnCustomerCreate.BackColor = Color.FromArgb(255, 224, 192);
            btnCustomerCreate.Enabled = false;
            btnCustomerCreate.FlatStyle = FlatStyle.Popup;
            btnCustomerCreate.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomerCreate.Location = new Point(236, 520);
            btnCustomerCreate.Margin = new Padding(4, 3, 4, 3);
            btnCustomerCreate.Name = "btnCustomerCreate";
            btnCustomerCreate.Size = new Size(94, 31);
            btnCustomerCreate.TabIndex = 1;
            btnCustomerCreate.Text = "Create";
            btnCustomerCreate.UseVisualStyleBackColor = false;
            btnCustomerCreate.Click += btnCustomerCreate_Click;
            // 
            // btnCustomerUpdate
            // 
            btnCustomerUpdate.BackColor = Color.FromArgb(255, 224, 192);
            btnCustomerUpdate.Enabled = false;
            btnCustomerUpdate.FlatStyle = FlatStyle.Popup;
            btnCustomerUpdate.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomerUpdate.Location = new Point(236, 557);
            btnCustomerUpdate.Margin = new Padding(4, 3, 4, 3);
            btnCustomerUpdate.Name = "btnCustomerUpdate";
            btnCustomerUpdate.Size = new Size(94, 31);
            btnCustomerUpdate.TabIndex = 1;
            btnCustomerUpdate.Text = "Update";
            btnCustomerUpdate.UseVisualStyleBackColor = false;
            btnCustomerUpdate.Click += btnCustomerUpdate_Click;
            // 
            // btnCustomerDelete
            // 
            btnCustomerDelete.BackColor = Color.FromArgb(255, 224, 192);
            btnCustomerDelete.Enabled = false;
            btnCustomerDelete.FlatStyle = FlatStyle.Popup;
            btnCustomerDelete.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomerDelete.Location = new Point(236, 594);
            btnCustomerDelete.Margin = new Padding(4, 3, 4, 3);
            btnCustomerDelete.Name = "btnCustomerDelete";
            btnCustomerDelete.Size = new Size(94, 31);
            btnCustomerDelete.TabIndex = 1;
            btnCustomerDelete.Text = "Delete";
            btnCustomerDelete.UseVisualStyleBackColor = false;
            btnCustomerDelete.Click += btnCustomerDelete_Click;
            // 
            // btnCarParkCreate
            // 
            btnCarParkCreate.BackColor = Color.FromArgb(192, 192, 255);
            btnCarParkCreate.Enabled = false;
            btnCarParkCreate.FlatStyle = FlatStyle.Popup;
            btnCarParkCreate.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarParkCreate.Location = new Point(462, 520);
            btnCarParkCreate.Margin = new Padding(4, 3, 4, 3);
            btnCarParkCreate.Name = "btnCarParkCreate";
            btnCarParkCreate.Size = new Size(94, 31);
            btnCarParkCreate.TabIndex = 1;
            btnCarParkCreate.Text = "Create";
            btnCarParkCreate.UseVisualStyleBackColor = false;
            btnCarParkCreate.Click += btnCarParkCreate_Click;
            // 
            // btnCarParkUpdate
            // 
            btnCarParkUpdate.BackColor = Color.FromArgb(192, 192, 255);
            btnCarParkUpdate.Enabled = false;
            btnCarParkUpdate.FlatStyle = FlatStyle.Popup;
            btnCarParkUpdate.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarParkUpdate.Location = new Point(462, 557);
            btnCarParkUpdate.Margin = new Padding(4, 3, 4, 3);
            btnCarParkUpdate.Name = "btnCarParkUpdate";
            btnCarParkUpdate.Size = new Size(94, 31);
            btnCarParkUpdate.TabIndex = 1;
            btnCarParkUpdate.Text = "Update";
            btnCarParkUpdate.UseVisualStyleBackColor = false;
            btnCarParkUpdate.Click += btnCarParkUpdate_Click;
            // 
            // btnCarParkDelete
            // 
            btnCarParkDelete.BackColor = Color.FromArgb(192, 192, 255);
            btnCarParkDelete.Enabled = false;
            btnCarParkDelete.FlatStyle = FlatStyle.Popup;
            btnCarParkDelete.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarParkDelete.Location = new Point(462, 594);
            btnCarParkDelete.Margin = new Padding(4, 3, 4, 3);
            btnCarParkDelete.Name = "btnCarParkDelete";
            btnCarParkDelete.Size = new Size(94, 31);
            btnCarParkDelete.TabIndex = 1;
            btnCarParkDelete.Text = "Delete";
            btnCarParkDelete.UseVisualStyleBackColor = false;
            btnCarParkDelete.Click += btnCarParkDelete_Click;
            // 
            // btnCarParkFloorCreate
            // 
            btnCarParkFloorCreate.BackColor = Color.FromArgb(192, 255, 255);
            btnCarParkFloorCreate.Enabled = false;
            btnCarParkFloorCreate.FlatStyle = FlatStyle.Popup;
            btnCarParkFloorCreate.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarParkFloorCreate.Location = new Point(690, 520);
            btnCarParkFloorCreate.Margin = new Padding(4, 3, 4, 3);
            btnCarParkFloorCreate.Name = "btnCarParkFloorCreate";
            btnCarParkFloorCreate.Size = new Size(94, 31);
            btnCarParkFloorCreate.TabIndex = 1;
            btnCarParkFloorCreate.Text = "Create";
            btnCarParkFloorCreate.UseVisualStyleBackColor = false;
            btnCarParkFloorCreate.Click += btnCarParkFloorCreate_Click;
            // 
            // btnCarParkFloorUpdate
            // 
            btnCarParkFloorUpdate.BackColor = Color.FromArgb(192, 255, 255);
            btnCarParkFloorUpdate.Enabled = false;
            btnCarParkFloorUpdate.FlatStyle = FlatStyle.Popup;
            btnCarParkFloorUpdate.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarParkFloorUpdate.Location = new Point(690, 557);
            btnCarParkFloorUpdate.Margin = new Padding(4, 3, 4, 3);
            btnCarParkFloorUpdate.Name = "btnCarParkFloorUpdate";
            btnCarParkFloorUpdate.Size = new Size(94, 31);
            btnCarParkFloorUpdate.TabIndex = 1;
            btnCarParkFloorUpdate.Text = "Update";
            btnCarParkFloorUpdate.UseVisualStyleBackColor = false;
            btnCarParkFloorUpdate.Click += btnCarParkFloorUpdate_Click;
            // 
            // btnCarParkFloorDelete
            // 
            btnCarParkFloorDelete.BackColor = Color.FromArgb(192, 255, 255);
            btnCarParkFloorDelete.Enabled = false;
            btnCarParkFloorDelete.FlatStyle = FlatStyle.Popup;
            btnCarParkFloorDelete.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarParkFloorDelete.Location = new Point(690, 594);
            btnCarParkFloorDelete.Margin = new Padding(4, 3, 4, 3);
            btnCarParkFloorDelete.Name = "btnCarParkFloorDelete";
            btnCarParkFloorDelete.Size = new Size(94, 31);
            btnCarParkFloorDelete.TabIndex = 1;
            btnCarParkFloorDelete.Text = "Delete";
            btnCarParkFloorDelete.UseVisualStyleBackColor = false;
            btnCarParkFloorDelete.Click += btnCarParkFloorDelete_Click;
            // 
            // btnCarCustomerCreate
            // 
            btnCarCustomerCreate.BackColor = Color.FromArgb(255, 192, 255);
            btnCarCustomerCreate.Enabled = false;
            btnCarCustomerCreate.FlatStyle = FlatStyle.Popup;
            btnCarCustomerCreate.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarCustomerCreate.Location = new Point(916, 520);
            btnCarCustomerCreate.Margin = new Padding(4, 3, 4, 3);
            btnCarCustomerCreate.Name = "btnCarCustomerCreate";
            btnCarCustomerCreate.Size = new Size(94, 31);
            btnCarCustomerCreate.TabIndex = 1;
            btnCarCustomerCreate.Text = "Create";
            btnCarCustomerCreate.UseVisualStyleBackColor = false;
            btnCarCustomerCreate.Click += btnCarCustomerCreate_Click;
            // 
            // btnCarCustomerUpdate
            // 
            btnCarCustomerUpdate.BackColor = Color.FromArgb(255, 192, 255);
            btnCarCustomerUpdate.Enabled = false;
            btnCarCustomerUpdate.FlatStyle = FlatStyle.Popup;
            btnCarCustomerUpdate.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarCustomerUpdate.Location = new Point(916, 557);
            btnCarCustomerUpdate.Margin = new Padding(4, 3, 4, 3);
            btnCarCustomerUpdate.Name = "btnCarCustomerUpdate";
            btnCarCustomerUpdate.Size = new Size(94, 31);
            btnCarCustomerUpdate.TabIndex = 1;
            btnCarCustomerUpdate.Text = "Update";
            btnCarCustomerUpdate.UseVisualStyleBackColor = false;
            btnCarCustomerUpdate.Click += btnCarCustomerUpdate_Click;
            // 
            // btnCarCustomerDelete
            // 
            btnCarCustomerDelete.BackColor = Color.FromArgb(255, 192, 255);
            btnCarCustomerDelete.Enabled = false;
            btnCarCustomerDelete.FlatStyle = FlatStyle.Popup;
            btnCarCustomerDelete.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarCustomerDelete.Location = new Point(916, 594);
            btnCarCustomerDelete.Margin = new Padding(4, 3, 4, 3);
            btnCarCustomerDelete.Name = "btnCarCustomerDelete";
            btnCarCustomerDelete.Size = new Size(94, 31);
            btnCarCustomerDelete.TabIndex = 1;
            btnCarCustomerDelete.Text = "Delete";
            btnCarCustomerDelete.UseVisualStyleBackColor = false;
            btnCarCustomerDelete.Click += btnCarCustomerDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 17);
            label1.TabIndex = 2;
            label1.Text = "Cars:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(238, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 2;
            label2.Text = "Customers:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(464, 58);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 2;
            label3.Text = "CarParks:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(690, 58);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 17);
            label4.TabIndex = 2;
            label4.Text = "CarParkFloors:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(916, 58);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 17);
            label5.TabIndex = 2;
            label5.Text = "CarCustomers:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 410);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 17);
            label6.TabIndex = 2;
            label6.Text = "Car Model:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(236, 410);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(131, 17);
            label7.TabIndex = 2;
            label7.Text = "Customer Firstname:";
            // 
            // txtCustomerFirstname
            // 
            txtCustomerFirstname.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtCustomerFirstname.Location = new Point(236, 428);
            txtCustomerFirstname.Margin = new Padding(4, 3, 4, 3);
            txtCustomerFirstname.Name = "txtCustomerFirstname";
            txtCustomerFirstname.Size = new Size(220, 24);
            txtCustomerFirstname.TabIndex = 3;
            txtCustomerFirstname.TextChanged += txtCustomerFirstname_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(236, 466);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(130, 17);
            label8.TabIndex = 2;
            label8.Text = "Customer Lastname:";
            // 
            // txtCustomerLastname
            // 
            txtCustomerLastname.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtCustomerLastname.Location = new Point(236, 484);
            txtCustomerLastname.Margin = new Padding(4, 3, 4, 3);
            txtCustomerLastname.Name = "txtCustomerLastname";
            txtCustomerLastname.Size = new Size(220, 24);
            txtCustomerLastname.TabIndex = 3;
            txtCustomerLastname.TextChanged += txtCustomerFirstname_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(462, 410);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(79, 17);
            label9.TabIndex = 2;
            label9.Text = "CarPark No:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(690, 410);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(108, 17);
            label10.TabIndex = 2;
            label10.Text = "CarParkFloor No:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(918, 410);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(83, 17);
            label11.TabIndex = 2;
            label11.Text = "PickUp Date:";
            // 
            // dtpPickUpDate
            // 
            dtpPickUpDate.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dtpPickUpDate.Location = new Point(916, 428);
            dtpPickUpDate.Margin = new Padding(4, 3, 4, 3);
            dtpPickUpDate.Name = "dtpPickUpDate";
            dtpPickUpDate.Size = new Size(220, 24);
            dtpPickUpDate.TabIndex = 4;
            dtpPickUpDate.ValueChanged += dtpPickUpDate_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(916, 466);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(90, 17);
            label12.TabIndex = 2;
            label12.Text = "Delivery Date:";
            // 
            // dtpDeliveryDate
            // 
            dtpDeliveryDate.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDeliveryDate.Location = new Point(916, 484);
            dtpDeliveryDate.Margin = new Padding(4, 3, 4, 3);
            dtpDeliveryDate.Name = "dtpDeliveryDate";
            dtpDeliveryDate.Size = new Size(220, 24);
            dtpDeliveryDate.TabIndex = 4;
            dtpDeliveryDate.ValueChanged += dtpPickUpDate_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Corbel", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(479, 9);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(187, 23);
            label13.TabIndex = 2;
            label13.Text = "RENT A CAR SYSTEM";
            // 
            // label14
            // 
            label14.BackColor = Color.Black;
            label14.Location = new Point(231, 42);
            label14.Name = "label14";
            label14.Size = new Size(2, 590);
            label14.TabIndex = 5;
            // 
            // label15
            // 
            label15.BackColor = Color.Black;
            label15.Location = new Point(458, 42);
            label15.Name = "label15";
            label15.Size = new Size(2, 590);
            label15.TabIndex = 5;
            // 
            // label16
            // 
            label16.BackColor = Color.Black;
            label16.Location = new Point(684, 42);
            label16.Name = "label16";
            label16.Size = new Size(2, 590);
            label16.TabIndex = 5;
            // 
            // label17
            // 
            label17.BackColor = Color.Black;
            label17.Location = new Point(911, 42);
            label17.Name = "label17";
            label17.Size = new Size(2, 590);
            label17.TabIndex = 5;
            // 
            // label18
            // 
            label18.BackColor = Color.Black;
            label18.Location = new Point(1140, 42);
            label18.Name = "label18";
            label18.Size = new Size(2, 590);
            label18.TabIndex = 5;
            // 
            // label19
            // 
            label19.BackColor = Color.Black;
            label19.Location = new Point(3, 42);
            label19.Name = "label19";
            label19.Size = new Size(2, 590);
            label19.TabIndex = 5;
            // 
            // label20
            // 
            label20.BackColor = Color.Black;
            label20.Location = new Point(3, 40);
            label20.Name = "label20";
            label20.Size = new Size(1139, 2);
            label20.TabIndex = 5;
            // 
            // label21
            // 
            label21.BackColor = Color.Black;
            label21.Location = new Point(3, 403);
            label21.Name = "label21";
            label21.Size = new Size(1139, 2);
            label21.TabIndex = 5;
            // 
            // label22
            // 
            label22.BackColor = Color.Black;
            label22.Location = new Point(3, 630);
            label22.Name = "label22";
            label22.Size = new Size(1139, 2);
            label22.TabIndex = 5;
            // 
            // cbCarModel
            // 
            cbCarModel.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cbCarModel.FormattingEnabled = true;
            cbCarModel.Location = new Point(8, 428);
            cbCarModel.Name = "cbCarModel";
            cbCarModel.Size = new Size(220, 23);
            cbCarModel.TabIndex = 6;
            cbCarModel.SelectedIndexChanged += cbCarModel_SelectedIndexChanged;
            // 
            // nudCarParkNo
            // 
            nudCarParkNo.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            nudCarParkNo.Location = new Point(462, 429);
            nudCarParkNo.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCarParkNo.Name = "nudCarParkNo";
            nudCarParkNo.Size = new Size(220, 24);
            nudCarParkNo.TabIndex = 7;
            nudCarParkNo.ValueChanged += nudCarParkNo_ValueChanged;
            // 
            // nudCarkParkFloorNo
            // 
            nudCarkParkFloorNo.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            nudCarkParkFloorNo.Location = new Point(688, 429);
            nudCarkParkFloorNo.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCarkParkFloorNo.Name = "nudCarkParkFloorNo";
            nudCarkParkFloorNo.Size = new Size(220, 24);
            nudCarkParkFloorNo.TabIndex = 7;
            nudCarkParkFloorNo.ValueChanged += nudCarkParkFloorNo_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1147, 641);
            Controls.Add(nudCarkParkFloorNo);
            Controls.Add(nudCarParkNo);
            Controls.Add(cbCarModel);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(dtpDeliveryDate);
            Controls.Add(dtpPickUpDate);
            Controls.Add(txtCustomerLastname);
            Controls.Add(txtCustomerFirstname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label13);
            Controls.Add(label1);
            Controls.Add(btnCarCustomerDelete);
            Controls.Add(btnCarParkFloorDelete);
            Controls.Add(btnCarParkDelete);
            Controls.Add(btnCustomerDelete);
            Controls.Add(btnCarDelete);
            Controls.Add(btnCarCustomerUpdate);
            Controls.Add(btnCarParkFloorUpdate);
            Controls.Add(btnCarParkUpdate);
            Controls.Add(btnCustomerUpdate);
            Controls.Add(btnCarUpdate);
            Controls.Add(btnCarCustomerCreate);
            Controls.Add(btnCarParkFloorCreate);
            Controls.Add(btnCarParkCreate);
            Controls.Add(btnCustomerCreate);
            Controls.Add(btnCarCreate);
            Controls.Add(dgvCarCustomers);
            Controls.Add(dgvCarParkFloors);
            Controls.Add(dgvCarParks);
            Controls.Add(dgvCustomers);
            Controls.Add(dgvCars);
            Font = new Font("Corbel", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RentACarApp";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarParks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarParkFloors).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCarParkNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCarkParkFloorNo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCars;
        private DataGridView dgvCustomers;
        private DataGridView dgvCarParks;
        private DataGridView dgvCarParkFloors;
        private DataGridView dgvCarCustomers;
        private Button btnCarCreate;
        private Button btnCarUpdate;
        private Button btnCarDelete;
        private Button btnCustomerCreate;
        private Button btnCustomerUpdate;
        private Button btnCustomerDelete;
        private Button btnCarParkCreate;
        private Button btnCarParkUpdate;
        private Button btnCarParkDelete;
        private Button btnCarParkFloorCreate;
        private Button btnCarParkFloorUpdate;
        private Button btnCarParkFloorDelete;
        private Button btnCarCustomerCreate;
        private Button btnCarCustomerUpdate;
        private Button btnCarCustomerDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCustomerFirstname;
        private Label label8;
        private TextBox txtCustomerLastname;
        private Label label9;
        private Label label10;
        private Label label11;
        private DateTimePicker dtpPickUpDate;
        private Label label12;
        private DateTimePicker dtpDeliveryDate;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private ComboBox cbCarModel;
        private NumericUpDown nudCarParkNo;
        private NumericUpDown nudCarkParkFloorNo;
    }
}