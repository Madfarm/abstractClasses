

namespace Users;

public abstract class User 
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? AccountType { get; set; }
    public int NumOfSearches { get; set; }

    public User(string name)
    {
        this.Id = new Guid();
        this.Name = name;
        this.NumOfSearches = CalculateSearches();
    } 

    public abstract int CalculateSearches();

    public override string ToString()
    {
        return $"Id = {this.Id} \nName = {this.Name} \nAccount Type = {this.AccountType} \nSearches = {this.NumOfSearches} \n";
    } 

}

public class FreeUser : User
{
    public FreeUser(string name) : base(name)
    {
        this.AccountType = "free";
    }
    public override int CalculateSearches()
    {
        return 5;
    }
}