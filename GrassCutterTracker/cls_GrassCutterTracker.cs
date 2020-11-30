using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GrassCutterTracker
{
    [Serializable]
    public static class cls_GrassCutterTracker
    {
        private static Dictionary<string, cls_Item> _ItemList = new Dictionary<string, cls_Item>();

        public static Dictionary<string, cls_Item> ItemList { get => _ItemList; }

        //private static string fileName = "GrassCutterTracker.dat";

        public static void Save(string fileName)
        {
            using (FileStream lcFileStream = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcFormatter.Serialize(lcFileStream, _ItemList);
            }
        }

        public static void Retrieve(string fileName)
        {
            using (FileStream lcfileStream = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                _ItemList = (Dictionary<string, cls_Item>)lcFormatter.Deserialize(lcfileStream);
            }
        }
    }
}
