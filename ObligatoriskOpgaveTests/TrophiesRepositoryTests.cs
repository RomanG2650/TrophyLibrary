using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskOpgave.Tests
{
    [TestClass()]
    public class TrophiesRepositoryTests
    {
        private TrophiesRepository repository;

        
        public TrophiesRepositoryTests()
        {
            repository = new TrophiesRepository();
        }



        [TestMethod()]
        public void GetAllTest()
        {
           List<Trophy> trophies = repository.GetAll(); //få alle 5 trophies

           Assert.AreEqual(5, trophies.Count);

           
        }

       
        [TestMethod()]
        public void GetByIdTest()
        {
            Trophy trophy = repository.GetById(10);
            Assert.IsNull(trophy);

          
        }

        [TestMethod()]
        public void AddTrophyTest()
        {
            
            var newTrophy = new Trophy { Competition = "New Competition", Year = 2024 };

            
            var addedTrophy = repository.AddTrophy(newTrophy);

            
            Assert.IsNotNull(addedTrophy);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            
        }

        [TestMethod()]
        public void UpdateTest()
        {
            
        }
    }
}

