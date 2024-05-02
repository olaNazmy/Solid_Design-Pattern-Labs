using ISP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    //1- Audio class, not play video, not display subtitles
    public class AudioPlayer : IAudioPlayer, IMediaLoader
    {
        public void PlayAudio()
        {
            Console.WriteLine("Audio Player method");
        }
        public void LoadMedia(string filepath)
        {
            Console.WriteLine("media loader method");
        }
    }

    //2- Video Class, can't play without audio
    public class VideoPlayer : IVideoPlayer, IMediaLoader, ISubtitlePlayer,IAudioPlayer
    {
        public void DisptaySubtitltes()
        {
            Console.WriteLine("Subtitles method");
        }

        public void LoadMedia(string filepath)
        {
            Console.WriteLine("media loader method");
        }

        public void PlayAudio()
        {
            throw new NotImplementedException();
        }

        public void PlayVideo()
        {
            Console.WriteLine("Play video method");
        }


    }
    
    public class Program
    {
        static void Main(string[] args)
        {
            // You can instantiate and use your AudioPlayer and VideoPlayer classes here
            Console.WriteLine("Program execution started...");

            // Example usage:
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.LoadMedia("example.mp3");
            audioPlayer.PlayAudio();

            VideoPlayer videoPlayer = new VideoPlayer();
            videoPlayer.LoadMedia("videofile.mp4");
            videoPlayer.PlayVideo();
            videoPlayer.DisptaySubtitltes();

            Console.WriteLine("Program execution completed.");
        }
    }

}
