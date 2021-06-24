using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using ModbusPOC.Library;
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

    public class PrinterTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange

            var data = InMemoryData.Lines;
            var printerClient = new PrinterClient("testPrinter", "192.168.0.9", "502");

            
            //Act
            var response = printerClient.SendMessage("ABC123");

            //Assert
            Assert.True(response);
        }
    }
}
