using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSample
{
  public class SignInViewModel
  {
    public string UserName
    {
      set {
        LogonCommand.UserName = value;
      }
    }

    public string Password
    {
      set {
        LogonCommand.Password = value;
      }
    }

    public LogonCommand LogonCommand
    { get; private set; } = new LogonCommand();

    public SignInViewModel()
    {
      Password = "passwd";
    }
  }
}
