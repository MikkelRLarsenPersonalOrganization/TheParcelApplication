using ParcelService.Facade.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelService.Facade.Commands
{
    public interface ICreateParcelCommand
    {
        public Task<CreateParcelCommandResponse> Handle(CreateParcelCommandDto command);
    }
}
