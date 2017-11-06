using System.Windows.Forms;

namespace CrossWordExpress
{
    class Other
    {
        public static void AboutAuthor()
        {
            foreach (Form f in Application.OpenForms)
                if (f.Name == "AboutAuthor")
                    return;
            AboutAuthor form = new AboutAuthor();
            form.Show();
        }

        public static void Help()
        {
            foreach (Form f in Application.OpenForms)
                if (f.Name == "HelpUser")
                    return;
            HelpUser form = new HelpUser();
            form.Show();
        }

    }
}
