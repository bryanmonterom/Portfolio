namespace Portfolio.Models
{
    public class PortfolioViewModel
    {
      public IEnumerable<Project> Projects { get; set; }
      public IEnumerable<Skills> BackendSkills { get; set; }
      public IEnumerable<Skills> FrontEndSkills { get; set; }
    }
}