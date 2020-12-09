using System;
using System.Collections.Generic;
using csLogin.Models;
using csLogin.Services;
namespace csLogin.Controllers
{
  class UserController
  {

    public UserController()
    {
      Run();
    }
    public UserService _service { get; set; } = new UserService();


    private bool _running { get; set; }
    public void Run()
    {
      _running = true;
      while (_running)
      {
        GetUserInput();

      }
    }
    private void GetUserInput()
    {
      System.Console.WriteLine("Enter your name: ");
      string userName = Console.ReadLine();
      Console.Clear();
      System.Console.WriteLine("Enter your password: ");
      string userPassword = Console.ReadLine();
      Console.Clear();
      if (userName == "q" || userPassword == "q")
      {
        _running = false;
      }
      _service.users.ForEach(user =>
      {
        if ((user.Name == userName) && (user.Password == userPassword))
        {
          Console.Clear();
          System.Console.WriteLine("Authenticated");
          _running = false;
        }
      });
    }
  }
}