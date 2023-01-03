using System;
using System.Drawing;
using System.Windows.Forms;

namespace ServerProgram
{
    public partial class AddNewMemberWindow : Form
    {
        public AddNewMemberWindow()
        {
            InitializeComponent();
        }

        private static string FileName = "";

        //thêm thành viên khi nhấn nút thêm
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            //check input có phải là số không ?
            bool IsNumber(string pValue)
            {
                foreach (Char c in pValue)
                {
                    if (!Char.IsDigit(c))
                        return false;
                }
                return true;
            }
            string MemberName_ = NameBox.Text;
            string tMemberID_ = IdBox.Text;
            string MemberPhoneNumber_ = PhoneNumberBox.Text;
            string MemberEmail_ = EmailBox.Text;
            string MemberImageAddress_ = FileName;
            if (MemberName_ == string.Empty || tMemberID_ == string.Empty || MemberPhoneNumber_ == string.Empty || MemberEmail_ == string.Empty || FileName == string.Empty) 
            {
                MessageBox.Show("Không thể có bất cứ ô vào trống !!!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!IsNumber(tMemberID_) || !IsNumber(MemberPhoneNumber_)) 
            {
                MessageBox.Show("Mã số và số điện thoại chỉ chứa ký tự số !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int MemberID_ = Int32.Parse(tMemberID_);
                ListMember.Instance.ListMemberInfomation.Add(new MemberInfomation(MemberName_, MemberID_, MemberPhoneNumber_, MemberEmail_,MemberImageAddress_));
                NameBox.Clear();
                IdBox.Clear();
                PhoneNumberBox.Clear();
                EmailBox.Clear();
                PictureBox.Image = null;
                FileName = null;
                MessageBox.Show("Thêm thành viên thành công !!!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        //đóng cửa sổ khi nhấn THOÁT
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            openFile.ShowDialog();
            FileName = openFile.FileName;
            if (string.IsNullOrEmpty(FileName))
                return;
            Image memberImage = Image.FromFile(FileName);
            PictureBox.Image = memberImage;
        }
    }
}
