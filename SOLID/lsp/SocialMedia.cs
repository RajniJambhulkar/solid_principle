namespace lsp.SocialMedia
{
    public interface ISocialMedia
    {
        void ChatWithFriend(string friendName, string message);
        void SendPhotosAndVideos(string filePath);
    }
}

