using Portfolio.Models;

namespace Portfolio.Services;

public interface IRepository {
    List<Badges> GetBadges();
    List<Project> GetProjects();
    List<Skills> GetSkills();
}

public class Repository:IRepository{
       public List<Project> GetProjects(){
        return new List<Project>() {
            new Project{Title="Budget Manager",Description="With this app you can manage and track your expenses!",Link="https://bryanmonterom.bsite.net/",ImgUrl="/img/budgetmanager.png"},
            new Project{Title="to-do lists",Description="Application to manage and handle tasks to do's by projects",Link="https://bryanmonterom.github.io/todo-list/",ImgUrl="/img/todo.png"},
            new Project{Title="FTD System",Description="Web system for the automation of the Processing Form Interdepartmental (FTI) for a Dominican University",Link="https://github.com/bryanmonterom/FTD",ImgUrl="/img/fti.jpg"},
            new Project{Title="Weather API",Description="A web app that consumes data from the OpenWeather api for a specified location as part of TheOdinProject learning path.",Link="https://bryanmonterom.github.io/weather-api/",ImgUrl="/img/weather.png"},
            new Project{Title="js-library",Description="Project simulating a book watch list as part of TheOdinProject learning path.",Link="https://bryanmonterom.github.io/js-library/",ImgUrl="/img/jslibrary.png"},
            new Project{Title="js-restaurant",Description="A single page application part of the Odin Project Learning Path to practice JS Modules and Webpack.",Link="https://bryanmonterom.github.io/js-restaurant/",ImgUrl="/img/js-restaurant.png"},
            new Project{Title="Tic-tac-toe",Description="An implementation of the famous tic tac toe game with pure CSS, JS and HTML.",Link="https://bryanmonterom.github.io/tic-tac-toe/",ImgUrl="/img/tictactoe.png"},
            new Project{Title="js-calculator",Description="A simple calculator with JS as part of the Odin Project Learning Path",Link="https://bryanmonterom.github.io/js-calculator/",ImgUrl="/img/js-calculator.png"},
            new Project{Title="etch-a-sketch",Description="A etch a sketch game part of the Odin Project Learning Path",Link="https://bryanmonterom.github.io/etch-a-sketch/",ImgUrl="/img/etch.png"},
            new Project{Title="Landing Page",Description="Simple landing page to practice flexbox as part of TheOdinProject learning path",Link="https://bryanmonterom.github.io/landing-page/",ImgUrl="/img/landing.png"},
            new Project{Title="Syshotel",Description="College (2019) project to handle Reservations in a Hotel",Link="https://github.com/bryanmonterom/SysHotel",ImgUrl="/img/syshotel.png"},
        }; 

    }
    public List<Skills> GetSkills() {
        return new List<Skills>
        {
            new Skills{Name="JavaScript" },
            new Skills{Name="CSS" },
            new Skills{Name=".NET Framework" },
            new Skills{Name="C#" },
            new Skills{Name="SQL" },
            new Skills{Name="JQuery" },
            new Skills{Name="Power BI" },
            new Skills{Name="Leadership" },
            new Skills{Name="SCRUM" },
            new Skills{Name="ASP.NET MVC" },
            new Skills{Name="Entity Framework" },
            new Skills{Name="GIT" },
            new Skills{Name="Azure" },
        }.OrderBy(a=>a.Name).ToList(); ;
    }

    public List<Badges> GetBadges() {
        return new List<Badges> {

        new Badges{ Badge="Microsoft Certified: Azure Fundamentals",Img="https://images.credly.com/size/220x220/images/be8fcaeb-c769-4858-b567-ffaaa73ce8cf/image.png",Issuer="Microsoft" },
           new Badges{ Badge="Microsoft Certified: Power Platform Fundamentals",Img="https://images.credly.com/size/220x220/images/2a6251f2-737b-4bf6-9190-d77570cc76fc/CERT-Fundamentals-Power-Platform.png",Issuer="Microsoft" },
           new Badges{ Badge="Microsoft Certified: Power BI Data Analyst Associate",Img="https://images.credly.com/size/220x220/images/619f60f8-4f63-4772-910e-dc31c6f2f7e8/image.png",Issuer="Microsoft" },
           new Badges{ Badge="Scrum Foundation Professional Certificate - SFPC™",Img="https://images.credly.com/size/220x220/images/3be57d7c-55de-4119-9ca9-738e20c0fae0/Scrum-Foundation-Professional-Certificate-SFPC-2021_.png",Issuer="Certiprof" },
           new Badges{ Badge="Remote Worker Professional Certificate - RWPC™",Img="https://images.credly.com/size/220x220/images/f40022a5-10a4-4d3e-af39-074e013144f6/image.png",Issuer="Certiprof" }

        };
    }
}
