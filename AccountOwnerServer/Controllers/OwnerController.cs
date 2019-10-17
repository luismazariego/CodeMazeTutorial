using System;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AccountOwnerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly ILoggerManager _logger;

        public OwnerController(IRepositoryWrapper repositoryWrapper, ILoggerManager logger)
        {
            _repositoryWrapper = repositoryWrapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOwners()
        {
            //try
            //{
            //    var owners = await _repositoryWrapper.Owner.GetAllAsync();
            //    return Ok(owners);
            //}
            //catch (Exception ex)
            //{
            //    _logger.LogError($"Some error in the GetAllOwners method: {ex}");
            //    return StatusCode(500, "Internal server error");
            //}
            _logger.LogInfo("Fetching all owners from the DB");

            var owners = await _repositoryWrapper.Owner.GetOwnerByIdAsync(Guid.NewGuid());

            _logger.LogInfo($"Returning {owners.Name}.");

            return Ok(owners);

            throw new Exception("Exception while fetching all the students from the storage.");

            
        }
    }
}