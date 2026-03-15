namespace TresDias.DomainModels;

public class TeamMember
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public int? YearJoined { get; set; }
    
    public ICollection<Speech>  HistoricSpeeches { get; set; } = new List<Speech>();
    public ICollection<Role>  HistoricRoles { get; set; }  = new List<Role>();
}