using Microsoft.AspNetCore.Identity;

namespace Business.Entities;

public class MemberEntity : IdentityUser
{
    [ProtectedPersonalData]
    public string? FirstName { get; set; }


    [ProtectedPersonalData]
    public string? LastName { get; set; }
    
    
    [ProtectedPersonalData]
    public string? JobTitle { get; set; }

    public virtual MemberAddressEntity? Address { get; set; }

}
