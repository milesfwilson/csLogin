using System.Collections.Generic;
using csLogin.Models;
using csLogin.Controllers;

namespace csLogin.Services
{
  class UserService
  {
    public List<User> users { get; set; } = new List<User>();
    User miles = new User("Miles", "password");
    User mae = new User("Mae", "password");

    public UserService()
    {

      users.Add(miles);
      users.Add(mae);
    }
  }
}