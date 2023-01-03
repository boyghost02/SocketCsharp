using System;
using System.Collections.Generic;

namespace ClassListMemberInfomationWithImage
{
    [Serializable]
    public class MemberInfomationWithImage
    {
        private string MemberName_;
        private int MemberID_;
        private string MemberPhoneNumber_;
        private string MemberEmail_;
        private byte[] MemberImage_;

        public string MemberName { get => MemberName_; set => MemberName_ = value; }
        public int MemberID { get => MemberID_; set => MemberID_ = value; }
        public string MemberPhoneNumber { get => MemberPhoneNumber_; set => MemberPhoneNumber_ = value; }
        public string MemberEmail { get => MemberEmail_; set => MemberEmail_ = value; }
        public byte[] MemberImage { get => MemberImage_; set => MemberImage_ = value; }

        public MemberInfomationWithImage(string name, int id, string phone, string email, byte[] image)
        {
            this.MemberName = name;
            this.MemberID = id;
            this.MemberPhoneNumber = phone;
            this.MemberEmail = email;
            this.MemberImage = image;
        }
    }

    [Serializable]
    public class ListMemberWithImage
    {
        private static ListMemberWithImage instance; //singleton
        List<MemberInfomationWithImage> ListMemberInfomation_;

        public List<MemberInfomationWithImage> ListMemberInfomation { get => ListMemberInfomation_; set => ListMemberInfomation_ = value; }

        public static ListMemberWithImage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListMemberWithImage();
                }
                return instance;
            }
            set => instance = value;
        }
        public ListMemberWithImage()
        {
            ListMemberInfomation = new List<MemberInfomationWithImage>();
        }

        public void Sort(int type)
        {
            if (type == 0) Instance.SortByName();
            if (type == 1) Instance.SortByID();
            if (type == 2) Instance.SortByPhoneNumber();
            if (type == 3) Instance.SortByEmail();
        }

        private void SortByName()
        {
            int n = Instance.ListMemberInfomation.Count;
            for (int i = 1; i < n; i++)
            {
                var key = Instance.ListMemberInfomation[i];
                int j = i - 1;
                while (j >= 0 && string.Compare(Instance.ListMemberInfomation[j].MemberName, key.MemberName) == 1)
                {
                    Instance.ListMemberInfomation[j + 1] = Instance.ListMemberInfomation[j];
                    j--;
                }
                Instance.ListMemberInfomation[j + 1] = key;
            }
        }
        private void SortByID()
        {
            int n = Instance.ListMemberInfomation.Count;
            for (int i = 1; i < n; i++)
            {
                var key = Instance.ListMemberInfomation[i];
                int j = i - 1;
                while (j >= 0 && Instance.ListMemberInfomation[j].MemberID > key.MemberID)
                {
                    Instance.ListMemberInfomation[j + 1] = Instance.ListMemberInfomation[j];
                    j--;
                }
                Instance.ListMemberInfomation[j + 1] = key;
            }
        }

        private void SortByPhoneNumber()
        {
            int n = Instance.ListMemberInfomation.Count;
            for (int i = 1; i < n; i++)
            {
                var key = Instance.ListMemberInfomation[i];
                int j = i - 1;
                while (j >= 0 && Int64.Parse(Instance.ListMemberInfomation[j].MemberPhoneNumber) > Int64.Parse(key.MemberPhoneNumber)) 
                {
                    Instance.ListMemberInfomation[j + 1] = Instance.ListMemberInfomation[j];
                    j--;
                }
                Instance.ListMemberInfomation[j + 1] = key;
            }
        }
        private void SortByEmail()
        {
            int n = Instance.ListMemberInfomation.Count;
            for (int i = 1; i < n; i++)
            {
                var key = Instance.ListMemberInfomation[i];
                int j = i - 1;
                while (j >= 0 && string.Compare(Instance.ListMemberInfomation[j].MemberEmail, key.MemberEmail) == 1)
                {
                    Instance.ListMemberInfomation[j + 1] = Instance.ListMemberInfomation[j];
                    j--;
                }
                Instance.ListMemberInfomation[j + 1] = key;
            }
        }
    }

}
