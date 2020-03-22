namespace hw7_excep
{
    public class Password
    {
        public Password(string inputString)
        {
            int count = inputString.Length;

            if (count < 6)
            {
                throw new LengthCheck(count);
            }
        }
    }
}