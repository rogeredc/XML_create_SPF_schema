using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;

namespace XMLcreate
{
    class XmlProcess_Property
    {
        public string ExcelFullName { get; set; }
        //建構子
        public XmlProcess_Property(string fileName)
        {
            this.ExcelFullName = fileName;
        }
        public XmlDocument Export()
        {
            DataSet ds = new DataSet("ds");
            DataTable dt = new DataTable("dt");

            string path = this.ExcelFullName;
            ExcelProcess excel1 = new ExcelProcess(this.ExcelFullName);

            ds = excel1.Import();
            dt = ds.Tables["Property"];







            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            //建立根節點
            XmlElement container = doc.CreateElement("Container");
            container.SetAttribute("version", "1.0");
            container.SetAttribute("SoftwareVersion", "04.02.00.14");
            container.SetAttribute("Scope", "");
            container.SetAttribute("IRel_DomainUID2", "Auto");
            container.SetAttribute("IRel_DomainUID1", "Auto");
            container.SetAttribute("IObject_UniqueKey", "Auto");
            container.SetAttribute("IObject_TerminationDate", "9999/12/31-23:59:59:999");
            container.SetAttribute("IObject_OBID", "Auto");
            container.SetAttribute("IObject_LastUpdatedDate", "Now");
            container.SetAttribute("IObject_DomainUID", "Auto");
            container.SetAttribute("IObject_CreationUser", "superuser");
            container.SetAttribute("IObject_CreationDate", "Now");
            container.SetAttribute("IObject_ContainerID", "CDWDEV.Schema");
            container.SetAttribute("CompSchema", "");
            doc.AppendChild(container);


            foreach (DataRow dr in dt.Rows)
            {
                //建立Property def
                XmlElement PropertyDef = doc.CreateElement("PropertyDef");
                container.AppendChild(PropertyDef);

                //建立Property def的子節點-----IObject_Interface
                XmlElement IObject_Interface = doc.CreateElement("IObject");
                IObject_Interface.SetAttribute("Name", dr["Property name"].ToString());
                IObject_Interface.SetAttribute("UID", dr["Property name"].ToString());
                PropertyDef.AppendChild(IObject_Interface);

                //建立Property def的子節點-----IObject_ISchemaObj
                XmlElement IObject_ISchemaObj = doc.CreateElement("ISchemaObj");
                IObject_ISchemaObj.SetAttribute("DisplayName", dr["Property displayname"].ToString());
                PropertyDef.AppendChild(IObject_ISchemaObj);


                //建立Realizes def
                XmlElement RealizesDef = doc.CreateElement("Rel");
                container.AppendChild(RealizesDef);

                //建立Realizes def的子節點-----IObject_Interface
                XmlElement IObject_Realizes = doc.CreateElement("IObject");
                IObject_Realizes.SetAttribute("UID", dr["Interface name"].ToString() + "." + dr["Property name"].ToString() + ".Exposes");
                RealizesDef.AppendChild(IObject_Realizes);

                //建立Realizes def的子節點-----IObject_Interface
                XmlElement IRel_Realizes = doc.CreateElement("IRel");
                IRel_Realizes.SetAttribute("UID1", dr["Interface name"].ToString());
                IRel_Realizes.SetAttribute("DefUID", "Exposes");
                IRel_Realizes.SetAttribute("IsRequired", "False");
                IRel_Realizes.SetAttribute("UID2", dr["Property name"].ToString());
                RealizesDef.AppendChild(IRel_Realizes);




                //建立Implies def
                XmlElement ImpliesDef = doc.CreateElement("Rel");
                container.AppendChild(ImpliesDef);

                //建立Realizes def的子節點-----IObject_Interface
                XmlElement IObject_Implies = doc.CreateElement("IObject");
                IObject_Implies.SetAttribute("UID", dr["Property name"].ToString() + "." + dr["Scopeby"].ToString() + ".ScopedBy");
                ImpliesDef.AppendChild(IObject_Implies);

                //建立Realizes def的子節點-----IObject_Interface
                XmlElement IRel_Implies = doc.CreateElement("IRel");
                IRel_Implies.SetAttribute("UID1", dr["Property name"].ToString());
                IRel_Implies.SetAttribute("DefUID", "ScopedBy");
                IRel_Implies.SetAttribute("IsRequired", "False");
                IRel_Implies.SetAttribute("UID2", dr["Scopeby"].ToString());
                ImpliesDef.AppendChild(IRel_Implies);
            }


            return doc;
        }
    }
}
