using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Client.Pages
{
    [Table("TeamMates")]
    public partial class TeamMate
    {
        public string Name { get; set; }
    }
}