using Microsoft.AspNetCore.SignalR;

namespace CodePulse.API.Models.Domain
{
    public class Category
    {
        public Guid Id {get;set;}
        public required string Name {get;set;}
        public required string UrlHandle {get;set;}
    }
}