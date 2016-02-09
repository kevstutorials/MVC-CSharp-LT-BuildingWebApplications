# Building Web Applications using ASP.NET MVC CSharp
## Project: ListPlus
MVC C# Tutorial.  ListPlus is a list management system

### Exercise 2.1 - Creating the Case Study
Create a model called <a href="https://github.com/kevstutorials/MVC-CSharp-LT-BuildingWebApplications/blob/2.1-CreatingCaseStudyProject/ListPlus/ListPlus.Web/Models/ListingModel.cs">ListingModel</a>

```C# 
/*
    Models/ListingModel.cs
    Model for List Items
*/
public class ListingModel
{
    public int Id {get; set;}
    public string Title {get; set;} 
}
```

Hardcode example items in the ActionResult List View in the controller <a href="https://github.com/kevstutorials/MVC-CSharp-LT-BuildingWebApplications/blob/2.1-CreatingCaseStudyProject/ListPlus/ListPlus.Web/Controllers/ListingController.cs">ListingController</a>

```C# 
/*
    Controllers/ListingController.cs
    Controller for List Items
*/
// Action Result for List View
public ActionResult List()
{
    var list = new List<ListingModel>
    {
        new ListingModel {Id = 1, Title = "Food"},
        new ListingModel {Id = 2, Title = "Hardware"},
        new ListingModel {Id = 3, Title = "Vacation"}
    };
    
    return View(list);
}
```

Loop through all items titles in the view <a href="https://github.com/kevstutorials/MVC-CSharp-LT-BuildingWebApplications/blob/2.1-CreatingCaseStudyProject/ListPlus/ListPlus.Web/Views/Listing/List.cshtml">Listing/List.cshtml</a>

```C#
/* 
    Views/Listing/List.cshtml
    View lists item titles
*/
<div>
  List
  <ul>
      @foreach (var item in Model)
      {
          <li>@item.Title</li>
      }
  </ul>
</div>
```

