﻿using System;

namespace CommandAndEvent.Events
{
    public class LocationCreatedEvent : BaseEvent
    {
        public readonly int LocationID;
        public readonly string StreetAddress;
        public readonly string City;
        public readonly string State;
        public readonly string PostalCode;

        public LocationCreatedEvent(Guid id, int locationID, string streetAddress, string city, string state, string postalCode)
        {
            Id = id;
            LocationID = locationID;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            PostalCode = postalCode;
        }
    }
}
