using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskOpgave.Tests
{
    [TestClass()]
    public class TrophyTests
    {
        [TestMethod()]
        public void ValidateCompetitionTest()
        {
            Trophy trophy = new Trophy() { Competition = null };
            Assert.ThrowsException<ArgumentNullException>(() => trophy.ValidateCompetition());

            trophy.Competition = "UCLS";

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trophy.ValidateCompetition());

        }

        [TestMethod()]
        public void ValidateYearTest()
        {
            Trophy trophy = new Trophy() { Year = 1969 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trophy.ValidateYear());

            trophy.Year = 2025;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trophy.ValidateYear());
        }

        [TestMethod()]
        public void ValidateTest()
        {

        }

        [TestMethod()]
        public void ToStringTest() 
        {
            Trophy trophy = new Trophy() { Id = 1, Competition = "UCLS", Year = 1969 };

            string result = trophy.ToString();

            Assert.AreEqual("Id: 1, Competition: UCLS, Year: 1969", result);


        }
        
    }


    }

