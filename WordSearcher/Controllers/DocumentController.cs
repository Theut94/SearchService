using Microsoft.AspNetCore.Mvc;
using WordSearcher;

[ApiController]
[Route("[controller]")]
public class DocumentController : ControllerBase
{
    private Database database = Database.GetInstance();

    [HttpGet("GetByDocIds")]
    public async Task<List<string>> GetByDocIds([FromQuery] List<int> docIds)
    {
        return await database.GetDocDetails(docIds);
    }

    [HttpGet("GetByWordIds")]
    public async Task< Dictionary<int, int>> GetByWordIds([FromQuery] List<int> wordIds)
    {
        return await database.GetDocuments(wordIds);
    }

    [HttpPost]
    public async Task Post(int id, string url)
    {
       await database.InsertDocument(id, url);
    }
}