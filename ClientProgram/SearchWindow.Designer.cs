
namespace ClientProgram
{
    partial class SearchWindow
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
            this.ButtonSearchMember = new System.Windows.Forms.Button();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSearchMember
            // 
            this.ButtonSearchMember.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSearchMember.Location = new System.Drawing.Point(337, 178);
            this.ButtonSearchMember.Name = "ButtonSearchMember";
            this.ButtonSearchMember.Size = new System.Drawing.Size(107, 33);
            this.ButtonSearchMember.TabIndex = 40;
            this.ButtonSearchMember.Text = "Tìm kiếm";
            this.ButtonSearchMember.UseVisualStyleBackColor = true;
            this.ButtonSearchMember.Click += new System.EventHandler(this.ButtonSearchMember_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailBox.Location = new System.Drawing.Point(505, 108);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(268, 32);
            this.EmailBox.TabIndex = 39;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneBox.Location = new System.Drawing.Point(138, 108);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(268, 32);
            this.PhoneBox.TabIndex = 38;
            // 
            // IdBox
            // 
            this.IdBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdBox.Location = new System.Drawing.Point(505, 34);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(268, 32);
            this.IdBox.TabIndex = 37;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameBox.Location = new System.Drawing.Point(138, 34);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(268, 32);
            this.NameBox.TabIndex = 36;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(435, 111);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(63, 25);
            this.EmailLabel.TabIndex = 35;
            this.EmailLabel.Text = "Email";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(13, 111);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(129, 25);
            this.PhoneNumberLabel.TabIndex = 34;
            this.PhoneNumberLabel.Text = "Số điện thoại";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.Location = new System.Drawing.Point(435, 37);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(64, 25);
            this.IdLabel.TabIndex = 33;
            this.IdLabel.Text = "Mã số";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(13, 37);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(97, 25);
            this.NameLabel.TabIndex = 32;
            this.NameLabel.Text = "Họ và tên";
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 223);
            this.Controls.Add(this.ButtonSearchMember);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "SearchWindow";
            this.Text = "SearchWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSearchMember;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}