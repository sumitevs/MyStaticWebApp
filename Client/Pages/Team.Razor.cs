namespace BlazorApp.Client.Pages
{
    public partial class Team
    {
        IEnumerable<TeamMate> teamMates;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            teamMates = new List<TeamMate>();
        }
    }
}
