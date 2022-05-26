using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationLibraries
{
    class PasswordValidator
    {  
        static private Byte PasswordRate = 0; 
        static private Byte CapitalLettersCount = 0;
        static private Byte SmallLettersCount = 0;
        static private Byte NumbersCount = 0;
        static private Byte SymbolsCount = 0;


        //this method will return password rate (score) (Byte Data Type)
        //PasswordFromInput : is the password that you want to rate it
        //MinPasswordLength : is the minimum length of character that must password contain it
        //
        //every password must contain at least 1 Capital Letter , 1 Small letter , 1 Symbol , 1 Number , it must not contain any space
        //and it must be more that (or eqiual) to MinPasswordLength
        static public string  checkPassword(string PasswordFromInput , Byte MinPasswordLength = 9)
        {
            try {
                Byte passwordLetterCount = (Byte)PasswordFromInput.Length;
                if (passwordLetterCount < MinPasswordLength)  throw new Exception("Password Rate = 0 , Password Must be more than 9 charackter !"); 
                
                //Because password length more than 9 character
                PasswordRate += 10;
                 
                for (Byte i = 0; i < passwordLetterCount; i++)
                {
                    char charackter = PasswordFromInput[i];

                    if (char.IsWhiteSpace(charackter)) throw new Exception("Password Rate = 0 ,  Must not contain any space");

                    if (CharackterIsNumber(charackter)) continue;
                    if (CharackterIsSymbol(charackter)) continue;
                    if (CharackterIsUpper(charackter)) continue; else CharackterIsLower(charackter);
                }
                //because password dosen't contain any space
                PasswordRate += 10;

                if (isPasswordValid())
                    return PasswordRate + "%";

                throw new Exception("Password Not Valid !");
            } catch (Exception e)
            {
                return e.Message;
            }
           
        }

        //this method will return Capital Letters Count these are in the password (Byte Data Type)
        static public Byte getCapitalLettersCount() { return CapitalLettersCount; }

        //this method will return Small Letters Count these are in the password (Byte Data Type)
        static public Byte getSmallLettersCount() { return SmallLettersCount; }

        //this method will return Numbers Count these are in the password (Byte Data Type)
        static public Byte getNumbersCount() { return NumbersCount; }

        //this method will return Symbols Count these are in the password (Byte Data Type)
        static public Byte getSymbolsCount() { return SymbolsCount; }


        static private bool CharackterIsNumber(char charackter)
        { 
            if (char.IsNumber(charackter))
            {  
                PasswordRate += NumbersCount < 2 ? (byte) 10 : (byte) 0;
                NumbersCount += 1;
                return true; 
            }
            return false; 
        }


        static private bool CharackterIsSymbol(char charackter)
        {
            if (char.IsSymbol(charackter))
            {
                PasswordRate += SymbolsCount < 2 ? (byte) 10 : (byte) 0;
                SymbolsCount += 1;
                return true; 
            }
            return false; 
        }

        static private bool CharackterIsUpper(char charackter)
        {
            if (char.IsUpper(charackter))
            {
                PasswordRate += CapitalLettersCount < 2 ? (byte)10 : (byte)0;
                CapitalLettersCount += 1;
                return true; 
            }
            return false; 
        }
        static private bool CharackterIsLower(char charackter)
        {
            if (char.IsLower(charackter))
            {
                PasswordRate += SmallLettersCount < 2 ? (byte)10 : (byte)0;
                SmallLettersCount += 1;
                return true; 
            }
            return false; 
        }

        static private bool isPasswordValid()
        {
            if (CapitalLettersCount == 0 || SmallLettersCount == 0 || NumbersCount == 0 || SymbolsCount == 0) { return false; }
            return true;
        }

    }
}
