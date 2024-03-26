using RentCars.BusinessLogic.Interfaces;
using RentCars.Domain.Entities.GeneralResponses;
using RentCars.Domain.Entities.Product;
using RentCars.Domain.Entities.User;
using RentCars.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentCars.Controllers
{
    public class ProductController : Controller
    {
        internal IProduct _product;
        public ProductController()
        {
            var bl = new BusinessLogic.BusinessLogic();
            _product = bl.GetProductBL();
        }

        // GET: Product
        public ActionResult Products()
        {
            ProductDataModel products = _product.GetProductsToList(); //pr1  lt
            //связать с моделью из View
            ProductPresentation productPr = new ProductPresentation(); //создаем модель из View 
            productPr.Name = products.SingleProduct.Name;              // и передаем ей данные из базы данных
                                                                       // чтобы использовать в View
            var model = new
            {
                products
            };


            return View(productPr);
        }


        //single product page info 
        public ActionResult CarSingle(int id) 
        {
            ProductDataModel singleProduct = _product.GetSingleProduct(id);
           
            var model = new
            {
                singleProduct
            };

            return View(model);
        }


    }
}