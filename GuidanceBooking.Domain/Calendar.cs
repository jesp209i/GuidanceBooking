using System;

namespace GuidanceBooking.Domain
{
    public class Calendar
    {
        public CalendarId Id { get; }
        public Calendar(CalendarId id, UserId ownerId)
        {
            Id = id;
            _ownerId = ownerId;
        }

        public void SetCounseTitle(string title) => _courseTitle = title;
        public void UpdateDescription(string newDescription) => _description = newDescription;
        private UserId _ownerId;
        private string _courseTitle;
        private string _description;
    }
}
