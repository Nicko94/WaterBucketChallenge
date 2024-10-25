using Microsoft.AspNetCore.Mvc;
using WaterBucketChallenge.Application.Dtos;
using WaterBucketChallenge.Application.Dtos.BaseDtos;
using WaterBucketChallenge.Application.Interfaces;

namespace WaterBucketChallenge.API.Controllers
{
    public class WaterBucketController : ControllerBase
    {

        private readonly IWaterBucketService _solver;

        public WaterBucketController(IWaterBucketService solver)
        {
            _solver = solver;
        }
        
        [HttpPost("solve")]
        //public IActionResult Solve(int x, int y, int z)
        public IActionResult Solve([FromBody] WaterJugRequestDto request)
        {
            //if (x <= 0 || y <= 0 || z <= 0)
            if (request.XCapacity <= 0 || request.YCapacity <= 0 || request.ZTarget < 0)
            {
                return BadRequest(new { error = "X, Y, and Z must be positive integers." });
            }
            else if (request.ZTarget > Math.Max(request.XCapacity, request.YCapacity))
            {
                return BadRequest(new { error = "Target volume cannot be larger than the largest jug." });
            }

            WaterBucketBaseResponseDto waterBucketResponseDto = _solver.Solve(request.XCapacity, request.YCapacity, request.ZTarget);

            if (waterBucketResponseDto is WaterBucketErrorResponseDto || waterBucketResponseDto is WaterBucketNoSolutionResponseDto)
            {
                return BadRequest(waterBucketResponseDto);
            }

            return Ok(waterBucketResponseDto);
        }
    }
}
