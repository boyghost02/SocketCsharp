
namespace ServerProgram
{
    partial class ServerMainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerMainWindow));
            this.DataMemberList = new System.Windows.Forms.DataGridView();
            this.PictureMemberBox = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.ButtonAddMember = new System.Windows.Forms.Button();
            this.ButtonDeleteMember = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonFixInfomation = new System.Windows.Forms.Button();
            this.ButtonRefreshDataGridView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataMemberList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMemberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DataMemberList
            // 
            this.DataMemberList.AllowUserToResizeColumns = false;
            this.DataMemberList.AllowUserToResizeRows = false;
            this.DataMemberList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMemberList.Location = new System.Drawing.Point(2, 335);
            this.DataMemberList.Name = "DataMemberList";
            this.DataMemberList.ReadOnly = true;
            this.DataMemberList.RowTemplate.Height = 25;
            this.DataMemberList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataMemberList.Size = new System.Drawing.Size(1326, 331);
            this.DataMemberList.TabIndex = 0;
            this.DataMemberList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMemberList_CellClick);
            this.DataMemberList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataMemberList_ColumnHeaderMouseClick);
            // 
            // PictureMemberBox
            // 
            this.PictureMemberBox.Location = new System.Drawing.Point(60, 12);
            this.PictureMemberBox.Name = "PictureMemberBox";
            this.PictureMemberBox.Size = new System.Drawing.Size(400, 300);
            this.PictureMemberBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureMemberBox.TabIndex = 1;
            this.PictureMemberBox.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(610, 68);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(97, 25);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Họ và tên";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.Location = new System.Drawing.Point(610, 123);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(64, 25);
            this.IdLabel.TabIndex = 3;
            this.IdLabel.Text = "Mã số";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(610, 178);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(129, 25);
            this.PhoneNumberLabel.TabIndex = 4;
            this.PhoneNumberLabel.Text = "Số điện thoại";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(611, 233);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(63, 25);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "Email";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameBox.Location = new System.Drawing.Point(826, 65);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(337, 32);
            this.NameBox.TabIndex = 6;
            // 
            // IdBox
            // 
            this.IdBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdBox.Location = new System.Drawing.Point(826, 120);
            this.IdBox.Name = "IdBox";
            this.IdBox.ReadOnly = true;
            this.IdBox.Size = new System.Drawing.Size(337, 32);
            this.IdBox.TabIndex = 7;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneBox.Location = new System.Drawing.Point(826, 175);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.ReadOnly = true;
            this.PhoneBox.Size = new System.Drawing.Size(337, 32);
            this.PhoneBox.TabIndex = 8;
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailBox.Location = new System.Drawing.Point(826, 230);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.ReadOnly = true;
            this.EmailBox.Size = new System.Drawing.Size(337, 32);
            this.EmailBox.TabIndex = 9;
            // 
            // ButtonAddMember
            // 
            this.ButtonAddMember.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddMember.Location = new System.Drawing.Point(134, 671);
            this.ButtonAddMember.Name = "ButtonAddMember";
            this.ButtonAddMember.Size = new System.Drawing.Size(226, 46);
            this.ButtonAddMember.TabIndex = 10;
            this.ButtonAddMember.Text = "Thêm thành viên";
            this.ButtonAddMember.UseVisualStyleBackColor = true;
            this.ButtonAddMember.Click += new System.EventHandler(this.ButtonAddMember_Click);
            // 
            // ButtonDeleteMember
            // 
            this.ButtonDeleteMember.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDeleteMember.Location = new System.Drawing.Point(1039, 672);
            this.ButtonDeleteMember.Name = "ButtonDeleteMember";
            this.ButtonDeleteMember.Size = new System.Drawing.Size(224, 45);
            this.ButtonDeleteMember.TabIndex = 12;
            this.ButtonDeleteMember.Text = "Xóa thành viên";
            this.ButtonDeleteMember.UseVisualStyleBackColor = true;
            this.ButtonDeleteMember.Click += new System.EventHandler(this.ButtonDeleteMember_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSave.Location = new System.Drawing.Point(724, 672);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(223, 45);
            this.ButtonSave.TabIndex = 13;
            this.ButtonSave.Text = "Lưu danh sách";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonFixInfomation
            // 
            this.ButtonFixInfomation.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonFixInfomation.Location = new System.Drawing.Point(434, 671);
            this.ButtonFixInfomation.Name = "ButtonFixInfomation";
            this.ButtonFixInfomation.Size = new System.Drawing.Size(226, 46);
            this.ButtonFixInfomation.TabIndex = 14;
            this.ButtonFixInfomation.Text = "Sửa thông tin";
            this.ButtonFixInfomation.UseVisualStyleBackColor = true;
            this.ButtonFixInfomation.Click += new System.EventHandler(this.ButtonFixInfomation_Click);
            // 
            // ButtonRefreshDataGridView
            // 
            this.ButtonRefreshDataGridView.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonRefreshDataGridView.Location = new System.Drawing.Point(1222, 297);
            this.ButtonRefreshDataGridView.Name = "ButtonRefreshDataGridView";
            this.ButtonRefreshDataGridView.Size = new System.Drawing.Size(107, 33);
            this.ButtonRefreshDataGridView.TabIndex = 15;
            this.ButtonRefreshDataGridView.Text = "Refresh";
            this.ButtonRefreshDataGridView.UseVisualStyleBackColor = true;
            this.ButtonRefreshDataGridView.Click += new System.EventHandler(this.ButtonRefreshDataGridView_Click);
            // 
            // ServerMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.ButtonRefreshDataGridView);
            this.Controls.Add(this.ButtonFixInfomation);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonDeleteMember);
            this.Controls.Add(this.ButtonAddMember);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PictureMemberBox);
            this.Controls.Add(this.DataMemberList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerMainWindow";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerMainWindow_FormClosed);
            this.Load += new System.EventHandler(this.ServerMainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataMemberList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMemberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataMemberList;
        private System.Windows.Forms.PictureBox PictureMemberBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Button ButtonAddMember;
        private System.Windows.Forms.Button ButtonDeleteMember;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonFixInfomation;
        private System.Windows.Forms.Button ButtonRefreshDataGridView;
    }
}

