using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]
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
            int i;
            int j;
            int k;
            i = firstString.Length;
            j = 1;
            char[] slovo;
             var slovo1 = new StringBuilder(firstString);

            slovo = firstString.ToCharArray(0,i);

            for (k = 0; k < i; k++)
              {

                for (j = k; j < i; j++)
                    {
                    slovo1.Remove(k, 1);
                    slovo1.Insert(k, slovo[j]);
                    slovo1.Remove(j, 1);
                    slovo1.Insert(j, slovo[k]);
                      if(secondString == slovo1.ToString())
                           {
                             return true;
                           }
                    slovo1 = new StringBuilder(firstString);
                     }

                 }
            return false;
            throw new NotImplementedException();
        }


        private bool CheckRemoveCharacter(string longString, string shortString)
        {
           int i = longString.Length;
            int j;
            var slovo1 = new StringBuilder(longString);

            for (j=0;j<i;j++)
            {
                slovo1.Remove(j, 1);
                if (shortString == slovo1.ToString())
                {
                  return true;
                }

                slovo1 = new StringBuilder(longString);
            }

            return false;
            throw new NotImplementedException();
        }
    }
}