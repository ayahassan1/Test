using System;
using Microsoft.AspNetCore.Mvc;
using MongoExample.Services;
using MongoExample.Models;

namespace MongoExample.Controllers; 

[Controller]
[Route("api/[controller]")]
public class PlaylistController: Controller {
    
    private readonly MongoDBService _mongoDBService;

    public PlaylistController(MongoDBService mongoDBService) {
        _mongoDBService = mongoDBService;
    }

    [HttpGet]
    public async Task<List<Playlist>> Get() {}

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Person P) {}

    [HttpPut("{id}")]
    public async Task<IActionResult> AddToPerson(string id, [FromBody] string PersonId) {}

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id) {}

    public async Task CreateAsync(Person P) {
    await person_collection.InsertOneAsync(playlist);
    return;
}
[HttpPost]
public async Task<IActionResult> Post([FromBody] person p) {
    await _mongoDBService.CreateAsync(p);
    return CreatedAtAction(nameof(Get), new { id = p.Id }, p);
}
public async Task<List<p>> GetAsync() {
    return await _playlistCollection.Find(new BsonDocument()).ToListAsync();
}
[HttpGet]
public async Task<List<p>> Get() {
    return await _mongoDBService.GetAsync();
}
public async Task AddTopersonAsync(string id, string personId) {
    FilterDefinition<Playlist> filter = Builders<person>.Filter.Eq("Id", id);
    UpdateDefinition<Playlist> update = Builders<person>.Update.AddToSet<string>("movieIds", movieId);
    await _playlistCollection.UpdateOneAsync(filter, update);
    return;
}
[HttpPut("{id}")]
public async Task<IActionResult> AddToperson_list(string id, [FromBody] string personID) {
    await _mongoDBService.AddTopersonAsync(id, personID);
    return NoContent();
}
}