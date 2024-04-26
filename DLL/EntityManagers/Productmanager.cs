using BLL.Entities;
using BLL.EntityLists;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManagers
{
    public class Productmanager
    {
        static DBManager dBManager = new DBManager();
        public static Productlist SelectAllProducts() 
        {
            try
            {
                return DataTableToProductList(
                    dBManager.executeReader("SelectAllProducts"));
              
            }
            catch (SqlNullValueException ex)
            {
                throw ex;
            }  
            return new Productlist();
        }
        #region Mapping Functions
        internal static Productlist DataTableToProductList(DataTable Dt)
        {
            Productlist products = new Productlist();
            try
            {
                if (Dt?.Rows?.Count > 0)
                {
                    foreach(DataRow row in Dt.Rows)
                    {
                        products.Add(DataRowToProduct(row));
                    }
                }

            }
            catch (SqlNullValueException ex)
            {
                throw ex;
            }
            return products;
        }
        internal static Product DataRowToProduct(DataRow Dr)
        {
            
            try
            {
                return new Product
                {
                    id = (int)Dr["id"],
                    ProductName = Dr["ProductName"].ToString(),
                    SupplierId = Dr["SupplierId"] as int?,
                    UnitPrice = Dr["UnitPrice"] as decimal?,
                    Package = Dr["Package"].ToString(),
                    IsDiscontinued = (bool)Dr["IsDiscontinued"]
                };
            }
            catch (SqlNullValueException ex)
            {
                throw ex;
            }
        }
        #endregion


        
        

        }


    }

