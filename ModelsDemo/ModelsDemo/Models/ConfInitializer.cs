using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace ModelsDemo.Models
{
    public class ConfInitializer :DropCreateDatabaseAlways<ConfContext>
    {
        public override void InitializeDatabase(ConfContext context)
        {
            context.Sessions.Add(
               new Session()
               {
                   SessionID=1,
                   Title = "Session 1",
                   Description="Dummy Description",
                   Speaker= new Speaker()
                    {   SpeakerID=1,
                      EmailAddress="usman@live.com",
                      SpeakerName="Usman"
                      
                    }
            
               });

            context.SaveChanges();
        }
    }
}