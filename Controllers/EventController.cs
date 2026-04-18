using Microsoft.AspNetCore.Mvc;
using sporting.Data;
using sporting.Models;

namespace sporting.Controllers;

public class EventController : Controller
{
    private readonly MySqlDbContext _context;

    public EventController(MySqlDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var events = _context.events.ToList();// Select * from users
        return View(events);
    }

    [HttpPost]
    public IActionResult Create(Event MyEvent)
    {
        _context.Add(MyEvent);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Show(int id)
    {
        var MyEvent = _context.events.Find(id);
        return View(MyEvent);
    }

    public IActionResult Edit(int id)
    {
        var MyEvent = _context.events.Find(id);
        return View(MyEvent);
    }
    [HttpPost]
    public IActionResult Update(Event MyEvent)
    {
        var eventDb = _context.events.Find(MyEvent.Id);
        eventDb.Name = MyEvent.Name;
        eventDb.Description = MyEvent.Description;
        eventDb.SportType = MyEvent.SportType;
        eventDb.StartDate = MyEvent.StartDate;
        eventDb.Venue = MyEvent.Venue;
        _context.SaveChanges();
        
        return RedirectToAction("Index");

    }
    [HttpPost]
    public IActionResult Destroy(int id)
    {
        var MyEvent = _context.events.Find(id);
        _context.Remove(MyEvent);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    
    public IActionResult Gallery()
    {
        var events = _context.events.ToList();
        return View(events);
    }
}