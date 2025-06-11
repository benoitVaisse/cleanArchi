namespace HotelManagement.Application.Authentication;

public interface IAuthService
{
    Task<AuthenticationResponseDto> Authenticate(AuthenticationDto authenticationDto);
}
