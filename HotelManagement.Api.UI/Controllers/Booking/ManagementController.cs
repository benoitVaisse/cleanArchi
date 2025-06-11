using Microsoft.AspNetCore.Authorization;

namespace HotelManagement.Api.UI.Controllers.Booking;

[Authorize(Roles = "Receptionist")]
public class ManagementController : HotelManagementControllerBase
{
}
