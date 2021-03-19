namespace AddOnBOM
{
    partial class ProductView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_vGridSearch = new DevExpress.XtraVerticalGrid.VGridControl();
            this.m_titleSearch = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.m_Code = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.m_Description = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.m_ProductGridView = new DevExpress.XtraGrid.GridControl();
            this.m_gridViewSearch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.m_ClientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_LayoutControlBase)).BeginInit();
            this.m_LayoutControlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lyc_Header)).BeginInit();
            this.lyc_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_lycGroupHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LayoutControlGroupBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lycItemHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_vGridSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_gridViewSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ViewHeader
            // 
            this.m_ViewHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(118)))));
            this.m_ViewHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ViewHeader.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_ViewHeader.Appearance.Options.UseBackColor = true;
            this.m_ViewHeader.Appearance.Options.UseFont = true;
            this.m_ViewHeader.Appearance.Options.UseForeColor = true;
            this.m_ViewHeader.LookAndFeel.UseDefaultLookAndFeel = false;
            this.m_ViewHeader.LookAndFeel.UseWindowsXPTheme = true;
            // 
            // m_ClientPanel
            // 
            this.m_ClientPanel.Location = new System.Drawing.Point(-8, 46);
            this.m_ClientPanel.Size = new System.Drawing.Size(1039, 656);
            // 
            // m_LayoutControlBase
            // 
            this.m_LayoutControlBase.Controls.Add(this.m_ProductGridView);
            this.m_LayoutControlBase.Controls.Add(this.m_vGridSearch);
            this.m_LayoutControlBase.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(47, 169, 944, 350);
            this.m_LayoutControlBase.OptionsView.UseDefaultDragAndDropRendering = false;
            this.m_LayoutControlBase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_LayoutControlBase.Size = new System.Drawing.Size(1039, 656);
            // 
            // lyc_Header
            // 
            this.lyc_Header.OptionsView.UseDefaultDragAndDropRendering = false;
            this.lyc_Header.Controls.SetChildIndex(this.m_ViewHeader, 0);
            // 
            // m_lycGroupHeader
            // 
            this.m_lycGroupHeader.OptionsItemText.TextToControlDistance = 5;
            // 
            // m_LayoutControlGroupBase
            // 
            this.m_LayoutControlGroupBase.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.m_LayoutControlGroupBase.OptionsItemText.TextToControlDistance = 5;
            this.m_LayoutControlGroupBase.Size = new System.Drawing.Size(1039, 656);
            // 
            // m_vGridSearch
            // 
            this.m_vGridSearch.Font = new System.Drawing.Font("Tahoma", 10F);
            this.m_vGridSearch.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.m_vGridSearch.Location = new System.Drawing.Point(5, 5);
            this.m_vGridSearch.Margin = new System.Windows.Forms.Padding(0);
            this.m_vGridSearch.Name = "m_vGridSearch";
            this.m_vGridSearch.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.m_titleSearch,
            this.m_Code,
            this.m_Description});
            this.m_vGridSearch.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowAlways;
            this.m_vGridSearch.Size = new System.Drawing.Size(244, 646);
            this.m_vGridSearch.TabIndex = 0;
            this.m_vGridSearch.UseDisabledStatePainter = false;
            // 
            // m_titleSearch
            // 
            this.m_titleSearch.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_titleSearch.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_titleSearch.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_titleSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.m_titleSearch.Appearance.Options.UseBackColor = true;
            this.m_titleSearch.Appearance.Options.UseBorderColor = true;
            this.m_titleSearch.Appearance.Options.UseFont = true;
            this.m_titleSearch.Height = 24;
            this.m_titleSearch.Name = "m_titleSearch";
            this.m_titleSearch.Properties.Caption = "Search Criteria";
            // 
            // m_Code
            // 
            this.m_Code.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.m_Code.Appearance.Options.UseFont = true;
            this.m_Code.Height = 35;
            this.m_Code.Name = "m_Code";
            this.m_Code.Properties.Caption = "Code";
            // 
            // m_Description
            // 
            this.m_Description.Height = 35;
            this.m_Description.Name = "m_Description";
            this.m_Description.Properties.Caption = "Description";
            // 
            // m_ProductGridView
            // 
            this.m_ProductGridView.Location = new System.Drawing.Point(259, 5);
            this.m_ProductGridView.MainView = this.m_gridViewSearch;
            this.m_ProductGridView.Margin = new System.Windows.Forms.Padding(0);
            this.m_ProductGridView.Name = "m_ProductGridView";
            this.m_ProductGridView.Size = new System.Drawing.Size(775, 646);
            this.m_ProductGridView.TabIndex = 4;
            this.m_ProductGridView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_gridViewSearch});
            // 
            // m_gridViewSearch
            // 
            this.m_gridViewSearch.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_gridViewSearch.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_gridViewSearch.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_gridViewSearch.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.m_gridViewSearch.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_gridViewSearch.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.m_gridViewSearch.Appearance.HeaderPanel.Options.UseFont = true;
            this.m_gridViewSearch.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_gridViewSearch.AppearancePrint.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_gridViewSearch.AppearancePrint.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_gridViewSearch.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.m_gridViewSearch.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
            this.m_gridViewSearch.AppearancePrint.HeaderPanel.Options.UseBorderColor = true;
            this.m_gridViewSearch.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.m_gridViewSearch.GridControl = this.m_ProductGridView;
            this.m_gridViewSearch.Name = "m_gridViewSearch";
            this.m_gridViewSearch.OptionsBehavior.Editable = false;
            this.m_gridViewSearch.RowHeight = 30;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.m_ProductGridView;
            this.layoutControlItem2.Location = new System.Drawing.Point(254, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(785, 656);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.m_vGridSearch;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(254, 656);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ProductView
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = true;
            this.Name = "ProductView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_ClientPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_LayoutControlBase)).EndInit();
            this.m_LayoutControlBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lyc_Header)).EndInit();
            this.lyc_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_lycGroupHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LayoutControlGroupBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lycItemHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_vGridSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_gridViewSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl m_ProductGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView m_gridViewSearch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow m_titleSearch;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow m_Code;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow m_Description;
        public DevExpress.XtraVerticalGrid.VGridControl m_vGridSearch;
    }
}
