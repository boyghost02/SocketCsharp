using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using System.Drawing;
using ClassListMemberInfomationWithImage;

namespace ServerProgram
{
    public partial class ServerMainWindow : Form
    {
        private int index = -1;
        public ServerMainWindow()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Connect();
        }

        private void ServerMainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseWindow();
            Application.Exit();
        }

        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;

        //kết nối
        void Connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);


            server.Bind(IP);

            Thread listen = new Thread(() =>
            {
               try
               {
                   while (true)
                   {
                       server.Listen(10000);
                       Socket client = server.Accept();

                       clientList.Add(client);

                       Thread receive = new Thread(ReceiveAndReply);
                       receive.IsBackground = true;
                       receive.Start(client);
                   }
               }
               catch
               {
                   IP = new IPEndPoint(IPAddress.Any, 9999);
                   server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
               }
            });
            listen.IsBackground = true;
            listen.Start();
        }

        //đóng kết nối
        void CloseWindow()
        {
            server.Close();
        }

        #region Data_Member_List
        //load chương trình
        private void ServerMainWindow_Load(object sender, System.EventArgs e)
        {
            ImportJson();
            LoadListMember();
        }

        //tạo cột
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
            colMemberEmail.Width = 365;

            DataMemberList.Columns.AddRange(new DataGridViewColumn[] {colMemberName, colMemberID, colMemberPhoneNumber, colMemberEmail });
        }

        //load thông tin vào cột
        public void LoadListMember()
        {
            DataMemberList.DataSource = null;
            CreatColumnForListMember();
            if (ListMember.Instance.ListMemberInfomation.Count != 0)
                DataMemberList.DataSource = ListMember.Instance.ListMemberInfomation;
            DataMemberList.Refresh();
        }

        //load thông tin lên các text box
        private void DataMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0 && ListMember.Instance.ListMemberInfomation.Count != 0) 
            { 
                NameBox.Text = DataMemberList.Rows[index].Cells[0].Value.ToString();
                IdBox.Text = DataMemberList.Rows[index].Cells[1].Value.ToString();               
                PhoneBox.Text = DataMemberList.Rows[index].Cells[2].Value.ToString();
                EmailBox.Text = DataMemberList.Rows[index].Cells[3].Value.ToString();
                if (!string.IsNullOrEmpty(ListMember.Instance.ListMemberInfomation[index].MemberImageAddress))
                {
                    Image memberImage = Image.FromFile(ListMember.Instance.ListMemberInfomation[index].MemberImageAddress);
                    PictureMemberBox.Image = memberImage;
                }
                else
                {
                    PictureMemberBox.Image = null;
                }
            }
        }

        //đọc file Json chứa thông tin thành viên
        void ImportJson()
        {
            try
            {
                using (StreamReader reader = new StreamReader(@".\MemberList.json"))
                {
                    var json = reader.ReadToEnd();
                    var members = JsonConvert.DeserializeObject<List<MemberInfomation>>(json);
                    if (members != null)
                    {
                        foreach (var member in members)
                        {
                            ListMember.Instance.ListMemberInfomation.Add(new MemberInfomation(member.MemberName, member.MemberID, member.MemberPhoneNumber, member.MemberEmail, member.MemberImageAddress));
                        }
                    }
                }
            }
            catch
            {
                return;    	
            }
        }

        #endregion Data_Member_List

        #region Buttons_Are_Pressed
        //hiển thị cửa sổ khi thêm thành viên mới
        private void ButtonAddMember_Click(object sender, System.EventArgs e)
        {
            AddNewMemberWindow AddMemberForm = new AddNewMemberWindow();
            AddMemberForm.ShowDialog();
        }

        private void ButtonRefreshDataGridView_Click(object sender, System.EventArgs e)
        {
            LoadListMember();
        }
        

        //hiển thị cửa sổ sửa thông tin thành viên
        private void ButtonFixInfomation_Click(object sender, System.EventArgs e)
        {
            FixInfomationWindow FixInfoMemberForm = new FixInfomationWindow();
            FixInfoMemberForm.ShowDialog();
        }

        //Xóa thành viên được chọn
        private void ButtonDeleteMember_Click(object sender, System.EventArgs e)
        {
            ListMember.Instance.ListMemberInfomation.RemoveAt(index);
            MessageBox.Show("Xóa danh sách thông tin thành viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
            LoadListMember();
        }

        //Lưu danh sách thành viên dưới file JSON 
        private void ButtonSave_Click(object sender, System.EventArgs e)
        {
            var filePath = @".\MemberList.json";
            StreamWriter wfile = new StreamWriter(filePath, append: false);
            string json = JsonConvert.SerializeObject(ListMember.Instance.ListMemberInfomation, Formatting.Indented);
            wfile.WriteLine(json);
            MessageBox.Show("Lưu danh sách thông tin thành viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
            wfile.Close();
        }

        //asc sort khi nhấn vào header mỗi cột
        private void DataMemberList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ind = e.ColumnIndex;
            ListMember.Instance.Sort(ind);
            LoadListMember();
        }
        #endregion

        #region Data_Processing
        //nhận tin
        void ReceiveAndReply(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5120];
                    client.Receive(data);

                    string message = (string)Deserialize(data);
                    if (message.Equals("GetData"))
                    {
                        foreach (Socket item in clientList)
                        {
                            if (item != null && item == client)
                                SendData(client);
                        }
                    }
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }
#pragma warning disable SYSLIB0011
        //phân mảnh dữ liệu
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        //gom mảnh dữ liệu đã phân mảnh
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
#pragma warning restore SYSLIB0011
        byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        //gửi thông tin đi đến client
        private void SendData(Socket client)
        {
            if (client != null)
            {
                CreatDataMemberWithImage();

                client.Send(Serialize(ListMemberWithImage.Instance.ListMemberInfomation));
            }
        }

        private void CreatDataMemberWithImage()
        {
            ListMemberWithImage.Instance.ListMemberInfomation.Clear();
            for (int i = 0; i < ListMember.Instance.ListMemberInfomation.Count; i++)
            {

                Image memberImage = Image.FromFile(ListMember.Instance.ListMemberInfomation[i].MemberImageAddress);
                string name = ListMember.Instance.ListMemberInfomation[i].MemberName;
                int id = ListMember.Instance.ListMemberInfomation[i].MemberID;
                string phone = ListMember.Instance.ListMemberInfomation[i].MemberPhoneNumber;
                string email = ListMember.Instance.ListMemberInfomation[i].MemberEmail;
                byte[] image = ImageToByteArray(memberImage);
                ListMemberWithImage.Instance.ListMemberInfomation.Add(new MemberInfomationWithImage(name, id, phone, email, image));
            }
        }

        #endregion Data_Processing
    }
}
