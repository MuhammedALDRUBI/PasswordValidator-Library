# PasswordValidator-Lirary
PasswordValidator Class - By C#


#usable methodes :

## Note : Don't forget to use ValidationLibraries namespace 

## checkPassword(string PasswordFromInput , Byte MinPasswordLength = 9)
- this method will return password rate (score) (Byte Data Type)
- PasswordFromInput : is the password that you want to rate it
- MinPasswordLength : is the minimum length of character that must password contain it
        
- every password must contain at least 1 Capital Letter , 1 Small letter , 1 Symbol , 1 Number , it must not contain any space
and it must be more that (or eqiual) to MinPasswordLength

<hr>

## getCapitalLettersCount()
- this method will return Capital Letters Count these are in the password (Byte Data Type)

<hr>

## getSmallLettersCount()
- this method will return Small Letters Count these are in the password (Byte Data Type)

<hr>

## getNumbersCount()
- this method will return Numbers Count these are in the password (Byte Data Type)

<hr>

## getSymbolsCount()
- this method will return Symbols Count these are in the password (Byte Data Type)


<hr>

For Example :
here is the Main Method code (that is found in Program Class that is found in any c# template):

<code>
        
        
        
        
        
         static void Main(string[] args)
        {  
            Console.WriteLine("Write Your Password !");
            string PasswordFromInput = Console.ReadLine();
            string PasswordRate = PasswordValidator.checkPassword(PasswordFromInput);

            Byte CapitalLettersCount = PasswordValidator.getCapitalLettersCount(),
                   SmallLettersCount = PasswordValidator.getSmallLettersCount(),
                   NumbersCount = PasswordValidator.getNumbersCount(),
                   SymbolsCount = PasswordValidator.getSymbolsCount();
             
            Console.WriteLine("Password Rate : " + PasswordRate);
            Console.WriteLine("Capital Letters Count = " + CapitalLettersCount);
            Console.WriteLine("Small Letters Count = " + SmallLettersCount);
            Console.WriteLine("Numbers Count = " + NumbersCount);
            Console.WriteLine("Symbols Count = " + SymbolsCount);
        }       
        
        
        
        
        
 <code>
