using ProgrammingClub.Models.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammingClub.Repositories
{
    public class BackOfficeRepository
    {

        private ClubMembershipModelsDataContext dbContext;

        public BackOfficeRepository()
        {
            this.dbContext = new ClubMembershipModelsDataContext();
        }

        public BackOfficeRepository(ClubMembershipModelsDataContext dbContext)
        {
            this.dbContext = dbContext;
        }





    }
}