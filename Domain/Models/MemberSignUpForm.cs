using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class MemberSignUpForm
{
    [Required]
    [Display(Name = "First Name", Prompt = "Enter first name")]
    [DataType(DataType.Text)]
    public string FirstName { get; set; } = null!;


    [Required]
    [Display(Name = "Last Name", Prompt = "Enter last name")]
    [DataType(DataType.Text)]
    public string LastName { get; set; } = null!;


    [Required]
    [Display(Name = "Email", Prompt = "Enter email address")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;


    [Display(Name = "Phone", Prompt = "Enter phone number")]
    [DataType(DataType.PhoneNumber)]
    public string? Phone { get; set; }

    [Required]
    [Display(Name = "Password", Prompt = "Enter password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Required]
    [Compare(nameof(Password), ErrorMessage ="Passwords do not match!")]
    [Display(Name = "Confirm Password", Prompt = "Confirm password")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; } = null!;


    [Display(Name = "Terms And Conditions", Prompt ="I accept the terms and conditions.")]
    [Range(typeof(bool), "true", "true", ErrorMessage ="You must accept the terms and conditions to use this site.")]
    public bool TermsAndConditions { get; set; }
}
