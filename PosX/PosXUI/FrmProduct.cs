using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosXLib.Model;
using PosXLib.DataAccess;

namespace PosXUI
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void btnCreateSaveProduct_Click(object sender, EventArgs e)
        {
            isFormProdValid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //1. We validate the Form
            if (isFormProdValid())
            {
                //We create the model for the pruct
                ProductModel mode = new ProductModel(
                txtBarcode.Text ,
                txtItemName.Text ,
                txtItemDescription.Text ,
                txtAttribute.Text,
                txtBuyPrice.Text ,
                txtSellPrice.Text ,
                txtReorder.Text ,
                txtItemNumber.Text,
                txtStockQuant.Text ,
                txtItemLookup.Text,
                txtTaxPerc.Text
                                           
                    );

                // We save the model to the database
                try
                {

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Something went wrong", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //after saving to database we clear the form
                clearForm();


            }
            {
                MessageBox.Show("This form has invalid information, please check it and try again");
            }



        }
        private bool isFormProdValid() { 
        bool output = true;
        int prodId = 0;
        bool isProdIdValidNum = int.TryParse(txtItemNumber.Text, out prodId);

        int prodbarcode = 0;
        bool isbarcodeValid = int.TryParse(txtBarcode.Text, out prodbarcode);
            int length = txtBarcode.TextLength;
            if (length < 13 || length > 13) {
                output = false;
                MessageBox.Show("the barcod should be only 13 digit max, since it is UPC");
            }

            decimal prodBuyPrice = 0;
            bool isProdBuyPriceValid = decimal.TryParse(txtBuyPrice.Text, out prodBuyPrice);

            decimal sellPrice = 0;
            bool isSellPriceValid = decimal.TryParse(txtSellPrice.Text, out sellPrice);
            if (sellPrice < prodBuyPrice) {
                output = false;
                MessageBox.Show("The sell price should be greater than buy price.");

            }
                
            int quant = 0;
            bool isQuantValid = int.TryParse(txtQuant.Text, out quant);
            if (quant < 0)
            {
                output = false;
                MessageBox.Show("Please enter a valid quantity");

            }
            int reorderquant = 0;
         
            bool isReorderQuaValid = int.TryParse(txtReorder.Text, out reorderquant);
            if (quant < 0)
            {
                output = false;
                MessageBox.Show("Please enter a valid quantity");

            }
            int taxPer = 0;

            bool isTaxPercentValid = int.TryParse(txtTaxPerc.Text , out reorderquant);
            if (taxPer < 0)
            {
                output = false;
                MessageBox.Show("Please enter a valid Taxt Percentage");

            }

            return output;
          }

        private void clearForm()
        {
            txtBarcode.Text = "";
            txtItemName.Text = "";
            txtItemDescription.Text = "";
            txtBuyPrice.Text = "";
            txtSellPrice.Text = "";
            txtReorder.Text = "";
            txtItemNumber.Text = "";
            txtStockQuant.Text = "";
            txtItemLookup.Text = "";
          
        }
    }
}
