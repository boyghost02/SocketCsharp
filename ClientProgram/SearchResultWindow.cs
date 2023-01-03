using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ClientProgram
{
    public partial class SearchResultWindow : Form
    {
        public SearchResultWindow()
        {
            InitializeComponent();
        }

        public SearchResultWindow(ClassListMemberInfomationWithImage.MemberInfomationWithImage member)
        {
            InitializeComponent();
            NameBox.Text = member.MemberName;
            IdBox.Text = member.MemberID.ToString();
            PhoneBox.Text = member.MemberPhoneNumber;
            EmailBox.Text = member.MemberEmail;
            PictureMemberBox.Image = ConvertByteToImage(member.MemberImage);
        }

        private Image ConvertByteToImage(byte[] imgBytes)
        {
            if (imgBytes == null)
                return null;
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
