using ParcelService.Domain.Entities;
using ParcelService.UseCase.InfrastructureInterfaces.Ports;
using Shared.ResultPattern;
using System;
using System.Collections.Generic;
using System.Text;
using Dapr.Client;
using ParcelService.Infrastructure.InfrastructureErrors;

namespace ParcelService.Infrastructure.Messages
{
    public class DaprPubSub : INewParcelPublisher
    {
        private readonly DaprClient _daprClient;
        private const string _pubSubName = "daprpubsub";
        private const string _topic = "new-parcel";

        public DaprPubSub(DaprClient daprClient)
        {
            _daprClient = daprClient;
        }

        public async Task<Result> PublishNewParcelEvent(Parcel parcel)
        {
            try
            {
                await _daprClient.PublishEventAsync(_pubSubName, _topic, parcel);
                return Result.Success();
            }
            catch (Exception)
            {
                return MessageError.MessagePublishError(parcel);
            }
        }
    }
}
