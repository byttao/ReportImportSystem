using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraEditors;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace ReportImportSystem
{
    public partial class Main : XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btSet_Click(object sender, EventArgs e)
        {
            XtraFormItem formItem = new XtraFormItem();
            formItem.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel文件(*.xls)|*.xls|所有文件|*.*";
            ofd.ValidateNames = true;
            ofd.CheckPathExists = true;
            ofd.CheckFileExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                IWorkbook workbook;
                List<List<string>> zcfzb = new List<List<string>>();
                List<List<string>> lrb = new List<List<string>>();
                using (FileStream fs = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read))
                {
                    workbook = new HSSFWorkbook(fs);
                    ISheet sheet = workbook.GetSheet("取数");
                    int rowK,rowZ;
                    rowK = int.Parse(GetString(sheet.GetRow(0).GetCell(1)));
                    rowZ = int.Parse(GetString(sheet.GetRow(0).GetCell(2)));
                    for (int i = rowK; i <= rowZ; i++)
                    {
                            var list = new List<string>();
                            for (int j = 0; j < 7; j++)
                            {
                                list.Add(GetString(sheet.GetRow(i).GetCell(j)));
                            }
                            zcfzb.Add(list);

                    }
                    rowK = int.Parse(GetString(sheet.GetRow(1).GetCell(1)));
                    rowZ = int.Parse(GetString(sheet.GetRow(1).GetCell(2)));
                    for (int i = rowK; i <= rowZ; i++)
                    {
                            var list = new List<string>();
                            for (int j = 8; j < 12; j++)
                            {
                                list.Add(GetString(sheet.GetRow(i).GetCell(j)));
                            }
                            lrb.Add(list);
                    }
                }

                string nsrsbh = "91350203MA2XTLL347";
                string nsrmc = "厦门馥蕾餐饮管理有限公司";
                string license = "7fdd4b67ce41e9c916172dfd0499b8ad";
                string sequence = Guid.NewGuid().ToString("N"); // e0a953c3ee6040eaa9fae2b667060e09
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");//yyyy MM dd HH24 mi ss SSS 年月日24时分秒毫秒
                Cauthen CS = new Cauthen("100008", nsrsbh, nsrmc, license, sequence, timestamp, "0", "2018-04-01", "2018-06-30");
                XDocument document;
                //获取到XML的根元素进行操作
                document = XDocument.Load(System.AppDomain.CurrentDomain.BaseDirectory + @"template\100008.xml");
                Func.ProduceReportBody(ref document, "100008", CS, zcfzb, lrb);
                document.Save(System.AppDomain.CurrentDomain.BaseDirectory + @"template\100008.xml");
                //将XML文件加载进来
                document = XDocument.Load(System.AppDomain.CurrentDomain.BaseDirectory + @"template\envelope.xml");
                Func.ProduceEnvelopeBody(ref document, CS);
                document.Save(System.AppDomain.CurrentDomain.BaseDirectory + @"template\envelope.xml");
                richTextBox1.Text= Func.Upload("100008");
            }
        }

        string GetString(ICell cell)
        {
            if (cell == null)
                return "";
            switch (cell.CellType)
            {
                case CellType.Blank: //BLANK:  
                case CellType.Error: //ERROR:  
                    return "";
                case CellType.String: //STRING:  
                    return cell.StringCellValue;
                default:
                    return cell.NumericCellValue.ToString();
            }
        }
    }
}
