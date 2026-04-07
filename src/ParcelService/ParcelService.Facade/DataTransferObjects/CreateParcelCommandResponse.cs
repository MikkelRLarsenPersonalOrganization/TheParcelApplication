using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelService.Facade.DataTransferObjects
{
    public record CreateParcelCommandResponse(
        Guid TrackingNumber
    );
}
