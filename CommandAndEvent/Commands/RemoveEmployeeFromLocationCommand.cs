using System;

namespace CommandAndEvent.Commands
{
    public class RemoveEmployeeFromLocationCommand : BaseCommand
    {
        public readonly int EmployeeID;
        public readonly int LocationID;

        public RemoveEmployeeFromLocationCommand(Guid id, int locationID, int employeeID)
        {
            Id = id;
            EmployeeID = employeeID;
            LocationID = locationID;
        }
    }
}
