using Portfolio.Models;

namespace Portfolio.Services;

public interface IRepository {
    List<Project> GetProjects();
    }

public class Repository:IRepository{
       public List<Project> GetProjects(){
        return new List<Project>() {
            new Project{Title="to-do lists",Description="Application to manage and handle tasks to do's by projects",Link="https://bryanmonterom.github.io/todo-list/",ImgUrl="/img/todo.png"},
            new Project{Title="FTD System",Description="Web system for the automation of the Processing Form Interdepartmental (FTI) for a Dominican University",Link="https://github.com/bryanmonterom/FTD",ImgUrl="/img/fti.jpg"},
            new Project{Title="Weather API",Description="A web app that consumes data from the OpenWeather api for a specified location as part of TheOdinProject learning path.",Link="https://bryanmonterom.github.io/weather-api/",ImgUrl="/img/weather.png"},
            new Project{Title="js-library",Description="Project simulating a book watch list as part of TheOdinProject learning path.",Link="https://bryanmonterom.github.io/js-library/",ImgUrl="/img/jslibrary.png"},
        };
    }
}
