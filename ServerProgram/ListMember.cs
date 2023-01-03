using System;
using System.Collections.Generic;

namespace ServerProgram
{
    public class ListMember
    {
        private static ListMember instance; //singleton
        List<MemberInfomation> ListMemberInfomation_;

        public List<MemberInfomation> ListMemberInfomation { get => ListMemberInfomation_; set => ListMemberInfomation_ = value; }

        public static ListMember Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListMember();
                }
                return instance;
            }
            set => instance = value;
        }
        private ListMember()
        {
            ListMemberInfomation = new List<MemberInfomation>();
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
            for(int i=1;i<n;i++)
            {
                var key = Instance.ListMemberInfomation[i];
                int j = i - 1;
                while (j >= 0 && string.Compare(Instance.ListMemberInfomation[j].MemberName, key.MemberName) == 1)
                {
                    Instance.ListMemberInfomation[j + 1] = Instance.ListMemberInfomation[j];
                    j--;
                }
                Instance.ListMemberInfomation[j+1] = key;
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
                Instance.ListMemberInfomation[j+1] = key;
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