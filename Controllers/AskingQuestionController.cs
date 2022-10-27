//Harrison Busby
//10/27/2022
//Asking Questions Endpoint
//Peer reviewed by: Carlos Felipe: This program is clean. The endpoint routes and controller are both formatted correctly. 
//My input was taken in and converted to a output string. One thing I thought was redundant was the use of AskingQuestions in the route. 
//You could simply have done : localhost/askingquestion(the controller) /{name}/{place}. But other than that everything works well. Good job!


using Microsoft.AspNetCore.Mvc;

namespace BusbyHAskingQuestionsEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingQuestionController : ControllerBase
{
   
[HttpGet]
[Route("AskingQuestions/{name}/{place}")]

public string Questions(string name, string place){

return $"Hello {name}, how are you doing today? Oh you're doing good, that's great! Would you like to go to {place}?";

}




}
