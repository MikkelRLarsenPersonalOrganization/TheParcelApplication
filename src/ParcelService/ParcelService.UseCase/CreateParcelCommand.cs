using ParcelService.Facade.Commands;
using ParcelService.Facade.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelService.UseCase
{
    public class CreateParcelCommand : ICreateParcelCommand
    {
        public CreateParcelCommandResponse Handle(CreateParcelCommandDto command)
        {
            throw new NotImplementedException();
        }
    }
}
