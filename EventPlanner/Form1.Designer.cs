namespace EventPlanner
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.decorationCheckBox = new System.Windows.Forms.CheckBox();
            this.beveragesCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(116, 12);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of person";
            // 
            // decorationCheckBox
            // 
            this.decorationCheckBox.AutoSize = true;
            this.decorationCheckBox.Checked = true;
            this.decorationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.decorationCheckBox.Location = new System.Drawing.Point(5, 44);
            this.decorationCheckBox.Name = "decorationCheckBox";
            this.decorationCheckBox.Size = new System.Drawing.Size(108, 17);
            this.decorationCheckBox.TabIndex = 2;
            this.decorationCheckBox.Text = "Fancy decoration";
            this.decorationCheckBox.UseVisualStyleBackColor = true;
            this.decorationCheckBox.CheckedChanged += new System.EventHandler(this.decorationCheckBox_CheckedChanged);
            // 
            // beveragesCheckBox
            // 
            this.beveragesCheckBox.AutoSize = true;
            this.beveragesCheckBox.Location = new System.Drawing.Point(5, 76);
            this.beveragesCheckBox.Name = "beveragesCheckBox";
            this.beveragesCheckBox.Size = new System.Drawing.Size(162, 17);
            this.beveragesCheckBox.TabIndex = 3;
            this.beveragesCheckBox.Text = "Healthy option for beverages";
            this.beveragesCheckBox.UseVisualStyleBackColor = true;
            this.beveragesCheckBox.CheckedChanged += new System.EventHandler(this.beveragesCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(91, 122);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 20);
            this.costTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 167);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.beveragesCheckBox);
            this.Controls.Add(this.decorationCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox decorationCheckBox;
        private System.Windows.Forms.CheckBox beveragesCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox costTextBox;
    }
}

