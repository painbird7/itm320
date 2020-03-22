using System;

namespace hw7_excep
{
    public class LengthCheck : Exception
    {
        public LengthCheck(int inputString) : base($"The length of entered password is {inputString}. Password has to be at least 6 characters long.")
        {
            
        }
    }
}