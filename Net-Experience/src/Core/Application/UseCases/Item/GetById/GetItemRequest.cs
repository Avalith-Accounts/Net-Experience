using MediatR;
using Net.Experience.Common.Helpers;
using System;

namespace Net.Experience.Application.UseCases.Item.GetById
{
    public class GetItemRequest : IRequest<Response<GetItemResult>>
    {
        public Guid Id { get; set; }

        public GetItemRequest(Guid itemId) 
        {
            Id = itemId;
        }
    }
}
