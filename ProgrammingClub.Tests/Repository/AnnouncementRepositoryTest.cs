using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingClub.Models;
using ProgrammingClub.Models.DBObjects;
using ProgrammingClub.Repositories;
using System;
using System.Configuration;

namespace ProgrammingClub.Tests.Repository
{
    [TestClass]
    public class AnnouncementRepositoryTest
    {
        private ClubMembershipModelsDataContext dbContext;
        private string testConnectionString;
        private AnnouncementRepository announcementRepository;

        [TestInitialize]
        public void Initialize()
        {
            testConnectionString = ConfigurationManager
                .ConnectionStrings["clubmembershipConnectionStringTest"]
                .ConnectionString;
            dbContext = new ClubMembershipModelsDataContext(testConnectionString);
            announcementRepository = new AnnouncementRepository(dbContext);
        }

        [TestMethod]
        public void GetAnnouncementById_AnnouncementExists()
        {
            // AAA pattern -> Arrange, Act, Assert. Setup all objects (Arrange). Invoke the method under test(Act).
            // Verify the fact that the method behaves as expected (Assert)
            // Arange
            Guid ID = Guid.NewGuid();
            Announcement expectedAnnouncement = new Announcement
            {
                IDAnnouncement = ID,
                ValidFrom = new DateTime(2021, 1, 1),
                ValidTo = new DateTime(2021, 1, 1),
                Tags = "test tag",
                Text = "Announcement",
                Title = "Important",
                EventDateTime = null
            };
            dbContext.Announcements.InsertOnSubmit(expectedAnnouncement);
            dbContext.SubmitChanges();

            //Act
            AnnouncementModel result = announcementRepository.GetAnnouncementById(ID);

            //Assert
            Assert.AreEqual(result.IDAnnouncement, expectedAnnouncement.IDAnnouncement);            
            Assert.AreEqual(result.ValidFrom, expectedAnnouncement.ValidFrom);
            Assert.AreEqual(result.ValidTo, expectedAnnouncement.ValidTo);
            Assert.AreEqual(result.Tags, expectedAnnouncement.Tags);           
            Assert.AreEqual(result.Text, expectedAnnouncement.Text);
            Assert.AreEqual(result.Title, expectedAnnouncement.Title);
            Assert.AreEqual(result.EventDateTime, expectedAnnouncement.EventDateTime);


        }

        [TestMethod]
        public void GetAnnouncementById_AnnouncementDoesntExist()
        {
            //Arange
            Guid ID = Guid.NewGuid();
            Announcement expectedAnnouncement = new Announcement
            {
                IDAnnouncement = ID,
                ValidFrom = new DateTime(2021, 1, 1),
                ValidTo = new DateTime(2021, 1, 1),
                Tags = "test tag",
                Text = "Announcement",
                Title = "Important",
                EventDateTime = null
            };
            dbContext.Announcements.InsertOnSubmit(expectedAnnouncement);
            dbContext.SubmitChanges();
            
            //Act
            AnnouncementModel result = announcementRepository.GetAnnouncementById(Guid.NewGuid());

            //Assert
            Assert.IsNull(result);


        }

    }
}
