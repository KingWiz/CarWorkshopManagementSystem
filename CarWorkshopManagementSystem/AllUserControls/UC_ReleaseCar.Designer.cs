
namespace CarWorkshopManagementSystem.AllUserControls
{
    partial class UC_ReleaseCar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReleaseCar = new System.Windows.Forms.DataGridView();
            this.carModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carAssignedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carProblem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCarNumber = new System.Windows.Forms.Label();
            this.lblCarColor = new System.Windows.Forms.Label();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.txbCarType = new System.Windows.Forms.TextBox();
            this.txbCarColor = new System.Windows.Forms.TextBox();
            this.txbCarNumber = new System.Windows.Forms.TextBox();
            this.txbCarModel = new System.Windows.Forms.TextBox();
            this.txbCarAssignedDate = new System.Windows.Forms.TextBox();
            this.txbCarReleaseDate = new System.Windows.Forms.TextBox();
            this.txbCarStatus = new System.Windows.Forms.TextBox();
            this.lblCarAssignedDate = new System.Windows.Forms.Label();
            this.lblCarReleaseDate = new System.Windows.Forms.Label();
            this.lblCarStatus = new System.Windows.Forms.Label();
            this.lblCarProblem = new System.Windows.Forms.Label();
            this.txbCarProblem = new System.Windows.Forms.TextBox();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblCuPhoneNo = new System.Windows.Forms.Label();
            this.lblCuEmail = new System.Windows.Forms.Label();
            this.lblCuGender = new System.Windows.Forms.Label();
            this.lblCuName = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txbCuGender = new System.Windows.Forms.TextBox();
            this.txbCuEmail = new System.Windows.Forms.TextBox();
            this.txbCuPhoneNo = new System.Windows.Forms.TextBox();
            this.txbCuName = new System.Windows.Forms.TextBox();
            this.txbCuAddress = new System.Windows.Forms.TextBox();
            this.txbCuCity = new System.Windows.Forms.TextBox();
            this.lblCuAddress = new System.Windows.Forms.Label();
            this.lblCuCity = new System.Windows.Forms.Label();
            this.lblCuState = new System.Windows.Forms.Label();
            this.tlpReleaseDetails = new System.Windows.Forms.TableLayoutPanel();
            this.txbCuState = new System.Windows.Forms.TextBox();
            this.kryptonBtnRelease = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReleaseCar)).BeginInit();
            this.tlpReleaseDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReleaseCar
            // 
            this.dgvReleaseCar.AllowUserToDeleteRows = false;
            this.dgvReleaseCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReleaseCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReleaseCar.BackgroundColor = System.Drawing.Color.Indigo;
            this.dgvReleaseCar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReleaseCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReleaseCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReleaseCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carModel,
            this.carNumber,
            this.carColor,
            this.carType,
            this.carAssignedDate,
            this.carReleaseDate,
            this.carStatus,
            this.carProblem,
            this.cuName,
            this.cuPhoneNo,
            this.cuAddress});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReleaseCar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReleaseCar.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvReleaseCar.Location = new System.Drawing.Point(29, 8);
            this.dgvReleaseCar.Name = "dgvReleaseCar";
            this.dgvReleaseCar.ReadOnly = true;
            this.dgvReleaseCar.Size = new System.Drawing.Size(749, 173);
            this.dgvReleaseCar.TabIndex = 1;
            // 
            // carModel
            // 
            this.carModel.HeaderText = "Model";
            this.carModel.Name = "carModel";
            this.carModel.ReadOnly = true;
            // 
            // carNumber
            // 
            this.carNumber.HeaderText = "Number";
            this.carNumber.Name = "carNumber";
            this.carNumber.ReadOnly = true;
            // 
            // carColor
            // 
            this.carColor.HeaderText = "Color";
            this.carColor.Name = "carColor";
            this.carColor.ReadOnly = true;
            // 
            // carType
            // 
            this.carType.HeaderText = "Type";
            this.carType.Name = "carType";
            this.carType.ReadOnly = true;
            // 
            // carAssignedDate
            // 
            this.carAssignedDate.HeaderText = "Assigned Date";
            this.carAssignedDate.Name = "carAssignedDate";
            this.carAssignedDate.ReadOnly = true;
            // 
            // carReleaseDate
            // 
            this.carReleaseDate.HeaderText = "Release Date";
            this.carReleaseDate.Name = "carReleaseDate";
            this.carReleaseDate.ReadOnly = true;
            // 
            // carStatus
            // 
            this.carStatus.HeaderText = "Status";
            this.carStatus.Name = "carStatus";
            this.carStatus.ReadOnly = true;
            // 
            // carProblem
            // 
            this.carProblem.HeaderText = "Problem";
            this.carProblem.Name = "carProblem";
            this.carProblem.ReadOnly = true;
            // 
            // cuName
            // 
            this.cuName.HeaderText = "Customer Name";
            this.cuName.Name = "cuName";
            this.cuName.ReadOnly = true;
            // 
            // cuPhoneNo
            // 
            this.cuPhoneNo.HeaderText = "Phone No.";
            this.cuPhoneNo.Name = "cuPhoneNo";
            this.cuPhoneNo.ReadOnly = true;
            // 
            // cuAddress
            // 
            this.cuAddress.HeaderText = "Address";
            this.cuAddress.Name = "cuAddress";
            this.cuAddress.ReadOnly = true;
            // 
            // lblCarNumber
            // 
            this.lblCarNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCarNumber.AutoSize = true;
            this.lblCarNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCarNumber.Location = new System.Drawing.Point(257, 55);
            this.lblCarNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarNumber.Name = "lblCarNumber";
            this.lblCarNumber.Size = new System.Drawing.Size(58, 15);
            this.lblCarNumber.TabIndex = 55;
            this.lblCarNumber.Text = "Number";
            // 
            // lblCarColor
            // 
            this.lblCarColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCarColor.AutoSize = true;
            this.lblCarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarColor.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCarColor.Location = new System.Drawing.Point(510, 55);
            this.lblCarColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarColor.Name = "lblCarColor";
            this.lblCarColor.Size = new System.Drawing.Size(41, 15);
            this.lblCarColor.TabIndex = 59;
            this.lblCarColor.Text = "Color";
            // 
            // lblCarType
            // 
            this.lblCarType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCarType.AutoSize = true;
            this.lblCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarType.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCarType.Location = new System.Drawing.Point(4, 93);
            this.lblCarType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(37, 15);
            this.lblCarType.TabIndex = 60;
            this.lblCarType.Text = "Type";
            // 
            // lblCarModel
            // 
            this.lblCarModel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModel.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCarModel.Location = new System.Drawing.Point(4, 55);
            this.lblCarModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(47, 15);
            this.lblCarModel.TabIndex = 53;
            this.lblCarModel.Text = "Model";
            // 
            // txbCarType
            // 
            this.txbCarType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCarType.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCarType.ForeColor = System.Drawing.Color.Indigo;
            this.txbCarType.Location = new System.Drawing.Point(138, 91);
            this.txbCarType.Margin = new System.Windows.Forms.Padding(4);
            this.txbCarType.Name = "txbCarType";
            this.txbCarType.ReadOnly = true;
            this.txbCarType.Size = new System.Drawing.Size(111, 20);
            this.txbCarType.TabIndex = 50;
            // 
            // txbCarColor
            // 
            this.txbCarColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCarColor.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCarColor.ForeColor = System.Drawing.Color.Indigo;
            this.txbCarColor.Location = new System.Drawing.Point(629, 53);
            this.txbCarColor.Margin = new System.Windows.Forms.Padding(4);
            this.txbCarColor.Name = "txbCarColor";
            this.txbCarColor.ReadOnly = true;
            this.txbCarColor.Size = new System.Drawing.Size(116, 20);
            this.txbCarColor.TabIndex = 49;
            // 
            // txbCarNumber
            // 
            this.txbCarNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCarNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCarNumber.ForeColor = System.Drawing.Color.Indigo;
            this.txbCarNumber.Location = new System.Drawing.Point(391, 53);
            this.txbCarNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txbCarNumber.Name = "txbCarNumber";
            this.txbCarNumber.ReadOnly = true;
            this.txbCarNumber.Size = new System.Drawing.Size(111, 20);
            this.txbCarNumber.TabIndex = 48;
            // 
            // txbCarModel
            // 
            this.txbCarModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCarModel.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCarModel.ForeColor = System.Drawing.Color.Indigo;
            this.txbCarModel.Location = new System.Drawing.Point(138, 53);
            this.txbCarModel.Margin = new System.Windows.Forms.Padding(4);
            this.txbCarModel.Name = "txbCarModel";
            this.txbCarModel.ReadOnly = true;
            this.txbCarModel.Size = new System.Drawing.Size(111, 20);
            this.txbCarModel.TabIndex = 46;
            // 
            // txbCarAssignedDate
            // 
            this.txbCarAssignedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCarAssignedDate.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCarAssignedDate.ForeColor = System.Drawing.Color.Indigo;
            this.txbCarAssignedDate.Location = new System.Drawing.Point(138, 129);
            this.txbCarAssignedDate.Margin = new System.Windows.Forms.Padding(4);
            this.txbCarAssignedDate.Name = "txbCarAssignedDate";
            this.txbCarAssignedDate.ReadOnly = true;
            this.txbCarAssignedDate.Size = new System.Drawing.Size(111, 20);
            this.txbCarAssignedDate.TabIndex = 47;
            // 
            // txbCarReleaseDate
            // 
            this.txbCarReleaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCarReleaseDate.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCarReleaseDate.ForeColor = System.Drawing.Color.Indigo;
            this.txbCarReleaseDate.Location = new System.Drawing.Point(391, 129);
            this.txbCarReleaseDate.Margin = new System.Windows.Forms.Padding(4);
            this.txbCarReleaseDate.Name = "txbCarReleaseDate";
            this.txbCarReleaseDate.Size = new System.Drawing.Size(111, 20);
            this.txbCarReleaseDate.TabIndex = 51;
            // 
            // txbCarStatus
            // 
            this.txbCarStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCarStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCarStatus.ForeColor = System.Drawing.Color.Indigo;
            this.txbCarStatus.Location = new System.Drawing.Point(391, 91);
            this.txbCarStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txbCarStatus.Name = "txbCarStatus";
            this.txbCarStatus.ReadOnly = true;
            this.txbCarStatus.Size = new System.Drawing.Size(111, 20);
            this.txbCarStatus.TabIndex = 52;
            // 
            // lblCarAssignedDate
            // 
            this.lblCarAssignedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCarAssignedDate.AutoSize = true;
            this.lblCarAssignedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarAssignedDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCarAssignedDate.Location = new System.Drawing.Point(4, 131);
            this.lblCarAssignedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarAssignedDate.Name = "lblCarAssignedDate";
            this.lblCarAssignedDate.Size = new System.Drawing.Size(99, 15);
            this.lblCarAssignedDate.TabIndex = 54;
            this.lblCarAssignedDate.Text = "Assigned Date";
            // 
            // lblCarReleaseDate
            // 
            this.lblCarReleaseDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCarReleaseDate.AutoSize = true;
            this.lblCarReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarReleaseDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCarReleaseDate.Location = new System.Drawing.Point(257, 131);
            this.lblCarReleaseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarReleaseDate.Name = "lblCarReleaseDate";
            this.lblCarReleaseDate.Size = new System.Drawing.Size(94, 15);
            this.lblCarReleaseDate.TabIndex = 56;
            this.lblCarReleaseDate.Text = "Release Date";
            // 
            // lblCarStatus
            // 
            this.lblCarStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCarStatus.AutoSize = true;
            this.lblCarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCarStatus.Location = new System.Drawing.Point(257, 93);
            this.lblCarStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarStatus.Name = "lblCarStatus";
            this.lblCarStatus.Size = new System.Drawing.Size(47, 15);
            this.lblCarStatus.TabIndex = 57;
            this.lblCarStatus.Text = "Status";
            // 
            // lblCarProblem
            // 
            this.lblCarProblem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCarProblem.AutoSize = true;
            this.lblCarProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarProblem.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCarProblem.Location = new System.Drawing.Point(510, 93);
            this.lblCarProblem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarProblem.Name = "lblCarProblem";
            this.lblCarProblem.Size = new System.Drawing.Size(61, 15);
            this.lblCarProblem.TabIndex = 58;
            this.lblCarProblem.Text = "Problem";
            // 
            // txbCarProblem
            // 
            this.txbCarProblem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCarProblem.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCarProblem.ForeColor = System.Drawing.Color.Indigo;
            this.txbCarProblem.Location = new System.Drawing.Point(628, 91);
            this.txbCarProblem.Name = "txbCarProblem";
            this.txbCarProblem.ReadOnly = true;
            this.txbCarProblem.Size = new System.Drawing.Size(118, 20);
            this.txbCarProblem.TabIndex = 61;
            // 
            // lblCar
            // 
            this.lblCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCar.AutoSize = true;
            this.lblCar.BackColor = System.Drawing.Color.Transparent;
            this.lblCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(100)))));
            this.lblCar.Location = new System.Drawing.Point(3, 10);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(128, 24);
            this.lblCar.TabIndex = 62;
            this.lblCar.Text = "Car";
            // 
            // lblCuPhoneNo
            // 
            this.lblCuPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuPhoneNo.AutoSize = true;
            this.lblCuPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuPhoneNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCuPhoneNo.Location = new System.Drawing.Point(257, 213);
            this.lblCuPhoneNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuPhoneNo.Name = "lblCuPhoneNo";
            this.lblCuPhoneNo.Size = new System.Drawing.Size(70, 15);
            this.lblCuPhoneNo.TabIndex = 73;
            this.lblCuPhoneNo.Text = "Phone No";
            // 
            // lblCuEmail
            // 
            this.lblCuEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuEmail.AutoSize = true;
            this.lblCuEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCuEmail.Location = new System.Drawing.Point(510, 213);
            this.lblCuEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuEmail.Name = "lblCuEmail";
            this.lblCuEmail.Size = new System.Drawing.Size(44, 15);
            this.lblCuEmail.TabIndex = 77;
            this.lblCuEmail.Text = "Email";
            // 
            // lblCuGender
            // 
            this.lblCuGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuGender.AutoSize = true;
            this.lblCuGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuGender.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCuGender.Location = new System.Drawing.Point(4, 251);
            this.lblCuGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuGender.Name = "lblCuGender";
            this.lblCuGender.Size = new System.Drawing.Size(54, 15);
            this.lblCuGender.TabIndex = 78;
            this.lblCuGender.Text = "Gender";
            // 
            // lblCuName
            // 
            this.lblCuName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuName.AutoSize = true;
            this.lblCuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCuName.Location = new System.Drawing.Point(4, 213);
            this.lblCuName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuName.Name = "lblCuName";
            this.lblCuName.Size = new System.Drawing.Size(45, 15);
            this.lblCuName.TabIndex = 71;
            this.lblCuName.Text = "Name";
            // 
            // lblCustomer
            // 
            this.lblCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(100)))));
            this.lblCustomer.Location = new System.Drawing.Point(3, 168);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(128, 24);
            this.lblCustomer.TabIndex = 79;
            this.lblCustomer.Text = "Customer";
            // 
            // txbCuGender
            // 
            this.txbCuGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCuGender.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCuGender.ForeColor = System.Drawing.Color.Indigo;
            this.txbCuGender.Location = new System.Drawing.Point(138, 249);
            this.txbCuGender.Margin = new System.Windows.Forms.Padding(4);
            this.txbCuGender.Name = "txbCuGender";
            this.txbCuGender.ReadOnly = true;
            this.txbCuGender.Size = new System.Drawing.Size(111, 20);
            this.txbCuGender.TabIndex = 67;
            // 
            // txbCuEmail
            // 
            this.txbCuEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCuEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCuEmail.ForeColor = System.Drawing.Color.Indigo;
            this.txbCuEmail.Location = new System.Drawing.Point(629, 211);
            this.txbCuEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbCuEmail.Name = "txbCuEmail";
            this.txbCuEmail.ReadOnly = true;
            this.txbCuEmail.Size = new System.Drawing.Size(116, 20);
            this.txbCuEmail.TabIndex = 66;
            // 
            // txbCuPhoneNo
            // 
            this.txbCuPhoneNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCuPhoneNo.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCuPhoneNo.ForeColor = System.Drawing.Color.Indigo;
            this.txbCuPhoneNo.Location = new System.Drawing.Point(391, 211);
            this.txbCuPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txbCuPhoneNo.Name = "txbCuPhoneNo";
            this.txbCuPhoneNo.ReadOnly = true;
            this.txbCuPhoneNo.Size = new System.Drawing.Size(111, 20);
            this.txbCuPhoneNo.TabIndex = 65;
            // 
            // txbCuName
            // 
            this.txbCuName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCuName.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCuName.ForeColor = System.Drawing.Color.Indigo;
            this.txbCuName.Location = new System.Drawing.Point(138, 211);
            this.txbCuName.Margin = new System.Windows.Forms.Padding(4);
            this.txbCuName.Name = "txbCuName";
            this.txbCuName.ReadOnly = true;
            this.txbCuName.Size = new System.Drawing.Size(111, 20);
            this.txbCuName.TabIndex = 63;
            // 
            // txbCuAddress
            // 
            this.txbCuAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCuAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCuAddress.ForeColor = System.Drawing.Color.Indigo;
            this.txbCuAddress.Location = new System.Drawing.Point(391, 249);
            this.txbCuAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txbCuAddress.Name = "txbCuAddress";
            this.txbCuAddress.ReadOnly = true;
            this.txbCuAddress.Size = new System.Drawing.Size(111, 20);
            this.txbCuAddress.TabIndex = 68;
            // 
            // txbCuCity
            // 
            this.txbCuCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCuCity.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCuCity.ForeColor = System.Drawing.Color.Indigo;
            this.txbCuCity.Location = new System.Drawing.Point(629, 249);
            this.txbCuCity.Margin = new System.Windows.Forms.Padding(4);
            this.txbCuCity.Name = "txbCuCity";
            this.txbCuCity.ReadOnly = true;
            this.txbCuCity.Size = new System.Drawing.Size(116, 20);
            this.txbCuCity.TabIndex = 69;
            // 
            // lblCuAddress
            // 
            this.lblCuAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuAddress.AutoSize = true;
            this.lblCuAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuAddress.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCuAddress.Location = new System.Drawing.Point(257, 251);
            this.lblCuAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuAddress.Name = "lblCuAddress";
            this.lblCuAddress.Size = new System.Drawing.Size(58, 15);
            this.lblCuAddress.TabIndex = 74;
            this.lblCuAddress.Text = "Address";
            // 
            // lblCuCity
            // 
            this.lblCuCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuCity.AutoSize = true;
            this.lblCuCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuCity.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCuCity.Location = new System.Drawing.Point(510, 251);
            this.lblCuCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuCity.Name = "lblCuCity";
            this.lblCuCity.Size = new System.Drawing.Size(30, 15);
            this.lblCuCity.TabIndex = 75;
            this.lblCuCity.Text = "City";
            // 
            // lblCuState
            // 
            this.lblCuState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuState.AutoSize = true;
            this.lblCuState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuState.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCuState.Location = new System.Drawing.Point(4, 290);
            this.lblCuState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuState.Name = "lblCuState";
            this.lblCuState.Size = new System.Drawing.Size(40, 15);
            this.lblCuState.TabIndex = 76;
            this.lblCuState.Text = "State";
            // 
            // tlpReleaseDetails
            // 
            this.tlpReleaseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpReleaseDetails.ColumnCount = 6;
            this.tlpReleaseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpReleaseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpReleaseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpReleaseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpReleaseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpReleaseDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpReleaseDetails.Controls.Add(this.txbCuState, 1, 7);
            this.tlpReleaseDetails.Controls.Add(this.lblCar, 0, 0);
            this.tlpReleaseDetails.Controls.Add(this.txbCuGender, 1, 6);
            this.tlpReleaseDetails.Controls.Add(this.lblCustomer, 0, 4);
            this.tlpReleaseDetails.Controls.Add(this.txbCuCity, 5, 6);
            this.tlpReleaseDetails.Controls.Add(this.txbCuAddress, 3, 6);
            this.tlpReleaseDetails.Controls.Add(this.lblCuState, 0, 7);
            this.tlpReleaseDetails.Controls.Add(this.lblCuEmail, 4, 5);
            this.tlpReleaseDetails.Controls.Add(this.lblCuPhoneNo, 2, 5);
            this.tlpReleaseDetails.Controls.Add(this.lblCuCity, 4, 6);
            this.tlpReleaseDetails.Controls.Add(this.txbCuEmail, 5, 5);
            this.tlpReleaseDetails.Controls.Add(this.lblCarModel, 0, 1);
            this.tlpReleaseDetails.Controls.Add(this.lblCuAddress, 2, 6);
            this.tlpReleaseDetails.Controls.Add(this.txbCarModel, 1, 1);
            this.tlpReleaseDetails.Controls.Add(this.lblCarNumber, 2, 1);
            this.tlpReleaseDetails.Controls.Add(this.txbCuPhoneNo, 3, 5);
            this.tlpReleaseDetails.Controls.Add(this.txbCarNumber, 3, 1);
            this.tlpReleaseDetails.Controls.Add(this.lblCarColor, 4, 1);
            this.tlpReleaseDetails.Controls.Add(this.txbCuName, 1, 5);
            this.tlpReleaseDetails.Controls.Add(this.txbCarColor, 5, 1);
            this.tlpReleaseDetails.Controls.Add(this.lblCarType, 0, 2);
            this.tlpReleaseDetails.Controls.Add(this.txbCarType, 1, 2);
            this.tlpReleaseDetails.Controls.Add(this.txbCarStatus, 3, 2);
            this.tlpReleaseDetails.Controls.Add(this.lblCarStatus, 2, 2);
            this.tlpReleaseDetails.Controls.Add(this.txbCarProblem, 5, 2);
            this.tlpReleaseDetails.Controls.Add(this.txbCarAssignedDate, 1, 3);
            this.tlpReleaseDetails.Controls.Add(this.lblCarProblem, 4, 2);
            this.tlpReleaseDetails.Controls.Add(this.lblCarAssignedDate, 0, 3);
            this.tlpReleaseDetails.Controls.Add(this.lblCarReleaseDate, 2, 3);
            this.tlpReleaseDetails.Controls.Add(this.txbCarReleaseDate, 3, 3);
            this.tlpReleaseDetails.Controls.Add(this.lblCuName, 0, 5);
            this.tlpReleaseDetails.Controls.Add(this.lblCuGender, 0, 6);
            this.tlpReleaseDetails.Location = new System.Drawing.Point(29, 200);
            this.tlpReleaseDetails.Name = "tlpReleaseDetails";
            this.tlpReleaseDetails.RowCount = 8;
            this.tlpReleaseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpReleaseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpReleaseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpReleaseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpReleaseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpReleaseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpReleaseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpReleaseDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpReleaseDetails.Size = new System.Drawing.Size(749, 318);
            this.tlpReleaseDetails.TabIndex = 80;
            // 
            // txbCuState
            // 
            this.txbCuState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCuState.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCuState.ForeColor = System.Drawing.Color.Indigo;
            this.txbCuState.Location = new System.Drawing.Point(138, 288);
            this.txbCuState.Margin = new System.Windows.Forms.Padding(4);
            this.txbCuState.Name = "txbCuState";
            this.txbCuState.ReadOnly = true;
            this.txbCuState.Size = new System.Drawing.Size(111, 20);
            this.txbCuState.TabIndex = 82;
            // 
            // kryptonBtnRelease
            // 
            this.kryptonBtnRelease.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonBtnRelease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonBtnRelease.Location = new System.Drawing.Point(346, 564);
            this.kryptonBtnRelease.Name = "kryptonBtnRelease";
            this.kryptonBtnRelease.Size = new System.Drawing.Size(134, 36);
            this.kryptonBtnRelease.StateCommon.Back.Color1 = System.Drawing.Color.Indigo;
            this.kryptonBtnRelease.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(55)))));
            this.kryptonBtnRelease.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(100)))));
            this.kryptonBtnRelease.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(100)))));
            this.kryptonBtnRelease.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnRelease.StateCommon.Border.Rounding = 10;
            this.kryptonBtnRelease.StateCommon.Border.Width = 2;
            this.kryptonBtnRelease.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonBtnRelease.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonBtnRelease.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonBtnRelease.TabIndex = 81;
            this.kryptonBtnRelease.Values.Text = "Release";
            // 
            // UC_ReleaseCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Indigo;
            this.Controls.Add(this.kryptonBtnRelease);
            this.Controls.Add(this.tlpReleaseDetails);
            this.Controls.Add(this.dgvReleaseCar);
            this.Name = "UC_ReleaseCar";
            this.Size = new System.Drawing.Size(807, 468);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReleaseCar)).EndInit();
            this.tlpReleaseDetails.ResumeLayout(false);
            this.tlpReleaseDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReleaseCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn carColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn carType;
        private System.Windows.Forms.DataGridViewTextBoxColumn carAssignedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn carReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn carStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn carProblem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuAddress;
        private System.Windows.Forms.Label lblCarNumber;
        private System.Windows.Forms.Label lblCarColor;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.TextBox txbCarType;
        private System.Windows.Forms.TextBox txbCarColor;
        private System.Windows.Forms.TextBox txbCarNumber;
        private System.Windows.Forms.TextBox txbCarModel;
        private System.Windows.Forms.TextBox txbCarAssignedDate;
        private System.Windows.Forms.TextBox txbCarReleaseDate;
        private System.Windows.Forms.TextBox txbCarStatus;
        private System.Windows.Forms.Label lblCarAssignedDate;
        private System.Windows.Forms.Label lblCarReleaseDate;
        private System.Windows.Forms.Label lblCarStatus;
        private System.Windows.Forms.Label lblCarProblem;
        private System.Windows.Forms.TextBox txbCarProblem;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblCuPhoneNo;
        private System.Windows.Forms.Label lblCuEmail;
        private System.Windows.Forms.Label lblCuGender;
        private System.Windows.Forms.Label lblCuName;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txbCuGender;
        private System.Windows.Forms.TextBox txbCuEmail;
        private System.Windows.Forms.TextBox txbCuPhoneNo;
        private System.Windows.Forms.TextBox txbCuName;
        private System.Windows.Forms.TextBox txbCuAddress;
        private System.Windows.Forms.TextBox txbCuCity;
        private System.Windows.Forms.Label lblCuAddress;
        private System.Windows.Forms.Label lblCuCity;
        private System.Windows.Forms.Label lblCuState;
        private System.Windows.Forms.TableLayoutPanel tlpReleaseDetails;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonBtnRelease;
        private System.Windows.Forms.TextBox txbCuState;
    }
}
