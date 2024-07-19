using System;
using lsp.SocialMedia;
using lsp.PostMediaManager;

namespace lsp.Instagram
{
    public class Instagram : ISocialMedia, IPostMediaManager
    {
        public void ChatWithFriend(string friendName, string message)
        {
            // Simulate sending a chat message to a friend
            Console.WriteLine($"Chatting with {friendName} on Instagram: {message}");
        }

        public void SendPhotosAndVideos(string filePath)
        {
            // Simulate sending photos and videos
            Console.WriteLine($"Photo/Video sent on Instagram from: {filePath}");
        }

        public void PublishPost(object post)
        {
            // Simulate publishing a post
            Console.WriteLine($"Instagram post published: {post}");
        }
    }
}
