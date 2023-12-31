﻿using Member.Application;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Member.API.Controllers
{
    //En esta capa se implementa el API, la caul presenta la información recibida desde las capas internas.
    //Esta capa depende a todas las capas internas.
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {

        private readonly IMemberService memberService;

        public MembersController(IMemberService memberService)
        {
            this.memberService = memberService;
        }
        // GET: api/<MembersController>
        [HttpGet]
        public ActionResult<IList<Domain.IPlayer>> Get()
        {
            return Ok(this.memberService.GetAllMembers());
        }

    }
}
