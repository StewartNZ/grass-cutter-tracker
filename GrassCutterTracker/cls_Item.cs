using System;
using System.Collections.Generic;

namespace GrassCutterTracker
{
    [Serializable]
    public class cls_Item
    {
        public static readonly Dictionary<int, string> ItemTypes = new Dictionary<int, string>
        {
            {0, "Push Mower"},
            {1, "Ride-On Mower"},
            {2, "Other"}
        };

        private static frm_Item _Form = new frm_Item();

        private string _Code;
        private string _Name;
        private DateTime _Date = DateTime.Today;
        private bool _Paid = false;
        private int _Type;

        public string Code { get => _Code; set => _Code = value; }
        public string Name { get => _Name; set => _Name = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public bool Paid { get => _Paid; set => _Paid = value; }
        public int Type { get => _Type; set => _Type = value; }

        public bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }
    }
}
