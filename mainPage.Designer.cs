
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.updButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.avatarImage = new System.Windows.Forms.PictureBox();
            this.tabMain = new System.Windows.Forms.ListView();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageText = new System.Windows.Forms.Label();
            this.edtButton = new System.Windows.Forms.Button();
            this.tabAdmin = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.Location = new System.Drawing.Point(640, 184);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(137, 17);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Добро пожаловать,";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstnameLabel.Location = new System.Drawing.Point(640, 216);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(95, 17);
            this.firstnameLabel.TabIndex = 0;
            this.firstnameLabel.Text = "firstnamehere";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastnameLabel.Location = new System.Drawing.Point(640, 248);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(94, 17);
            this.lastnameLabel.TabIndex = 0;
            this.lastnameLabel.Text = "lastnamehere";
            // 
            // updButton
            // 
            this.updButton.Location = new System.Drawing.Point(640, 464);
            this.updButton.Name = "updButton";
            this.updButton.Size = new System.Drawing.Size(144, 32);
            this.updButton.TabIndex = 1;
            this.updButton.Text = "Обновить";
            this.updButton.UseVisualStyleBackColor = true;
            this.updButton.Click += new System.EventHandler(this.updButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(640, 416);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(144, 32);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Сменить пользователя";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(640, 360);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(144, 40);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Управление\r\nпользователями";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // avatarImage
            // 
            this.avatarImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avatarImage.Image = global::App.Properties.Resources.e2;
            this.avatarImage.InitialImage = null;
            this.avatarImage.Location = new System.Drawing.Point(640, 24);
            this.avatarImage.Name = "avatarImage";
            this.avatarImage.Size = new System.Drawing.Size(150, 150);
            this.avatarImage.TabIndex = 2;
            this.avatarImage.TabStop = false;
            // 
            // tabMain
            // 
            this.tabMain.HideSelection = false;
            this.tabMain.Location = new System.Drawing.Point(24, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(592, 472);
            this.tabMain.TabIndex = 3;
            this.tabMain.UseCompatibleStateImageBehavior = false;
            this.tabMain.View = System.Windows.Forms.View.Tile;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.Location = new System.Drawing.Point(640, 280);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(121, 17);
            this.ageLabel.TabIndex = 0;
            this.ageLabel.Text = "Возраст:        лет";
            // 
            // ageText
            // 
            this.ageText.AutoSize = true;
            this.ageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageText.Location = new System.Drawing.Point(704, 280);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(61, 17);
            this.ageText.TabIndex = 0;
            this.ageText.Text = "agehere";
            // 
            // edtButton
            // 
            this.edtButton.Location = new System.Drawing.Point(640, 312);
            this.edtButton.Name = "edtButton";
            this.edtButton.Size = new System.Drawing.Size(144, 32);
            this.edtButton.TabIndex = 1;
            this.edtButton.Text = "Управление курсами";
            this.edtButton.UseVisualStyleBackColor = true;
            this.edtButton.Click += new System.EventHandler(this.edtButton_Click);
            // 
            // tabAdmin
            // 
            this.tabAdmin.HideSelection = false;
            this.tabAdmin.Location = new System.Drawing.Point(328, 24);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Size = new System.Drawing.Size(288, 472);
            this.tabAdmin.TabIndex = 3;
            this.tabAdmin.UseCompatibleStateImageBehavior = false;
            this.tabAdmin.View = System.Windows.Forms.View.Details;
            this.tabAdmin.Visible = false;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 513);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.avatarImage);
            this.Controls.Add(this.edtButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.updButton);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainPage";
            this.Text = "Главная страница";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainPage_FormClosing);
            this.Load += new System.EventHandler(this.mainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Button updButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.PictureBox avatarImage;
        private System.Windows.Forms.ListView tabMain;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label ageText;
        private System.Windows.Forms.Button edtButton;
        private System.Windows.Forms.ListView tabAdmin;
    }
}