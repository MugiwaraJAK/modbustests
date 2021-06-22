using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using Xunit;

namespace ModbusPOC.Tests
{

    //In memory data (from profile onward)
    public static class InMemoryData
    {
        public static List<string> Lines = new List<string>
        {
            new string("Product1"),
            new string("Product2"),
            new string("Product3")
        };
    }

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange

            var data = InMemoryData.Lines;


            //Act

            //var response = LibraryWrapper.SendMessage(ipAddress, port, data);



            //Assert
            //Assert.Equal(response.responseCode,10);
        }
    }
}
