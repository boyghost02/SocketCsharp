using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using ClassListMemberInfomationWithImage;

namespace ClientProgram
{
    public partial class ClientProgram : Form
    {
        public ClientProgram()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Connect();
        }

        IPEndPoint IP;
        Socket client;
        //kết nối
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối server", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connect();
            }
            ButtonRefreshDataGridView_Click(null, null);
        }

        //đóng kết nối
        void CloseWindow()
        {
            client.Close();
        }

        //load danh sách khi load cửa sổ
        private void Client_Load(object sender, EventArgs e)
        {
            LoadListMember();
        }

        //đóng kết nối khi đóng window
        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseWindow();
        }

        #region Data_Member_List
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

            colMemberName.Width = 375;
            colMemberID.Width = 270;
            colMemberPhoneNumber.Width = 270;
            colMemberEmail.Width = 370;

            DataMemberList.Columns.AddRange(new DataGridViewColumn[] { colMemberName, colMemberID, colMemberPhoneNumber, colMemberEmail });
        }

        //load thông tin vào cột
        private void LoadListMember()
        {
            DataMemberList.DataSource = null;
            CreatColumnForListMember();
            if (ListMemberWithImage.Instance.ListMemberInfomation.Count != 0)
                DataMemberList.DataSource = ListMemberWithImage.Instance.ListMemberInfomation;
            DataMemberList.Refresh();
        }

        //load thông tin lên các text box
        int index = -1;
        private void DataMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0 && ListMemberWithImage.Instance.ListMemberInfomation.Count != 0)
            {
                NameBox.Text = DataMemberList.Rows[index].Cells[0].Value.ToString();
                IdBox.Text = DataMemberList.Rows[index].Cells[1].Value.ToString();
                PhoneBox.Text = DataMemberList.Rows[index].Cells[2].Value.ToString();
                EmailBox.Text = DataMemberList.Rows[index].Cells[3].Value.ToString();
                PictureMemberBox.Image = ConvertByteToImage(ListMemberWithImage.Instance.ListMemberInfomation[index].MemberImage);
            }
        }
        #endregion Data_Member_List

        #region Buttons_Are_Pressed
        //Refresh button
        private void ButtonRefreshDataGridView_Click(object sender, EventArgs e)
        {
            ReceiceData();
            LoadListMember();
        }

        //Search button
        private void ButtonSearchMember_Click(object sender, EventArgs e)
        {
            SearchWindow SearchWindowForm = new SearchWindow();
            SearchWindowForm.ShowDialog();
        }

        //Sắp xếp khi nhấn vào header các cột
        private void DataMemberList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ind = e.ColumnIndex;
            ListMemberWithImage.Instance.Sort(ind);
            LoadListMember();
        }
        #endregion Buttons_Are_Pressed

        #region Data_Processing
        //nhận dữ liệu từ server
        void ReceiceData()
        {
            try
            {
                //gửi tin hiệu xin dữ liệu
                client.Send(Serialize("GetData"));

                byte[] data = new byte[1024 * 5120];
                client.Receive(data);
                ListMemberWithImage.Instance.ListMemberInfomation = (List<MemberInfomationWithImage>)Deserialize(data);
                DirectoryInfo creatFolder = new DirectoryInfo(@".\SavePicture");
                if (!creatFolder.Exists)
                    creatFolder.Create();
                foreach (MemberInfomationWithImage member in ListMemberWithImage.Instance.ListMemberInfomation)
                {                    
                    string fileName = @".\SavePicture\"+member.MemberID.ToString()+".jpg";
                    ConvertByteToImage(member.MemberImage).Save(fileName);
                }
            }
            catch
            {

            }
        }

#pragma warning disable SYSLIB0011
        //phân mảnh dữ liệu
        public byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        //gom mảnh dữ liệu đã phân mảnh
        public object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            stream.Position = 0;
            return formatter.Deserialize(stream);
        }

        //byte to image
        private Image ConvertByteToImage(byte[] imgBytes)
        {
            if (imgBytes == null)
                return null;
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
#pragma warning restore SYSLIB0011
        #endregion Data_Processing
    }
}