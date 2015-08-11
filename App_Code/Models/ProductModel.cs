using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ProductModel
/// </summary>
public class ProductModel
{
	

		public string InsertProduct(Product product){
            try{
                CANDZOILPDBEntities1 db = new CANDZOILPDBEntities1();
                db.Products.Add(product);
                db.SaveChanges();

                return product.Name + " was succesfully inserted";
            }catch (Exception e){
                return "Error: " + e;
            }
        }

        public string UpdateProduct(int id, Product product){
            try{
                CANDZOILPDBEntities1 db = new CANDZOILPDBEntities1();
                 
                Product p = db.Products.Find(id);

                p.Name = product.Name;
                p.Price = product.Price;
                p.TypeId = product.TypeId;
                p.Description = product.Description;
                p.Image = product.Image;

                db.SaveChanges();
                
                return product.Name + " was succesfully updated";
            }catch (Exception e){
                return "Error: " + e;
            }

        }
        public string DeleteProduct(int id){
            try{
                CANDZOILPDBEntities1 db = new CANDZOILPDBEntities1();
                Product product = db.Products.Find(id);

                db.Products.Attach(product);
                db.Products.Remove(product);
                db.SaveChanges();

                return product.Name + " was succesfully deleted";
            }catch (Exception e){
                return "Error: " + e;
            }

        }

        public Product GetProduct(int id) {
            try {
                using (CANDZOILPDBEntities1 db = new CANDZOILPDBEntities1())
                {
                    Product product = db.Products.Find(id);
                    return product;

                }
            }
            catch (Exception e) {
                return null;
            }
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                using (CANDZOILPDBEntities1 db = new CANDZOILPDBEntities1())
                {
                    List<Product> products = (from x in db.Products
                                                  select x).ToList();
                    return products;

                }
            }
            catch (Exception e)
            {
                return null;
            }
 
        }

        public List<Product> GetProductByType(int typeId)
        {

            try
            {
                using (CANDZOILPDBEntities1 db = new CANDZOILPDBEntities1())
                {
                    List<Product> products = (from x in db.Products
                                              where x.TypeId == typeId
                                              select x).ToList();
                    return products;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    


	}
