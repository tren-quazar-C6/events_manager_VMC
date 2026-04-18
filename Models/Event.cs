using System.ComponentModel.DataAnnotations.Schema;

namespace sporting.Models;

public class Event
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    
    [Column("sport_type")]
    public string? SportType { get; set; }
    
    [Column("start_date")]
    public DateTime? StartDate { get; set; }
    
    [Column("end_date")]
    public DateTime? EndDate { get; set; }
    public string? Venue { get; set; }

    public string? Status { get; set; }
    
    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }
    
}