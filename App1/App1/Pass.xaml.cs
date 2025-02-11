using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pass : ContentPage
    {

        Label textLabel;
        Entry loginEntry, passwordEntry;
        public Pass()
        {


            StackLayout stackLayout = new StackLayout();

            loginEntry = new Entry { Placeholder = "Login" };
            loginEntry.TextChanged += loginEntry_TextChanged;

            passwordEntry = new Entry
            {
                Placeholder = "Password",
                IsPassword = true
            };
            textLabel = new Label { FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) };

            stackLayout.Children.Add(loginEntry);
            stackLayout.Children.Add(passwordEntry);
            stackLayout.Children.Add(textLabel);
            this.Content = stackLayout;
        }

        private void loginEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            textLabel.Text = loginEntry.Text;
        }
    }
}