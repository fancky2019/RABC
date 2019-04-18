using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using RABC.Common;
namespace RABC.Dal.XML
{
   public class XMLHelper
    {
        public static XMLHelper Instance { get; set; }
        static XMLHelper()
        {
            Instance = new XMLHelper();
        }

        private XMLHelper()
        {

        }

        /// <summary>
        /// 创建xml文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileName"></param>
        public void CreateXML<T>()
        {
            string modelName = typeof(T).Name;
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"data\\{modelName}.xml");
         
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            //if (!File.Exists(Path.Combine(path, fileName)))
            //{
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(dec);
            //根节点  
            XmlElement root = doc.CreateElement(modelName);
            doc.AppendChild(root);
            doc.Save(filePath);
            //}
        }


        /// <summary>
        /// 写入xml数据
        /// </summary>
        /// <param name="productList"></param>
        public int WriteDatas<T>(T model)
        {
            try
            {
                string name =model.GetType().Name;
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"data\\{name}.xml");
                if (!File.Exists(path))
                {
                    XMLHelper.Instance.CreateXML<T>();
                }
                XmlDocument xmlDocument = new XmlDocument();

                xmlDocument.Load(path);
                XmlNode root = xmlDocument.SelectSingleNode(name);

                XmlNode node = xmlDocument.CreateNode("element", "Data", "");
                PropertyInfo[] infoArray = typeof(T).GetProperties();
                foreach (PropertyInfo info in infoArray)
                {
                    XmlElement element = xmlDocument.CreateElement(info.Name);
                    element.InnerText = info.GetValue(model)?.ToString();
                    node.AppendChild(element);
                }
                root.AppendChild(node);

                xmlDocument.Save(path);
                return 1;

            }
            catch (Exception ex)
            {
                Log.Error<XMLHelper>(ex.ToString());
                return 0;
            }
        }


        public int GetMaxID<T>()
        {
            string name = typeof(T).Name;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"data\\{name}.xml");
            if (!File.Exists(path))
            {
                return 0;
            }
            XDocument doc = XDocument.Load(path);
            string id = doc.Element(name).Elements("Data").Max(p => p.Element("ID").Value);
            //XElement element = doc.Element(name).Elements("Data").Where(p => p.Element("ID").Value == ).FirstOrDefault();
            //Team team = new Team();
            //team.ID = int.Parse(element.Elements("ID").First().Value);
            //team.ParentID = int.Parse(element.Elements("ParentID").First().Value);
            //team.TeamName = element.Elements("TeamName").First().Value;
            //team.Saler = element.Elements("Saler").First().Value;
            return int.Parse(id);
        }

        /// <summary>
        /// 读取xml
        /// </summary>
        /// <returns></returns>
        public List<T> ReadAllXMLData<T>()
        {
            Type type = typeof(T);
            string name = type.Name;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"data\\{name}.xml");
            if (!File.Exists(Path.Combine(path)))
            {
                return null;
            }

            List<T> list = new List<T>();
            XDocument doc = XDocument.Load(path);
            IEnumerable<XElement> node = doc.Element(name).Elements("Data");
            PropertyInfo[] properties = type.GetProperties();
            foreach (XElement element in node)
            {
                T t = Activator.CreateInstance<T>();
                foreach(PropertyInfo property in properties)
                {
                    string propertyName = property.Name;
                    property.SetValue(t, property.PropertyType.GetValueByString( element.Elements(propertyName).FirstOrDefault().Value ));
                }
                list.Add(t);
            }
            return list;

        }

        public T GetModelByID<T>(int id)
        {
            Type type = typeof(T);
            string name = type.Name;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"data\\{name}.xml");
            if (!File.Exists(Path.Combine(path)))
            {
                return default(T);
            }
            XDocument doc = XDocument.Load(path);
            XElement element = doc.Element(name).Elements("Data").Where(p => p.Element("ID").Value == id.ToString()).FirstOrDefault(); ;
            if(element==null)
            {
                return default(T);
            }
            PropertyInfo[] properties = type.GetProperties();
          
                T t = Activator.CreateInstance<T>();
                foreach (PropertyInfo property in properties)
                {
                    string propertyName = property.Name;
                    property.SetValue(t, property.PropertyType.GetValueByString(element.Elements(propertyName).FirstOrDefault().Value));
                }
            
            return t;
        }

        /// <summary>
        /// XElement
        /// </summary>
        /// <returns></returns>
        public List<T> ReadXElementData<T>(IEnumerable<XElement> node)
        {
            Type type = typeof(T);
            List<T> list = new List<T>();
            PropertyInfo[] properties = type.GetProperties();
            foreach (XElement element in node)
            {
                T t = Activator.CreateInstance<T>();
                foreach (PropertyInfo property in properties)
                {
                    string propertyName = property.Name;
                    property.SetValue(t, property.PropertyType.GetValueByString(element.Elements(propertyName).FirstOrDefault().Value));
                }
                list.Add(t);
            }
            return list;

        }
    }
}
