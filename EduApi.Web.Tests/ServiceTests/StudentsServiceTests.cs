﻿using System.Linq;
using EduApi.Web.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EduApi.Web.Tests.ServiceTests
{
    public class StudentsServiceTests
    {
        [TestClass]
        public class When_getting_all_students
        {
            [TestMethod]
            public void Should_return_a_collection_of_students()
            {
                IStudentsService service = new StudentsService();
                var actualModel = service.Get();
                Assert.IsTrue(actualModel.Any());
            }
        }
    }
}