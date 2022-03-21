using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TechnicalTask.Models
{
    public class ForumDbInitializer : DropCreateDatabaseAlways<TopicContext>
    {
        protected override void Seed(TopicContext db)
        {
            db.Forums.Add(new Forum { Title = "Барахолка", Description = "Форум с возможностью купить или продать что-нибудь", Created = new DateTime(2022, 03, 21) });
            db.Forums.Add(new Forum { Title = "GeekNews", Description = "Новости последних событий в мире IT", Created = new DateTime(2020, 10, 15) });
            db.Forums.Add(new Forum { Title = "Movies", Description = "Форум о кинопрьемьерах города", Created = new DateTime(2019, 06, 07) });

            base.Seed(db);
        }
    }
}