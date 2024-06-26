using Microsoft.AspNetCore.SignalR;

namespace CodePulse.API.Models.Domain
{
    public class BlogPost
    {
        public Guid Id {get;set;}
        public required string Title {get;set;}
        public required string ShortDescription {get;set;}
        public required string Content {get;set;}
        public required string FeaturedImageUrl {get;set;}
        public required string UrlHandle {get;set;}
        public required DateTime PublishedDate {get;set;}

        public required string Author {get;set;}

        public required bool IsVisible {get;set;}

    }
}