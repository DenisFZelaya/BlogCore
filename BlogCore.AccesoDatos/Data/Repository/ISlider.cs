using BlogCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace BlogCore.AccesoDatos.Data.Repository
{
    public interface ISliderRepository : IRepository<Slider>
    {
        void Update(Slider slider);
    }
}
