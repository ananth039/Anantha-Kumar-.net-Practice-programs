using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;


namespace Demo_on_Speech_Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to speak:");
            string TextToSpeak = Console.ReadLine(); 
            SpeechSynthesizer ss = new SpeechSynthesizer();
            ss.Volume = 100; //1 to 100
            ss.Rate = -3; // -10 to +10 
            ss.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
            ss.SpeakAsync(TextToSpeak); 
            Console.Read();
        }
    }
}
