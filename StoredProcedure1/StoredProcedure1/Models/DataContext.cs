using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StoredProcedure1.Models
{
    public class DataContext:DbContext
    {
        public DbSet<FootBallMatch> footBallMatches { get; set; }

    }
}