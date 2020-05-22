using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HotelBilling.Controls
{
    class AroImage : Image
    {
        public static BindableProperty CommandProperty =
            BindableProperty.Create("Command", typeof(Command), typeof(AroImage));

        public static BindableProperty CommandParameterProperty =
            BindableProperty.Create("CommandParameter", typeof(object), typeof(AroImage));

        public Command Command
        {
            get { return (Command)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public AroImage()
        {
            GestureRecognizers.Add(new TapGestureRecognizer() { Command = new Command(BindedCommand) });
        }

        private void BindedCommand(object sender)
        {
            if (Command != null)
            {
                Command.Execute(CommandParameter);
            }
        }
    }
}