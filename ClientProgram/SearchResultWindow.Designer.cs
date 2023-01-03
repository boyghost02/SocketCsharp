
namespace ClientProgram
{
    partial class SearchResultWindow
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
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PictureMemberBox = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMemberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailBox.Location = new System.Drawing.Point(684, 226);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.ReadOnly = true;
            this.EmailBox.Size = new System.Drawing.Size(337, 32);
            this.EmailBox.TabIndex = 34;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneBox.Location = new System.Drawing.Point(684, 171);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.ReadOnly = true;
            this.PhoneBox.Size = new System.Drawing.Size(337, 32);
            this.PhoneBox.TabIndex = 33;
            // 
            // IdBox
            // 
            this.IdBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdBox.Location = new System.Drawing.Point(684, 116);
            this.IdBox.Name = "IdBox";
            this.IdBox.ReadOnly = true;
            this.IdBox.Size = new System.Drawing.Size(337, 32);
            this.IdBox.TabIndex = 32;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameBox.Location = new System.Drawing.Point(684, 61);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(337, 32);
            this.NameBox.TabIndex = 31;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(469, 229);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(63, 25);
            this.EmailLabel.TabIndex = 30;
            this.EmailLabel.Text = "Email";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(468, 174);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(129, 25);
            this.PhoneNumberLabel.TabIndex = 29;
            this.PhoneNumberLabel.Text = "Số điện thoại";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.Location = new System.Drawing.Point(468, 119);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(64, 25);
            this.IdLabel.TabIndex = 28;
            this.IdLabel.Text = "Mã số";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(468, 64);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(97, 25);
            this.NameLabel.TabIndex = 27;
            this.NameLabel.Text = "Họ và tên";
            // 
            // PictureMemberBox
            // 
            this.PictureMemberBox.Location = new System.Drawing.Point(12, 12);
            this.PictureMemberBox.Name = "PictureMemberBox";
            this.PictureMemberBox.Size = new System.Drawing.Size(400, 300);
            this.PictureMemberBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureMemberBox.TabIndex = 26;
            this.PictureMemberBox.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NextButton.Location = new System.Drawing.Point(967, 289);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(95, 36);
            this.NextButton.TabIndex = 35;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SearchResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 337);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PictureMemberBox);
            this.Name = "SearchResultWindow";
            this.Text = "SearchResultWindow";
            ((System.ComponentModel.ISupportInitialize)(this.PictureMemberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox PictureMemberBox;
        private System.Windows.Forms.Button NextButton;
    }
}