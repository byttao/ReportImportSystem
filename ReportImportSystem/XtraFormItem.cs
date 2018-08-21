using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraEditors;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace ReportImportSystem
{
    public partial class XtraFormItem : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormItem()
        {
            InitializeComponent();
            SZRQ(DateTime.Now.AddMonths(-3 - ((DateTime.Now.Month - 1) % 3)));
        }

        private void SZRQ(DateTime date)
        {
            if (SBQX.IsOn)
            {
                SSQQ.DateTime = DateTime.Parse(date.ToString("yyyy-01-01"));
            }
            else
            {
                SSQQ.DateTime =
                    DateTime.Parse(date.AddMonths(0 - ((date.Month - 1) % 3)).ToString("yyyy-MM-01"));
            }
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
            foreach (TileItem item in tileBarGroupTables.Items)
            {
                item.Checked = e.Item.Text == item.Text ? true : false;
            }
        }


        private void SSQQ_DateTimeChanged(object sender, EventArgs e)
        {
            Boolean o=true;
            if (SBQX.IsOn)//年度
            {
                SSQZ.Text = SSQQ.DateTime.AddMonths(11).ToString("yyyy-MM");
                if (SSQQ.DateTime.Year >= DateTime.Now.Year)
                {
                    MessageBox.Show("超过可申报日期");
                    o = false;
                }
            }
            else//季度
            {
                SSQZ.Text = SSQQ.DateTime.AddMonths(2).ToString("yyyy-MM");
                if (SSQQ.DateTime > DateTime.Parse(DateTime.Now.AddMonths(0 - ((DateTime.Now.Month - 1) % 3)).ToString("yyyy-MM-01")).AddDays(-1))
                {
                    MessageBox.Show("超过可申报日期");
                    o = false;
                }
            }

            if (o)
            {
                if (SBQX.IsOn)
                {
                    if (SSQQ.DateTime.Month == 1) return;
                }
                else
                {
                    if( (SSQQ.DateTime.Month-1) % 3 ==  0) return;
                }
                        
            }
            SZRQ(o?SSQQ.DateTime: DateTime.Now.AddMonths(-3 - ((DateTime.Now.Month - 1) % 3)));
        }

        private void SBLX_Toggled(object sender, EventArgs e)
        {
            if (SBQX.IsOn)
            {
                SZRQ(DateTime.Now.AddYears(-1));
            }else
            {
                SZRQ(DateTime.Now.AddMonths(-3 - ((DateTime.Now.Month - 1) % 3)));
            }
        }

        private void DRLJ_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel文件(*.xls)|*.xls|所有文件|*.*";
            ofd.ValidateNames = true;
            ofd.CheckPathExists = true;
            ofd.CheckFileExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DRLJ.Text = ofd.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            if (DRLJ.Text != "")
            {
                IWorkbook workbook;
                List<List<string>> zcfzb = new List<List<string>>();
                List<List<string>> lrb = new List<List<string>>();
                using (FileStream fs = new FileStream(DRLJ.Text, FileMode.Open, FileAccess.Read))
                {
                    workbook = new HSSFWorkbook(fs);
                    ISheet sheet = workbook.GetSheet("取数");
                    int rowK, rowZ;
                    rowK = int.Parse(Func.GetString(sheet.GetRow(0).GetCell(1)));
                    rowZ = int.Parse(Func.GetString(sheet.GetRow(0).GetCell(2)));
                    for (int i = rowK; i <= rowZ; i++)
                    {
                        var list = new List<string>();
                        for (int j = 0; j < 7; j++)
                        {
                            list.Add(Func.GetString(sheet.GetRow(i).GetCell(j)));
                        }
                        zcfzb.Add(list);

                    }
                    rowK = int.Parse(Func.GetString(sheet.GetRow(1).GetCell(1)));
                    rowZ = int.Parse(Func.GetString(sheet.GetRow(1).GetCell(2)));
                    for (int i = rowK; i <= rowZ; i++)
                    {
                        var list = new List<string>();
                        for (int j = 8; j < 12; j++)
                        {
                            list.Add(Func.GetString(sheet.GetRow(i).GetCell(j)));
                        }
                        lrb.Add(list);
                    }
                }

                string nsrsbh = "91350203MA2XTLL347";
                string nsrmc = "厦门馥蕾餐饮管理有限公司";
                string license = "7fdd4b67ce41e9c916172dfd0499b8ad";
                string sequence = Guid.NewGuid().ToString("N"); // e0a953c3ee6040eaa9fae2b667060e09
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");//yyyy MM dd HH24 mi ss SSS 年月日24时分秒毫秒
                Cauthen CS = new Cauthen("100008", nsrsbh, nsrmc, license, sequence, timestamp, "1", "2018-04-01", "2018-06-30");
                XDocument document;
                //获取到XML的根元素进行操作
                document = XDocument.Load(System.AppDomain.CurrentDomain.BaseDirectory + @"template\100008.xml");
                Func.ProduceReportBody(ref document, "100008", CS, zcfzb, lrb);
                document.Save(System.AppDomain.CurrentDomain.BaseDirectory + @"template\100008.xml");
                //将XML文件加载进来
                document = XDocument.Load(System.AppDomain.CurrentDomain.BaseDirectory + @"template\envelope.xml");
                Func.ProduceEnvelopeBody(ref document, CS);
                document.Save(System.AppDomain.CurrentDomain.BaseDirectory + @"template\envelope.xml");
                MessageBox.Show( Func.Upload("100008"));
            }
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            new QYcollection().Show();
        }
    }
}