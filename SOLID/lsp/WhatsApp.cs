using System;
using lsp.SocialMedia;
using lsp.SocialVideoCallManager;

namespace lsp.WhatsApp
{
    public class WhatsApp : ISocialMedia, ISocialVideoCallManager
    {
        public void ChatWithFriend(string friendName, string message)
        {
            // Simulate sending a chat message to a friend
            Console.WriteLine($"Chatting with {friendName} on WhatsApp: {message}");
        }

        public void SendPhotosAndVideos(string filePath)
        {
            // Simulate sending photos and videos
            Console.WriteLine($"Photo/Video sent on WhatsApp from: {filePath}");
        }

        public void GroupVideoCall(params string[] users)
        {
            // Simulate a group video call
            Console.WriteLine("Starting group video call on WhatsApp with:");
            foreach (var user in users)
            {
                Console.WriteLine($"- {user}");
            }
        }
    }
}
