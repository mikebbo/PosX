using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosXLib.Model
{
   public class ProductModel
    {
        public int itemNumber { get; set; }
        public string barcode { get; set; }
        public string  ItemName { get; set; }
        public string ItemDescrition { get; set; }
        public string ItemAttribute { get; set; }
        public decimal SellPrice { get; set; }
        public decimal BuyPrice { get; set; }
        public int reorderPoint { get; set; }
        public int quant { get; set; }
        public string department  { get; set; }
        public decimal tax { get; set; }

        public ProductModel(string paritemNumber, string prbarcode, string parItemName, string parItemDescrition, string parItemAttribute, string parSellPrice, string parBuyPrice, string parReorderPoint, string  parQuant, string parDepartment, string partax)
        {
            int itemNumberValue = 0;
            int.TryParse(paritemNumber,out itemNumberValue);
            itemNumber = itemNumberValue;
            barcode = prbarcode;
            ItemName = parItemName;
            ItemDescrition= parItemDescrition;
            ItemAttribute= parItemAttribute;
            decimal sellpriceValue = 0;
            decimal.TryParse(parSellPrice, out sellpriceValue);
            SellPrice = sellpriceValue;
            int reorderPointValue = 0;
            int.TryParse(parReorderPoint, out reorderPointValue);
            reorderPoint=reorderPointValue;
            int quantValue = 0;
            int.TryParse(parQuant, out quantValue);
            quant = quantValue;
            department= parDepartment;
            decimal taxValue = 0;
            decimal.TryParse(partax, out taxValue);
            tax = taxValue;

        }

    }
    
}
