namespace ARomines
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
        protected override void Dispose( bool disposing )
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
            this.enterButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.investmentTextBox = new System.Windows.Forms.TextBox();
            this.exemptionTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.investmentLabel = new System.Windows.Forms.Label();
            this.exemptionLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.marriedCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.taxpayerDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.investmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exemptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marriedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.taxableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxpayerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.taxpayerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxpayerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(16, 229);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(100, 28);
            this.enterButton.TabIndex = 6;
            this.enterButton.Text = "Enter Data";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(135, 229);
            this.loadButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(100, 28);
            this.loadButton.TabIndex = 7;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(254, 229);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(16, 265);
            this.displayButton.Margin = new System.Windows.Forms.Padding(4);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(100, 28);
            this.displayButton.TabIndex = 9;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(135, 265);
            this.summaryButton.Margin = new System.Windows.Forms.Padding(4);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(100, 28);
            this.summaryButton.TabIndex = 10;
            this.summaryButton.Text = "Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(254, 265);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 28);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(16, 436);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 28);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(407, 44);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(743, 187);
            this.outputTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(204, 23);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(132, 22);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Visible = false;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(204, 53);
            this.salaryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(132, 22);
            this.salaryTextBox.TabIndex = 1;
            this.salaryTextBox.Visible = false;
            // 
            // investmentTextBox
            // 
            this.investmentTextBox.Location = new System.Drawing.Point(204, 82);
            this.investmentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.investmentTextBox.Name = "investmentTextBox";
            this.investmentTextBox.Size = new System.Drawing.Size(132, 22);
            this.investmentTextBox.TabIndex = 2;
            this.investmentTextBox.Visible = false;
            // 
            // exemptionTextBox
            // 
            this.exemptionTextBox.Location = new System.Drawing.Point(204, 108);
            this.exemptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.exemptionTextBox.Name = "exemptionTextBox";
            this.exemptionTextBox.Size = new System.Drawing.Size(132, 22);
            this.exemptionTextBox.TabIndex = 3;
            this.exemptionTextBox.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 26);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 17);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Enter Name:";
            this.nameLabel.Visible = false;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(13, 56);
            this.salaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(90, 17);
            this.salaryLabel.TabIndex = 13;
            this.salaryLabel.Text = "Enter Salary:";
            this.salaryLabel.Visible = false;
            // 
            // investmentLabel
            // 
            this.investmentLabel.AutoSize = true;
            this.investmentLabel.Location = new System.Drawing.Point(13, 85);
            this.investmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.investmentLabel.Name = "investmentLabel";
            this.investmentLabel.Size = new System.Drawing.Size(167, 17);
            this.investmentLabel.TabIndex = 14;
            this.investmentLabel.Text = "Enter Investment Income:";
            this.investmentLabel.Visible = false;
            // 
            // exemptionLabel
            // 
            this.exemptionLabel.AutoSize = true;
            this.exemptionLabel.Location = new System.Drawing.Point(13, 111);
            this.exemptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exemptionLabel.Name = "exemptionLabel";
            this.exemptionLabel.Size = new System.Drawing.Size(156, 17);
            this.exemptionLabel.TabIndex = 15;
            this.exemptionLabel.Text = "Enter Exemption Count:";
            this.exemptionLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(980, 447);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "created by Anya Romines";
            // 
            // marriedCheckBox
            // 
            this.marriedCheckBox.AutoSize = true;
            this.marriedCheckBox.Location = new System.Drawing.Point(204, 138);
            this.marriedCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.marriedCheckBox.Name = "marriedCheckBox";
            this.marriedCheckBox.Size = new System.Drawing.Size(86, 21);
            this.marriedCheckBox.TabIndex = 4;
            this.marriedCheckBox.Text = "Married?";
            this.marriedCheckBox.UseVisualStyleBackColor = true;
            this.marriedCheckBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tax Information:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(204, 167);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 28);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Visible = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // taxpayerDataGridView
            // 
            this.taxpayerDataGridView.AutoGenerateColumns = false;
            this.taxpayerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taxpayerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.investmentDataGridViewTextBoxColumn,
            this.exemptionDataGridViewTextBoxColumn,
            this.marriedDataGridViewCheckBoxColumn,
            this.taxableDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn});
            this.taxpayerDataGridView.DataSource = this.taxpayerBindingSource;
            this.taxpayerDataGridView.Location = new System.Drawing.Point(407, 238);
            this.taxpayerDataGridView.Name = "taxpayerDataGridView";
            this.taxpayerDataGridView.RowTemplate.Height = 24;
            this.taxpayerDataGridView.Size = new System.Drawing.Size(743, 188);
            this.taxpayerDataGridView.TabIndex = 19;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // investmentDataGridViewTextBoxColumn
            // 
            this.investmentDataGridViewTextBoxColumn.DataPropertyName = "Investment";
            this.investmentDataGridViewTextBoxColumn.HeaderText = "Investment";
            this.investmentDataGridViewTextBoxColumn.Name = "investmentDataGridViewTextBoxColumn";
            this.investmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exemptionDataGridViewTextBoxColumn
            // 
            this.exemptionDataGridViewTextBoxColumn.DataPropertyName = "Exemption";
            this.exemptionDataGridViewTextBoxColumn.HeaderText = "Exemption";
            this.exemptionDataGridViewTextBoxColumn.Name = "exemptionDataGridViewTextBoxColumn";
            this.exemptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marriedDataGridViewCheckBoxColumn
            // 
            this.marriedDataGridViewCheckBoxColumn.DataPropertyName = "Married";
            this.marriedDataGridViewCheckBoxColumn.HeaderText = "Married";
            this.marriedDataGridViewCheckBoxColumn.Name = "marriedDataGridViewCheckBoxColumn";
            this.marriedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // taxableDataGridViewTextBoxColumn
            // 
            this.taxableDataGridViewTextBoxColumn.DataPropertyName = "Taxable";
            this.taxableDataGridViewTextBoxColumn.HeaderText = "Taxable";
            this.taxableDataGridViewTextBoxColumn.Name = "taxableDataGridViewTextBoxColumn";
            this.taxableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxpayerBindingSource
            // 
            this.taxpayerBindingSource.DataSource = typeof(ARomines.Taxpayer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 472);
            this.Controls.Add(this.taxpayerDataGridView);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.marriedCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exemptionLabel);
            this.Controls.Add(this.investmentLabel);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.exemptionTextBox);
            this.Controls.Add(this.investmentTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.enterButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARomines";
            ((System.ComponentModel.ISupportInitialize)(this.taxpayerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxpayerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox investmentTextBox;
        private System.Windows.Forms.TextBox exemptionTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label investmentLabel;
        private System.Windows.Forms.Label exemptionLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox marriedCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DataGridView taxpayerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn investmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exemptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn marriedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource taxpayerBindingSource;
    }
}

