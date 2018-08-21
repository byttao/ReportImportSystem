using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraBars;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ReportImportSystem
{
    public partial class QYcollection : XtraForm
    {
        public QYcollection()
        {
            InitializeComponent();
            GridRefresh();
        }

        private void GridRefresh()
        {
            using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"QY.json"))
            {
                List<QY> qYs = JsonConvert.DeserializeObject<List<QY>>(sr.ReadToEnd());
                gridControl.DataSource = qYs;

            }
        }

        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
                case "新增":
                    new QYitem(new List<string>(){"","","","",""}).ShowDialog();
                    return;
                case "修改":
                    if (gridView.GetSelectedRows().Length > 0)
                    {
                        int i = gridView.GetSelectedRows()[0];
                        List<string> vs = new List<string>();
                        for (int j = 0; j < 5; j++)
                        {
                            vs.Add(gridView.GetRowCellValue(i, gridView.Columns[j].FieldName).ToString());
                        }
                        new QYitem(vs).ShowDialog();
                    }
                    return;
                case "刷新":
                    return;
                case "打印":
                    gridControl.ShowPrintPreview();
                    return;
            }
        }

        private void windowsUIButtonPanel_Click(object sender, EventArgs e)
        {

        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            if (gridView.GetSelectedRows().Length > 0)
            {
                int i = gridView.GetSelectedRows()[0];
                List<string> vs = new List<string>();
                for (int j = 0; j < 5; j++)
                {
                    vs.Add(gridView.GetRowCellValue(i, gridView.Columns[j].FieldName).ToString());
                }
                new QYitem(vs).ShowDialog();
            }

        }
    }
}
