using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResetable
  {
    private string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }
    public void Display(){
      Console.WriteLine("Password");
      if(Hidden == false){
      Console.WriteLine($"{Password}");
      }
      else if (Hidden == true){
        Console.WriteLine($"********");
      }

    }
    public void Reset(){
      Password = "";
      Hidden = false;
    }
  }
}
