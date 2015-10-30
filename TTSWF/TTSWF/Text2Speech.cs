
namespace TTSWF
{
    using System.IO;
    using System.Speech.Synthesis;
    using System.Speech.AudioFormat;
    using System.Text;
    using System.Collections.Generic;
    using NAudio.Wave;
    using NAudio.Lame;
    public class Text2Speech
    {
        public SpeechSynthesizer synthesizer = null;

        public List<VoiceInfo> AllVoices = null;

        public Text2Speech()
        {
            synthesizer = new SpeechSynthesizer();

            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);  

            synthesizer.Rate = 0;

            AllVoices = new List<VoiceInfo>();
        }

        public void SetVoiceInfo(VoiceInfo info)
        {
            synthesizer.SelectVoice(info.Name);
        }

        public List<string> GetInstalledVoiceInfo()
        {
            // get all voices
            List<string> VoiceName = new List<string>();
            foreach (var voice in synthesizer.GetInstalledVoices())
            {
                VoiceInfo infor = voice.VoiceInfo;

                StringBuilder sb = new StringBuilder();
                foreach (SpeechAudioFormatInfo fmt in infor.SupportedAudioFormats)
                {
                    sb.Append(string.Format(@"{0}\n", fmt.EncodingFormat.ToString()));
                }

                string message = string.Format(@" Name ：{0} ; Culture : {1} ; Age :{2} ; Gender :{3} ; Description :{4} ; ID :{5} ; Enabled :{6} ; Audio Formats :{7}", infor.Name, infor.Culture, infor.Age, infor.Gender, infor.Description, infor.Id, voice.Enabled, sb.ToString());

                VoiceName.Add(message);

                AllVoices.Add(infor);
            }

            return VoiceName;
        }

        public void SpeeckText(string text)
        {
            synthesizer.SpeakAsync(text);
        }

        public void SaveToMp3File(string text, string mp3)
        {
            MemoryStream ms = new MemoryStream();
            
            synthesizer.SetOutputToWaveStream(ms);
            synthesizer.Speak(text);
            ConvertWavStreamToMp3File(ref ms, mp3);
        }

        private void ConvertWavStreamToMp3File(ref MemoryStream ms, string savetofilename)
        {
            //rewind to beginning of stream
            ms.Seek(0, SeekOrigin.Begin);

            using (var retMs = new MemoryStream())
            using (var rdr = new WaveFileReader(ms))
            using (var wtr = new LameMP3FileWriter(savetofilename, rdr.WaveFormat, LAMEPreset.VBR_90))
            {
                rdr.CopyTo(wtr);
            }
        }
    }
}
