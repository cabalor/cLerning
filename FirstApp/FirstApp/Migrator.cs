using System;

namespace FirstApp
{

    public partial class Migrator
    {

        private readonly ILoger logger;

        public Migrator(ILoger _loger)
        {
            logger = _loger;
        }


        public void Migrate() {
            logger.logInfo("migrate going on {0}"+ DateTime.Now);

            logger.logInfo("migrate ended {0}"+ DateTime.Now);
        }


    }
}

