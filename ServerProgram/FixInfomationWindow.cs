using System;
using System.Drawing;
using System.Windows.Forms;

namespace ServerProgram
{
    public partial class FixInfomationWindow : Form
    {
        private int index = -1;
        public FixInfomationWindow()
        {
            InitializeComponent();
        }

        private static string FileName = "";

        public void LoadListMember()
        {
            DataMemberList.DataSource = null;
            CreatColumnForListMember();
            DataMemberList.DataSource = ListMember.Instance.ListMemberInfomation;
            DataMemberList.Refresh();
        }

        void CreatColumnForListMember()
        {
            var colMemberName = new DataGridViewTextBoxColumn();
            var colMemberID = new DataGridViewTextBoxColumn();
            var colMemberPhoneNumber = new DataGridViewTextBoxColumn();
            var colMemberEmail = new DataGridViewTextBoxColumn();

            colMemberName.HeaderText = "Họ và tên";
            colMemberID.HeaderText = "Mã số";
            colMemberPhoneNumber.HeaderText = "Số điện thoại";
            colMemberEmail.HeaderText = "Email";

            colMemberName.DataPropertyName = "MemberName";
            colMemberID.DataPropertyName = "MemberID";
            colMemberPhoneNumber.DataPropertyName = "MemberPhoneNumber";
            colMemberEmail.DataPropertyName = "MemberEmail";

            colMemberName.Width = 300;
            colMemberID.Width = 175;
            colMemberPhoneNumber.Width = 175;
            colMemberEmail.Width = 270;

            DataMemberList.Columns.AddRange(new DataGridViewColumn[] { colMemberName, colMemberID, colMemberPhoneNumber, colMemberEmail });
        }

        //load danh sách khi load cửa sổ
        private void FixInfomationWindow_Load(object sender, EventArgs e)
        {
            LoadListMember();
        }

        //load thành viên lên textbox
        private void DataMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                NameBox.Text = DataMemberList.Rows[index].Cells[0].Value.ToString();
                IdBox.Text = DataMemberList.Rows[index].Cells[1].Value.ToString();
                PhoneBox.Text = DataMemberList.Rows[index].Cells[2].Value.ToString();
                EmailBox.Text = DataMemberList.Rows[index].Cells[3].Value.ToString();
                if (!string.IsNullOrEmpty(ListMember.Instance.ListMemberInfomation[index].MemberImageAddress))
                {
                    Image memberImage = Image.FromFile(ListMember.Instance.ListMemberInfomation[index].MemberImageAddress);
                    PictureBox.Image = memberImage;
                }
                else
                {
                    PictureBox.Image = null;
                }
            }
        }

        //nhấn nút SỬA sẽ cập nhật lại danh sách
        private void AcceptButton_Click(object sender, EventArgs e)
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
            string MemberName_ = NameBox.Text;
            string tMemberID_ = IdBox.Text;
            string MemberPhoneNumber_ = PhoneBox.Text;
            string MemberEmail_ = EmailBox.Text;
            string MemberImageAddress_ = FileName;
            if (MemberName_ == string.Empty || tMemberID_ == string.Empty || MemberPhoneNumber_ == string.Empty || MemberEmail_ == string.Empty || string.IsNullOrEmpty(ListMember.Instance.ListMemberInfomation[index].MemberImageAddress+MemberImageAddress_)   )
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
                if (!string.IsNullOrEmpty(MemberImageAddress_))
                {
                    ListMember.Instance.ListMemberInfomation[index].FixInfomationMember(MemberName_, MemberID_, MemberPhoneNumber_, MemberEmail_, MemberImageAddress_);
                }
                else
                {
                    ListMember.Instance.ListMemberInfomation[index].FixInfomationMember(MemberName_, MemberID_, MemberPhoneNumber_, MemberEmail_);
                }
                FileName = null;
                MessageBox.Show("Sửa thông tin thành viên thành công !!!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadListMember();
            }
        }

        //đóng cửa sổ khi nhấn thoát
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //mở file director khi nhấn vào nút thêm
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