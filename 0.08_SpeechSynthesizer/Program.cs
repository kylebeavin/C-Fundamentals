using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_SpeechSynthesizer
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer speak = new SpeechSynthesizer();
            speak.Volume = 100;
            speak.Speak("Hello Kyle");
        }
    }
}
