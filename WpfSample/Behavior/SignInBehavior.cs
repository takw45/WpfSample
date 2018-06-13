using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace WpfSample
{
  [TypeConstraint(typeof(Button))]
  class SignInBehavior : Behavior<Button>
  {
    protected override void OnAttached()
    {
      base.OnAttached();
      AssociatedObject.Click += OnClicked;
    }

    protected override void OnDetaching()
    {
      AssociatedObject.Click -= OnClicked;
      base.OnDetaching();
    }

    private void OnClicked(object sender, System.Windows.RoutedEventArgs e)
    {
      SignInView view = new SignInView();
      view.ShowDialog();
    }
  }

}
