namespace MSIL
{
    partial class frmILInstructions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbMethods = new System.Windows.Forms.ComboBox();
            this.tbManualEntry = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.gvILInstructions = new System.Windows.Forms.DataGridView();
            this.colLineNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlClassInfo = new System.Windows.Forms.Panel();
            this.gbManualEntry = new System.Windows.Forms.GroupBox();
            this.btnSearchTypeAndMethod = new System.Windows.Forms.Button();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAssemblyName = new System.Windows.Forms.TextBox();
            this.lblMethodName = new System.Windows.Forms.Label();
            this.lblTypeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvILInstructions)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlClassInfo.SuspendLayout();
            this.gbManualEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMethods
            // 
            this.cbMethods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMethods.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMethods.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbMethods.FormattingEnabled = true;
            this.cbMethods.Location = new System.Drawing.Point(197, 72);
            this.cbMethods.Name = "cbMethods";
            this.cbMethods.Size = new System.Drawing.Size(346, 21);
            this.cbMethods.TabIndex = 3;
            this.cbMethods.SelectedIndexChanged += new System.EventHandler(this.cbMethods_SelectedIndexChanged);
            // 
            // tbManualEntry
            // 
            this.tbManualEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbManualEntry.Location = new System.Drawing.Point(6, 28);
            this.tbManualEntry.Name = "tbManualEntry";
            this.tbManualEntry.Size = new System.Drawing.Size(471, 20);
            this.tbManualEntry.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(517, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(26, 20);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // gvILInstructions
            // 
            this.gvILInstructions.AllowUserToAddRows = false;
            this.gvILInstructions.AllowUserToDeleteRows = false;
            this.gvILInstructions.AllowUserToResizeRows = false;
            this.gvILInstructions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvILInstructions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLineNr,
            this.colCodeName});
            this.gvILInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvILInstructions.Location = new System.Drawing.Point(0, 0);
            this.gvILInstructions.Name = "gvILInstructions";
            this.gvILInstructions.ReadOnly = true;
            this.gvILInstructions.RowHeadersWidth = 5;
            this.gvILInstructions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvILInstructions.Size = new System.Drawing.Size(555, 242);
            this.gvILInstructions.TabIndex = 0;
            // 
            // colLineNr
            // 
            this.colLineNr.DataPropertyName = "Offset";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.colLineNr.DefaultCellStyle = dataGridViewCellStyle1;
            this.colLineNr.HeaderText = "Line";
            this.colLineNr.MinimumWidth = 50;
            this.colLineNr.Name = "colLineNr";
            this.colLineNr.ReadOnly = true;
            this.colLineNr.Width = 80;
            // 
            // colCodeName
            // 
            this.colCodeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCodeName.DataPropertyName = "OpCodeName";
            this.colCodeName.HeaderText = "Code Name";
            this.colCodeName.Name = "colCodeName";
            this.colCodeName.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gvILInstructions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 242);
            this.panel1.TabIndex = 4;
            // 
            // pnlClassInfo
            // 
            this.pnlClassInfo.Controls.Add(this.gbManualEntry);
            this.pnlClassInfo.Controls.Add(this.cbTypes);
            this.pnlClassInfo.Controls.Add(this.label1);
            this.pnlClassInfo.Controls.Add(this.tbAssemblyName);
            this.pnlClassInfo.Controls.Add(this.lblMethodName);
            this.pnlClassInfo.Controls.Add(this.lblTypeName);
            this.pnlClassInfo.Controls.Add(this.btnBrowse);
            this.pnlClassInfo.Controls.Add(this.cbMethods);
            this.pnlClassInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClassInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlClassInfo.Name = "pnlClassInfo";
            this.pnlClassInfo.Size = new System.Drawing.Size(555, 187);
            this.pnlClassInfo.TabIndex = 0;
            // 
            // gbManualEntry
            // 
            this.gbManualEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbManualEntry.Controls.Add(this.btnSearchTypeAndMethod);
            this.gbManualEntry.Controls.Add(this.tbManualEntry);
            this.gbManualEntry.Location = new System.Drawing.Point(3, 112);
            this.gbManualEntry.Name = "gbManualEntry";
            this.gbManualEntry.Size = new System.Drawing.Size(547, 57);
            this.gbManualEntry.TabIndex = 4;
            this.gbManualEntry.TabStop = false;
            this.gbManualEntry.Text = "Type and Method Names (manual entry)";
            // 
            // btnSearchTypeAndMethod
            // 
            this.btnSearchTypeAndMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchTypeAndMethod.Location = new System.Drawing.Point(483, 20);
            this.btnSearchTypeAndMethod.Name = "btnSearchTypeAndMethod";
            this.btnSearchTypeAndMethod.Size = new System.Drawing.Size(57, 28);
            this.btnSearchTypeAndMethod.TabIndex = 1;
            this.btnSearchTypeAndMethod.Text = "Search";
            this.btnSearchTypeAndMethod.UseVisualStyleBackColor = true;
            this.btnSearchTypeAndMethod.Click += new System.EventHandler(this.btnSearchTypeAndMethod_Click);
            // 
            // cbTypes
            // 
            this.cbTypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(12, 72);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(179, 21);
            this.cbTypes.TabIndex = 2;
            this.cbTypes.SelectedIndexChanged += new System.EventHandler(this.cbTypes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assembly FileName";
            // 
            // tbAssemblyName
            // 
            this.tbAssemblyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAssemblyName.Location = new System.Drawing.Point(12, 25);
            this.tbAssemblyName.Name = "tbAssemblyName";
            this.tbAssemblyName.Size = new System.Drawing.Size(503, 20);
            this.tbAssemblyName.TabIndex = 0;
            this.tbAssemblyName.Leave += new System.EventHandler(this.tbAssemblyName_Leave);
            // 
            // lblMethodName
            // 
            this.lblMethodName.AutoSize = true;
            this.lblMethodName.Location = new System.Drawing.Point(194, 57);
            this.lblMethodName.Name = "lblMethodName";
            this.lblMethodName.Size = new System.Drawing.Size(71, 13);
            this.lblMethodName.TabIndex = 4;
            this.lblMethodName.Text = "MethodName";
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(12, 57);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(59, 13);
            this.lblTypeName.TabIndex = 3;
            this.lblTypeName.Text = "TypeName";
            // 
            // frmAssemblies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlClassInfo);
            this.Name = "frmAssemblies";
            this.Text = "IL Instructions";
            ((System.ComponentModel.ISupportInitialize)(this.gvILInstructions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlClassInfo.ResumeLayout(false);
            this.pnlClassInfo.PerformLayout();
            this.gbManualEntry.ResumeLayout(false);
            this.gbManualEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMethods;
        private System.Windows.Forms.TextBox tbManualEntry;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView gvILInstructions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlClassInfo;
        private System.Windows.Forms.Label lblMethodName;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAssemblyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLineNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodeName;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.GroupBox gbManualEntry;
        private System.Windows.Forms.Button btnSearchTypeAndMethod;
    }
}

