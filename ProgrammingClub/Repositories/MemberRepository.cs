using ProgrammingClub.Models;
using ProgrammingClub.Models.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammingClub.Repositories
{
    public class MemberRepository
    {
        private ClubMembershipModelsDataContext dbContext;

        public MemberRepository()
        {
            this.dbContext = new ClubMembershipModelsDataContext();
        }

        public MemberRepository(ClubMembershipModelsDataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void InsertMember(MemberModel memberModel)
        {
            memberModel.IDMember = Guid.NewGuid();
            dbContext.Members.InsertOnSubmit(MapModelToDbObject(memberModel));
            dbContext.SubmitChanges();
        }

        public List<MemberModel> GetAllMembers()
        {
            List<MemberModel> memberModels = new List<MemberModel>();
            foreach (var member in dbContext.Members)
            {
                memberModels.Add(MapDbObjectToModel(member));
            }
            return memberModels;
        }

        public MemberModel GetMemberById(Guid id)
        {
            return MapDbObjectToModel(dbContext.Members.FirstOrDefault(m => m.IDMember == id));
        }

        public void UpdateMember(MemberModel memberModel)
        {
            Member exisitingMember = dbContext.Members.FirstOrDefault(m => m.IDMember == memberModel.IDMember);
            if (exisitingMember != null)
            {
                exisitingMember.IDMember = memberModel.IDMember;
                exisitingMember.Name = memberModel.Name;
                exisitingMember.Title = memberModel.Title;
                exisitingMember.Position = memberModel.Position;
                exisitingMember.Description = memberModel.Description;
                exisitingMember.Resume = memberModel.Resume;
                dbContext.SubmitChanges();
            }
        }

        public void DeleteMember(Guid id)
        {
            Member member = dbContext.Members.FirstOrDefault(m => m.IDMember == id);
            if (member != null)
            {
                dbContext.Members.DeleteOnSubmit(member);
                dbContext.SubmitChanges();
            }
        }

        private MemberModel MapDbObjectToModel(Member member)
        {
            MemberModel memberModel = new MemberModel();
            if (member != null)
            {
                memberModel.IDMember = member.IDMember;
                memberModel.Name = member.Name;
                memberModel.Title = member.Title;
                memberModel.Position = member.Position;
                memberModel.Description = member.Description;
                memberModel.Resume = member.Resume;
            }
            return memberModel;
        }

        private Member MapModelToDbObject(MemberModel memberModel)
        {
            Member member = new Member();
            if (memberModel != null)
            {
                member.IDMember = memberModel.IDMember;
                member.Name = memberModel.Name;
                member.Title = memberModel.Title;
                member.Position = memberModel.Position;
                member.Description = memberModel.Description;
                member.Resume = memberModel.Resume;
            }
            return member;
        }

    }
}