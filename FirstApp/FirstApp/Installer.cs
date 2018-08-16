namespace FirstApp
{
    public class Installer
    {
        private readonly Logger loger;

        public Installer(Logger loger)
        {
            this.loger = loger;
        }


        public void install()
        {
            loger.log("instalujemy");
        }

    }
}
