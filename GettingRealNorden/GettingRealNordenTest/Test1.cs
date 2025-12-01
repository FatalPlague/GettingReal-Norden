using GettingRealNorden;
using GettingRealNorden.Models;
using System.Runtime.InteropServices;

namespace GettingRealNordenTest
{
    [TestClass]
    public sealed class Test1
    {

        //ARRANGE
        NewsletterRepository nlRepo = new NewsletterRepository("Resources/Test.csv");

        Company c1 = new Company("Norden Odense", "Christian IX's Vej 15, 5230 Odense M",
            "45048330", "https://foreningen-norden-odense.dk/");
        Company c2 = new Company("Danske bank", "Danmark",
            "12345678", "danskebank.dk");

        Admin a1 = new Admin("Andreas", "Andreas1234", 1);
        Admin a2 = new Admin("Magnus", "Magnus1234", 2);

        [TestMethod]
        public void ShouldCreateNewslettersAndFindThemInRepositoryByCompanyNameAndAdminId()
        {
            //ACT
            nlRepo.CreateNewsletter(c1, a1);
            nlRepo.CreateNewsletter(c2, a2);
            List<Newsletter> nls = new List<Newsletter>();
            nls = nlRepo.GetAll();

            //ASSERT
            Assert.AreEqual("Norden Odense", nls[0].CompanyName);
            Assert.AreEqual(1, nls[0].AdminId);

            Assert.AreEqual("Danske bank", nls[1].CompanyName);
            Assert.AreEqual(2, nls[1].AdminId);

        }
    }
}
