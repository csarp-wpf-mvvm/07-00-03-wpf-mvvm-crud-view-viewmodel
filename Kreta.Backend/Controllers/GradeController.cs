﻿using Kreta.Backend.Repos;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GradeController : BaseController<Grade, GradeDto>
    {
        public GradeController(GradeAssambler? assambler, IGradeRepo? repo) : base(assambler, repo)
        {
        }
    }
}
