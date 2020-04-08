namespace WebApplicationLibrary.Models
{
    public interface IAuthenticatedUser
    {
        string Access_Token { get; set; }
        string UserName { get; set; }
    }
}