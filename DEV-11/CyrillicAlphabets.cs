

namespace DEV_11
{
    class CyrillicAlphabets
    {
        //Method which converts cyrilics letters to roman
        public string ConvertToLat(AdjacentLetters adjacentLetters, bool ending, ref int checker)
        {
            switch (adjacentLetters.letter)
            {
                case 'А': return "A";
                case 'Б': return "B";
                case 'В': return "V";
                case 'Г': return "G";
                case 'Д': return "D";
                case 'Е': return CheckOnDoubleSound(adjacentLetters).ToUpper();
                case 'Ё': return CheckOnDoubleSound(adjacentLetters).ToUpper();
                case 'Ж': return "ZH";
                case 'З': return "Z";
                case 'И': return CheckTheEnding(adjacentLetters, ending, ref checker).ToUpper();
                case 'Й': return "Y";
                case 'К': return "K";
                case 'Л': return "L";
                case 'М': return "M";
                case 'Н': return "N";
                case 'О': return "O";
                case 'П': return "P";
                case 'Р': return "R";
                case 'С': return "S";
                case 'Т': return "T";
                case 'У': return "U";
                case 'Ф': return "F";
                case 'Х': return "KH";
                case 'Ц': return "TS";
                case 'Ч': return "CH";
                case 'Ш': return "SH";
                case 'Щ': return "SHCH";
                case 'Ъ': return "";
                case 'Ы': return CheckTheEnding(adjacentLetters, ending, ref checker).ToUpper();
                case 'Ь': return CheckTheEnding(adjacentLetters, ending, ref checker).ToUpper();
                case 'Э': return "E";
                case 'Ю': return "YU";
                case 'Я': return "YA";
                case 'а': return "a";
                case 'б': return "b";
                case 'в': return "v";
                case 'г': return "g";
                case 'д': return "d";
                case 'е': return CheckOnDoubleSound(adjacentLetters);
                case 'ё': return CheckOnDoubleSound(adjacentLetters);
                case 'ж': return "zh";
                case 'з': return "z";
                case 'и': return CheckTheEnding(adjacentLetters, ending, ref checker);
                case 'й': return "y";
                case 'к': return "k";
                case 'л': return "l";
                case 'м': return "m";
                case 'н': return "n";
                case 'о': return "o";
                case 'п': return "p";
                case 'р': return "r";
                case 'с': return "s";
                case 'т': return "t";
                case 'у': return "u";
                case 'ф': return "f";
                case 'х': return "kh";
                case 'ц': return "ts";
                case 'ч': return "ch";
                case 'ш': return "sh";
                case 'щ': return "shch";
                case 'ъ': return "";
                case 'ы': return CheckTheEnding(adjacentLetters, ending, ref checker);
                case 'ь': return CheckTheEnding(adjacentLetters, ending, ref checker);
                case 'э': return "e";
                case 'ю': return "yu";
                case 'я': return "ya";
                default: return adjacentLetters.letter.ToString();
            }
        }

        //Check situations when cyrillic letters have double sound and convert as two latinic letters
        public string CheckOnDoubleSound(AdjacentLetters letters)
        {
            if (letters.previousLetter == '\0' || letters.previousLetter == 'ь' || letters.previousLetter == 'ъ' ||
                letters.previousLetter == ' ' || letters.previousLetter == 'а' || letters.previousLetter == 'я' ||
                letters.previousLetter == 'и' || letters.previousLetter == 'ю' || letters.previousLetter == 'ы' ||
                letters.previousLetter == 'о' || letters.previousLetter == 'э' || letters.previousLetter == 'у' ||
                letters.previousLetter == 'е' || letters.previousLetter == 'Ь' || letters.previousLetter == 'Ъ' ||
                letters.previousLetter == 'А' || letters.previousLetter == 'Я' || letters.previousLetter == 'Е' ||
                letters.previousLetter == 'И' || letters.previousLetter == 'Ю' || letters.previousLetter == 'Ы' ||
                letters.previousLetter == 'О' || letters.previousLetter == 'Э' || letters.previousLetter == 'У')
                return "ye";
            else
                return "e"; 
        }

        //Check if the letters are at the end of the word
        public string CheckTheEnding(AdjacentLetters letters, bool ending, ref int checker)
        {
            if ((ending && letters.letter == 'и' && letters.nextLetter == 'й') ||
                (ending && letters.letter == 'И' && letters.nextLetter == 'Й'))
            {
                checker++;
                return "iy";
            }
            if ((letters.nextLetter != 'й' && letters.letter == 'и')||(letters.nextLetter != 'Й' && letters.letter == 'И'))
                return "i";

            if ((ending && letters.letter == 'ы' && letters.nextLetter == 'й')||
                (ending && letters.letter == 'Ы' && letters.nextLetter == 'Й'))
            {
                checker++;
                return "iy";
            }
            if ((!ending && letters.letter == 'ы')|| (!ending && letters.letter == 'Ы'))
                return "y";

            if ((ending && letters.letter == 'ь' && letters.nextLetter == 'я')||
                (ending && letters.letter == 'Ь' && letters.nextLetter == 'Я'))
            {
                checker++;
                return "ia";
            }     
            else
                return "";
        }
    }
}
