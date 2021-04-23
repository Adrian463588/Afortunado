using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace TenantMoney
{
    public class borrower
    {
        private string _ID;
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        private string _Job;
        public string Job
        {
            get { return _Job; }
            set { _Job = value; }
        }
        public void Detail(string id, string Name, string Address, string Job)
        {
            _ID = id;
            _Name = Name;
            _Address = Address;
            _Job = Job;
        }


        //private List<Borrowing> _BorrowedVehicle = new List<Borrowing>();
        //public List<Borrowing> BorrowedVehicle
        //{
        //  get
        //    {
        //        return _BorrowedVehicle;
        //    }
        //}
        // public abstract int DUE_DAYS();

        // private int DUE_DAYS
        // {
        //     get
        //     {
        //         int i = 0;
        //         if (_ID.Length < 7) i = 28;
        //         else i = 7;
        //         return i;
        //     }
        // }

        // public DateTime GetDueDate()
        // {
        //     DateTime ret = DateTime.Now;
        //     ret += new TimeSpan(DUE_DAYS, 23 - ret.Hour, 59 - ret.Minute, 59 - ret.Second, 999 - ret.Millisecond);
        //     return ret;
        // }


        // public override string ToString()
        // {
        //     return string.Format("{0}, {1} {2} {3})", _Name, _Address, _Job, _ID);
        // }

        // public string GetDetails()
        // {
        //     StringBuilder sb = new StringBuilder();
        //     sb.AppendLine(string.Format("         ID: {0}", _ID));
        //     sb.AppendLine(string.Format("Name: {0}", _Name));
        //     sb.AppendLine(string.Format("Job : {0}", _Job));


        //     if (_BorrowedVehicle.Count > 0)
        //     {
        //         sb.AppendLine(" Borrowings:");
        //         foreach (Borrowing b in _BorrowedVehicle)
        //             sb.AppendLine(string.Format("\t{0}", b.Item.ToString()));
        //     }
        //     return sb.ToString();
        // }

    }

}