using LabStore.Domain.Abstracts;
using MediatR;

namespace LabStore.Application.UseCases.Products.GetById
{
    public sealed record GetByIdCommand(Guid id) : IRequest<Result<GetByIdResponse>>;
}
