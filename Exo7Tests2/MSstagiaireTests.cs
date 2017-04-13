using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exo7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo7.Tests
{
    [TestClass()]
    public class MSstagiaireTests
    {
        MSstagiaire unStagiaire;

        [TestInitialize]
        public void initialize()
        {
            this.unStagiaire = new MSstagiaire();
        }
        [TestMethod()]
        public void codePostale_CodePost_OK()
        {
            string code = "12654";
            unStagiaire.CodePostal = code;
            Assert.AreEqual(unStagiaire.CodePostal, code, "mouvais");
        }

        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void numOSIA_chaine_LeveException()
        {
            string a = "45gh456";
            Convert.ToInt32(a);
           
        }


    }
}