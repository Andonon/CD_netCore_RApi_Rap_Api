using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace MusicApi.Controllers {

    
    public class ArtistController : Controller {

        private List<Artist> allArtists;

        public ArtistController() 
        {
            allArtists = JsonToFile<Artist>.ReadJson();
        }

        [HttpGet]
            [Route("artists")]
            public JsonResult Artist()
            {
                
                return Json(allArtists);
            }

        [HttpGet]
            [Route("artist/{Name}")]
            public IActionResult GetArtistName(string Name)
            {
                var foundArtist = from artist in allArtists
                                    where artist.ArtistName == Name
                                    select new { artist };
                return Json(foundArtist);
            }

        [HttpGet]
            [Route("artists/name/{Name}")]
            public IActionResult GetArtistsByName(string Name)
            {
                var foundArtists = from artists in allArtists where artists.ArtistName.Contains(Name) select artists;
                return Json(foundArtists);                 
            }

        [HttpGet]
            [Route("artists/realname/{Name}")]
            public IActionResult GetArtistsByRealName(string Name)
            {
                var foundArtists = from artists in allArtists where artists.RealName.Contains(Name) select artists;
                return Json(foundArtists);                 
            }

        [HttpGet]
            [Route("artists/hometown/{town}")]
            public IActionResult GetArtistsByHomeTown(string town)
            {
                var foundArtists = from artists in allArtists where artists.Hometown.Contains(town) select artists;
                return Json(foundArtists);                 
            }

        [HttpGet]
            [Route("artists/groupid/{id}")]
            public IActionResult GetArtistsByGroupId(string id)
            {
                var foundArtists = from artists in allArtists where artists.GroupId.ToString() == id select artists;
                return Json(foundArtists);                 
            }

        //This method is shown to the user navigating to the default API domain name
        //It just display some basic information on how this API functions
        [Route("")]
        [HttpGet]
        public string Index() {
            //String describing the API functionality
            string instructions = "Welcome to the Music API~~\n========================\n";
            instructions += "    Use the route /artists/ to get artist info.\n";
            instructions += "    End-points:\n";
            instructions += "       *Name/{string}\n";
            instructions += "       *RealName/{string}\n";
            instructions += "       *Hometown/{string}\n";
            instructions += "       *GroupId/{int}\n\n";
            instructions += "    Use the route /groups/ to get group info.\n";
            instructions += "    End-points:\n";
            instructions += "       *Name/{string}\n";
            instructions += "       *GroupId/{int}\n";
            instructions += "       *ListArtists=?(true/false)\n";
            return instructions;
        }

        
    }
}