using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CXS.Retail.UIComponents;
using AddOnBOM.Models;
using CXS.Retail.ManagementUIComponents;
using CXS.SubSystem.Inventory;
using CXS.Framework.Core;

namespace AddOnBOM
{
    public partial class ViewBOM : BaseConsoleCustomView
    {
        Product mProduct;
        public ViewBOM(string key)
        {
            InitializeComponent();
            Title = "BOM";
            m_gridViewProduct.GroupPanelText = "BOM Defined";
            showButton();
            mProduct = ProductSubSystem.Instance.LoadByKey(key);
            bindDataHeader();
        }
        private void showButton()
        {
            m_Button1.Visible = true;
            m_Button1.Text = "F1\n Add";
            m_Button1.Click += new System.EventHandler(SearchButtonClickHandler);

            m_Button2.Visible = true;
            m_Button2.Text = "F2\n Delete";
            m_Button2.Click += new System.EventHandler(ClearButtonClickHandler);

            m_Button3.Visible = false;
            m_Button3.Text = "F3\n New";
            m_Button3.Click += new System.EventHandler(NewButtonClickHandler);

            m_Button4.Visible = false;
            m_Button4.Text = "F4\n Edit";
            m_Button4.Click += new System.EventHandler(NewButtonClickHandler);

            m_Button5.Visible = false;
            m_Button5.Text = "F5\n View";
            m_Button5.Click += new System.EventHandler(NewButtonClickHandler);

            m_Button11.Visible = true;
            m_Button11.Text = "Ok";
            m_Button11.Click += new System.EventHandler(OkButtonClickHandler);

            m_Button12.Visible = true;
            m_Button12.Text = "Cancel";
            m_Button12.Click += new System.EventHandler(CancelButtonClickHandler);

            m_Button6.Enabled = false;
            m_Button7.Enabled = false;
            m_Button8.Enabled = false;
            m_Button9.Enabled = false;
            m_Button10.Enabled = false;
        }
       
        public void setProduct(Product product)
        {
            this.mProduct = product;
            bindDataHeader();
        }
        private void bindDataHeader()
        {
            m_vGridProduct.Rows["m_Code"].Properties.Value = mProduct.Id;
            m_vGridProduct.Rows["m_Description"].Properties.Value = mProduct.Description;
            m_vGridProduct.Rows["m_UoM"].Properties.Value = mProduct.DefaultUOMGroup;
            m_vGridProduct.Rows["m_BasePrice"].Properties.Value = mProduct.BasePrice;
        }
        private void SearchButtonClickHandler(object sender, System.EventArgs e)
        {
            
        }
        private void ClearButtonClickHandler(object sender, System.EventArgs e)
        {

        }
        private void NewButtonClickHandler(object sender, System.EventArgs e)
        {
           
        }
        private void OkButtonClickHandler(object sender, System.EventArgs e)
        {

            try
            {
                //int[] selRows = ((GridView)m_ProductGridView.MainView).GetSelectedRows();
                //DataRowView selRow = (DataRowView)(((GridView)m_ProductGridView.MainView).GetRow(selRows[0]));
                //MessageBox.Show(String.Format("Selected row: {0}", selRow[0].ToString()));

                //this.send("Form 2");
                ConsoleViewManager.Instance.Pop();
            }
            catch
            {
                //ShowError(Common.GetString("SampleSearchView", "ErrorEncounteredDuringSearch"));
            }
            finally
            {
                CloseWaitForm();
                Cursor = UIHelper.Instance.DefaultCursor;
            }
        }
        private void CancelButtonClickHandler(object sender, System.EventArgs e)
        {
            try
            {
                ConsoleViewManager.Instance.Pop();
            }
            catch
            {
                //ShowError(Common.GetString("SampleSearchView", "ErrorEncounteredDuringSearch"));
            }
            finally
            {
                CloseWaitForm();
                Cursor = UIHelper.Instance.DefaultCursor;
            }
        }
    }
}
