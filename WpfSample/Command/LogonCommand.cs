using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfSample
{
  public class LogonCommand : ICommand
  {
    private string _userName;
    private string _password;

    public event EventHandler CanExecuteChanged;
 
    public string UserName
    {
      set
      {
        _userName = value;
        CanExecuteChanged?.Invoke(this, new EventArgs());
      }
    }
    
    public string Password
    {
      set
      {
        _password = value;
        CanExecuteChanged?.Invoke(this, new EventArgs());
      }
    }

    public bool CanExecute(object parameter)
    {
      return !string.IsNullOrEmpty(_userName) && !string.IsNullOrEmpty(_password);
    }

    public void Execute(object obj)
    {
      MyApp.Logon(_userName, _password);
    }
  }
}
