using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Car : IEntity
    {
        public int CarID { get; set; }
        public int CarBrandID { get; set; }
        public int CarColorID { get; set; }
        public int CarModalYear { get; set; }
        public decimal CarDailyPrice { get; set; }
        public string CarDescription { get; set; }
    }
}
