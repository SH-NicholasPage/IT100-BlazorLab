/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
*/

using BlazorLab.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorLab.Pages
{
    public partial class Index : ComponentBase
    {
        public List<Movie> Movies = Program.GenerateMovies();
        
        //Treat this method as if it were your Main() method.
        protected override void OnInitialized()
        {
            
        }
    }
}
