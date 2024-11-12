using MediatR;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Application.Abstracts;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}