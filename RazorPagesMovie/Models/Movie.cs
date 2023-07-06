using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;

public class Movie
{
    public int Id { get; set; } // The ID field is required by the database for the primary key. The ID field is hidden from the user interface by omitting the ScaffoldColumnAttribute attribute.
    public string? Title { get; set; } // The Title property is a string because the movie title is a string. The question mark after the type name indicates that the property is nullable.
    [DataType(DataType.Date)] // The DataType attribute specifies the type of the data (Date). With this attribute: user isn't required to enter time information in the date field. Only the date is displayed, not time information.
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; } 
    public decimal Price { get; set; } 
}