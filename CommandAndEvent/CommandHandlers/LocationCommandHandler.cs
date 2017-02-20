using System;
using CommandAndEvent.AggregateRootObjects;
using CommandAndEvent.Commands;
using CQRSlite.Commands;
using CQRSlite.Domain;

namespace CommandAndEvent.CommandHandlers
{
    public class LocationCommandHandler : ICommandHandler<CreateLocationCommand>,
                                          ICommandHandler<AssignEmployeeToLocationCommand>,
                                          ICommandHandler<RemoveEmployeeFromLocationCommand>
    {
        private readonly ISession _session;

        public LocationCommandHandler(ISession session)
        {
            _session = session;
        }

        public void Handle(RemoveEmployeeFromLocationCommand command)
        {
            Location location = _session.Get<Location>(command.Id);
            location.RemoveEmployee(command.EmployeeID);
            _session.Commit();
        }

        public void Handle(AssignEmployeeToLocationCommand command)
        {
            Location location = _session.Get<Location>(command.Id);
            location.AddEmployee(command.EmployeeID);
            _session.Commit();
        }

        public void Handle(CreateLocationCommand command)
        {
            var location = new Location(command.Id, command.LocationID, command.StreetAddress, command.City, command.State, command.PostalCode);
            _session.Add(location);
            _session.Commit();
        }
    }
}
