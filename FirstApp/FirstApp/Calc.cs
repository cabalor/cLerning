namespace FirstApp
{
    public class Calc
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;

            foreach(var numb in numbers)
            {
                sum += numb;
            }
            return sum;

        }
    }
}
