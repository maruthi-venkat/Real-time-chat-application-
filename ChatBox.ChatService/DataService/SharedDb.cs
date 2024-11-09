using System.Collections.Concurrent;
using ChatBox.ChatService.Models;

namespace ChatBox.ChatService.DataService;

public class SharedDb
{
    private readonly ConcurrentDictionary<string, UserConnection> _connections = new ();
    
    public ConcurrentDictionary<string, UserConnection> connections => _connections;
}