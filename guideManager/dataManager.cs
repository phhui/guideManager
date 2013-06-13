using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Xml;
using System.Collections;

namespace guideManager
{
    class dataManager
    {
        public static dataManager dm;
        public dataManager()
        {
            if (dm!=null) throw new Exception("单例~~");
        }
        public static dataManager getThis()
        {
            if (dm == null) dm = new dataManager();
            return dm;
        }
        public string path = "";
        public Form1 fm;
        public ArrayList idList = new ArrayList();//ID列表
        public ArrayList infoList = new ArrayList();//注释列表
        public Dictionary<string, string> gList = new Dictionary<string, string>();//ID字典
        public Dictionary<string, XmlElement> iList = new Dictionary<string, XmlElement>();//注释字典
        public Dictionary<string, XmlElement> xmlList = new Dictionary<string, XmlElement>();//ID字典，存XML格式
        public string currentId = "";//当前项
        public void resetData()
        {
            idList.Clear();
            infoList.Clear();
            gList.Clear();
            iList.Clear();
            xmlList.Clear();
        }
    }
}
