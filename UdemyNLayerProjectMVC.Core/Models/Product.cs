﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyNLayerProjectMVC.Core.Models
{
    /*Access Modifiers: Internal, Protected, Public, Protected Internal, Private Protected, Private
    * Diğer katmanlardan erişileceği için public olmak durumunda.*/
    public class Product
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public bool IsDeleted { get; set; }

        public String InnerBarkode { get; set; }

        //izleme yapabilmesi için Category virtual tanımlandı
        public virtual Category Category { get; set; }

}
}
