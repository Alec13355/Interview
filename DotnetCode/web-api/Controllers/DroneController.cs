using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DroneController : ControllerBase
    {
        public DroneController(){}

        [HttpGet]
        public List<int> GetDroneList(List<int> droneList)
        {
            throw new NotImplementedException();
        }
    }
}
