using Microsoft.AspNetCore.Mvc;
using WordSearcher;

[ApiController]
[Route("[controller]")]
public class DatabaseController : ControllerBase
{
    private Database database = Database.GetInstance();

    [HttpDelete]
    public async Task Delete()
    {
        await database.DeleteDatabase();
    }

    [HttpPost]
    public async Task Post()
    {
        await database.RecreateDatabase();
    }
}