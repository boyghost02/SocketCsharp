
namespace ServerProgram
{
    partial class AddNewMemberWindow
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
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.AddPictureButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.AddPictureButton);
            this.GroupBox.Controls.Add(this.PictureBox);
            this.GroupBox.Controls.Add(this.CancelButton);
            this.GroupBox.Controls.Add(this.AcceptButton);
            this.GroupBox.Controls.Add(this.EmailBox);
            this.GroupBox.Controls.Add(this.PhoneNumberBox);
            this.GroupBox.Controls.Add(this.IdBox);
            this.GroupBox.Controls.Add(this.NameBox);
            this.GroupBox.Controls.Add(this.EmailLabel);
            this.GroupBox.Controls.Add(this.PhoneLabel);
            this.GroupBox.Controls.Add(this.IdLabel);
            this.GroupBox.Controls.Add(this.NameLabel);
            this.GroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupBox.Location = new System.Drawing.Point(13, 12);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(768, 392);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Nhập thêm thành viên mới";
            // 
            // AddPictureButton
            // 
            this.AddPictureButton.Location = new System.Drawing.Point(573, 274);
            this.AddPictureButton.Name = "AddPictureButton";
            this.AddPictureButton.Size = new System.Drawing.Size(106, 31);
            this.AddPictureButton.TabIndex = 11;
            this.AddPictureButton.Text = "Thêm ảnh";
            this.AddPictureButton.UseVisualStyleBackColor = true;
            this.AddPictureButton.Click += new System.EventHandler(this.AddPictureButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(450, 55);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(312, 213);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 10;
            this.PictureBox.TabStop = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(450, 314);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(113, 64);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Thoát";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(193, 314);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(113, 64);
            this.AcceptButton.TabIndex = 8;
            this.AcceptButton.Text = "Thêm";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailBox.Location = new System.Drawing.Point(149, 254);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(267, 26);
            this.EmailBox.TabIndex = 7;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberBox.Location = new System.Drawing.Point(149, 188);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(267, 26);
            this.PhoneNumberBox.TabIndex = 6;
            // 
            // IdBox
            // 
            this.IdBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdBox.Location = new System.Drawing.Point(149, 123);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(267, 26);
            this.IdBox.TabIndex = 5;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameBox.Location = new System.Drawing.Point(149, 52);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(267, 26);
            this.NameBox.TabIndex = 4;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(46, 257);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(46, 19);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhoneLabel.Location = new System.Drawing.Point(46, 191);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(100, 19);
            this.PhoneLabel.TabIndex = 2;
            this.PhoneLabel.Text = "Số điện thoại";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.Location = new System.Drawing.Point(46, 126);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(52, 19);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "Mã Số";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(46, 55);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 19);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Họ và tên";
            // 
            // AddNewMemberWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 410);
            this.Controls.Add(this.GroupBox);
            this.Name = "AddNewMemberWindow";
            this.Text = "Thêm thành viên";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Button AddPictureButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AcceptButton;
    }
}