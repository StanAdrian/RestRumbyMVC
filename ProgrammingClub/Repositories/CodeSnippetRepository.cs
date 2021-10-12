using ProgrammingClub.Models;
using ProgrammingClub.Models.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammingClub.Repositories
{
    public class CodeSnippetRepository
    {
        ClubMembershipModelsDataContext dbContext;

        public CodeSnippetRepository()
        {
            this.dbContext = new ClubMembershipModelsDataContext();
        }

        public CodeSnippetRepository(ClubMembershipModelsDataContext dataContext)
        {
            this.dbContext = dataContext;
        }

        public void InsertCodeSnippet(CodeSnippetModel codeSnippetModel)
        {
            codeSnippetModel.IDCodeSnippet = Guid.NewGuid();
            dbContext.CodeSnippets.InsertOnSubmit(MapModelToDbObject(codeSnippetModel));
            dbContext.SubmitChanges();
        }

        public List<CodeSnippetModel> GetAllCodeSnippets()
        {
            List<CodeSnippetModel> codeSnippetModels = new List<CodeSnippetModel>();
            foreach (var dbCodeSnippet in dbContext.CodeSnippets)
            {
                codeSnippetModels.Add(MapDbObjectToModel(dbCodeSnippet));
            }

            return codeSnippetModels;
        }

        public CodeSnippetModel GetCodeSnippetById(Guid id)
        {
            return MapDbObjectToModel(dbContext.CodeSnippets.
                FirstOrDefault(cs => cs.IDCodeSnippet == id));
        }

        public void UpdateCodeSnippet(CodeSnippetModel codeSnippetModel)
        {
            CodeSnippet exisitingCodeSnippet = dbContext.CodeSnippets.
                FirstOrDefault(cs => cs.IDCodeSnippet == codeSnippetModel.IDCodeSnippet);
            
            if (exisitingCodeSnippet != null)
            {
                exisitingCodeSnippet.ContentCode = codeSnippetModel.ContentCode;
                exisitingCodeSnippet.IDCodeSnippet = codeSnippetModel.IDCodeSnippet;
                exisitingCodeSnippet.IDMember = codeSnippetModel.IDMember;
                exisitingCodeSnippet.Revision = codeSnippetModel.Revision;
                exisitingCodeSnippet.Title = codeSnippetModel.Title;
                
                dbContext.SubmitChanges();
            }
        }

        public void DeleteCodeSnippet(Guid id)
        {
            CodeSnippet codeSnippetToBeDeleted = dbContext.CodeSnippets.FirstOrDefault(cs => cs.IDCodeSnippet == id);
            
            if (codeSnippetToBeDeleted != null)
            {
                dbContext.CodeSnippets.DeleteOnSubmit(codeSnippetToBeDeleted);
                dbContext.SubmitChanges();
            }
        }




        private CodeSnippetModel MapDbObjectToModel(CodeSnippet codeSnippet)
        {
            CodeSnippetModel codeSnippetModel = new CodeSnippetModel();
            if(codeSnippet != null)
            {
                codeSnippetModel.IDCodeSnippet = codeSnippet.IDCodeSnippet;
                codeSnippetModel.ContentCode = codeSnippet.ContentCode;
                codeSnippetModel.IDMember = codeSnippet.IDMember;
                codeSnippetModel.Title = codeSnippet.Title;
                codeSnippetModel.Revision = codeSnippet.Revision;

            }
            return codeSnippetModel;
        }


        private CodeSnippet MapModelToDbObject(CodeSnippetModel codeSnippetModel)
        {
            CodeSnippet codeSnippet = new CodeSnippet();
            if(codeSnippetModel != null)
            {
                codeSnippet.ContentCode = codeSnippetModel.ContentCode;
                codeSnippet.IDCodeSnippet = codeSnippetModel.IDCodeSnippet;
                codeSnippet.IDMember = codeSnippetModel.IDMember;
                codeSnippet.Revision = codeSnippetModel.Revision;
                codeSnippet.Title = codeSnippetModel.Title;
            }
            return codeSnippet;
        }
    }
}