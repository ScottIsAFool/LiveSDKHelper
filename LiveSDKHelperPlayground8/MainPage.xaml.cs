using System.Collections.Generic;
using System.Windows;
using LiveSDKHelper;
using LiveSDKHelper.Hotmail;
using Microsoft.Live;
using Microsoft.Live.Controls;
using Microsoft.Phone.Controls;
using Newtonsoft.Json;

namespace LiveSDKHelperPlayground8
{
    public partial class MainPage : PhoneApplicationPage
    {
        private LiveConnectClient _client;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            //wl.basic wl.signin wl.offline_access wl.skydrive_update wl.calendars
            var scopes = new List<Scope>
                {
                    Scope.Basic,
                    Scope.SignIn,
                    Scope.OfflineAccess,
                    Scope.SkyDriveUpdate,
                    Scope.Calendars
                };

            SignInButton.Scopes = scopes.ToConcatenatedString(
                scope => scope.ToStringScope(),
                " ");

            SignedInAs.Text = "Not signed in";

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private async void SignInButton_OnSessionChanged(object sender, LiveConnectSessionChangedEventArgs e)
        {
            if (e.Error == null && e.Status == LiveConnectSessionStatus.Connected)
            {
                _client = new LiveConnectClient(e.Session);

                try
                {
                    var meResult = await _client.GetAsync(LiveSdkConstants.MyDetails);
                    var myDetails = JsonConvert.DeserializeObject<MeDetails>(meResult.RawResult);

                    SignedInAs.Text = string.Format("Signed in as {0}", myDetails.Name);
                }
                catch
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }

        private async void HowManyContacts_OnClick(object sender, RoutedEventArgs e)
        {
            if (_client == null) return;

            var result = await _client.GetAsync(MeDetails.MyContacts);
            var contacts = JsonConvert.DeserializeObject<Contacts>(result.RawResult);

            MessageBox.Show("You have " + contacts.Items.Count + " contacts!!");
        }

        private async void HowManyFriends_OnClick(object sender, RoutedEventArgs e)
        {
            if (_client == null) return;

            var result = await _client.GetAsync(MeDetails.MyFriends);
            var contacts = JsonConvert.DeserializeObject<Contacts>(result.RawResult);

            MessageBox.Show("You have " + contacts.Items.Count + " friends!!");
        }

        private async void NumberOfCalendars_OnClick(object sender, RoutedEventArgs e)
        {
            if (_client == null) return;

            var result = await _client.GetAsync(MeDetails.MyCalendars);
            var calendars = JsonConvert.DeserializeObject<CalendarEvents>(result.RawResult);
            // var calendars = CalendarEvents.FromJson(result.RawResult);

            MessageBox.Show("You have " + calendars.Items.Count + " calendars!!");
        }
    }
}
