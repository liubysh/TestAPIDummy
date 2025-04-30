using FluentAssertions;
using RestSharp;
using TestAPIDummyJSON.Base;
using TestAPIDummyJSON.Models;

namespace TestAPIDummyJSON
{
    public class BasicTests
    {
        private readonly IRestFactory _restFactory;
  
        public BasicTests(IRestFactory restFactory) => _restFactory = restFactory;

        [Fact]
        public async Task GetListOfAnimalsTest() //Get list of animals test
        {
                var response = await _restFactory.Create()
                .WithRequest("pet/{id}")
                .WithUrlSegment("id", "10")
                .WithGet<Pet>();

            //Assert
            response.Id.Should().Be(10);
        }

        [Fact]
        public async Task GetAnimalByIdTest() //Get animals by id test
        {
            var response = await _restFactory.Create()
            .WithRequest("pet/{id}")
            .WithUrlSegment("id", "10")
            .WithGet<Pet>();

            //Assert
            response.Id.Should().Be(10);
        }
    }
}
