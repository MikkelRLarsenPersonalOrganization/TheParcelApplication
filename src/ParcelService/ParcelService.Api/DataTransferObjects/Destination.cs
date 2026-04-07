using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelService.Api.DataTransferObjects
{
    public record Destination
    {
        public string Region { get; init; }
        public string Terminal { get; init; }

        public Destination(string region, string termnial)
        {
            Region = region;
            Terminal = termnial;
        }

        public Facade.DataTransferObjects.Destination Map()
        {
            return new Facade.DataTransferObjects.Destination(
                Region: this.Region,
                Terminal: this.Terminal);
        }
    }   
}
