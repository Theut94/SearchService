using Microsoft.AspNetCore.Mvc;
using WordSearcher;

[ApiController]
[Route("[controller]")]
public class OccurrenceController : ControllerBase
{
    private Database database = Database.GetInstance();

    [HttpPost]
    public async Task Post(int docId, [FromBody] ISet<int> wordIds)
    {
       await database.InsertAllOcc(docId, wordIds);
    }
}