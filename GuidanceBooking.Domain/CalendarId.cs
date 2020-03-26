using GuidanceBooking.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GuidanceBooking.Domain
{
    public class CalendarId : Value<CalendarId>
    {
        public Guid Value { get; }
        public CalendarId(Guid value) => Value = value;
    }
}
