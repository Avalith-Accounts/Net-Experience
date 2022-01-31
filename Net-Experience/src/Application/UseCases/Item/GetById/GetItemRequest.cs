using MediatR;
using System;

namespace Net.Experience.Application.UseCases.Item.GetById
{
    public class GetItemRequest : IRequest<GetItemResult>
    {
        public Guid Id { get; set; }

        public GetItemRequest(Guid itemId) 
        {
            Id = itemId;
        }
    }
}
