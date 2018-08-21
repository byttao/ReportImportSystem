namespace ReportImportSystem
{
    partial class XtraFormItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormItem));
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.employeesTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.customersTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.BBSBNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.SBLX = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnUpload = new DevExpress.XtraEditors.SimpleButton();
            this.SSQZ = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SBQX = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.DRLJ = new DevExpress.XtraEditors.ButtonEdit();
            this.SSQQ = new DevExpress.XtraEditors.DateEdit();
            this.customersNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.customersLabelControl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.BBSBNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBLX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSQZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBQX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRLJ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSQQ.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSQQ.Properties)).BeginInit();
            this.customersNavigationPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowDrag = false;
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.AppearanceText.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tileBar.AppearanceText.Options.UseFont = true;
            this.tileBar.AppearanceText.Options.UseTextOptions = true;
            this.tileBar.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tileBar.MaxId = 7;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 150);
            this.tileBar.MinimumSize = new System.Drawing.Size(0, 150);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(30, 5, 34, 14);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.ShowText = true;
            this.tileBar.Size = new System.Drawing.Size(902, 150);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "有限公司";
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.employeesTileBarItem);
            this.tileBarGroupTables.Items.Add(this.customersTileBarItem);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // employeesTileBarItem
            // 
            this.employeesTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.employeesTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.employeesTileBarItem.Checked = true;
            this.employeesTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.Image = global::ReportImportSystem.Properties.Resources.textbox_32x32;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement1.ImageOptions.ImageUri.Uri = "WrapText;Size32x32";
            tileItemElement1.Text = "报表申报";
            this.employeesTileBarItem.Elements.Add(tileItemElement1);
            this.employeesTileBarItem.Name = "employeesTileBarItem";
            // 
            // customersTileBarItem
            // 
            this.customersTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement2.Text = "税费申报";
            this.customersTileBarItem.Elements.Add(tileItemElement2);
            this.customersTileBarItem.Id = 2;
            this.customersTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.customersTileBarItem.Name = "customersTileBarItem";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.BBSBNavigationPage);
            this.navigationFrame.Controls.Add(this.customersNavigationPage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 150);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.BBSBNavigationPage,
            this.customersNavigationPage});
            this.navigationFrame.SelectedPage = this.BBSBNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(902, 409);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // BBSBNavigationPage
            // 
            this.BBSBNavigationPage.Controls.Add(this.textEdit1);
            this.BBSBNavigationPage.Controls.Add(this.labelControl6);
            this.BBSBNavigationPage.Controls.Add(this.labelControl5);
            this.BBSBNavigationPage.Controls.Add(this.SBLX);
            this.BBSBNavigationPage.Controls.Add(this.btnUpload);
            this.BBSBNavigationPage.Controls.Add(this.SSQZ);
            this.BBSBNavigationPage.Controls.Add(this.labelControl4);
            this.BBSBNavigationPage.Controls.Add(this.labelControl3);
            this.BBSBNavigationPage.Controls.Add(this.labelControl2);
            this.BBSBNavigationPage.Controls.Add(this.SBQX);
            this.BBSBNavigationPage.Controls.Add(this.labelControl1);
            this.BBSBNavigationPage.Controls.Add(this.DRLJ);
            this.BBSBNavigationPage.Controls.Add(this.SSQQ);
            this.BBSBNavigationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BBSBNavigationPage.Name = "BBSBNavigationPage";
            this.BBSBNavigationPage.Size = new System.Drawing.Size(902, 409);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(103, 31);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(233, 24);
            this.textEdit1.TabIndex = 12;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            this.textEdit1.Click += new System.EventHandler(this.textEdit1_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(37, 34);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 17);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "报表类型：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(331, 85);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 17);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "申报类型：";
            // 
            // SBLX
            // 
            this.SBLX.Location = new System.Drawing.Point(397, 81);
            this.SBLX.Name = "SBLX";
            this.SBLX.Properties.OffText = "新增申报";
            this.SBLX.Properties.OnText = "更正申报";
            this.SBLX.Size = new System.Drawing.Size(139, 26);
            this.SBLX.TabIndex = 9;
            // 
            // btnUpload
            // 
            this.btnUpload.ImageOptions.Image = global::ReportImportSystem.Properties.Resources.publish_32x32;
            this.btnUpload.Location = new System.Drawing.Point(441, 244);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(161, 39);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "提交";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // SSQZ
            // 
            this.SSQZ.Location = new System.Drawing.Point(397, 129);
            this.SSQZ.Name = "SSQZ";
            this.SSQZ.Properties.ReadOnly = true;
            this.SSQZ.Size = new System.Drawing.Size(132, 24);
            this.SSQZ.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(331, 132);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 17);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "所属期止：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(37, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 17);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "申报期限：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(37, 132);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "所属期起：";
            // 
            // SBQX
            // 
            this.SBQX.Location = new System.Drawing.Point(103, 81);
            this.SBQX.Name = "SBQX";
            this.SBQX.Properties.OffText = "季度申报";
            this.SBQX.Properties.OnText = "年度申报";
            this.SBQX.Size = new System.Drawing.Size(139, 26);
            this.SBQX.TabIndex = 3;
            this.SBQX.Toggled += new System.EventHandler(this.SBLX_Toggled);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 185);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "导入路径：";
            // 
            // DRLJ
            // 
            this.DRLJ.Location = new System.Drawing.Point(103, 182);
            this.DRLJ.Name = "DRLJ";
            this.DRLJ.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DRLJ.Size = new System.Drawing.Size(512, 24);
            this.DRLJ.TabIndex = 0;
            this.DRLJ.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.DRLJ_ButtonClick);
            // 
            // SSQQ
            // 
            this.SSQQ.EditValue = null;
            this.SSQQ.Location = new System.Drawing.Point(103, 129);
            this.SSQQ.Name = "SSQQ";
            this.SSQQ.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SSQQ.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SSQQ.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.SSQQ.Properties.DisplayFormat.FormatString = "yyyy-MM";
            this.SSQQ.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.SSQQ.Properties.Mask.EditMask = "yyyy-MM";
            this.SSQQ.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.SSQQ.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.SSQQ.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.SSQQ.Size = new System.Drawing.Size(139, 24);
            this.SSQQ.TabIndex = 2;
            this.SSQQ.DateTimeChanged += new System.EventHandler(this.SSQQ_DateTimeChanged);
            // 
            // customersNavigationPage
            // 
            this.customersNavigationPage.Caption = "customersNavigationPage";
            this.customersNavigationPage.Controls.Add(this.customersLabelControl);
            this.customersNavigationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersNavigationPage.Name = "customersNavigationPage";
            this.customersNavigationPage.Size = new System.Drawing.Size(902, 409);
            // 
            // customersLabelControl
            // 
            this.customersLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.customersLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.customersLabelControl.Appearance.Options.UseFont = true;
            this.customersLabelControl.Appearance.Options.UseForeColor = true;
            this.customersLabelControl.Appearance.Options.UseTextOptions = true;
            this.customersLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customersLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.customersLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.customersLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersLabelControl.Location = new System.Drawing.Point(0, 0);
            this.customersLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersLabelControl.Name = "customersLabelControl";
            this.customersLabelControl.Size = new System.Drawing.Size(902, 409);
            this.customersLabelControl.TabIndex = 2;
            this.customersLabelControl.Text = "Customers";
            // 
            // XtraFormItem
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 559);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XtraFormItem";
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.BBSBNavigationPage.ResumeLayout(false);
            this.BBSBNavigationPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBLX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSQZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBQX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRLJ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSQQ.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSQQ.Properties)).EndInit();
            this.customersNavigationPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarItem employeesTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem customersTileBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage BBSBNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage customersNavigationPage;
        private DevExpress.XtraEditors.LabelControl customersLabelControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit DRLJ;
        private DevExpress.XtraEditors.DateEdit SSQQ;
        private DevExpress.XtraEditors.TextEdit SSQZ;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ToggleSwitch SBQX;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ToggleSwitch SBLX;
        private DevExpress.XtraEditors.SimpleButton btnUpload;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}