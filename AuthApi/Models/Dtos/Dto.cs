namespace AuthApi.Models.Dtos
{
    public record CreateUserDto(string Username,string Email, string Password, DateTime BirthDate, string PhoneNumber);
}
