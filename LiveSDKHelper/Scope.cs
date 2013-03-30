namespace LiveSDKHelper
{
    public enum Scope
    {
        /// <summary>
        /// Read access to a user's basic profile info. Also enables read access to a user's list of contacts.
        /// </summary>
        Basic, //wl.basic
        
        /// <summary>
        /// Single sign-in behavior. With single sign-in, users who are already signed in to Live Connect are also signed in to your website.
        /// </summary>
        SignIn, // wl.signin
        
        /// <summary>
        /// The ability of an app to read and update a user's info at any time. Without this scope, an app can access the user's info only while the user is signed in to Live Connect and is using your app.
        /// </summary>
        OfflineAccess, // wl.offline_access
        
        /// <summary>
        /// Read and write access to a user's files stored in SkyDrive.
        /// </summary>
        SkyDriveUpdate, // wl.skydrive_update
        
        /// <summary>
        /// Read access to a user's calendars and events.
        /// </summary>
        Calendars, // wl.calendars
        
        /// <summary>
        /// The contacts
        /// </summary>
        Contacts, // wl.contacts
        
        /// <summary>
        /// Creation of new contacts in the user's address book.
        /// </summary>
        ContactsCreate, // wl.contacts_create
        
        /// <summary>
        /// Read access to a user's birthday info including birth day, month, and year.
        /// </summary>
        Birthday, // wl.birthday
        
        /// <summary>
        /// Read and write access to a user's calendars and events.
        /// </summary>
        CalendarsUpdate, // wl.calendars_update
        
        /// <summary>
        /// Read access to a user's calendars and events. Also enables read access to any calendars and events that other users have shared with the user
        /// </summary>
        ContactsCalendars, // wl.contacts_calendars
        
        /// <summary>
        /// Read access to a user's albums, photos, videos, and audio, and their associated comments and tags. Also enables read access to any albums, photos, videos, and audio that other users have shared with the user.
        /// </summary>
        ContactsPhotos, // wl.contacts_photos
        
        /// <summary>
        /// Read access to Microsoft SkyDrive files that other users have shared with the user. Note that this also gives read access to the user's files stored in SkyDrive.
        /// </summary>
        ContactsSkyDrive, // wl.contacts_skydrive
        
        /// <summary>
        /// Read access to a user's personal, preferred, and business email addresses.
        /// </summary>
        Emails, // wl.emails
        
        /// <summary>
        /// Creation of events on the user's default calendar.
        /// </summary>
        EventsCreate, // wl.events_create
        
        /// <summary>
        /// Read access to a user's personal, business, and mobile phone numbers.
        /// </summary>
        PhoneNumbers, // wl.phone_numbers
        
        /// <summary>
        /// Read access to a user's photos, videos, audio, and albums.
        /// </summary>
        Photos, // wl.photos
        
        /// <summary>
        /// Read access to a user's postal addresses.
        /// </summary>
        PostalAddresses, // wl.postaladdresses
        
        /// <summary>
        /// Enables updating a user's status message.
        /// </summary>
        Share, // wl.share
        
        /// <summary>
        /// Read access to a user's files stored in SkyDrive.
        /// </summary>
        SkyDrive, // wl.skydrive
        
        /// <summary>
        /// Read access to a user's employer and work position information.
        /// </summary>
        WorkProfile, // wl.work_profile

    }
}
