using System;
using System.Windows.Forms;
using Good.BusinessLayer;
using Good.DataAccessLayer;
using Good.PresentationLayer;

namespace Good.WindowsFormApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var peopleForm = BuildPeopleForm();
            Application.Run(peopleForm);
        }

        public static PeopleForm BuildPeopleForm()
        {
            var peopleRepository = new PeopleRepository();
            var peopleService = new PeopleService(peopleRepository);
            return new PeopleForm(peopleService);
        }
    }
}
