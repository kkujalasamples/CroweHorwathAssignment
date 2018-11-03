namespace HelloWorld.Api.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello World";
        }
    }
}
