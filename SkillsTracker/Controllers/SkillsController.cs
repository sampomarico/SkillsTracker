using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker
{
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("skills/")]
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Coding skills to learn:</h2>" +
                "<ol>" +
                "<li>JavaScript</li>" +
                "<li>C#</li>" +
                "<li>SQL</li>" +
                "</ol>";
            return Content(html, "text/html");
        }

        [HttpGet]
        [Route("skills/form")]
        public IActionResult SubmitForm()
        {
            string formString = "<form method='post' action='skills/form'>" +
                "<label for='date'>Date:</label><br>" +
                "<input type='date' label id='date' <br><br>" +
                "<label for='javascript'>JavaScript:</label><br>" +
                "<select name='skillLevel'>" +
                "<option value='beginner'>Beginner</option>" +
                "<option value='intermediate'>Intermediate</option>" +
                "<option value='advanced'>Advanced</option>" +
                "</select><br>" +
                "<label for='c#'>C#:</label><br>" +
                "<select name='skillLevel'>" +
                "<option value='beginner'>Beginner</option>" +
                "<option value='intermediate'>Intermediate</option>" +
                "<option value='advanced'>Advanced</option>" +
                "</select><br>" +
                "<label for='sql'>SQL:</label><br>" +
                "<select name='skillLevel'>" +
                "<option value='beginner'>Beginner</option>" +
                "<option value='intermediate'>Intermediate</option>" +
                "<option value='advanced'>Advanced</option>" +
                "</select>" +
                "</form>";
            return Content(formString, "text/html");
        }
    }
}
