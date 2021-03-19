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
using CXS.Retail.ManagementUIComponents;
using DevExpress.XtraGrid.Views.Grid;
using CXS.Platform.Data;
using AddOnBOM.Models;

namespace AddOnBOM
{
    public partial class ProductView : BaseConsoleCustomView
    {
        public ProductView()
        {
            InitializeComponent();
            showButton();
            m_gridViewSearch.GroupPanelText = "Products";
            Title = "Products";
        }
        private void showButton()
        {
            m_Button1.Visible = true;
            m_Button1.Text = "F1\n Search";
            m_Button1.Click += new System.EventHandler(SearchButtonClickHandler);

            m_Button2.Visible = true;
            m_Button2.Text = "F2\n Clear";
            m_Button2.Click += new System.EventHandler(ClearButtonClickHandler);

            m_Button3.Visible = true;
            m_Button3.Text = "F3\n New";
            m_Button3.Click += new System.EventHandler(NewButtonClickHandler);

            m_Button4.Visible = true;
            m_Button4.Text = "F4\n Edit";
            m_Button4.Click += new System.EventHandler(NewButtonClickHandler);

            m_Button5.Visible = true;
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
        private void SearchButtonClickHandler(object sender, System.EventArgs e)
        {
            BindGridOnInitizlization();
        }
        private void ClearButtonClickHandler(object sender, System.EventArgs e)
        {

        }
        private void NewButtonClickHandler(object sender, System.EventArgs e)
        {
            try
            {
                int[] selRows = ((GridView)m_ProductGridView.MainView).GetSelectedRows();
                DataRowView selRow = (DataRowView)(((GridView)m_ProductGridView.MainView).GetRow(selRows[0]));

                ProductBOMModel product = new ProductBOMModel();
                product.mProductKey = m_gridViewSearch.GetRowCellValue(selRows[0], "ProductKey").ToString();
                product.mId = m_gridViewSearch.GetRowCellValue(selRows[0], "Id").ToString();
                product.mDescription = m_gridViewSearch.GetRowCellValue(selRows[0], "Description").ToString();
                product.mUomKey = m_gridViewSearch.GetRowCellValue(selRows[0], "UOMGroupKey").ToString();
                product.mUoM = m_gridViewSearch.GetRowCellValue(selRows[0], "UoM").ToString();
                product.mBasePrice = double.Parse(m_gridViewSearch.GetRowCellValue(selRows[0], "BasePrice").ToString());

                //ViewBOM viewBOM = new ViewBOM();
                //viewBOM.setProductModel(product);
                //ConsoleViewManager.Instance.Push(viewBOM);

            }catch(Exception ex)
            {

            }
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
            catch (Exception ex)
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
            catch (Exception ex)
            {
                //ShowError(Common.GetString("SampleSearchView", "ErrorEncounteredDuringSearch"));
            }
            finally
            {
                CloseWaitForm();
                Cursor = UIHelper.Instance.DefaultCursor;
            }
        }

        private void BindGridOnInitizlization()
        {
            string sql = "SELECT T1.ProductKey,T1.Id,T1.Description,T2.UOMGroupKey,T2.Description UoM,T1.BasePrice FROM InvProduct T1"
                        +" JOIN InvUOMGroup T2 ON T1.UOMGroupKey = T2.UOMGroupKey where T1.IsDeleted = 0";
            try
            {
                var code = m_vGridSearch.GetCellValue(m_vGridSearch.Rows.GetRowByFieldName("m_Code"), m_vGridSearch.FocusedRecord);
                string codeValue = (code == null) ? string.Empty : code.ToString();
                if (!string.IsNullOrEmpty(codeValue))
                {
                    sql = sql + " AND Id like '%" + codeValue + "%'";
                }

                var description = m_vGridSearch.GetCellValue(m_vGridSearch.Rows.GetRowByFieldName("m_Description"), m_vGridSearch.FocusedRecord);
                string desValue = (description == null) ? string.Empty : description.ToString();
                if (!string.IsNullOrEmpty(desValue))
                {
                    sql = sql + " AND Description like '%" + desValue + "%'";
                }
                m_ProductGridView.DataSource = iVendRunQuery(sql);
                m_gridViewSearch.Columns["ProductKey"].Visible = false;
                m_gridViewSearch.Columns["UOMGroupKey"].Visible = false;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        public static DataTable iVendRunQuery(string Query)
        {
            IDbConnection iVendConnection = SessionManager.Instance.CurrentSession.Connection;
            IDbCommand cmd = iVendConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Query;
            return SessionManager.Instance.FillDataSet(cmd).Tables[0];
        }
    }
}
