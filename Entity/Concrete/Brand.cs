using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{

    public class Brand : IEntity
    {
        [Key]
        public int CarBrandID { get; set; }
        public string CarBrandName { get; set; }
    }
}
