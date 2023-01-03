using System;
using System.Windows.Forms;
using ClassListMemberInfomationWithImage;

namespace ClientProgram
{
    public partial class SearchWindow : Form
    {
        public SearchWindow()
        {
            InitializeComponent();
        }

        private void ButtonSearchMember_Click(object sender, System.EventArgs e)
        {
            bool IsNumber(string pValue)
            {
                foreach (Char c in pValue)
                {
                    if (!Char.IsDigit(c))
                        return false;
                }
                return true;
            }
            string MemberName_ = NameBox.Text.ToLower();
            string MemberID_ = IdBox.Text.ToLower();
            string MemberPhoneNumber_ = PhoneBox.Text.ToLower();
            string MemberEmail_ = EmailBox.Text.ToLower();
            if (!IsNumber(MemberID_) || !IsNumber(MemberPhoneNumber_))
            {
                MessageBox.Show("Mã số và số điện thoại chỉ chứa ký tự số !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ListMemberWithImage SearchList = new ListMemberWithImage();
            foreach (MemberInfomationWithImage member in ListMemberWithImage.Instance.ListMemberInfomation)
            {
                string name = member.MemberName.ToLower();
                string id = member.MemberID.ToString().ToLower();
                string phone = member.MemberPhoneNumber.ToLower();
                string email = member.MemberEmail.ToLower();
                if (name.Contains(MemberName_)
                    && id.Contains(MemberID_)
                    && phone.Contains(MemberPhoneNumber_)
                    && email.Contains(MemberEmail_)) 
                {
                    SearchList.ListMemberInfomation.Add(member);
                }
            }
            if (SearchList.ListMemberInfomation.Count == 0) 
            {
                MessageBox.Show("Không tìm thấy thành viên có thông tin này trong danh sách !!!", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                foreach (MemberInfomationWithImage member in SearchList.ListMemberInfomation)
                {
                    SearchResultWindow result = new SearchResultWindow(member);
                    result.ShowDialog();
                }
            }            
        }
    }
}