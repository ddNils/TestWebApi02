using System;

namespace TestWebApi02.DataContracts
{
    public interface IBlogpost
    {
        string Body { get; set; }
        DateTime CreatedDate { get; set; }
        int Id { get; set; }
        DateTime LastEditDate { get; set; }
        string Title { get; set; }
    }
}