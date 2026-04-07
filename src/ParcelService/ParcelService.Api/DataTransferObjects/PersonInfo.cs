using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelService.Api.DataTransferObjects
{
    public record PersonInfo
    {
        public string Name { get; init; }
        public Address Address { get; init; }

        public PersonInfo(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public ParcelService.Facade.DataTransferObjects.PersonInfo Map()
        {
            return new Facade.DataTransferObjects.PersonInfo(
                Name: this.Name,
                Address: this.Address.Map());
        }
    }    
}
