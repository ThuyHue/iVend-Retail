namespace AddOnBOM
{
    partial class ViewBOM
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
            this.m_LayoutControlBase = new DevExpress.XtraLayout.LayoutControl();
            this.lyc_Header = new DevExpress.XtraLayout.LayoutControl();
            this.m_lycGroupHeader = new DevExpress.XtraLayout.LayoutControlGroup();
            this.m_LayoutControlGroupBase = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lycItemHeader = new DevExpress.XtraLayout.LayoutControlItem();
            this.m_vGridProduct = new DevExpress.XtraVerticalGrid.VGridControl();
            this.m_General = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.m_Code = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.m_Description = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.m_Quantity = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.m_UoM = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.m_Cost = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.m_gridControlProduct = new DevExpress.XtraGrid.GridControl();
            this.m_gridViewProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.u_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.u_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.u_Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.u_UoM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.u_Rate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.u_Consumable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.u_InStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.m_ClientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_LayoutControlBase)).BeginInit();
            this.m_LayoutControlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lyc_Header)).BeginInit();
            this.lyc_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_lycGroupHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LayoutControlGroupBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lycItemHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_vGridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_gridControlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_gridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this.m_ClientPanel.Location = new System.Drawing.Point(0, 58);
            // 
            // m_LayoutControlBase
            // 
            this.m_LayoutControlBase.BackColor = System.Drawing.Color.LightSteelBlue;
            this.m_LayoutControlBase.Controls.Add(this.m_vGridProduct);
            this.m_LayoutControlBase.Controls.Add(this.m_gridControlProduct);
            this.m_LayoutControlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_LayoutControlBase.Location = new System.Drawing.Point(0, 0);
            this.m_LayoutControlBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_LayoutControlBase.Name = "m_LayoutControlBase";
            this.m_LayoutControlBase.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(47, 169, 250, 350);
            this.m_LayoutControlBase.OptionsView.UseDefaultDragAndDropRendering = false;
            this.m_LayoutControlBase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_LayoutControlBase.Root = this.m_LayoutControlGroupBase;
            this.m_LayoutControlBase.Size = new System.Drawing.Size(1195, 802);
            this.m_LayoutControlBase.TabIndex = 0;
            this.m_LayoutControlBase.Text = "layoutControl1";
            // 
            // lyc_Header
            // 
            this.lyc_Header.Controls.Add(this.m_ViewHeader);
            this.lyc_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.lyc_Header.Location = new System.Drawing.Point(0, 0);
            this.lyc_Header.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lyc_Header.Name = "lyc_Header";
            this.lyc_Header.OptionsView.UseDefaultDragAndDropRendering = false;
            this.lyc_Header.Root = this.m_lycGroupHeader;
            this.lyc_Header.Size = new System.Drawing.Size(1195, 57);
            this.lyc_Header.TabIndex = 2;
            this.lyc_Header.Text = "layoutControl1";
            this.lyc_Header.Controls.SetChildIndex(this.m_ViewHeader, 0);
            // 
            // m_lycGroupHeader
            // 
            this.m_lycGroupHeader.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.m_lycGroupHeader.GroupBordersVisible = false;
            this.m_lycGroupHeader.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lycItemHeader});
            this.m_lycGroupHeader.Name = "m_lycGroupHeader";
            this.m_lycGroupHeader.OptionsItemText.TextToControlDistance = 5;
            this.m_lycGroupHeader.Size = new System.Drawing.Size(1195, 57);
            this.m_lycGroupHeader.TextVisible = false;
            // 
            // m_LayoutControlGroupBase
            // 
            this.m_LayoutControlGroupBase.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.m_LayoutControlGroupBase.GroupBordersVisible = false;
            this.m_LayoutControlGroupBase.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.m_LayoutControlGroupBase.Name = "Root";
            this.m_LayoutControlGroupBase.OptionsItemText.TextToControlDistance = 5;
            this.m_LayoutControlGroupBase.Size = new System.Drawing.Size(1195, 802);
            this.m_LayoutControlGroupBase.TextVisible = false;
            // 
            // lycItemHeader
            // 
            this.lycItemHeader.Control = this.m_ViewHeader;
            this.lycItemHeader.Location = new System.Drawing.Point(0, 0);
            this.lycItemHeader.Name = "lycItemHeader";
            this.lycItemHeader.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lycItemHeader.Size = new System.Drawing.Size(1195, 57);
            this.lycItemHeader.TextSize = new System.Drawing.Size(0, 0);
            this.lycItemHeader.TextVisible = false;
            // 
            // m_vGridProduct
            // 
            this.m_vGridProduct.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.m_vGridProduct.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.m_vGridProduct.Location = new System.Drawing.Point(5, 5);
            this.m_vGridProduct.Name = "m_vGridProduct";
            this.m_vGridProduct.RecordWidth = 138;
            this.m_vGridProduct.RowHeaderWidth = 62;
            this.m_vGridProduct.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.m_General,
            this.m_Code,
            this.m_Description,
            this.m_Quantity,
            this.m_UoM,
            this.m_Cost});
            this.m_vGridProduct.Size = new System.Drawing.Size(1014, 196);
            this.m_vGridProduct.TabIndex = 3;
            // 
            // m_General
            // 
            this.m_General.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_General.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_General.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_General.Appearance.Options.UseBackColor = true;
            this.m_General.Appearance.Options.UseBorderColor = true;
            this.m_General.Height = 24;
            this.m_General.Name = "m_General";
            this.m_General.Properties.Caption = "General";
            // 
            // m_Code
            // 
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
            // m_Quantity
            // 
            this.m_Quantity.Height = 35;
            this.m_Quantity.Name = "m_Quantity";
            this.m_Quantity.Properties.Caption = "Quantity";
            // 
            // m_UoM
            // 
            this.m_UoM.Height = 35;
            this.m_UoM.Name = "m_UoM";
            this.m_UoM.Properties.Caption = "UoM";
            // 
            // m_Cost
            // 
            this.m_Cost.Height = 30;
            this.m_Cost.Name = "m_Cost";
            this.m_Cost.Properties.Caption = "Cost";
            // 
            // m_gridControlProduct
            // 
            this.m_gridControlProduct.Location = new System.Drawing.Point(6, 259);
            this.m_gridControlProduct.MainView = this.m_gridViewProduct;
            this.m_gridControlProduct.Name = "m_gridControlProduct";
            this.m_gridControlProduct.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3});
            this.m_gridControlProduct.Size = new System.Drawing.Size(1183, 537);
            this.m_gridControlProduct.TabIndex = 2;
            this.m_gridControlProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_gridViewProduct});
            // 
            // m_gridViewProduct
            // 
            this.m_gridViewProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.u_Id,
            this.u_Description,
            this.u_Quantity,
            this.u_UoM,
            this.u_Rate,
            this.u_Consumable,
            this.u_InStock});
            this.m_gridViewProduct.GridControl = this.m_gridControlProduct;
            this.m_gridViewProduct.Name = "m_gridViewProduct";
            // 
            // u_Id
            // 
            this.u_Id.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.u_Id.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.u_Id.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.u_Id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.u_Id.AppearanceHeader.Options.UseBackColor = true;
            this.u_Id.AppearanceHeader.Options.UseBorderColor = true;
            this.u_Id.AppearanceHeader.Options.UseFont = true;
            this.u_Id.Caption = "Id";
            this.u_Id.ColumnEdit = this.repositoryItemButtonEdit1;
            this.u_Id.FieldName = "u_Id";
            this.u_Id.Name = "u_Id";
            this.u_Id.Visible = true;
            this.u_Id.VisibleIndex = 0;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // u_Description
            // 
            this.u_Description.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.u_Description.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.u_Description.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.u_Description.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.u_Description.AppearanceHeader.Options.UseBackColor = true;
            this.u_Description.AppearanceHeader.Options.UseBorderColor = true;
            this.u_Description.AppearanceHeader.Options.UseFont = true;
            this.u_Description.Caption = "Description";
            this.u_Description.ColumnEdit = this.repositoryItemTextEdit3;
            this.u_Description.FieldName = "u_Description";
            this.u_Description.Name = "u_Description";
            this.u_Description.Visible = true;
            this.u_Description.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // u_Quantity
            // 
            this.u_Quantity.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.u_Quantity.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.u_Quantity.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.u_Quantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.u_Quantity.AppearanceHeader.Options.UseBackColor = true;
            this.u_Quantity.AppearanceHeader.Options.UseBorderColor = true;
            this.u_Quantity.AppearanceHeader.Options.UseFont = true;
            this.u_Quantity.Caption = "Quantity";
            this.u_Quantity.ColumnEdit = this.repositoryItemTextEdit2;
            this.u_Quantity.FieldName = "u_Quantity";
            this.u_Quantity.Name = "u_Quantity";
            this.u_Quantity.Visible = true;
            this.u_Quantity.VisibleIndex = 2;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // u_UoM
            // 
            this.u_UoM.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.u_UoM.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.u_UoM.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.u_UoM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.u_UoM.AppearanceHeader.Options.UseBackColor = true;
            this.u_UoM.AppearanceHeader.Options.UseBorderColor = true;
            this.u_UoM.AppearanceHeader.Options.UseFont = true;
            this.u_UoM.Caption = "UoM";
            this.u_UoM.ColumnEdit = this.repositoryItemTextEdit1;
            this.u_UoM.FieldName = "u_UoM";
            this.u_UoM.Name = "u_UoM";
            this.u_UoM.Visible = true;
            this.u_UoM.VisibleIndex = 3;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // u_Rate
            // 
            this.u_Rate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.u_Rate.AppearanceHeader.Options.UseFont = true;
            this.u_Rate.Caption = "Rate";
            this.u_Rate.Name = "u_Rate";
            this.u_Rate.Visible = true;
            this.u_Rate.VisibleIndex = 4;
            // 
            // u_Consumable
            // 
            this.u_Consumable.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.u_Consumable.AppearanceHeader.Options.UseFont = true;
            this.u_Consumable.Caption = "Consumable";
            this.u_Consumable.Name = "u_Consumable";
            this.u_Consumable.Visible = true;
            this.u_Consumable.VisibleIndex = 5;
            // 
            // u_InStock
            // 
            this.u_InStock.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.u_InStock.AppearanceHeader.Options.UseFont = true;
            this.u_InStock.Caption = "InStock";
            this.u_InStock.Name = "u_InStock";
            this.u_InStock.Visible = true;
            this.u_InStock.VisibleIndex = 6;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.m_gridControlProduct;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 253);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1195, 549);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.m_vGridProduct;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1195, 253);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // ViewBOM
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ViewBOM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Controls.SetChildIndex(this.m_ClientPanel, 0);
            this.Controls.SetChildIndex(this.lyc_Header, 0);
            this.m_ClientPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_LayoutControlBase)).EndInit();
            this.m_LayoutControlBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lyc_Header)).EndInit();
            this.lyc_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_lycGroupHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LayoutControlGroupBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lycItemHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_vGridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_gridControlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_gridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraVerticalGrid.VGridControl m_vGridProduct;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow m_General;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow m_Code;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow m_Description;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow m_Quantity;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow m_UoM;
        private DevExpress.XtraGrid.GridControl m_gridControlProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView m_gridViewProduct;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow m_Cost;
        private DevExpress.XtraGrid.Columns.GridColumn u_Id;
        private DevExpress.XtraGrid.Columns.GridColumn u_Description;
        private DevExpress.XtraGrid.Columns.GridColumn u_Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn u_UoM;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn u_Rate;
        private DevExpress.XtraGrid.Columns.GridColumn u_Consumable;
        private DevExpress.XtraGrid.Columns.GridColumn u_InStock;
        //private DevExpress.XtraLayout.LayoutControl m_LayoutControlBase;
        //private DevExpress.XtraLayout.LayoutControlGroup m_LayoutControlGroupBase;
        //private DevExpress.XtraLayout.LayoutControl lyc_Header;
        //private DevExpress.XtraLayout.LayoutControlGroup m_lycGroupHeader;
        //private DevExpress.XtraLayout.LayoutControlItem lycItemHeader;
    }
}
