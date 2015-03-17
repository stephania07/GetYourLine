using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetYourlLine.Repository;
using GetYourlLine.Models;

namespace GetYourlLine.Tests.Repository
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        private static CustomerRepository repo;

        [ClassInitialize]
        public static void SetUp(TestContext _context)
        {
            repo = new CustomerRepository("Name=TestDB");
            repo.Clear();
        }
        [TestCleanup]
        public void ClearDatabase()
        {
            repo.Clear();
        }
        [TestMethod]
        public void TestAddToDatabase()
        {
            Assert.AreEqual(0, repo.GetCountCustomers());
            repo.AddCustomers(new Customer("Existing","John","Robert","J@gmail.com","1234567899"));
            Assert.AreEqual(1, repo.GetCountCustomers());
        }

        [TestMethod]
        public void TestGetCountCustomers()
        {
            Assert.AreEqual(0, repo.GetCountCustomers());
            repo.AddCustomers(new Customer("New Applicant", "John", "Robert", "J@gmail.com", "1234567899"));
            Assert.AreEqual(1, repo.GetCountCustomers());
        }

        [TestMethod]
        public void TestClearCustomers()
        {
            repo.AddCustomers(new Customer("New Applicant", "John", "Robert", "J@gmail.com", "1234567899"));
            repo.Clear();
            Assert.AreEqual(0, repo.GetCountCustomers());
        }

        [TestMethod]
        public void TestAddToCustomerDetails()
        {
            Assert.AreEqual(0, repo.GetCountCustomerDetails());
           // repo.AddCustomerDetails(new CustomerDetail("9:30:52 AM", "8:30:52 AM", "1", "3"));
            Assert.AreEqual(1, repo.GetCountCustomers());
        }

        [TestMethod]
        public void TestGetCountCustomerDetails()
        {
            Assert.AreEqual(0, repo.GetCountCustomers());
           // repo.AddCustomerDetails(new CustomerDetail("10:30:52 AM",  "9:30:52 AM", "1", "2"));
            Assert.AreEqual(1, repo.GetCountCustomers());
        }

        [TestMethod]
        public void TestClearCustomerDetails()
        {
           // repo.AddCustomerDetails(new CustomerDetail("11:30:52 AM", "10:30:52 AM", "1", "2"));
            repo.Clear();
            Assert.AreEqual(0, repo.GetCountCustomerDetails());
        }

       
    }
}
