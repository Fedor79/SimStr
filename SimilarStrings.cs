using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview
{
    /* Задача:

    Две различные строки называются похожими, если одну можно получить из другой удалением одного символа или 
    заменой местами двух символов (не обязательно соседних).

    Например, строка "korova" похожа на строки "kovora", "krova" и "korovan" и не похожа на строки "karova", "orov" и "okroav".

    Даны две различные непустые строки, состоящие из строчных латинских букв. Нужно определить, являются ли они похожими.

    Пример использования:
    var result = new SimilarStringsChecker().CheckStrings("korova", "vorona");

    Для проверки решения необходимо запустить тесты.
   */

    public class SimilarStringsChecker
    {
        public bool CheckStrings(string first, string second)
        {
            if (first.Length == second.Length)
                return CheckSwapTwoCharacters(first, second);
            if (first.Length == second.Length + 1)
                return CheckRemoveCharacter(first, second);
            if (first.Length == second.Length - 1)
                return CheckRemoveCharacter(second, first);
            return false;
        }

        private bool CheckSwapTwoCharacters(string firstString, string secondString)
        {
            throw new NotImplementedException();
        }

        private bool CheckRemoveCharacter(string longString, string shortString)
        {
            throw new NotImplementedException();
        }
    }
}