using System;

class Program
{
    static void Main(string[] args)
    {
        VideoManager videoManager = new VideoManager();
        Menu menu = new Menu(videoManager);
        menu.Display();
    }
}