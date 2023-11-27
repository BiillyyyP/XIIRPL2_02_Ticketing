using XIIRPL2_02_Ticketing.MasterForm;

namespace XIIRPL2_02_Ticketing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //FrmLogin formLogin = new FrmLogin();
            //formLogin.Show();
            //FrmMasterKodePromo kodepromo= new FrmMasterKodePromo();
            //kodepromo.Show();

            //FrmMasterMaskapai maskapai = new FrmMasterMaskapai();
            //maskapai.Show();

            //FrmMasterBandara bandara = new FrmMasterBandara();
            //bandara.Show();

            FrmMasterJadwalPenerbangan jadwalPenerbangan = new FrmMasterJadwalPenerbangan();
            jadwalPenerbangan.Show();

            Application.Run();
        }
    }
}