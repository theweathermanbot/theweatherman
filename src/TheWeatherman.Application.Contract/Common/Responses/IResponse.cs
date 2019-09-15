using MediatR;
using TheWeatherman.Common.Result;

namespace TheWeatherman.Application.Contract.Common.Responses
{
    public interface IResponse : IRequest<Result>
    {
    }
}