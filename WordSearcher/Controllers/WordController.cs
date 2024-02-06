using Microsoft.AspNetCore.Mvc;
using WordSearcher;

[ApiController]
[Route("[controller]")]
public class WordController : ControllerBase
{
    private Database database = Database.GetInstance();

    [HttpGet]
    public async  Task<Dictionary<string, int>> Get()
    {
        return await database.GetAllWords();
    }

    [HttpPost]
    public async Task Post([FromBody] Dictionary<string, int> res)
    {
       await database.InsertAllWords(res);
    }
}