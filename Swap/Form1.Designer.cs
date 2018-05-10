namespace Swap
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
            this.llyodBtn = new System.Windows.Forms.Button();
            this.lucindaBtn = new System.Windows.Forms.Button();
            this.swapBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // llyodBtn
            // 
            this.llyodBtn.Location = new System.Drawing.Point(92, 49);
            this.llyodBtn.Name = "llyodBtn";
            this.llyodBtn.Size = new System.Drawing.Size(75, 23);
            this.llyodBtn.TabIndex = 0;
            this.llyodBtn.Text = "Lloyd";
            this.llyodBtn.UseVisualStyleBackColor = true;
            this.llyodBtn.Click += new System.EventHandler(this.llyodBtn_Click);
            // 
            // lucindaBtn
            // 
            this.lucindaBtn.Location = new System.Drawing.Point(92, 96);
            this.lucindaBtn.Name = "lucindaBtn";
            this.lucindaBtn.Size = new System.Drawing.Size(75, 23);
            this.lucindaBtn.TabIndex = 1;
            this.lucindaBtn.Text = "Lucinda";
            this.lucindaBtn.UseVisualStyleBackColor = true;
            this.lucindaBtn.Click += new System.EventHandler(this.lucindaBtn_Click);
            // 
            // swapBtn
            // 
            this.swapBtn.Location = new System.Drawing.Point(92, 154);
            this.swapBtn.Name = "swapBtn";
            this.swapBtn.Size = new System.Drawing.Size(75, 23);
            this.swapBtn.TabIndex = 2;
            this.swapBtn.Text = "Swap !";
            this.swapBtn.UseVisualStyleBackColor = true;
            this.swapBtn.Click += new System.EventHandler(this.swapBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(92, 218);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 23);
            this.changeBtn.TabIndex = 3;
            this.changeBtn.Text = "Change !";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.swapBtn);
            this.Controls.Add(this.lucindaBtn);
            this.Controls.Add(this.llyodBtn);
            this.Name = "Form1";
            this.Text = "Swap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button llyodBtn;
        private System.Windows.Forms.Button lucindaBtn;
        private System.Windows.Forms.Button swapBtn;
        private System.Windows.Forms.Button changeBtn;
    }
}

