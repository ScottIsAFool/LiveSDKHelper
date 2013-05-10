namespace LiveSDKHelper
{
    // Reference: http://msdn.microsoft.com/en-us/library/live/hh243646.aspx
    public enum Scope
    {
        /// <summary>
        /// Read access to a user's basic profile info. Also enables read access to a user's list of contacts.
        /// </summary>
        [ScopeName("wl.basic")]
        Basic,

        /// <summary>
        /// The ability of an app to read and update a user's info at any time. Without this scope, an app can access the user's info only while the user is signed in to Live Connect and is using your app.
        /// </summary>
        [ScopeName("wl.offline_access")]
        OfflineAccess,

        /// <summary>
        /// Single sign-in behavior. With single sign-in, users who are already signed in to Live Connect are also signed in to your website.
        /// </summary>
        [ScopeName("wl.signin")]
        SignIn,

        /// <summary>
        /// Read access to a user's birthday info including birth day, month, and year.
        /// </summary>
        [ScopeName("wl.birthday")]
        Birthday,

        /// <summary>
        /// Read access to a user's calendars and events.
        /// </summary>
        [ScopeName("wl.calendars")]
        Calendars,

        /// <summary>
        /// Read and write access to a user's calendars and events.
        /// Superset for: Scope.Calendars
        /// </summary>
        [ScopeName("wl.calendars_update")]
        CalendarsUpdate,

        /// <summary>
        /// Read access to the birth day and birth month of a user's contacts. Note that this also gives read access to the user's birth day, birth month, and birth year.
        /// Superset for: Scope.Birthday
        /// </summary>
        [ScopeName("wl.contacts_birthday")]
        ContactsBirthday,

        /// <summary>
        /// Creation of new contacts in the user's address book.
        /// </summary>
        [ScopeName("wl.contacts_create")]
        ContactsCreate,

        /// <summary>
        /// Read access to a user's calendars and events. Also enables read access to any calendars and events that other users have shared with the user
        /// Superset for: Scope.Calendars
        /// </summary>
        [ScopeName("wl.contacts_calendars")]
        ContactsCalendars,

        /// <summary>
        /// Read access to a user's albums, photos, videos, and audio, and their associated comments and tags. Also enables read access to any albums, photos, videos, and audio that other users have shared with the user.
        /// Superset for: Scope.Photos
        /// </summary>
        [ScopeName("wl.contacts_photos")]
        ContactsPhotos,

        /// <summary>
        /// Read access to Microsoft SkyDrive files that other users have shared with the user. Note that this also gives read access to the user's files stored in SkyDrive.
        /// Superset for: Scope.SkyDrive
        /// </summary>
        [ScopeName("wl.contacts_skydrive")]
        ContactsSkyDrive,

        /// <summary>
        /// Read access to a user's personal, preferred, and business email addresses.
        /// </summary>
        [ScopeName("wl.emails")]
        Emails,

        /// <summary>
        /// Creation of events on the user's default calendar.
        /// </summary>
        [ScopeName("wl.events_create")]
        EventsCreate,

        /// <summary>
        /// Enables signing in to the Windows Live Messenger Extensible Messaging and Presence Protocol (XMPP) service.
        /// </summary>
        [ScopeName("wl.messenger")]
        Messenger,

        /// <summary>
        /// Read access to a user's personal, business, and mobile phone numbers.
        /// </summary>
        [ScopeName("wl.phone_numbers")]
        PhoneNumbers,

        /// <summary>
        /// Read access to a user's photos, videos, audio, and albums.
        /// </summary>
        [ScopeName("wl.photos")]
        Photos,

        /// <summary>
        /// Read access to a user's postal addresses.
        /// </summary>
        [ScopeName("wl.postal_addresses")]
        PostalAddresses,

        /// <summary>
        /// Enables updating a user's status message.
        /// </summary>
        [ScopeName("wl.share")]
        Share,

        /// <summary>
        /// Read access to a user's files stored in SkyDrive.
        /// </summary>
        [ScopeName("wl.skydrive")]
        SkyDrive,

        /// <summary>
        /// Read and write access to a user's files stored in SkyDrive.
        /// Superset for: Scope.SkyDrive
        /// </summary>
        [ScopeName("wl.skydrive_update")]
        SkyDriveUpdate,

        /// <summary>
        /// Read access to a user's employer and work position information.
        /// </summary>
        [ScopeName("wl.work_profile")]
        WorkProfile,

        /// <summary>
        /// Read access to a developer's client IDs that have been created to work with the Live Connect APIs.
        /// </summary>
        [ScopeName("wl.applications")]
        Applications,

        /// <summary>
        /// Creation of new client IDs on behalf of a developer.
        /// Superset for: Scope.Applications
        /// </summary>
        [ScopeName("wl.applications_create")]
        ApplicationsCreate,
    }
}
