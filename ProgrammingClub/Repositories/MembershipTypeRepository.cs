using ProgrammingClub.Models;
using ProgrammingClub.Models.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammingClub.Repositories
{
    public class MembershipTypeRepository
    {
        private ClubMembershipModelsDataContext dbContent;

        public MembershipTypeRepository()
        {
            dbContent = new ClubMembershipModelsDataContext();
        }

        public MembershipTypeRepository(ClubMembershipModelsDataContext dbContent)
        {
            this.dbContent = dbContent;
        }

        public void InsertMembershipType(MembershipTypeModel membershipTypeModel)
        {
            membershipTypeModel.IDMembershipType = Guid.NewGuid();
            dbContent.MembershipTypes.InsertOnSubmit(MapModelToDbObject(membershipTypeModel));
            dbContent.SubmitChanges();
        }

        public List<MembershipTypeModel> GetAllMembershipTypeModel()
        {
            List<MembershipTypeModel> membershipTypeModels = new List<MembershipTypeModel>();
            foreach(var membershipTypeModel in dbContent.MembershipTypes)
            {
                membershipTypeModels.Add(DbObjectToMapModel(membershipTypeModel));
            }
            return membershipTypeModels;
        }

        public MembershipTypeModel GetMembershipTypeModelById(Guid id)
        {
            return DbObjectToMapModel(dbContent.MembershipTypes.
                FirstOrDefault(m => m.IDMembershipType == id));
        }

        private MembershipType MapModelToDbObject(MembershipTypeModel membershipTypeModel)
        {
            MembershipType membershipType = new MembershipType();
            if(membershipTypeModel != null)
            {
                membershipType.IDMembershipType = membershipTypeModel.IDMembershipType;
                membershipType.Name = membershipTypeModel.Name;
                membershipType.Description = membershipTypeModel.Description;
                membershipType.SubscriptionLengthInMonths = membershipTypeModel.SubscriptionLengthInMonths;                
            }
            return membershipType;
        }

        private MembershipTypeModel DbObjectToMapModel(MembershipType membershipType)
        {
            MembershipTypeModel membershipTypeModel = new MembershipTypeModel();
            if(membershipType != null)
            {
                membershipTypeModel.IDMembershipType = membershipType.IDMembershipType;
                membershipTypeModel.Name = membershipType.Name;
                membershipTypeModel.Description = membershipType.Description;
                membershipTypeModel.SubscriptionLengthInMonths = membershipType.SubscriptionLengthInMonths;
                return membershipTypeModel;
            }
            return null;
        }

        public void UpdateMembershipTypeModel(MembershipTypeModel membershipTypeModel)
        {
            MembershipType existigMembershipType = dbContent.MembershipTypes.
                FirstOrDefault(m => m.IDMembershipType == membershipTypeModel.IDMembershipType);
            if(existigMembershipType != null)
            {
                existigMembershipType.IDMembershipType = membershipTypeModel.IDMembershipType;
                existigMembershipType.Name = membershipTypeModel.Name;
                existigMembershipType.Description = membershipTypeModel.Description;
                existigMembershipType.SubscriptionLengthInMonths = membershipTypeModel.SubscriptionLengthInMonths;
                dbContent.SubmitChanges();
            }

        }

        public void DeleteMembershipTypeModel(Guid id)
        {
            MembershipType membershipType = dbContent.MembershipTypes.FirstOrDefault(m => m.IDMembershipType == id);
            if(membershipType != null)
            {
                dbContent.MembershipTypes.DeleteOnSubmit(membershipType);
                dbContent.SubmitChanges();
            }
        }




    }
}