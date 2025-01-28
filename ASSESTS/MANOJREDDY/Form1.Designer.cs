namespace EcheverryAssign5
{
    partial class Form1
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
            this.lblAsset = new System.Windows.Forms.Label();
            this.lblPurchaseYear = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblDepreciationRate = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.txtAsset = new System.Windows.Forms.TextBox();
            this.txtPurchaseYear = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtDepreciationRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAsset
            // 
            this.lblAsset.AutoSize = true;
            this.lblAsset.Location = new System.Drawing.Point(96, 68);
            this.lblAsset.Name = "lblAsset";
            this.lblAsset.Size = new System.Drawing.Size(33, 13);
            this.lblAsset.TabIndex = 0;
            this.lblAsset.Text = "Asset";
            // 
            // lblPurchaseYear
            // 
            this.lblPurchaseYear.AutoSize = true;
            this.lblPurchaseYear.Location = new System.Drawing.Point(52, 120);
            this.lblPurchaseYear.Name = "lblPurchaseYear";
            this.lblPurchaseYear.Size = new System.Drawing.Size(77, 13);
            this.lblPurchaseYear.TabIndex = 1;
            this.lblPurchaseYear.Text = "Purchase Year";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(50, 170);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(79, 13);
            this.lblPurchasePrice.TabIndex = 2;
            this.lblPurchasePrice.Text = "Purchase Price";
            // 
            // lblDepreciationRate
            // 
            this.lblDepreciationRate.AutoSize = true;
            this.lblDepreciationRate.Location = new System.Drawing.Point(36, 230);
            this.lblDepreciationRate.Name = "lblDepreciationRate";
            this.lblDepreciationRate.Size = new System.Drawing.Size(93, 13);
            this.lblDepreciationRate.TabIndex = 3;
            this.lblDepreciationRate.Text = "Depreciation Rate";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(86, 316);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(131, 34);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Depreciation";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(250, 316);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 34);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(413, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 34);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(274, 65);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(270, 199);
            this.lstOutput.TabIndex = 7;
            // 
            // txtAsset
            // 
            this.txtAsset.Location = new System.Drawing.Point(144, 65);
            this.txtAsset.Name = "txtAsset";
            this.txtAsset.Size = new System.Drawing.Size(100, 20);
            this.txtAsset.TabIndex = 8;
            // 
            // txtPurchaseYear
            // 
            this.txtPurchaseYear.Location = new System.Drawing.Point(144, 117);
            this.txtPurchaseYear.Name = "txtPurchaseYear";
            this.txtPurchaseYear.Size = new System.Drawing.Size(100, 20);
            this.txtPurchaseYear.TabIndex = 9;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(144, 167);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(100, 20);
            this.txtPurchasePrice.TabIndex = 10;
            // 
            // txtDepreciationRate
            // 
            this.txtDepreciationRate.Location = new System.Drawing.Point(144, 227);
            this.txtDepreciationRate.Name = "txtDepreciationRate";
            this.txtDepreciationRate.Size = new System.Drawing.Size(100, 20);
            this.txtDepreciationRate.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 410);
            this.Controls.Add(this.txtDepreciationRate);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.txtPurchaseYear);
            this.Controls.Add(this.txtAsset);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblDepreciationRate);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.lblPurchaseYear);
            this.Controls.Add(this.lblAsset);
            this.Name = "Form1";
            this.Text = "Depreciation Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsset;
        private System.Windows.Forms.Label lblPurchaseYear;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblDepreciationRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.TextBox txtAsset;
        private System.Windows.Forms.TextBox txtPurchaseYear;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtDepreciationRate;
    }
}

