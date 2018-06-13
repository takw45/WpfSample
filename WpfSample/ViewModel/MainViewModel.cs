using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfSample
{
  public class MainViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }

    public bool IsAvailableLogon
    {
      get { return MyApp.CurrentUser == null; }
    }

    private string _topic;

    public string Topic
    {
      get { return _topic; }
      private set {
        _topic = value;
        NotifyPropertyChanged();
      }
    }

    public MainViewModel()
    {
      Topic = "サインインしてください";
      MyApp.ChangeCurrentUser += OnChangedCurrentUser;
    }

    private void OnChangedCurrentUser()
    {
      Topic = "Hello, " + MyApp.CurrentUser.Name + "!!"; 
    }
  }
}
