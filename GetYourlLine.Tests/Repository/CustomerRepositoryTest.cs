﻿using System;
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
            repo = new CustomerRepository();
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
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Customer("Existing","John","Robert","J@gmail.com","1234567899"));
            Assert.AreEqual(1, repo.GetCount());
        }

       
    }
}