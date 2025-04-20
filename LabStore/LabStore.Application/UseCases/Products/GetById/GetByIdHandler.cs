using LabStore.Domain.Abstracts;
using LabStore.Domain.Repositories;
using LabStore.Domain.Specifications.Products;
using MediatR;

namespace LabStore.Application.UseCases.Products.GetById
{
    public sealed class GetByIdHandler(IProductRepository repository)
    : IRequestHandler<GetByIdCommand, Result<GetByIdResponse>>
    {
        public async Task<Result<GetByIdResponse>> Handle(GetByIdCommand request, CancellationToken cancellationToken)
        {
            var spec = new GetProductByIdSpecification(request.id);
            var product = await repository.GetByIdAsync(spec, cancellationToken);

            if(product is null)
            {
                return Result.Failure<GetByIdResponse>(new Error("404", "Product not found"));
            } else
            {
                return Result.Success<GetByIdResponse>(new GetByIdResponse(product.Id, product.Title));
            }
        }
    }
}
