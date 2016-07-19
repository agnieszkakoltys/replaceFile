using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace replaceFile
{
    public class myCollection 
    {
        virtual public void createException()
        {
                       var textToReplace = " \n\n Akustyka to dział fizyki i techniki obejmujący zjawiska\n związane";
           textToReplace = textToReplace + "z powstawaniem, propagacją i oddziaływaniem\n fal akustycznych.";
           textToReplace = textToReplace + "Ze względu na różnorodność działów\n akustyka jest obecnie traktowana";
           textToReplace = textToReplace + "jako nauka\n interdyscyplinarna obejmująca oprócz akustyki ogólnej,\n";
           textToReplace = textToReplace + " zajmującej się zagadnieniami podstawowymi,\n również szereg działów akustyki";
           textToReplace = textToReplace +"stosowanej,\n zajmujących się praktycznym zastosowaniem zjawisk\n akustycznych.";
           
            try
            {
                textToReplace = textToReplace.Replace("ą", "a");
                textToReplace = textToReplace.Replace("ć", "c");
                textToReplace = textToReplace.Replace("ę", "e");
                textToReplace = textToReplace.Replace("ł", "l");
                textToReplace = textToReplace.Replace("ń", "n");
                textToReplace = textToReplace.Replace("ś", "s");
                textToReplace = textToReplace.Replace("ó", "o");
                textToReplace = textToReplace.Replace("ż", "z");
                textToReplace = textToReplace.Replace("ź", "z");
            }
            catch
            {
                Console.WriteLine("Proba zamiany nie powiodla sie.");
            }
         //collection
            var myVariable = new List<string>();
            myVariable.Add("\n\nText do zmiany:\n");
            myVariable.Add(" \n\n Akustyka to dział fizyki i techniki obejmujący zjawiska\n związane");
            myVariable.Add("z powstawaniem, propagacją i oddziaływaniem\n fal akustycznych.");
            myVariable.Add("Ze względu na różnorodność działów\n akustyka jest obecnie traktowana");
            myVariable.Add("jako nauka\n interdyscyplinarna obejmująca oprócz akustyki ogólnej,\n");
            myVariable.Add("zajmującej się zagadnieniami podstawowymi,\n również szereg działów akustyki");
            myVariable.Add("stosowanej,\n zajmujących się praktycznym zastosowaniem zjawisk\n akustycznych.");
            myVariable.Add("\n\n\nText po zamianie:\n");
            myVariable.Add(textToReplace);
            // Iterate through the list.
            foreach (var myVariables in myVariable)
            {
                Console.Write(myVariables + " ");
            }
            System.IO.File.WriteAllText(@"C:\Users\Aga\Desktop\replaceFile\WriteText.txt", textToReplace);
        }    
    }
}
