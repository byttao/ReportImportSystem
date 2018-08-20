using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

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
            Boolean o=true,b = true;
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
    }
}