using CXS.Platform.UIComponents;
using CXS.Retail.Extensibility;
using CXS.Retail.UIComponents;
using CXS.SubSystem.Inventory;
using DevExpress.XtraVerticalGrid.Rows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddOnBOM
{
    public class iVendAddOn : BasePlugin // version 6.6 cần bỏ public
    {
        ProductSearchView m_ProductSearchView;
        public override string CompanyName
        {
            get
            {
                return "FTI Trading";
            }
        }

        public override string Description
        {
            get
            {
                return "Product BOM";
            }
        }

        public override string Name
        {
            get
            {
                return "Product BOM";
            }
        }

        public override Version VersionInfo
        {
            get
            {
                return new Version("1.0.9");
            }
        }
        public override void Start()
        {
            base.Start();
            //AppExtensibilityContext.AddConsoleMenuItem(new MCMenuBOM());
        }        
    }
}
