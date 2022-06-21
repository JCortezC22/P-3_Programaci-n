using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Net.Http;

namespace Restaurant.Controllers
{
    public class ProductosController : ApiController
    {
        [System.Web.Http.HttpPost]
        public IHttpActionResult Add()
        {
            using (Models.RestaurantEntities1 db = new Models.RestaurantEntities1())
            {
                var oProducto = new Models.Producto();
                oProducto.Nombre = "Hamburguesa";
                oProducto.Descripcion = "Botella";
                oProducto.Precio = Convert.ToDecimal(2.50);
                oProducto.Cantidad = 12;
                oProducto.Estado = 1;
                oProducto.Foto = "https://assets.unileversolutions.com/recipes-v2/218401.jpg";

                db.Producto.Add(oProducto);
                db.SaveChanges();
            }
            return Ok("¡Hecho! El insert del producto se hizo correctamente");

        }

    }
}