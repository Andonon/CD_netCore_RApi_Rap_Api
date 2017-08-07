using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace MusicApi.Controllers {
    public class GroupController : Controller {
        List<Group> allGroups {get; set;}
        public GroupController() {
            allGroups = JsonToFile<Group>.ReadJson();
        }

        [HttpGet]
            [Route("groups")]
            public JsonResult GetAllGroups()
            {   
                return Json(allGroups);
            }

        [HttpGet]
            [Route("groups/name/{name}")]
            public IActionResult GetGroupsByName(string Name)
            {   
                var foundGroup = from groups in allGroups where groups.GroupName.Contains(Name) select groups;
                return Json(foundGroup);
            }

        [HttpGet]
            [Route("groups/id/{id}")]
            public IActionResult GetGroupsByID(string id)
            {   
                var foundGroup = from groups in allGroups where groups.Id.ToString() == id select groups;
                return Json(foundGroup);
            }

    }
}