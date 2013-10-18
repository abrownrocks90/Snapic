using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snapic.Snapchat_API
{
    class SnapChatAPI
    {
        const String VERSION = "6.0.0"; //API Version
        const String URL = "https://feelinsonice-hrd.appspot.com/bq"; //API URL
        const String SECRET = "iEk21fuwZApXlz93750dmW22pw389dPwOk"; //API secret
        const String STATIC_TOKEN = "m198sOkJEn37DjqZ32lpRu76xmw288xSQ9"; //API static token
        const String BLOB_ENCRYPTION_KEY = "M02cnQ51Ji97vwT4"; //Blob encryption key
        const String HASH_PATTERN = "0001110111101110001111010101111011010001001110011000110001000110"; //Hash pattern
        const int MEDIA_IMAGE = 0; //Incoming or outgoing media is an image
        const int MEDIA_VIDEO = 1; //Incoming or outgoing media is a video
        const int MEDIA_VIDEO_NOAUDIO = 2; //Incoming or outgoing media is a video with no audio
        const int MEDIA_FRIEND_REQUEST = 3; //Incoming or outgoing media is a friend request
        const int MEDIA_FRIEND_REQUEST_IMAGE = 4; //Incoming or outgoing media is a friend request with an image
        const int MEDIA_FRIEND_REQUEST_VIDEO = 5; //Incoming or outgoing media is a friend request with a video
        const int MEDIA_FRIEND_REQUEST_VIDEO_NOAUDIO = 6; //Incoming or outgoing media is a friend request with a video with no audio
        const int STATUS_NONE = -1; //No status for sent snap
        const int STATUS_SENT = 0; //Sent status for sent snap
        const int STATUS_DELIVERED = 1; //Delivered status for sent snap
        const int STATUS_OPENED = 2; //Opened status for sent snap
        const int STATUS_SCREENSHOT = 3; //Screenshot status for sent snap
        const int FRIEND_CONFIRMED = 0; //Friend is confirmed
        const int FRIEND_UNCONFIRMED = 1; //Friend is unconfirmed
        const int FRIEND_BLOCKED = 2; //"Friend" is blocked
        const int PRIVACY_EVERYONE = 0;
        const int PRIVACY_FRIENDS = 0;
        
        public void login(String userName, String passWord)
        {
            //var client = new RestClient();
        }
    }
}
