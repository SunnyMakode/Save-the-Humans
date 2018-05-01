namespace TalkerTester
{
    partial class Form2
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
            this.giveToJoe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.JoeCashlabel = new System.Windows.Forms.Label();
            this.bobCashlabel = new System.Windows.Forms.Label();
            this.BankCashlabel = new System.Windows.Forms.Label();
            this.giveToBob = new System.Windows.Forms.Button();
            this.bobGivesJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // giveToJoe
            // 
            this.giveToJoe.Location = new System.Drawing.Point(24, 161);
            this.giveToJoe.Name = "giveToJoe";
            this.giveToJoe.Size = new System.Drawing.Size(75, 38);
            this.giveToJoe.TabIndex = 0;
            this.giveToJoe.Text = "Give $10 to Joe";
            this.giveToJoe.UseVisualStyleBackColor = true;
            this.giveToJoe.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // JoeCashlabel
            // 
            this.JoeCashlabel.AutoSize = true;
            this.JoeCashlabel.Location = new System.Drawing.Point(21, 45);
            this.JoeCashlabel.Name = "JoeCashlabel";
            this.JoeCashlabel.Size = new System.Drawing.Size(0, 13);
            this.JoeCashlabel.TabIndex = 2;
            // 
            // bobCashlabel
            // 
            this.bobCashlabel.AutoSize = true;
            this.bobCashlabel.Location = new System.Drawing.Point(21, 73);
            this.bobCashlabel.Name = "bobCashlabel";
            this.bobCashlabel.Size = new System.Drawing.Size(0, 13);
            this.bobCashlabel.TabIndex = 3;
            // 
            // BankCashlabel
            // 
            this.BankCashlabel.AutoSize = true;
            this.BankCashlabel.Location = new System.Drawing.Point(21, 101);
            this.BankCashlabel.Name = "BankCashlabel";
            this.BankCashlabel.Size = new System.Drawing.Size(0, 13);
            this.BankCashlabel.TabIndex = 4;
            // 
            // giveToBob
            // 
            this.giveToBob.Location = new System.Drawing.Point(24, 205);
            this.giveToBob.Name = "giveToBob";
            this.giveToBob.Size = new System.Drawing.Size(75, 37);
            this.giveToBob.TabIndex = 5;
            this.giveToBob.Text = "Give $10 to Bob";
            this.giveToBob.UseVisualStyleBackColor = true;
            this.giveToBob.Click += new System.EventHandler(this.giveToBob_Click);
            // 
            // bobGivesJoe
            // 
            this.bobGivesJoe.Location = new System.Drawing.Point(168, 206);
            this.bobGivesJoe.Name = "bobGivesJoe";
            this.bobGivesJoe.Size = new System.Drawing.Size(75, 36);
            this.bobGivesJoe.TabIndex = 6;
            this.bobGivesJoe.Text = "Bob Gives $5 To Joe";
            this.bobGivesJoe.UseVisualStyleBackColor = true;
            this.bobGivesJoe.Click += new System.EventHandler(this.bobGivesJoe_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bobGivesJoe);
            this.Controls.Add(this.giveToBob);
            this.Controls.Add(this.BankCashlabel);
            this.Controls.Add(this.bobCashlabel);
            this.Controls.Add(this.JoeCashlabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.giveToJoe);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giveToJoe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label JoeCashlabel;
        private System.Windows.Forms.Label bobCashlabel;
        private System.Windows.Forms.Label BankCashlabel;
        private System.Windows.Forms.Button giveToBob;
        private System.Windows.Forms.Button bobGivesJoe;
    }
}