using HelloWorld.Api.Services;
using Moq;
using Xunit;

namespace HelloWorld.Api.Tests
{
    public class HelloWorldControllerTest
    {
        [Fact]
        public void TestGetMethod()
        {
            var messageService = new Mock<IMessageService>();
            messageService.Setup(ss => ss.GetMessage()).Returns("TestMessage");

            var sut = new Controllers.HelloWorldController(messageService.Object);

            var testMessage = sut.Get();

            Assert.True(testMessage == "TestMessage");
            
        }
    }
}
