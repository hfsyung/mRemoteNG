using System;

namespace mRemoteNG.UI.Forms.OptionsPages
{
    public partial class StartupExitPage
    {
        public StartupExitPage()
        {
            InitializeComponent();
            base.ApplyTheme();
        }

        public override string PageName
        {
            get { return Language.strStartupExit; }
            set { }
        }

        public override void ApplyLanguage()
        {
            base.ApplyLanguage();

            chkSaveConsOnExit.Text = Language.strSaveConsOnExit;
            chkReconnectOnStart.Text = Language.strReconnectAtStartup;
            chkSingleInstance.Text = Language.strAllowOnlySingleInstance;
            chkProperInstallationOfComponentsAtStartup.Text = Language.strCheckProperInstallationOfComponentsAtStartup;
        }

        public override void SaveSettings()
        {
            base.SaveSettings();

            Settings.Default.SaveConsOnExit = chkSaveConsOnExit.Checked;
            Settings.Default.OpenConsFromLastSession = chkReconnectOnStart.Checked;
            Settings.Default.SingleInstance = chkSingleInstance.Checked;
            Settings.Default.StartupComponentsCheck = chkProperInstallationOfComponentsAtStartup.Checked;

            Settings.Default.Save();
        }

        private void StartupExitPage_Load(object sender, EventArgs e)
        {
            chkSaveConsOnExit.Checked = Settings.Default.SaveConsOnExit;
            chkReconnectOnStart.Checked = Settings.Default.OpenConsFromLastSession;
            chkSingleInstance.Checked = Settings.Default.SingleInstance;
            chkProperInstallationOfComponentsAtStartup.Checked = Settings.Default.StartupComponentsCheck;
        }
    }
}