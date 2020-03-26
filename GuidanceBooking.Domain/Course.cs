using GuidanceBooking.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuidanceBooking.Domain
{
    public class Course: Value<Course>
    {
        public string Title { get; }
        public static Course FromString(string title) => new Course(title);
        private Course(string title)
        {
            if (title.Length < 3)
                throw new ArgumentOutOfRangeException("Title cannot be shorter than 3 characters", nameof(title));
            if (title.Length > 100)
                throw new ArgumentOutOfRangeException("Title cannot be longer than 100 characters", nameof(title));
            Title = title;

        }
    }
}
