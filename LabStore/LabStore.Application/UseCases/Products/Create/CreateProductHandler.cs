using LabStore.Domain.Abstracts;
using LabStore.Domain.Entities;
using LabStore.Domain.Repositories;
using MediatR;

namespace LabStore.Application.UseCases.Products.Create
{
    public class CreateProductHandler(IProductRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand, Result<CreateProductResponse>>
    {
        public async Task<Result<CreateProductResponse>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
            };

            await repository.Create(product, cancellationToken);
            
            await unitOfWork.CommitAsync();

            return Result.Success(new CreateProductResponse("Produto criado com sucesso"));
        }
    }
}
