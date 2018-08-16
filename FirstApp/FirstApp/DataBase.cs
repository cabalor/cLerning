namespace FirstApp
{
    public class DataBase
    {
        private readonly Logger log;

        public DataBase(Logger logg)
        {
            this.log = logg;
        }

        public void export()
        {
            log.log("robimy tutaj");
        }


    }
}
