using CXS.Retail.Extensibility.Modules.Inventory;
using System;
using CXS.Retail.Extensibility;
using CXS.Retail.UIComponents;
using CXS.Platform.UIComponents;
using CXS.SubSystem.Inventory;
using System.Windows.Forms;
using CXS.Retail.ManagementUIComponents;

namespace AddOnBOM
{
    class CustomButtonCreateBOM:ProductViewModuleBase
    {
        ProductAddEditView productView;
        Product mProduct;

        public override void OnGlobalize()
        {
            try
            {
                //base.OnGlobalize();            
                mProduct = productView.BusinessObject as Product;
            }catch()
            {

            }
        }
        public override void OnViewIntialized(object sender, ViewInitializedEventArgs args)
        {
           // MessageBox.Show("OnViewIntialized");
            base.OnViewIntialized(sender, args);
            productView = sender as ProductAddEditView;

            CXSButton m_CreateBOM = productView.AddCustomButton("Create BOM");
            m_CreateBOM.Click += ClickButtonBOM;
        }

        private void ClickButtonBOM(object sender, EventArgs args)
        {
            try
            {
                MessageBox.Show(mProduct.Id);
                string key = mProduct.Key;
                ViewBOM viewBOM = new ViewBOM(key);
                ConsoleViewManager.Instance.Push(viewBOM);
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }
    }
}
