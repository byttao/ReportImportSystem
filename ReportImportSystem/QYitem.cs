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
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using Newtonsoft.Json;

namespace ReportImportSystem
{
    public partial class QYitem : DevExpress.XtraEditors.XtraForm
    {
        private List<string> original, present=new List<string>(){"","","","",""};
        public QYitem(List<string> vs)
        {
            InitializeComponent();
            original = vs;
            SCBBLX();
            Init(vs);
        }

        private void Init(List<string> vs)
        {
            if (vs.Count==0)
            {
                return;
            }

            TEMC.Text = vs[0];
            TESH.Text = vs[1];
            TEMM.Text = vs[2];
            TESQM.Text = vs[3];
            LEBBLX.EditValue = vs[4];
        }

        void SCBBLX()
        {

            using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"BBLX.json"))
            {
                List<BBLX> qYs = JsonConvert.DeserializeObject<List<BBLX>>(sr.ReadToEnd());
                LEBBLX.Properties.DataSource = qYs.Select(c=>c.MC);
                
            }
        }

        private void QYitem_FormClosing(object sender, FormClosingEventArgs e)
        {
            present[0] = TEMC.Text;
            present[1] = TESH.Text;
            present[2] = TEMM.Text;
            present[3] = TESQM.Text;
            present[4] = LEBBLX.Text;
            if (!original.SequenceEqual(present))
            {
                if (present.Contains(""))
                {
                    using (FlyoutAction action = new FlyoutAction() {Caption = "警告", Description = "请检查字段是否填写完整！"})
                    {
                        action.Commands.Add(new FlyoutCommand() {Text = "好的", Result = DialogResult.OK});
                        action.Commands.Add(new FlyoutCommand() { Text = "不保存", Result = DialogResult.Cancel });
                        switch (FlyoutDialog.Show(this, action))
                        {
                            case DialogResult.OK:
                                e.Cancel = true;
                                return;
                            default:
                                return;
                        }
                    }
                }

                using (FlyoutAction action = new FlyoutAction() {Caption = "提示", Description = "信息已修改，是否保存？"})
                {
                    action.Commands.Add(new FlyoutCommand() {Text = "保存", Result = DialogResult.Yes});
                    action.Commands.Add(new FlyoutCommand() {Text = "不保存", Result = DialogResult.No});
                    action.Commands.Add(new FlyoutCommand() {Text = "取消", Result = DialogResult.Cancel});
                    switch (FlyoutDialog.Show(this, action))
                    {
                        case DialogResult.Yes:
                            if (original.Count == 0)
                            {

                            }

                            return;
                        case DialogResult.No:
                            return;
                        default:
                            e.Cancel = true;
                            return;
                    }
                }
            }
        }
    }
}