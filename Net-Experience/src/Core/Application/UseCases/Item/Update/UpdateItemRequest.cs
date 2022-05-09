using MediatR;
using Net.Experience.Common.Helpers;
using Net.Experience.Domain.Dtos;
using System;

namespace Net.Experience.Application.UseCases.Item.Update
{
    public class UpdateItemRequest : IRequest<Response<UpdateItemResult>>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
