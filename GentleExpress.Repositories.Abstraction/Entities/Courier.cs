namespace GentleExpress.Repositories.Abstraction.Entities;

public class Courier
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;
}
