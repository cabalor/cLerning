namespace FirstApp
{
    public class Test
    {

        private string nameTest { get; set; }

        private Test(string name)
        {
            this.nameTest = name;
        }

        private Test()
        {

        }

         public static Test nowyTest()
        {
            return new Test();
        }


        public static Test testWithName(string name)
        {
            return new Test(name);

            
        }

        public string toString()
        {
            return "nowy test z nazwa " + nameTest;
        }


    }
}
