using ActiveDirectoryMicroservice.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActiveDirectoryMicroservice.Controllers
{
    [Route("api/rest/v1/validate")]
    [ApiController]
    public class ValidateTokenController : ControllerBase
    {


        [HttpGet("user")]
        [Authorize(Policy = "MustBeCustomer")]
        public ActionResult isValidCustomer()
        {

            return Ok();

        }

        [HttpGet("admin")]
        [Authorize(Policy = "MustBeAdmin")]
        public ActionResult isValidAdmin()
        {

            return Ok();

        }

    }
    }
