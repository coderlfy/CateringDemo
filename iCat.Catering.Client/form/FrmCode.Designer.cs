namespace iCat.Catering.Client.form
{
    partial class FrmCode
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbCodeType = new System.Windows.Forms.GroupBox();
            this.lbTypeCode = new System.Windows.Forms.ListBox();
            this.gbTypeList = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTypeList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbCodeBH = new System.Windows.Forms.TextBox();
            this.tbCodeName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbCodeType.SuspendLayout();
            this.gbTypeList.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeList)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.gbCodeType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbTypeList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(727, 368);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbCodeType
            // 
            this.gbCodeType.Controls.Add(this.lbTypeCode);
            this.gbCodeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCodeType.Location = new System.Drawing.Point(3, 3);
            this.gbCodeType.Name = "gbCodeType";
            this.tableLayoutPanel1.SetRowSpan(this.gbCodeType, 2);
            this.gbCodeType.Size = new System.Drawing.Size(194, 362);
            this.gbCodeType.TabIndex = 0;
            this.gbCodeType.TabStop = false;
            this.gbCodeType.Text = "类型";
            // 
            // lbTypeCode
            // 
            this.lbTypeCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTypeCode.FormattingEnabled = true;
            this.lbTypeCode.ItemHeight = 12;
            this.lbTypeCode.Location = new System.Drawing.Point(3, 17);
            this.lbTypeCode.Name = "lbTypeCode";
            this.lbTypeCode.Size = new System.Drawing.Size(188, 342);
            this.lbTypeCode.TabIndex = 0;
            // 
            // gbTypeList
            // 
            this.gbTypeList.Controls.Add(this.dgvTypeList);
            this.gbTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTypeList.Location = new System.Drawing.Point(203, 3);
            this.gbTypeList.Name = "gbTypeList";
            this.gbTypeList.Size = new System.Drawing.Size(521, 242);
            this.gbTypeList.TabIndex = 1;
            this.gbTypeList.TabStop = false;
            this.gbTypeList.Text = "所选类型的所有码值";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(203, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 114);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "码值编辑区";
            // 
            // dgvTypeList
            // 
            this.dgvTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTypeList.Location = new System.Drawing.Point(3, 17);
            this.dgvTypeList.Name = "dgvTypeList";
            this.dgvTypeList.RowTemplate.Height = 23;
            this.dgvTypeList.Size = new System.Drawing.Size(515, 222);
            this.dgvTypeList.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.91262F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.08738F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbCodeBH, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbCodeName, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(515, 94);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "类型名称：";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSave.Location = new System.Drawing.Point(120, 66);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbCodeBH
            // 
            this.tbCodeBH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCodeBH.Location = new System.Drawing.Point(120, 5);
            this.tbCodeBH.Name = "tbCodeBH";
            this.tbCodeBH.Size = new System.Drawing.Size(241, 21);
            this.tbCodeBH.TabIndex = 3;
            // 
            // tbCodeName
            // 
            this.tbCodeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCodeName.Location = new System.Drawing.Point(120, 36);
            this.tbCodeName.Name = "tbCodeName";
            this.tbCodeName.Size = new System.Drawing.Size(241, 21);
            this.tbCodeName.TabIndex = 4;
            // 
            // FrmCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 368);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "餐饮系统码表配置";
            this.Load += new System.EventHandler(this.FrmCode_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbCodeType.ResumeLayout(false);
            this.gbTypeList.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeList)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbCodeType;
        private System.Windows.Forms.ListBox lbTypeCode;
        private System.Windows.Forms.GroupBox gbTypeList;
        private System.Windows.Forms.DataGridView dgvTypeList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbCodeBH;
        private System.Windows.Forms.TextBox tbCodeName;
    }
}