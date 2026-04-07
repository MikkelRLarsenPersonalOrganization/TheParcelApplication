using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelService.Api.DataTransferObjects
{
    public record CreateParcelRequest
    {
        public decimal Weight { get; init; }
        public int Priority { get; init; }
        public Destination Destination { get; init; }
        public PersonInfo Sender { get; init; }
        public PersonInfo Reciever { get; init; }

        public CreateParcelRequest(decimal weight, int priority, Destination destination, PersonInfo sender, PersonInfo reciever)
        {
            Weight = weight;
            Priority = priority;
            Destination = destination;
            Sender = sender;
            Reciever = reciever;
        }

        public Facade.DataTransferObjects.CreateParcelCommandDto Map()
        {
            return new Facade.DataTransferObjects.CreateParcelCommandDto(
                weight: this.Weight,
                priority: this.Priority,
                destination: this.Destination.Map(),
                sender: this.Sender.Map(),
                reciever: this.Reciever.Map());
        }

    }    
}
