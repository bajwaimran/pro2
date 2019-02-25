using MasspackWebApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http;
using MasspackWebApi.Models;


namespace MasspackWebApi.Tests.Controllers
{
    [TestClass]
    class ArtikelControllerTest
    {
        [TestMethod]
        public void GetArtikels()
        {
            var controller = new ArtikelController();
            //controller.Request = new HttpRequestMessage();
            
            //var result = art.Get();
        }
    }
}
