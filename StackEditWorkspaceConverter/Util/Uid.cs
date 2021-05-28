using System;
using System.Collections.Generic;
using System.Text;

namespace StackEditWorkspaceConverter.Util
{
    public static class Uid
    {
        private const int UID_LENGTH = 16;

        private static Random random = new Random();

        public static string NewUid()
        {
            string uid = string.Empty;

            for (int i = 0; i < UID_LENGTH; i++)
            {
                uid += GetRandomChar();
            }

            return uid;
        }

        private static char GetRandomChar()
        {
            const int upperCaseAlphabetTotal = 26;
            const int lowerCaseAlphabetTotal = 26;
            const int numberTotal = 10;
            const int characterTypeTotal = upperCaseAlphabetTotal + lowerCaseAlphabetTotal + numberTotal;

            int next = random.Next(characterTypeTotal);

            if (next < numberTotal)
            {
                return (char)('0' + next);
            }
            else if (next < numberTotal + lowerCaseAlphabetTotal)
            {
                return (char)('a' + next - numberTotal);
            }
            else
            {
                return (char)('A' + next - numberTotal - lowerCaseAlphabetTotal);
            }
        }
    }
}
