using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ReportImportSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btSet_Click(object sender, EventArgs e)
        {

            string nsrsbh = "91350203MA2XTLL347";
            string nsrmc = "厦门馥蕾餐饮管理有限公司";
            string license = "7fdd4b67ce41e9c916172dfd0499b8ad";
            string sequence = Guid.NewGuid().ToString("N"); // e0a953c3ee6040eaa9fae2b667060e09
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");//yyyy MM dd HH24 mi ss SSS 年月日24时分秒毫秒

            //将XML文件加载进来
            XDocument document = XDocument.Load(System.AppDomain.CurrentDomain.BaseDirectory + @"template\envelope.xml");
            //获取到XML的根元素进行操作
            XDocument doc2 = XDocument.Load(System.AppDomain.CurrentDomain.BaseDirectory + @"template\100008.xml");
            //获取name标签的值
            XElement Envelope = document.Element("envelope");

            // Xauthen.Element("envelope").Element("body").Element("logic").Element("cjbbxml").SetValue(doc2.ToString());
            //Envelope.Element("body").Element("logic").Element("cjbbxml").SetValue("doc2.ToString()");
            //MessageBox.Show(Envelope.Element("body").Element("logic").Element("cjbbxml").Value);
            document.Save(System.AppDomain.CurrentDomain.BaseDirectory + @"template\envelope.xml");
        }
    }
}
