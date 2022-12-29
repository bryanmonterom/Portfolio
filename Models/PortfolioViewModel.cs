namespace Portfolio.Models
{
    public class PortfolioViewModel
    {
      public IEnumerable<Project> Projects { get; set; }
      public IEnumerable<Skills> Skills { get; set; }
      public IEnumerable<Badges> Badges { get; set; }


    }
}