using ParcelService.Domain.Entities;
using Shared.ResultPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelService.UseCase.InfrastructureInterfaces.Ports
{
    public interface INewParcelPublisher
    {
        public Task<Result> PublishNewParcelEvent(Parcel parcel);
    }
}
