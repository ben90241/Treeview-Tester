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

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", "Warning");
        }

        private void TvLoadXML_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tvLoadXML.Nodes.Clear();
            tvLoadXML.Refresh();
            XmlDocument xml_doc = new XmlDocument();
            String path = Application.StartupPath;
            xml_doc.Load(path+@"\123.xml");
            //LinkedList<Data> list = new LinkedList<Data>();

            XmlNode root = xml_doc.SelectSingleNode("Table1");
            if (root != null)
            {
                Data data = new Data();
            }
        }
    }
}
