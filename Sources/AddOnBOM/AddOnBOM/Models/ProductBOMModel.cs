using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOnBOM.Models
{
    public class ProductBOMModel
    {
        public string mProductKey { get; set; }
        public string mId { get; set; }
        public string mDescription { get; set; }
        public int mQuantity { get; set; }
        public string mUomKey { get; set; }
        public string mUoM { get; set; }
        public List<ProductBOMModel> mDetail { get; set; }
    }
}
