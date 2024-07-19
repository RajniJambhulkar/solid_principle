using lsp.WhatsApp;
using lsp.Instagram;
public class Program
{
    public static void Main()
    {
        // Using WhatsApp
        WhatsApp whatsapp = new lsp.WhatsApp.WhatsApp();
        whatsapp.ChatWithFriend("Alice", "Hello, how are you?");
        whatsapp.SendPhotosAndVideos("path.jpg");
        whatsapp.GroupVideoCall("Alice", "Bob");

        // Using Instagram
        Instagram instagram = new lsp.Instagram.Instagram();
        instagram.ChatWithFriend("Bob", "Hey there!");
        instagram.SendPhotosAndVideos("path.jpg");
        instagram.PublishPost("This is a new Instagram post.");
    }
}
