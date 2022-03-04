
namespace App
{
    partial class loginPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.passText = new System.Windows.Forms.TextBox();
            this.profileText = new System.Windows.Forms.TextBox();
            this.profileLabel = new System.Windows.Forms.Label();
            this.passLable = new System.Windows.Forms.Label();
            this.titleLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(135, 245);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(110, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Вход";
            this.loginButton.UseVisualStyleBackColor = true;
            //this.loginButton.Click += new System.EventHandler(this.loginButton_ClickAsync);
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(135, 190);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(110, 20);
            this.passText.TabIndex = 1;
            // 
            // profileText
            // 
            this.profileText.Location = new System.Drawing.Point(135, 160);
            this.profileText.Name = "profileText";
            this.profileText.Size = new System.Drawing.Size(110, 20);
            this.profileText.TabIndex = 1;
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Location = new System.Drawing.Point(90, 165);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(38, 13);
            this.profileLabel.TabIndex = 2;
            this.profileLabel.Text = "Логин";
            this.profileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passLable
            // 
            this.passLable.AutoSize = true;
            this.passLable.Location = new System.Drawing.Point(85, 195);
            this.passLable.Name = "passLable";
            this.passLable.Size = new System.Drawing.Size(45, 13);
            this.passLable.TabIndex = 2;
            this.passLable.Text = "Пароль";
            this.passLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLable.Location = new System.Drawing.Point(100, 100);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(184, 25);
            this.titleLable.TabIndex = 3;
            this.titleLable.Text = "Войдите в аккаунт";
            this.titleLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.passLable);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.profileText);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginPage";
            this.Text = " Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox profileText;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Label passLable;
        private System.Windows.Forms.Label titleLable;
    }
}

