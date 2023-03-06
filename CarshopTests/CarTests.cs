using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carshop.Models;

namespace Carshop.Tests
{
    [TestClass()]
    public class CarTests
    {
        Car car = new Car { Id = 1, Model = "Bmw", Price = 150000, LicensPlat = "PD 25565" };
        Car IdNull = new Car { Id = 0, Model = "Bmw", Price = 150000, LicensPlat = "PD 25565" };
        Car modelnull = new Car { Id = 1, Model = "BM", Price = 150000, LicensPlat = "PD 25565" };
        Car Emptymodel = new Car { Id = 1, Model = null, Price = 150000, LicensPlat = "PD 25565" };
        Car PriceNull = new Car { Id = 1, Model = "BM", Price = 0, LicensPlat = "PD 25565" };
        Car EmptyLicensPlat = new Car { Id = 1, Model = "Bmw", Price = 150000, LicensPlat = null };
        Car licensplatsmallerThanOne = new Car { Id = 1, Model = "BM", Price = 0, LicensPlat = "p" };
        Car LicensplateMoreThanSeven = new Car { Id = 1, Model = "Bmw", Price = 150000, LicensPlat = "pp02565699" };



        [TestMethod]
        public void IDvalidateTest()
        {
            car.ValidateID();
            Assert.ThrowsException<ArgumentNullException>(() => IdNull.ValidateID());
        }

        [TestMethod()]
        public void ModelValidatTest()
        {
            car.ModelValidat();

           Assert.ThrowsException<ArgumentNullException>(() => Emptymodel.ModelValidat());

           Assert.ThrowsException<ArgumentException>(() => modelnull.ModelValidat());
        }

        [TestMethod()]
        public void PriceValidateTest()
        {
            car.PriceValdiate();
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() =>PriceNull.PriceValdiate());
            }
        }
        [TestMethod]
        public void LicensPlatValidateTest() 
        {
          car.LicensePlatvalidate();

            Assert.ThrowsException<ArgumentNullException>(()=> EmptyLicensPlat.LicensePlatvalidate());
            Assert.ThrowsException<ArgumentException>(()=> licensplatsmallerThanOne.LicensePlatvalidate());   
            Assert.ThrowsException<ArgumentException>(()=> LicensplateMoreThanSeven.LicensePlatvalidate());
        }

      
    }
}