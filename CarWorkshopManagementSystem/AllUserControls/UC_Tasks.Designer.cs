
namespace CarWorkshopManagementSystem.AllUserControls
{
    partial class UC_Tasks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvToDo = new System.Windows.Forms.DataGridView();
            this.carModelTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumberTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carColorTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTypeTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carAssignedDateTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carReleaseDateTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carStatusTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carProblemTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDoing = new System.Windows.Forms.DataGridView();
            this.carModelDoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumberDoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carColorDoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTypeDoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carAssignedDateDoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carReleaseDateDoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carStatusDoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carProblemDoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDone = new System.Windows.Forms.DataGridView();
            this.carModelDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumberDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carColorDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTypeDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carAssignedDateDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carReleaseDateDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carStatusDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carProblemDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblToDo = new System.Windows.Forms.Label();
            this.lblDoing = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.kryptonSeparatorDoing = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.kryptonSeparatorDone = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.kryptonSeparatorTD = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparatorDoing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparatorDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparatorTD)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvToDo
            // 
            this.dgvToDo.AllowUserToDeleteRows = false;
            this.dgvToDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvToDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToDo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(55)))));
            this.dgvToDo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvToDo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carModelTD,
            this.carNumberTD,
            this.carColorTD,
            this.carTypeTD,
            this.carAssignedDateTD,
            this.carReleaseDateTD,
            this.carStatusTD,
            this.carProblemTD});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvToDo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvToDo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(55)))));
            this.dgvToDo.Location = new System.Drawing.Point(13, 36);
            this.dgvToDo.Name = "dgvToDo";
            this.dgvToDo.ReadOnly = true;
            this.dgvToDo.Size = new System.Drawing.Size(781, 177);
            this.dgvToDo.TabIndex = 0;
            // 
            // carModelTD
            // 
            this.carModelTD.HeaderText = "Model";
            this.carModelTD.Name = "carModelTD";
            this.carModelTD.ReadOnly = true;
            // 
            // carNumberTD
            // 
            this.carNumberTD.HeaderText = "Number";
            this.carNumberTD.Name = "carNumberTD";
            this.carNumberTD.ReadOnly = true;
            // 
            // carColorTD
            // 
            this.carColorTD.HeaderText = "Color";
            this.carColorTD.Name = "carColorTD";
            this.carColorTD.ReadOnly = true;
            // 
            // carTypeTD
            // 
            this.carTypeTD.HeaderText = "Type";
            this.carTypeTD.Name = "carTypeTD";
            this.carTypeTD.ReadOnly = true;
            // 
            // carAssignedDateTD
            // 
            this.carAssignedDateTD.HeaderText = "Assigned Date";
            this.carAssignedDateTD.Name = "carAssignedDateTD";
            this.carAssignedDateTD.ReadOnly = true;
            // 
            // carReleaseDateTD
            // 
            this.carReleaseDateTD.HeaderText = "Release Date";
            this.carReleaseDateTD.Name = "carReleaseDateTD";
            this.carReleaseDateTD.ReadOnly = true;
            // 
            // carStatusTD
            // 
            this.carStatusTD.HeaderText = "Status";
            this.carStatusTD.Name = "carStatusTD";
            this.carStatusTD.ReadOnly = true;
            // 
            // carProblemTD
            // 
            this.carProblemTD.HeaderText = "Problem";
            this.carProblemTD.Name = "carProblemTD";
            this.carProblemTD.ReadOnly = true;
            // 
            // dgvDoing
            // 
            this.dgvDoing.AllowUserToDeleteRows = false;
            this.dgvDoing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoing.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(55)))));
            this.dgvDoing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDoing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carModelDoing,
            this.carNumberDoing,
            this.carColorDoing,
            this.carTypeDoing,
            this.carAssignedDateDoing,
            this.carReleaseDateDoing,
            this.carStatusDoing,
            this.carProblemDoing});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoing.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoing.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(55)))));
            this.dgvDoing.Location = new System.Drawing.Point(13, 256);
            this.dgvDoing.Name = "dgvDoing";
            this.dgvDoing.ReadOnly = true;
            this.dgvDoing.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(10)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoing.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDoing.Size = new System.Drawing.Size(781, 173);
            this.dgvDoing.TabIndex = 1;
            // 
            // carModelDoing
            // 
            this.carModelDoing.HeaderText = "Model";
            this.carModelDoing.Name = "carModelDoing";
            this.carModelDoing.ReadOnly = true;
            // 
            // carNumberDoing
            // 
            this.carNumberDoing.HeaderText = "Number";
            this.carNumberDoing.Name = "carNumberDoing";
            this.carNumberDoing.ReadOnly = true;
            // 
            // carColorDoing
            // 
            this.carColorDoing.HeaderText = "Color";
            this.carColorDoing.Name = "carColorDoing";
            this.carColorDoing.ReadOnly = true;
            // 
            // carTypeDoing
            // 
            this.carTypeDoing.HeaderText = "Type";
            this.carTypeDoing.Name = "carTypeDoing";
            this.carTypeDoing.ReadOnly = true;
            // 
            // carAssignedDateDoing
            // 
            this.carAssignedDateDoing.HeaderText = "Assigned Date";
            this.carAssignedDateDoing.Name = "carAssignedDateDoing";
            this.carAssignedDateDoing.ReadOnly = true;
            // 
            // carReleaseDateDoing
            // 
            this.carReleaseDateDoing.HeaderText = "Release Date";
            this.carReleaseDateDoing.Name = "carReleaseDateDoing";
            this.carReleaseDateDoing.ReadOnly = true;
            // 
            // carStatusDoing
            // 
            this.carStatusDoing.HeaderText = "Status";
            this.carStatusDoing.Name = "carStatusDoing";
            this.carStatusDoing.ReadOnly = true;
            // 
            // carProblemDoing
            // 
            this.carProblemDoing.HeaderText = "Problem";
            this.carProblemDoing.Name = "carProblemDoing";
            this.carProblemDoing.ReadOnly = true;
            // 
            // dgvDone
            // 
            this.dgvDone.AllowUserToDeleteRows = false;
            this.dgvDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDone.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(55)))));
            this.dgvDone.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carModelDone,
            this.carNumberDone,
            this.carColorDone,
            this.carTypeDone,
            this.carAssignedDateDone,
            this.carReleaseDateDone,
            this.carStatusDone,
            this.carProblemDone});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDone.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDone.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(55)))));
            this.dgvDone.Location = new System.Drawing.Point(13, 469);
            this.dgvDone.Name = "dgvDone";
            this.dgvDone.ReadOnly = true;
            this.dgvDone.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDone.Size = new System.Drawing.Size(781, 150);
            this.dgvDone.TabIndex = 2;
            // 
            // carModelDone
            // 
            this.carModelDone.HeaderText = "Model";
            this.carModelDone.Name = "carModelDone";
            this.carModelDone.ReadOnly = true;
            // 
            // carNumberDone
            // 
            this.carNumberDone.HeaderText = "Number";
            this.carNumberDone.Name = "carNumberDone";
            this.carNumberDone.ReadOnly = true;
            // 
            // carColorDone
            // 
            this.carColorDone.HeaderText = "Color";
            this.carColorDone.Name = "carColorDone";
            this.carColorDone.ReadOnly = true;
            // 
            // carTypeDone
            // 
            this.carTypeDone.HeaderText = "Type";
            this.carTypeDone.Name = "carTypeDone";
            this.carTypeDone.ReadOnly = true;
            // 
            // carAssignedDateDone
            // 
            this.carAssignedDateDone.HeaderText = "Assigned Date";
            this.carAssignedDateDone.Name = "carAssignedDateDone";
            this.carAssignedDateDone.ReadOnly = true;
            // 
            // carReleaseDateDone
            // 
            this.carReleaseDateDone.HeaderText = "Release Date";
            this.carReleaseDateDone.Name = "carReleaseDateDone";
            this.carReleaseDateDone.ReadOnly = true;
            // 
            // carStatusDone
            // 
            this.carStatusDone.HeaderText = "Status";
            this.carStatusDone.Name = "carStatusDone";
            this.carStatusDone.ReadOnly = true;
            // 
            // carProblemDone
            // 
            this.carProblemDone.HeaderText = "Problem";
            this.carProblemDone.Name = "carProblemDone";
            this.carProblemDone.ReadOnly = true;
            // 
            // lblToDo
            // 
            this.lblToDo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblToDo.AutoSize = true;
            this.lblToDo.BackColor = System.Drawing.Color.Red;
            this.lblToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblToDo.Location = new System.Drawing.Point(6, 3);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(67, 24);
            this.lblToDo.TabIndex = 3;
            this.lblToDo.Text = "To Do";
            // 
            // lblDoing
            // 
            this.lblDoing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDoing.AutoSize = true;
            this.lblDoing.BackColor = System.Drawing.Color.Green;
            this.lblDoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoing.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDoing.Location = new System.Drawing.Point(7, 3);
            this.lblDoing.Name = "lblDoing";
            this.lblDoing.Size = new System.Drawing.Size(65, 24);
            this.lblDoing.TabIndex = 4;
            this.lblDoing.Text = "Doing";
            // 
            // lblDone
            // 
            this.lblDone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDone.AutoSize = true;
            this.lblDone.BackColor = System.Drawing.Color.DarkOrange;
            this.lblDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDone.Location = new System.Drawing.Point(10, 3);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(60, 24);
            this.lblDone.TabIndex = 5;
            this.lblDone.Text = "Done";
            // 
            // kryptonSeparatorDoing
            // 
            this.kryptonSeparatorDoing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonSeparatorDoing.Location = new System.Drawing.Point(13, 228);
            this.kryptonSeparatorDoing.Name = "kryptonSeparatorDoing";
            this.kryptonSeparatorDoing.Size = new System.Drawing.Size(781, 2);
            this.kryptonSeparatorDoing.StateCommon.Separator.Back.Color1 = System.Drawing.Color.Green;
            this.kryptonSeparatorDoing.StateCommon.Separator.Back.Color2 = System.Drawing.Color.Green;
            this.kryptonSeparatorDoing.TabIndex = 6;
            // 
            // kryptonSeparatorDone
            // 
            this.kryptonSeparatorDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonSeparatorDone.Location = new System.Drawing.Point(13, 442);
            this.kryptonSeparatorDone.Name = "kryptonSeparatorDone";
            this.kryptonSeparatorDone.Size = new System.Drawing.Size(781, 2);
            this.kryptonSeparatorDone.StateCommon.Separator.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.kryptonSeparatorDone.StateCommon.Separator.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.kryptonSeparatorDone.TabIndex = 7;
            // 
            // kryptonSeparatorTD
            // 
            this.kryptonSeparatorTD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonSeparatorTD.Location = new System.Drawing.Point(13, 9);
            this.kryptonSeparatorTD.Name = "kryptonSeparatorTD";
            this.kryptonSeparatorTD.Size = new System.Drawing.Size(781, 2);
            this.kryptonSeparatorTD.StateCommon.Separator.Back.Color1 = System.Drawing.Color.Red;
            this.kryptonSeparatorTD.StateCommon.Separator.Back.Color2 = System.Drawing.Color.Red;
            this.kryptonSeparatorTD.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblDone, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(363, 437);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(80, 30);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblDoing, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(363, 225);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(80, 30);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblToDo, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(363, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(80, 30);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // UC_Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Indigo;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.kryptonSeparatorTD);
            this.Controls.Add(this.kryptonSeparatorDone);
            this.Controls.Add(this.kryptonSeparatorDoing);
            this.Controls.Add(this.dgvDone);
            this.Controls.Add(this.dgvDoing);
            this.Controls.Add(this.dgvToDo);
            this.Name = "UC_Tasks";
            this.Size = new System.Drawing.Size(824, 468);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparatorDoing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparatorDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparatorTD)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvToDo;
        private System.Windows.Forms.DataGridView dgvDoing;
        private System.Windows.Forms.DataGridView dgvDone;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Label lblDoing;
        private System.Windows.Forms.Label lblDone;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparatorDoing;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparatorDone;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparatorTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn carColorTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn carTypeTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn carAssignedDateTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn carReleaseDateTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn carStatusTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn carProblemTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelDoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberDoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn carColorDoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn carTypeDoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn carAssignedDateDoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn carReleaseDateDoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn carStatusDoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn carProblemDoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn carColorDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn carTypeDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn carAssignedDateDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn carReleaseDateDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn carStatusDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn carProblemDone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
