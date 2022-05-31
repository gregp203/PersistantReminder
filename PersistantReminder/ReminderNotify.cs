using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Windows.Forms;

namespace PersistantReminder
{
    class ReminderNotify
    {
        public   ReminderNotify ()
        {
            var outlook = new Outlook.Application();
            outlook.Reminder += OnOutlookReminder;            
            
        }

        void OnOutlookReminder(object item)
        {
            new Thread(() => new Form2().ShowDialog()).Start();
            /*String reminderMsg;
            if (item is Outlook.MailItem){
                Outlook.MailItem reminderMail;
                reminderMail = (Outlook.MailItem)item;
                reminderMsg = String.Format(
                    "subject: {0}\nReminder time: {1:t}", reminderMail.Subject,
                    reminderMail.ReminderTime);
            }
            else if (item is Outlook.AppointmentItem){
                Outlook.AppointmentItem reminderAppt;
                reminderAppt = (Outlook.AppointmentItem)item;
                reminderMsg = String.Format(
                "Appointment subject: {0}\nLocation: {1}\nReminder time: {2:t}",
                reminderAppt.Subject, reminderAppt.Location, reminderAppt.Start);
            }
            else if (item is Outlook.TaskItem){
                Outlook.TaskItem reminderTask;
                reminderTask = (Outlook.TaskItem)item;
                reminderMsg = String.Format(
                    "subject: {0}\nReminder time: {1:t}", reminderTask.Subject,
                    reminderTask.ReminderTime);
            }
            else{
                // Unsupported item
                return;
            }*/
        }
    }
}
