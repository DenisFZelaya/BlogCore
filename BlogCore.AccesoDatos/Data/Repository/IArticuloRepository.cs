using BlogCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace BlogCore.AccesoDatos.Data.Repository
{
    public interface IArticuloRepository : IRepository<Articulo>
    {
        void Update(Articulo articulo);
    }
}
