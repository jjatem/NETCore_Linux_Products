using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ProductLister
{
    public class Product
    {
        public int Id {get;set;}
        public string Name {get;set;}
    }
}