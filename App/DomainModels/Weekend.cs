namespace TresDias.DomainModels;

public class Weekend
{
    public required int Edition  { get; set; }
    public required IList<TeamMember>  TeamMembers { get; set; } = new List<TeamMember>();
}