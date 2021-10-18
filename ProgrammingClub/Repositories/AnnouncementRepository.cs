using ProgrammingClub.Models;
using ProgrammingClub.Models.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammingClub.Repositories
{
    public class AnnouncementRepository
    {
       
        private ClubMembershipModelsDataContext dbContext;

        public AnnouncementRepository()
        {
            this.dbContext = new ClubMembershipModelsDataContext();
        }

        public AnnouncementRepository(ClubMembershipModelsDataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<AnnouncementModel> GetAllAnnouncements()
        {
            List<AnnouncementModel> announcementModels = new List<AnnouncementModel>();
            foreach(var dbAnnouncement in dbContext.Announcements)
            {
                announcementModels.Add(MapDbObjectToModel(dbAnnouncement));
            }

            return announcementModels;
        }

        public AnnouncementModel GetAnnouncementById(Guid id)
        {
            return MapDbObjectToModel(dbContext.Announcements.
                FirstOrDefault(ann => ann.IDAnnouncement == id));
        }

        public void InsertAnnouncement(AnnouncementModel announcementModel)
        {
            announcementModel.IDAnnouncement = Guid.NewGuid();
            dbContext.Announcements.InsertOnSubmit(MapModelToDbObject(announcementModel));
            dbContext.SubmitChanges();
        }



        public void UpdateAnnouncements (AnnouncementModel announcementModel)
        {
            Announcement existingAnnouncement = dbContext.Announcements.
                FirstOrDefault(x => x.IDAnnouncement == announcementModel.IDAnnouncement);
            if(existingAnnouncement != null)
            {
                existingAnnouncement.IDAnnouncement = announcementModel.IDAnnouncement;
                existingAnnouncement.ValidFrom = announcementModel.ValidFrom;
                existingAnnouncement.ValidTo = announcementModel.ValidTo;
                existingAnnouncement.Title = announcementModel.Title;
                existingAnnouncement.Text = announcementModel.Text;
                existingAnnouncement.Tags = announcementModel.Tags;
                dbContext.SubmitChanges();
            }

        }


        public void DeleteAnnouncement(Guid id)
        {
            Announcement announcementToBeDeleted = dbContext.Announcements.
                FirstOrDefault(ann => ann.IDAnnouncement == id);
            if (announcementToBeDeleted != null)
            {
                dbContext.Announcements.DeleteOnSubmit(announcementToBeDeleted);
                dbContext.SubmitChanges();
            }
        }



        private AnnouncementModel MapDbObjectToModel(Announcement announcement)
        {
            AnnouncementModel announcementModel = new AnnouncementModel();
            if (announcement != null)
            {
                announcementModel.IDAnnouncement = announcement.IDAnnouncement;
                announcementModel.ValidFrom = announcement.ValidFrom;
                announcementModel.ValidTo = announcement.ValidTo;
                announcementModel.Title = announcement.Title;
                announcementModel.Text = announcement.Text;
                announcementModel.EventDateTime = announcement.EventDateTime;
                announcementModel.Tags = announcement.Tags;
                return announcementModel;
            }
            return null;
        }

        private Announcement MapModelToDbObject(AnnouncementModel announcementModel)
        {
            Announcement dbAnnouncement = new Announcement();
            if (announcementModel != null)
            {
                dbAnnouncement.IDAnnouncement = announcementModel.IDAnnouncement;
                dbAnnouncement.ValidFrom = announcementModel.ValidFrom;
                dbAnnouncement.ValidTo = announcementModel.ValidTo;
                dbAnnouncement.Title = announcementModel.Title;
                dbAnnouncement.Text = announcementModel.Text;
                dbAnnouncement.EventDateTime = announcementModel.EventDateTime;
                dbAnnouncement.Tags= announcementModel.Tags;
                return dbAnnouncement;
            }
            return null;
        }


      






    }
}