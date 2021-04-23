using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace TenantMoney
{
    public class vehicle
    {
        private static string _Type;
        public string Type
        {
            get {return _Type;}
            set {_Type = value;}
        }
        private static string _ID;
        public string ID
        {
            get {return _ID;}
            set {_ID = value;}
        }
        private static double _Price;
        public double Price
        {
            get {return _Price;}
            set {_Price = value;}
        }
        public void inputkendaraan(string type, string id, int price)
        {
            _Type = type;
            _ID = id;
            _Price = price;
        }
        public void ShowList()
        {

        }
    }
}