using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSample
{
  public class User
  {
    private string _name     = string.Empty;
    private string _password = string.Empty;

    public string Name
    {
      get { return _name; }
    }

    private User()
    {
    }

    public bool Authenticate(string password)
    {
      return string.Equals(_password, password);
    }

    static public User QueryBy(string userName)
    {
      User user = null;

      // 実際にはDBからデータを取得してインスタンスを生成することを想定
      if (userName.Equals("takashi"))
      {
        user = new User();
        user._name = "takashi";
        user._password = "passwd";
      }
      return user;
    }
  }
}
