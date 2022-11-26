namespace TheRealJester
{

    public abstract class Jester
    {

        public static int MaxValueOfArray(int[] arr)
        {
            int Result = 0;

            foreach (int i in arr)
            {
                Result = (i > Result) ? i : Result;
            }

            return Result;

        }
        /////////////////////////////////////////////////////

        public static void Ghoul()
        {
            for (int i = 1000; i >= -0; i-=7)
            {
                Console.Write(i + "\t");
            }
        }
        ////////////////////////////////////////////////////
        
    }




}