using BlogCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace BlogCore.AccesoDatos.Data.Repository
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        IEnumerable<SelectListItem> GetListaCategorias();

        void Update(Categoria categoria);
    }
}
