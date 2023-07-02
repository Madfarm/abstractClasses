

namespace Users;

public class User 
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? AccountType { get; set; }
    public int NumOfSearches { get; set; }

    public User(string name, string acctype)
    {
        this.Id = new Guid();
        this.Name = name;
        this.AccountType = acctype;
        this.NumOfSearches = CalculateSearches();
    } 

    public int CalculateSearches()
    {
        return 30;
    } 

}