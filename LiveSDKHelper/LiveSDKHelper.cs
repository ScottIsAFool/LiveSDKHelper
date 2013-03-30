using System.Collections.Generic;
using System.Text;

namespace LiveSDKHelper
{
    public static class LiveSDKClientHelper
    {
        public static string GetScopesString(List<Scope> scopes)
        {
            if (scopes == null) return "invalid list of scopes";

            var sb = new StringBuilder();

            foreach (var scope in scopes)
            {
                sb.AppendFormat("{0} ", scope.ToScope());
            }

            return sb.ToString().Trim();
        }

        public static string ToScope(this Scope scope)
        {
            switch (scope)
            {
                case Scope.Basic:
                    return "wl.basic";
                case Scope.Birthday:
                    return "wl.birthday";
                case Scope.Calendars:
                    return "wl.calendars";
                case Scope.CalendarsUpdate:
                    return "wl.calendars_update";
                case Scope.Contacts:
                    return "wl.contacts";
                case Scope.ContactsCalendars:
                    return "wl.contacts_calendars";
                case Scope.ContactsCreate:
                    return "wl.contacts_create";
                case Scope.ContactsPhotos:
                    return "wl.contacts_photos";
                case Scope.ContactsSkyDrive:
                    return "wl.contacts_skydrive";
                case Scope.Emails:
                    return "wl.emails";
                case Scope.EventsCreate:
                    return "wl.events_create";
                case Scope.OfflineAccess:
                    return "wl.offline_access";
                case Scope.PhoneNumbers:
                    return "wl.phone_numbers";
                case Scope.Photos:
                    return "wl.photos";
                case Scope.PostalAddresses:
                    return "wl.postal_addresses";
                case Scope.Share:
                    return "wl.share";
                case Scope.SkyDrive:
                    return "wl.skydrive";
                case Scope.SkyDriveUpdate:
                    return "wl.skydrive_update";
                case Scope.WorkProfile:
                    return "wl.work_profile";
            }
            return "";
        }
    }
}
