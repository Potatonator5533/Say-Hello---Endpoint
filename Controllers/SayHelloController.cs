using Microsoft.AspNetCore.Mvc;

namespace Say_Hello___Endpoint;

[ApiController]
[Route("[controller]")]

public class SayHelloController : ControllerBase
{
    public string userName;

    public SayHelloController()
    {
        userName = "";
    }

    [HttpPost]
    [Route("Name/{userInput}")]
    public string Name(string userInput)
    {
        userName = "Hello, " + userInput;
        return userName;
    }
}