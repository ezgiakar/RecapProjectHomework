﻿using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Color : IEntity
    {
        public int ColorID { get; set; }
        public string ColorName { get; set; }
    }
}
