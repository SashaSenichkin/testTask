using Microsoft.AspNetCore.Mvc;
using testTask;

namespace WebApplication1.Controllers;

[ApiController]
[Route("/[controller]")]
public class SimpleController : ControllerBase
{
    /// <summary>
    /// sum two simple ints. no overload check
    /// </summary>
    [HttpGet]
    public async Task<int> GetSumAsync(int a, int b)
    {
        return Interop.Sum(a, b);
    }
}