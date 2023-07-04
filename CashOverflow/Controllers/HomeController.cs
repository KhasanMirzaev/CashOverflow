// -------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by CashOverflow Team   
// -------------------------------------------------

using Microsoft.AspNetCore.Mvc;

namespace CashOverflow.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get() => "Cash flows...";
    }
}
