using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileTrader.Data;
using MobileTrader.Entity;
using MobileTrader.Web.Controllers.Resources;

namespace MobileTrader.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Makes")]
    public class MakesController : Controller
    {
        private readonly MobileTraderDbContext _context;
        private readonly IMapper _mapper;


        public MakesController(MobileTraderDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await _context.Makes.Include(x => x.Models).ToListAsync();
            return _mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}