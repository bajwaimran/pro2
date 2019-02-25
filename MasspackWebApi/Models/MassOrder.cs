using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasspackWebApi.Models
{
    public class MassOrder
    {
        public int[] KundenIds { get; set; }
        public int[] ArtikelIds { get; set; }
    }
}