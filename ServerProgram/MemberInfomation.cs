
namespace ServerProgram
{
    public class MemberInfomation
    {
        private string MemberName_;
        private int MemberID_;
        private string MemberPhoneNumber_;
        private string MemberEmail_;
        private string MemberImageAddress_;

        public string MemberName { get => MemberName_; set => MemberName_ = value; }
        public int MemberID { get => MemberID_; set => MemberID_ = value; }
        public string MemberPhoneNumber { get => MemberPhoneNumber_; set => MemberPhoneNumber_ = value; }
        public string MemberEmail { get => MemberEmail_; set => MemberEmail_ = value; }
        public string MemberImageAddress { get => MemberImageAddress_; set => MemberImageAddress_ = value; }

        public MemberInfomation(string name,int id,string phone,string email,string image)
        {
            this.MemberName = name;
            this.MemberID = id;
            this.MemberPhoneNumber = phone;
            this.MemberEmail = email;
            this.MemberImageAddress = image;
        }

        public void FixInfomationMember(string name, int id, string phone, string email,string image)
        {
            this.MemberName = name;
            this.MemberID = id;
            this.MemberPhoneNumber = phone;
            this.MemberEmail = email;
            this.MemberImageAddress = image;   
        }

        public void FixInfomationMember(string name, int id, string phone, string email)
        {
            this.MemberName = name;
            this.MemberID = id;
            this.MemberPhoneNumber = phone;
            this.MemberEmail = email;
        }
    }
}