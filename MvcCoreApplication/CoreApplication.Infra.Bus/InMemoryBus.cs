using CoreApplication.Domain.Core.Bus;
using CoreApplication.Domain.Core.Commands;
using MediatR;
using System;
using System.ComponentModel.Design;
using System.Threading.Tasks;

namespace CoreApplication.Infra.Bus
{
    public class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

       public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}
