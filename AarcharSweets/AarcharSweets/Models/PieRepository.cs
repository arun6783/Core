using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AarcharSweets.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _dbContext;

        public PieRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Pie GetPieById(int pieId)
        {
            return _dbContext.Pies.FirstOrDefault(x => x.PieId == pieId);
        }

        public IEnumerable<Pie> Pies
        {
            get { return _dbContext.Pies.Include(x => x.Category); }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get { return _dbContext.Pies.Include(p => p.Category).Where(x => x.IsPieOfTheWeek); }
        }
    }
}