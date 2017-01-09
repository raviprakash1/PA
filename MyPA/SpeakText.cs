using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Runtime.InteropServices;

namespace MyPA
{
    class SpeakText
    {
        //SpeakText()
        //{
        //   bool _isCurrentlySpeaking = true;
        //}
        public static void Speak(string text)
        {

            Form1._isSpeaking = true;
            SpeechSynthesizer reader = new SpeechSynthesizer();
            PromptBuilder pb = new PromptBuilder();
            reader.SelectVoice("eSpeak-ryan");
            reader.Rate = 1;
            reader.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);
            Console.Write(text);
            pb.AppendText(text);
            reader.Speak(pb);
            Form1._isSpeaking = false;
            //reader.SpeakCompleted += (x, y) =>
            //{
            //    Form1._isSpeak = false;
            //};
            // reader.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(reader_SpeakCompleted);
        }
        //private void reader_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        //{
        //    reader.Dispose();
        //}

    }
}
