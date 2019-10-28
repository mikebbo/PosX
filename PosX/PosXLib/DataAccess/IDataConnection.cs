using PosXLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosXLib.DataAccess
{
    interface IDataConnection
    {
        ProductModel CreateProduct(ProductModel p);
    }
}
