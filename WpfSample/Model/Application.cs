using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSample
{
  public delegate void ChangedCurrentUserEventHandler();

  public class MyApp
  {
    private static User _currentUser = null;
    private static event ChangedCurrentUserEventHandler _changedCurrentUserEvent;

    public static User CurrentUser
    {
      get { return _currentUser;  }
    }

    public static event ChangedCurrentUserEventHandler ChangeCurrentUser
    {
      add { _changedCurrentUserEvent += value; }
      remove { _changedCurrentUserEvent -= value; }
    }

    public static bool Logon(string userName, string password)
    {
      User user = User.QueryBy(userName);
      
      if(user == null)
      {
        return false;
      }  

      if(!user.Authenticate(password))
      {
        return false;
      }

      _currentUser = user;
      _changedCurrentUserEvent();

      return true;
    }
  } 
}
