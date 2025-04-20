using LabStore.Domain.Abstracts;
using MediatR;

namespace LabStore.Application.UseCases.Products.Create
{
    public record CreateProductCommand(string Title) : IRequest<Result<CreateProductResponse>>;
}
