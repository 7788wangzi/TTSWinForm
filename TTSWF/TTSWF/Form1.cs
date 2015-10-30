using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;

namespace TTSWF
{
    public partial class Form1 : Form
    {
        int voiceIndex = 0;

        Text2Speech text2Speech = null;
        public Form1()
        {
            InitializeComponent();

            text2Speech = new Text2Speech();
            ShowSupportedLanguages();
        }

        private void ShowSupportedLanguages()
        {
            List<string> allLanguages = text2Speech.GetInstalledVoiceInfo();

            cbSupportLanguages.DataSource = allLanguages;
            cbSupportLanguages.SelectedIndexChanged += CbSupportLanguages_SelectedIndexChanged;

        }

        private void CbSupportLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            voiceIndex = cbSupportLanguages.SelectedIndex;
        }

        private void btnReadOut_Click(object sender, EventArgs e)
        {

            string text = tbxContent.Text.Trim();

            if (!string.IsNullOrEmpty(text))
            {

                if (text2Speech.AllVoices.Count > voiceIndex)
                    text2Speech.SetVoiceInfo(text2Speech.AllVoices[voiceIndex]);
                text2Speech.SpeeckText(text);
                text2Speech.synthesizer.SpeakCompleted += Synthesizer_SpeakCompleted;
                btnReadOut.Enabled = false;
                btnSave.Enabled = false;
            }

        }

        private void Synthesizer_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            btnReadOut.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            string saveFile = string.Empty;
            if(dr!=DialogResult.Cancel)
            {
                saveFile = saveFileDialog1.FileName+".mp3";

                string text = tbxContent.Text.Trim();
                btnSave.Enabled = false;
                if (!string.IsNullOrEmpty(text))
                {
                    if (text2Speech.AllVoices.Count > voiceIndex)
                        text2Speech.SetVoiceInfo(text2Speech.AllVoices[voiceIndex]);
                    text2Speech.SaveToMp3File(text, saveFile);

                    MessageBox.Show("Saved to File Complete.");
                }

                btnSave.Enabled = true;
            }

            
        }

    }
}
