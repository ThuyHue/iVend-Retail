using CXS.Retail.Extensibility.Menu;
using CXS.Retail.ManagementUIComponents;
using CXS.Retail.UIComponents;
using CXS.SubSystem.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddOnBOM
{
    public class MCMenuBOM : ConsoleMenuItemCommandBase
    {
        public MCMenuBOM():base()
        {
            base.Position = 10;
            base.Category = CXS.Retail.Extensibility.ConsoleMenuCategory.InventoryGroup;
            base.Id = "MenuBOM";
            base.Caption = "BOM";
            base.IsVisible = true;
            base.IsEnabled = true;
            base.ToolTip = "BOM";
        }
        public override void Execute()
        {
            //ProductView product = new ProductView();
            //ConsoleViewManager.Instance.Push(product);
            showSearchProductView();
        }

        private void showSearchProductView()
        {
            try
            {
                ProductSearchView m_ProductSearchView = ConsoleViewManager.Instance.ProductSearchView;
                m_ProductSearchView.AllowMultiSelect = false;
                m_ProductSearchView.OnEvent += ProductSearchViewEventHandler;

                ConsoleViewManager.Instance.Push(m_ProductSearchView);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ProductSearchViewEventHandler(object sender, ProductSearchView.EventArgs args)
        {
            try
            {
                ProductSearchView m_ProductSearchView = sender as ProductSearchView;     
               
                if (args.EventType == ProductSearchView.EventType.Ok)
                {
                    //int[] selectedRows = m_ProductSearchView.m_GridView.GetSelectedRows();
                    //Product m_Product = m_ProductSearchView.m_GridView.GetRow(selectedRows[0]) as Product;
                    //MessageBox.Show(m_Product.Id);
                    Product m_Product = args.BusinessObjectList[0] as Product;
                    MessageBox.Show(m_Product.Id);
                    //ViewBOM viewBOM = new ViewBOM(m_Product);
                    //ConsoleViewManager.Instance.Push(viewBOM);
                }
                m_ProductSearchView.OnEvent -= ProductSearchViewEventHandler;
                m_ProductSearchView.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
