using System.Collections.Generic;
using System.Windows.Forms;
using TranslatorLib.Setting;

namespace iTranslator
{
    public partial class FrmSetting : Form
    {
        public FrmSetting()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            IConfiguration config = RegisterDependency.Container.GetInstance<IConfiguration>();
            TxtGoogleApiUrl.Text = config.Get(SettingName.BaseUrl) as string;
            TxtGoogleApiKey.Text = config.Get(SettingName.ApiKey) as string;
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            IConfiguration config = RegisterDependency.Container.GetInstance<IConfiguration>();
            Dictionary<string, object> settings = new Dictionary<string, object>();

            settings.Add(SettingName.BaseUrl, TxtGoogleApiUrl.Text);
            settings.Add(SettingName.ApiKey, TxtGoogleApiKey.Text);

            config.Set(settings);
            config.Save();

            MessageBox.Show("Settings save successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
