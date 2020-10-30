using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace SkillsTracker
{
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("/skills")]
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

        [HttpGet("skills/form")]
        public IActionResult RenderForm()
        {
                string formString = "<form method='post' action='/skills/form/submitted'>" +
                    "<label for='date'>Date:</label><br>" +
                    "<input type= 'date' name= 'date' <br><br>" +
                    "<label for='javascript'>JavaScript:</label><br>" +
                    "<select name= 'jsSkill'>" +
                        "<option value= 'beginner' >Beginner</option>" +
                        "<option value= 'intermediate' >Intermediate</option>" +
                        "<option value= 'advanced' >Advanced</option>" +
                    "</select><br>" +
                    "<label for='c#'>C#:</label><br>" +
                    "<select name='cSkill'>" +
                        "<option value= 'beginner' >Beginner</option>" +
                        "<option value= 'intermediate' >Intermediate</option>" +
                        "<option value= 'advanced' >Advanced</option>" +
                    "</select><br>" +
                    "<label for='sql'>SQL:</label><br>" +
                    "<select name='sqlSkill'>" +
                        "<option value='beginner'>Beginner</option>" +
                        "<option value='intermediate'>Intermediate</option>" +
                        "<option value='advanced'>Advanced</option>" +
                    "</select>" +
                    "<input type='submit' value='Submit'/>" +
                    "</form>";
                return Content(formString, "text/html");
        }

        [HttpPost("/skills/form/submitted")]
        public IActionResult SubmitForm(string date, string jsSkill, string cSkill, string sqlSkill)
        {

            string values = "<h1>" + date + "</h1>" +
                "<table style= 'border: 1px solid black'>" +
                "<tr style= 'border: 1px solid black'>" +
                    "<th style= 'border: 1px solid black'>JavaScript</th>" +
                    "<th style= 'border: 1px solid black'>C#</th>" +
                    "<th style= 'border: 1px solid black'>SQL</th>" +
                "</tr>" +
                "<tr>" +
                    "<td style= 'border: 1px solid black'>" + jsSkill + "</td>" +
                    "<td style= 'border: 1px solid black'>" + cSkill + "</td>" +
                    "<td style= 'border: 1px solid black'>" + sqlSkill + "</td>" +
                "</tr>" +
                "</table>";

            return Content(values, "text/html");
        }
    }
}
