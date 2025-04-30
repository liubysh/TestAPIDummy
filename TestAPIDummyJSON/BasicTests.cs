using FluentAssertions;
using RestSharp;
using System.Net;
using TestAPIDummyJSON.Base;
using TestAPIDummyJSON.Models;
using Xunit;

namespace TestAPIDummyJSON
{
    public class BasicTests
    {
        private readonly IRestFactory _restFactory;
  
        public BasicTests(IRestFactory restFactory) => _restFactory = restFactory;

        [Fact]
        public async Task GetListOfAnimalsByStatusTest() //Get animals by status test
        {
            var response = await _restFactory.Create()
            .WithRequest("pet/findByStatus")
            .WithHeader("Accept", "application/json")
            .WithQueryParameter("status", "sold")
            .WithGet<Pet[]>();

            //Assert
            response?.Any(p => p.Status == "sold");
        }

        [Fact]
        public async Task PostAnimalTest() //Post new animal
        {
            var response = await _restFactory.Create()
            .WithRequest("pet")
            .WithHeader("Accept", "application/json")
            .WithHeader("Content-Type", "application/json")
            .WithBody(new Pet
            {
                Id = 17171717,
                Category = new Category 
                { 
                    Id = 17171717,
                    Name = "testCategory"
                },
                Name = "NewPet17171717",
                Status = "available"
            })
            .WithPost<Pet>();

            //Assert
            response?.Id.Should().Be(17171717);
        }

        [Fact]
        public async Task GetAnimalByIdTest() //Get animals by id test
        {
            var response = await _restFactory.Create()
            .WithRequest("pet/{id}")
            .WithHeader("Accept", "application/json")
            .WithUrlSegment("id", "17171717")
            .WithGet<Pet>();

            //Assert
            response?.Id.Should().Be(17171717);
        }

        [Fact]
        public async Task DeleteAnimalByIdTest() //Delete animals by id test
        {
            var response = await _restFactory.Create()
            .WithRequest("pet/{id}")
            .WithHeader("Accept", "application/json")
            .WithUrlSegment("id", "17171717")
            .WithDelete();

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);//should be204, but this api is created in this way
        }
    }
}
