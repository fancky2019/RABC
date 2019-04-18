using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using RABC.Common;
using System.Reflection;

namespace RABC.Dal.XML
{
   public class ProductXML
    {
        

        //public int Add(Product product)
        //{
        //    List<Product> l = XMLHelper.Instance.ReadAllXMLData<Product>();
        //    int currentMaxID=  XMLHelper.Instance.GetMaxID<Product>();
        //    product.ID = currentMaxID + 1;
        //    return XMLHelper.Instance.WriteDatas<Product>(product);
        //}

        ///// <summary>
        ///// 读取xml
        ///// </summary>
        ///// <returns></returns>
        //public List<Team> ReadXMLData()
        //{
        //    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Department.xml");
        //    if (!File.Exists(Path.Combine(path)))
        //    {
        //        return null;
        //    }

        //    List<Team> teamList = new List<Team>();

        //    XDocument doc = XDocument.Load(path);
        //    IEnumerable<XElement> node = doc.Element("Department").Elements("Data");

        //    foreach (XElement element in node)
        //    {
        //        Team team = new Team();
        //        team.ID = int.Parse(element.Elements("ID").FirstOrDefault().Value);
        //        team.ParentID = int.Parse(element.Elements("ParentID").FirstOrDefault().Value);
        //        team.TeamName = element.Elements("TeamName").FirstOrDefault().Value;
        //        team.Saler = element.Elements("Saler").FirstOrDefault().Value;
        //        teamList.Add(team);

        //    }
        //    return teamList;

        //}

        ///// <summary>
        ///// 插入
        ///// </summary>
        ///// <param name="team"></param>
        ///// <returns></returns>
        //public int Insert(Team team)
        //{
        //    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Product.xml");
        //    XDocument doc = XDocument.Load(path);
        //    XElement node = doc.Element("Department").Elements().Where(p => string.IsNullOrEmpty(p.Element("Saler").Value)).First();

        //    //XElement node = rootNode.Element("Department").Elements("Data").Where(p =>string.IsNullOrEmpty( p.Element("Saler").Value)).First();
        //    XElement element = new XElement("Data",
        //          new XElement("ID", team.ID),
        //          new XElement("ParentID", team.ParentID),
        //          new XElement("TeamName", team.TeamName),
        //          new XElement("Saler", team.Saler)
        //         );
        //    node.AddBeforeSelf(element);
        //    doc.Save(path);
        //    return 1;
        //}

        //public Team GetXmlNodeByID(int id)
        //{
        //    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Product.xml");
        //    XDocument doc = XDocument.Load(path);
        //    XElement element = doc.Element("Department").Elements("Data").Where(p => p.Element("ID").Value == id.ToString()).FirstOrDefault();
        //    Team team = new Team();
        //    team.ID = int.Parse(element.Elements("ID").First();
        //    team.ParentID = int.Parse(element.Elements("ParentID").First().Value);
        //    team.TeamName = element.Elements("TeamName").First().Value;
        //    team.Saler = element.Elements("Saler").First().Value;
        //    return team;
        //}

        ///// <summary>
        ///// 修改
        ///// </summary>
        ///// <param name="team"></param>
        ///// <returns></returns>
        //public int AlterTeam(Team team)
        //{
        //    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Product.xml");
        //    XDocument doc = XDocument.Load(path);

        //    IEnumerable<XElement> t = doc.Element("Department").Elements("Data").Where(p => p.Element("ID").Value == team.ID.ToString());

        //    XElement elementParentID = t.FirstOrDefault().Elements("ParentID").FirstOrDefault();
        //    elementParentID.Value = team.ParentID.ToString();

        //    XElement elementTeamName = t.FirstOrDefault().Elements("TeamName").FirstOrDefault();
        //    elementTeamName.Value = team.TeamName;

        //    XElement elementSaler = t.FirstOrDefault().Elements("Saler").FirstOrDefault();
        //    elementSaler.Value = team.Saler;

        //    doc.Save(path);
        //    return 1;
        //}

        ///// <summary>
        ///// 删除节点
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public int DeleteNode(int id)
        //{
        //    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Product.xml");
        //    XDocument doc = XDocument.Load(path);

        //    IEnumerable<XElement> t = doc.Element("Department").Elements("Data").Where(p => p.Element("ID").Value == id.ToString());
        //    t.Remove();

        //    doc.Save(path);
        //    return 1;
        //}

    }
}
