using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelService.Facade.DataTransferObjects
{
    public record CreateParcelCommandDto
    {
        public decimal Weight { get; init; }
        public int Priority { get; init; }
        public Destination Destination { get; init; }
        public PersonInfo Sender { get; init; }
        public PersonInfo Reciever { get; init; }

        public CreateParcelCommandDto(decimal weight, int priority, Destination destination, PersonInfo sender, PersonInfo reciever)
        {
            Weight = weight;
            Priority = priority;
            Destination = destination;
            Sender = sender;
            Reciever = reciever;
        }
    }
}
