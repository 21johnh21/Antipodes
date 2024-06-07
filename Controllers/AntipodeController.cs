using Microsoft.AspNetCore.Mvc;

namespace Antipodes.Controllers;

[ApiController]
[Route("[controller]")]

public class AntipodeController : ControllerBase
{
    [HttpGet("string/{latitude:double},{longitude:double}")]
    public string String(double latitude, double longitude)
    {
        latitude = latitude * -1;
        if (longitude > 0){
            longitude = longitude - 180;
        } else{
            longitude = longitude + 180;
        }
        return latitude.ToString() + "," + longitude.ToString();
    }
}