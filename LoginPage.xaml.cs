using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Twindows
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class LoginPage : Twindows.Common.LayoutAwarePage
    {

        private bool rememberMe;
        public LoginPage()
        {
            this.InitializeComponent();

        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            //add the code to save the logins and the pw and send them to Oauth backend
            //ensure that an enter key press will also log in
            string username = usernameInput.Text;
            string pw = pwInput.Password;

            if (string.IsNullOrEmpty(username))
            {
                invalidInfo.Text = "Missing username";
            }
            else if (string.IsNullOrEmpty(pw))
            {
                invalidInfo.Text = "Missing password";
            }
            else
            {
                this.Frame.Navigate(typeof(GridMainPage));
            }


        }

        private void Enter_Press(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                string username = usernameInput.Text;
                string pw = pwInput.Password;

                if (string.IsNullOrEmpty(username))
                {
                    invalidInfo.Text = "Missing username";
                }
                else if (string.IsNullOrEmpty(pw))
                {
                    invalidInfo.Text = "Missing password";
                }
                else {
                    this.Frame.Navigate(typeof(GridMainPage));
                }
            }
        }

        private void HandleChange(object sender, RoutedEventArgs e)
        {
            if (rememberMe)
            {
                rememberMe = true;
            }
            else
            {
                rememberMe = false;
            }
        }
    }
}
