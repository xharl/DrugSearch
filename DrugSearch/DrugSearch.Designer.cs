namespace DrugSearch
{
    partial class DrugSearch
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
            this.pgbQuery = new System.Windows.Forms.ProgressBar();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lbltxtMF = new System.Windows.Forms.Label();
            this.lbltxtIUPAC = new System.Windows.Forms.Label();
            this.lbltxtName = new System.Windows.Forms.Label();
            this.lbltxtMW = new System.Windows.Forms.Label();
            this.lblMF = new System.Windows.Forms.Label();
            this.lblMW = new System.Windows.Forms.Label();
            this.lblIUPAC = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.pctDrug = new System.Windows.Forms.PictureBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctDrug)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgbQuery
            // 
            this.pgbQuery.Location = new System.Drawing.Point(135, 258);
            this.pgbQuery.Name = "pgbQuery";
            this.pgbQuery.Size = new System.Drawing.Size(465, 23);
            this.pgbQuery.TabIndex = 7;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(9, 87);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "label2";
            this.lblResult.Visible = false;
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblDescription);
            this.grpResult.Controls.Add(this.lbltxtMF);
            this.grpResult.Controls.Add(this.lbltxtIUPAC);
            this.grpResult.Controls.Add(this.lbltxtName);
            this.grpResult.Controls.Add(this.lbltxtMW);
            this.grpResult.Controls.Add(this.lblMF);
            this.grpResult.Controls.Add(this.lblMW);
            this.grpResult.Controls.Add(this.lblIUPAC);
            this.grpResult.Controls.Add(this.lblSearchName);
            this.grpResult.Controls.Add(this.pctDrug);
            this.grpResult.Location = new System.Drawing.Point(135, 12);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(465, 240);
            this.grpResult.TabIndex = 9;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 176);
            this.lblDescription.MaximumSize = new System.Drawing.Size(455, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(35, 13);
            this.lblDescription.TabIndex = 27;
            this.lblDescription.Text = "label1";
            this.lblDescription.Visible = false;
            // 
            // lbltxtMF
            // 
            this.lbltxtMF.AutoSize = true;
            this.lbltxtMF.Location = new System.Drawing.Point(273, 156);
            this.lbltxtMF.Name = "lbltxtMF";
            this.lbltxtMF.Size = new System.Drawing.Size(35, 13);
            this.lbltxtMF.TabIndex = 26;
            this.lbltxtMF.Text = "label4";
            this.lbltxtMF.Visible = false;
            // 
            // lbltxtIUPAC
            // 
            this.lbltxtIUPAC.AutoEllipsis = true;
            this.lbltxtIUPAC.AutoSize = true;
            this.lbltxtIUPAC.Location = new System.Drawing.Point(273, 61);
            this.lbltxtIUPAC.MaximumSize = new System.Drawing.Size(180, 0);
            this.lbltxtIUPAC.Name = "lbltxtIUPAC";
            this.lbltxtIUPAC.Size = new System.Drawing.Size(35, 13);
            this.lbltxtIUPAC.TabIndex = 25;
            this.lbltxtIUPAC.Text = "label3";
            this.lbltxtIUPAC.Visible = false;
            // 
            // lbltxtName
            // 
            this.lbltxtName.AutoSize = true;
            this.lbltxtName.Location = new System.Drawing.Point(273, 14);
            this.lbltxtName.Name = "lbltxtName";
            this.lbltxtName.Size = new System.Drawing.Size(35, 13);
            this.lbltxtName.TabIndex = 24;
            this.lbltxtName.Text = "label2";
            this.lbltxtName.Visible = false;
            // 
            // lbltxtMW
            // 
            this.lbltxtMW.AutoSize = true;
            this.lbltxtMW.Location = new System.Drawing.Point(273, 109);
            this.lbltxtMW.Name = "lbltxtMW";
            this.lbltxtMW.Size = new System.Drawing.Size(35, 13);
            this.lbltxtMW.TabIndex = 23;
            this.lbltxtMW.Text = "label1";
            this.lbltxtMW.Visible = false;
            // 
            // lblMF
            // 
            this.lblMF.AutoSize = true;
            this.lblMF.Location = new System.Drawing.Point(173, 156);
            this.lblMF.Name = "lblMF";
            this.lblMF.Size = new System.Drawing.Size(96, 13);
            this.lblMF.TabIndex = 22;
            this.lblMF.Text = "Molecular Formula:";
            // 
            // lblMW
            // 
            this.lblMW.AutoSize = true;
            this.lblMW.Location = new System.Drawing.Point(173, 109);
            this.lblMW.Name = "lblMW";
            this.lblMW.Size = new System.Drawing.Size(90, 13);
            this.lblMW.TabIndex = 21;
            this.lblMW.Text = "Molecular weight:";
            // 
            // lblIUPAC
            // 
            this.lblIUPAC.AutoSize = true;
            this.lblIUPAC.Location = new System.Drawing.Point(173, 62);
            this.lblIUPAC.Name = "lblIUPAC";
            this.lblIUPAC.Size = new System.Drawing.Size(45, 13);
            this.lblIUPAC.TabIndex = 20;
            this.lblIUPAC.Text = "IUPAC: ";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(173, 15);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(38, 13);
            this.lblSearchName.TabIndex = 19;
            this.lblSearchName.Text = "Name:";
            // 
            // pctDrug
            // 
            this.pctDrug.Location = new System.Drawing.Point(6, 19);
            this.pctDrug.Name = "pctDrug";
            this.pctDrug.Size = new System.Drawing.Size(150, 150);
            this.pctDrug.TabIndex = 18;
            this.pctDrug.TabStop = false;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtName);
            this.grpSearch.Controls.Add(this.lblResult);
            this.grpSearch.Location = new System.Drawing.Point(5, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(124, 135);
            this.grpSearch.TabIndex = 11;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // DrugSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 293);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.pgbQuery);
            this.MaximizeBox = false;
            this.Name = "DrugSearch";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Drug Search";
            this.Load += new System.EventHandler(this.AddDrug_Load);
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctDrug)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar pgbQuery;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lbltxtMF;
        private System.Windows.Forms.Label lbltxtIUPAC;
        private System.Windows.Forms.Label lbltxtName;
        private System.Windows.Forms.Label lbltxtMW;
        private System.Windows.Forms.Label lblMF;
        private System.Windows.Forms.Label lblMW;
        private System.Windows.Forms.Label lblIUPAC;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.PictureBox pctDrug;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
    }
}