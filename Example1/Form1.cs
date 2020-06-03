using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Example1
{
    public partial class Form1 : Form
    {
        class Data
        {
            public 
            string Id;
            string Name;
            string Position;
            string Adress;
            string Phone;            
        }

        /*class parsedData
        {
            Data d = new Data();

            public parsedData()
            {

            }
            void setsize(int sz)
            {
                d = new Data(sz);
                for(int i = 0; i < sz; i++)
                {
                    d[i] = new Data();
                }
            }
        }*/
        public Form1()
        {
            InitializeComponent();
        }


        private void tvloadXML()
        {
            tvLoadXML.Nodes.Clear();
            tvLoadXML.Refresh();
            XmlDataDocument xml_doc = new XmlDataDocument();
            String path = Application.StartupPath;

            xml_doc.Load(path+@"\123.xml");
            XmlNode root;

            root = xml_doc.ChildNodes[0];
            tvLoadXML.Nodes.Add(new TreeNode(xml_doc.DocumentElement.Name));
            TreeNode node;
            node = tvLoadXML.Nodes[0];

            addNodes(root, node);
            /*XmlNode root = xml_doc.SelectSingleNode("Table1");
            if (root != null)
            {
                Data data = new Data();
            }*/
        }

        void addNodes(XmlNode xNode, TreeNode tNode)
        {
            XmlNode x_node;
            TreeNode t_node;
            XmlNodeList nodeList;

            if(xNode.HasChildNodes)
            {
                nodeList = xNode.ChildNodes;
                for(int i=0;i<=nodeList.Count-1;i++)
                {
                    x_node = xNode.ChildNodes[i];
                    tNode.Nodes.Add(new TreeNode(x_node.Name));
                    t_node = tNode.Nodes[i];
                    addNodes(x_node, t_node);
                }
            }
            else
            {
                tNode.Text = xNode.InnerText.ToString();
            }
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            tvloadXML();
        }
    }
}
