using Api.Controllers;
using ParcelService.Api.DataTransferObjects;
using ParcelService.Facade.Commands;

namespace ParcelService.Api.Controllers
{
    public class ParcelControllerImplementation : IParcelController
    {
        private readonly ICreateParcelCommand _createParcelCommand;

        public ParcelControllerImplementation(ICreateParcelCommand createParcelCommand)
        {
            _createParcelCommand = createParcelCommand;
        }

        public async Task<CreateParcelResponse> CreateParcelAsync(CreateParcelRequest body)
        {
            var response = await _createParcelCommand.Handle(body.Map());

            return CreateParcelResponse.MapResponse(response);
        }
    }
}
