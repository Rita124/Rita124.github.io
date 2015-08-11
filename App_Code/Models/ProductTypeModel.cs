using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ProductTypeTypeModel
/// </summary>
public class ProductTypeTypeModel
{
    public string InsertProductType(ProductType productType)
    {
        try
        {
            
            CANDZOILPDBEntities1 db = new CANDZOILPDBEntities1();
            db.ProductTypes.Add(productType);
            db.SaveChanges();

            return productType.Name + " was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public string UpdateProductType(int id, ProductType productType)
    {
        try
        {
            CANDZOILPDBEntities1 db = new CANDZOILPDBEntities1();

            ProductType p = db.ProductTypes.Find(id);

            p.Name = productType.Name;
           

            db.SaveChanges();

            return productType.Name + " was succesfully updated";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }
    public string DeleteProductType(int id)
    {
        try
        {
            CANDZOILPDBEntities1 db = new CANDZOILPDBEntities1();
            ProductType productType = db.ProductTypes.Find(id);

            db.ProductTypes.Attach(productType);
            db.ProductTypes.Remove(productType);
            db.SaveChanges();

            return productType.Name + " was succesfully deleted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }
}