
namespace App
{
    partial class mainPage
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
            this.testLabel = new System.Windows.Forms.Label();
            this.testLogoff = new System.Windows.Forms.Button();
            this.testAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(215, 105);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(35, 13);
            this.testLabel.TabIndex = 0;
            this.testLabel.Text = "label1";
            // 
            // testLogoff
            // 
            this.testLogoff.Location = new System.Drawing.Point(195, 245);
            this.testLogoff.Name = "testLogoff";
            this.testLogoff.Size = new System.Drawing.Size(75, 23);
            this.testLogoff.TabIndex = 1;
            this.testLogoff.Text = "logoff";
            this.testLogoff.UseVisualStyleBackColor = true;
            this.testLogoff.Click += new System.EventHandler(this.button1_Click);
            // 
            // testAdd
            // 
            this.testAdd.Location = new System.Drawing.Point(195, 300);
            this.testAdd.Name = "testAdd";
            this.testAdd.Size = new System.Drawing.Size(75, 23);
            this.testAdd.TabIndex = 2;
            this.testAdd.Text = "add";
            this.testAdd.UseVisualStyleBackColor = true;
            this.testAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.testAdd);
            this.Controls.Add(this.testLogoff);
            this.Controls.Add(this.testLabel);
            this.Name = "mainPage";
            this.Text = "mainPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainPage_FormClosing);
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button testLogoff;
        private System.Windows.Forms.Button testAdd;
    }
}