using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rently.Models;

namespace Rently.ViewModels
{
    public class RandomCarViewModel
    {
        public Car Car { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
