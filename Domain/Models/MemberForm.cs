﻿namespace Domain.Models;

public class MemberForm
{
    public string? Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? JobTitle { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }

    public MemberAddressForm? Address { get; set; } = new();

}
