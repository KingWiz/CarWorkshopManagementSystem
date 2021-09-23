
namespace CarWorkshopManagementSystem.AllUserControls
{
    partial class UC_Search
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
            this.kryptonTxbSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearchResult = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.carModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carAssignedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carProblem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonBtnGo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tlpSearch.SuspendLayout();
            this.tlpSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonTxbSearch
            // 
            this.kryptonTxbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonTxbSearch.Location = new System.Drawing.Point(87, 10);
            this.kryptonTxbSearch.Name = "kryptonTxbSearch";
            this.kryptonTxbSearch.Size = new System.Drawing.Size(390, 29);
            this.kryptonTxbSearch.StateActive.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonTxbSearch.StateActive.Border.Color1 = System.Drawing.Color.Green;
            this.kryptonTxbSearch.StateActive.Border.Color2 = System.Drawing.Color.Green;
            this.kryptonTxbSearch.StateActive.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.kryptonTxbSearch.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTxbSearch.StateActive.Border.Rounding = 10;
            this.kryptonTxbSearch.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(165)))));
            this.kryptonTxbSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSearch.Location = new System.Drawing.Point(5, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(76, 24);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // tlpSearch
            // 
            this.tlpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSearch.ColumnCount = 3;
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.63486F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.36514F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tlpSearch.Controls.Add(this.kryptonTxbSearch, 1, 0);
            this.tlpSearch.Controls.Add(this.lblSearch, 0, 0);
            this.tlpSearch.Controls.Add(this.kryptonBtnGo, 2, 0);
            this.tlpSearch.Location = new System.Drawing.Point(132, 15);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 1;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearch.Size = new System.Drawing.Size(560, 49);
            this.tlpSearch.TabIndex = 3;
            // 
            // tlpSearchResult
            // 
            this.tlpSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSearchResult.ColumnCount = 1;
            this.tlpSearchResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchResult.Controls.Add(this.dgvSearchResult, 0, 0);
            this.tlpSearchResult.Location = new System.Drawing.Point(20, 125);
            this.tlpSearchResult.Name = "tlpSearchResult";
            this.tlpSearchResult.RowCount = 1;
            this.tlpSearchResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchResult.Size = new System.Drawing.Size(785, 187);
            this.tlpSearchResult.TabIndex = 4;
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.AllowUserToDeleteRows = false;
            this.dgvSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(10)))), ((int)(((byte)(117)))));
            this.dgvSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSearchResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carModel,
            this.carAssignedDate,
            this.carReleaseDate,
            this.carStatus,
            this.carProblem,
            this.cuName,
            this.cuAddress,
            this.cuPhoneNo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(10)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearchResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearchResult.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvSearchResult.Location = new System.Drawing.Point(3, 3);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearchResult.Size = new System.Drawing.Size(779, 170);
            this.dgvSearchResult.TabIndex = 0;
            // 
            // carModel
            // 
            this.carModel.HeaderText = "Model";
            this.carModel.Name = "carModel";
            this.carModel.ReadOnly = true;
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
            // cuAddress
            // 
            this.cuAddress.HeaderText = "Address";
            this.cuAddress.Name = "cuAddress";
            this.cuAddress.ReadOnly = true;
            // 
            // cuPhoneNo
            // 
            this.cuPhoneNo.HeaderText = "Phone No.";
            this.cuPhoneNo.Name = "cuPhoneNo";
            this.cuPhoneNo.ReadOnly = true;
            // 
            // kryptonBtnGo
            // 
            this.kryptonBtnGo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonBtnGo.Location = new System.Drawing.Point(483, 10);
            this.kryptonBtnGo.Name = "kryptonBtnGo";
            this.kryptonBtnGo.Size = new System.Drawing.Size(55, 28);
            this.kryptonBtnGo.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.kryptonBtnGo.StateCommon.Back.Color2 = System.Drawing.Color.Green;
            this.kryptonBtnGo.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonBtnGo.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonBtnGo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnGo.StateCommon.Border.Rounding = 5;
            this.kryptonBtnGo.StateCommon.Border.Width = 2;
            this.kryptonBtnGo.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonBtnGo.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonBtnGo.TabIndex = 2;
            this.kryptonBtnGo.Values.Text = "Go!";
            // 
            // UC_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.Controls.Add(this.tlpSearchResult);
            this.Controls.Add(this.tlpSearch);
            this.Name = "UC_Search";
            this.Size = new System.Drawing.Size(824, 472);
            this.tlpSearch.ResumeLayout(false);
            this.tlpSearch.PerformLayout();
            this.tlpSearchResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTxbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TableLayoutPanel tlpSearch;
        private System.Windows.Forms.TableLayoutPanel tlpSearchResult;
        private System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn carAssignedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn carReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn carStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn carProblem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuPhoneNo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonBtnGo;
    }
}
