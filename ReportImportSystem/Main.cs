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
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
        }

    }
}
