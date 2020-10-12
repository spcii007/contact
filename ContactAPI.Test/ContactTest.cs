using ContactAPI.Data;
using ContactAPI.Models;
using Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ContactAPI.Test
{
    public class ContactTest
    {
        [Fact]
        void ContactInsert_IsValid()
        {
            //Arrange
            var mock = new Mock<IPersonRepository>();
            var Id = 1;
            var person = new Person { Id = 1, 
                                      Name = new Name {Id = 1, first = "Pablo", middle = "Andres", last= "Cifuentes"},
                                      Address = new Address { Id = 1, state = "Virginia", city="Richmond" },
                                      Email = "spcii@foo.com"
            };

            mock.Setup(x => x.SelectPersonbyId(Id)).Returns(Task.Run(()=> person));
            mock.Setup(x => x.SaveChanges()).Returns (true);
            var controller = new ContactController(mock.Object);

            //Act

            ObjectResult newContact = (ObjectResult)controller.InsertPerson(person);
            
            //Assert
            Assert.Same(person, newContact.Value);
                         
        }
    }
}
