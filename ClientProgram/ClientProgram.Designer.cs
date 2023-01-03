
namespace ClientProgram
{
    partial class ClientProgram
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>c
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientProgram));
            this.ButtonRefreshDataGridView = new System.Windows.Forms.Button();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PictureMemberBox = new System.Windows.Forms.PictureBox();
            this.DataMemberList = new System.Windows.Forms.DataGridView();
            this.ButtonSearchMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMemberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRefreshDataGridView
            // 
            this.ButtonRefreshDataGridView.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonRefreshDataGridView.Location = new System.Drawing.Point(1230, 296);
            this.ButtonRefreshDataGridView.Name = "ButtonRefreshDataGridView";
            this.ButtonRefreshDataGridView.Size = new System.Drawing.Size(107, 33);
            this.ButtonRefreshDataGridView.TabIndex = 30;
            this.ButtonRefreshDataGridView.Text = "Refresh";
            this.ButtonRefreshDataGridView.UseVisualStyleBackColor = true;
            this.ButtonRefreshDataGridView.Click += new System.EventHandler(this.ButtonRefreshDataGridView_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailBox.Location = new System.Drawing.Point(856, 214);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.ReadOnly = true;
            this.EmailBox.Size = new System.Drawing.Size(337, 32);
            this.EmailBox.TabIndex = 25;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneBox.Location = new System.Drawing.Point(856, 159);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.ReadOnly = true;
            this.PhoneBox.Size = new System.Drawing.Size(337, 32);
            this.PhoneBox.TabIndex = 24;
            // 
            // IdBox
            // 
            this.IdBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdBox.Location = new System.Drawing.Point(856, 104);
            this.IdBox.Name = "IdBox";
            this.IdBox.ReadOnly = true;
            this.IdBox.Size = new System.Drawing.Size(337, 32);
            this.IdBox.TabIndex = 23;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameBox.Location = new System.Drawing.Point(856, 49);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(337, 32);
            this.NameBox.TabIndex = 22;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(641, 217);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(63, 25);
            this.EmailLabel.TabIndex = 21;
            this.EmailLabel.Text = "Email";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(640, 162);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(129, 25);
            this.PhoneNumberLabel.TabIndex = 20;
            this.PhoneNumberLabel.Text = "Số điện thoại";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.Location = new System.Drawing.Point(640, 107);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(64, 25);
            this.IdLabel.TabIndex = 19;
            this.IdLabel.Text = "Mã số";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(640, 52);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(97, 25);
            this.NameLabel.TabIndex = 18;
            this.NameLabel.Text = "Họ và tên";
            // 
            // PictureMemberBox
            // 
            this.PictureMemberBox.Location = new System.Drawing.Point(70, 12);
            this.PictureMemberBox.Name = "PictureMemberBox";
            this.PictureMemberBox.Size = new System.Drawing.Size(400, 300);
            this.PictureMemberBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureMemberBox.TabIndex = 17;
            this.PictureMemberBox.TabStop = false;
            // 
            // DataMemberList
            // 
            this.DataMemberList.AllowUserToResizeColumns = false;
            this.DataMemberList.AllowUserToResizeRows = false;
            this.DataMemberList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMemberList.Location = new System.Drawing.Point(12, 335);
            this.DataMemberList.Name = "DataMemberList";
            this.DataMemberList.ReadOnly = true;
            this.DataMemberList.RowTemplate.Height = 25;
            this.DataMemberList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataMemberList.Size = new System.Drawing.Size(1326, 382);
            this.DataMemberList.TabIndex = 16;
            this.DataMemberList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMemberList_CellClick);
            this.DataMemberList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataMemberList_ColumnHeaderMouseClick);
            // 
            // ButtonSearchMember
            // 
            this.ButtonSearchMember.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSearchMember.Location = new System.Drawing.Point(1110, 296);
            this.ButtonSearchMember.Name = "ButtonSearchMember";
            this.ButtonSearchMember.Size = new System.Drawing.Size(107, 33);
            this.ButtonSearchMember.TabIndex = 31;
            this.ButtonSearchMember.Text = "Tìm kiếm";
            this.ButtonSearchMember.UseVisualStyleBackColor = true;
            this.ButtonSearchMember.Click += new System.EventHandler(this.ButtonSearchMember_Click);
            // 
            // ClientProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.ButtonSearchMember);
            this.Controls.Add(this.ButtonRefreshDataGridView);
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
            this.Name = "ClientProgram";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureMemberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonRefreshDataGridView;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox PictureMemberBox;
        private System.Windows.Forms.DataGridView DataMemberList;
        private System.Windows.Forms.Button ButtonSearchMember;
    }
}

