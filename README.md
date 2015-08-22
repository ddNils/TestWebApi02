# TestWebApi02
Web Application Project (WebApi), which separates Identity and other entities in special Sub-projects for separation of concerns and testability

TestWebApi02.Entities
should hold the Entities for Entity Framework code first
(I did choose Blogposts cause everyone can visualise that)

TestWebApi02.DataContracts
should hold Interfaces for the Entities - this is often called contract i think

TestWebApi02.Repos
This holds repositories - i am not sure, if UserManager should reside here too... but i want to get rid of entity framework inside of TestWebApi02.WebApi

TestWebApi02.WebApi
should only hold WebApi and get repositories through dependency injection with Unity


THIS SOLUTION IS STILL IN THE MAKING, I AM TRYING THINGS OUT HERE
