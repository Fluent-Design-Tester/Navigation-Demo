using HelloWorld.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class Reminder
    {
        public int ID { get; set; }

        public String Name { get; set; }

        public String Time { get; set; }

        public bool IsActive { get; set; }
    }

    public class Sample
    {
        public static List<Reminder> GetRemindersSample()
        {
            // Testing database connection
            DatabaseConnection db = new DatabaseConnection();

            var reminders = new List<Reminder>();

            reminders.Add(new Reminder { ID = 1, Name = "Reminder 1", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 2, Name = "Reminder 2", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 3, Name = "Reminder 3", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });
            reminders.Add(new Reminder { ID = 4, Name = "Reminder 4", Time = "11:51", IsActive = true });

            return reminders;
        }
    }
}
