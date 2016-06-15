using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1.Controls
{
    class CustomComboBox : ComboBox
    {
    //    public CustomComboBox() : base()
    //    {
    //    }

    //    public ICommand Command
    //    {
    //        get { return (ICommand)GetValue(CommandProperty); }
    //        set { SetValue(CommandProperty, value); }
    //    }

    //    public static readonly DependencyProperty CommandProperty =
    //        DependencyProperty.Register("Command", typeof(ICommand), typeof(CustomComboBox), new PropertyMetadata(null));

    //    public object CommandParameter
    //    {
    //        get { return (object)GetValue(CommandParameterProperty); }
    //        set { SetValue(CommandParameterProperty, value); }
    //    }
    //    // Using a DependencyProperty as the backing store for CommandParameter.  This enables animation, styling, binding, etc...
    //    public static readonly DependencyProperty CommandParameterProperty =
    //        DependencyProperty.Register("CommandParameter", typeof(object), typeof(CustomComboBox), new PropertyMetadata(null));

    //    public IInputElement CommandTarget
    //    {
    //        get { return (IInputElement)GetValue(CommandTargetProperty); }
    //        set { SetValue(CommandTargetProperty, value); }
    //    }

    //    public static readonly DependencyProperty CommandTargetProperty =
    //DependencyProperty.Register("CommandTarget", typeof(IInputElement), typeof(CustomComboBox), new PropertyMetadata(null));


    //    protected override void OnDropDownClosed(object e)
    //    {
    //        base.OnDropDownClosed(e);

    //        var command = Command;
    //        var parameter = CommandParameter;
    //        var target = CommandTarget;

    //        if (command != null && command.CanExecute(parameter, target))
    //        {
    //            command.Execute(parameter, target);
    //        }
    //        else if (command != null && command.CanExecute(parameter))
    //        {
    //            command.Execute(parameter);
    //        }


    //        //var routedCmd = command as ICommand;
    //        //if (routedCmd != null && routedCmd.CanExecute(parameter, target))
    //        //{
    //        //    routedCmd.Execute(parameter, target);
    //        //}
    //        //else if (command != null && command.CanExecute(parameter))
    //        //{
    //        //    command.Execute(parameter);
    //        //}
    //    }
    }
}
