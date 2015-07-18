using System;
using System.Windows.Forms;
using iTranslator.Properties;
using TranslatorLib.Google;
using TranslatorLib;

namespace iTranslator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Initialise();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if(IsValid() == false)
                return;

            try
            {
                IGoogleRequest googleRequest = new GoogleRequest();
                ITranslate translator = new GoogleTranslator(googleRequest);
                var translatedTexts = translator.Translate(TxtFromLanguage.Text, ((ComboboxItem)CmdFromLangauge.SelectedItem).Text,
                    ((ComboboxItem)CmdToLangauge.SelectedItem).Text);

                TxtToLangauge.Text = string.Empty;

                foreach (var text in translatedTexts)
                {
                    TxtToLangauge.Text += text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Initialise()
        {
            var langauges = Langauge.GetInstanse().GetLangauges();

            CmdFromLangauge.Items.Clear();
            CmdToLangauge.Items.Clear();

            foreach (var langauge in langauges)
            {
                CmdFromLangauge.Items.Add(new ComboboxItem { Text = langauge.Key, Value = langauge.Value });
                CmdToLangauge.Items.Add(new ComboboxItem { Text = langauge.Key, Value = langauge.Value });
            }
        }

        private bool IsValid()
        {
            if (CmdFromLangauge.SelectedIndex < 0 || CmdToLangauge.SelectedIndex < 0)
            {
                MessageBox.Show(Resources.NoSelectFromToLangauge);
                return false;
            }

            if (string.IsNullOrEmpty(TxtFromLanguage.Text))
            {
                MessageBox.Show(Resources.NoEnterFromLangauge);
                return false;
            }

            return true;
        }
    }
}
