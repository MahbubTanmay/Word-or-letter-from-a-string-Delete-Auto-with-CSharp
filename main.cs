namespace CSharp_Learning
{
  
    internal class MyClass
    {

        static void Main()
        {
            int counter=0;
            Console.WriteLine("Enter A String :");
            string str = Console.ReadLine() ?? "";

        Again:
            Console.WriteLine("Enter A String To Replace :");
            string str2 = Console.ReadLine() ?? "";



            if (str.IndexOf(str2) < 0)//if replace word not found in the targated string
            {

                Console.WriteLine("The Word u enterd to replace not found in the String");
                goto Again;

            }



        Replacer: //Start again if the program has the replaceable word multytime
            string tmp1 = "";
            string tmp2="";
            if (str.IndexOf(str2) >= 0) // Check if the string has the word we want to replace. if has then index will be 0 or greater than 0
            {
                for (int i = 0; i < str.IndexOf(str2); i++) //Part before replace word will be stored in tmp1
                {
                    tmp1 += str[i];
                }

                for (int j = str.IndexOf(str2)+str2.Length; j < str.Length; j++) //Part after replace word will be stored in tmp2
                {
                    tmp2 += str[j];
                }

                str = tmp1 + tmp2; //change the value in str and put replaced word in it
                counter++;
                goto Replacer;
            }
           else
            {
 
                Console.WriteLine("After Replacement Operation: ");
                Console.WriteLine($"Total {counter} Word/s replaced");
                Console.WriteLine( str );
            }

        }
    }




}
