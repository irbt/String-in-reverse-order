//Given a string, write a method that prints it in reverse order.
using System;


namespace Program{
    class StringInReverseOrderRecursionTask{
            static string StringInReverseOrderRecursion(string str){
                
                 return str.Length >0 ? str[str.Length - 1] + StringInReverseOrderRecursion( str.Substring(0, str.Length-1) ) : str;
            }
        static void Main(string [] args){
            
            Console.WriteLine(StringInReverseOrderRecursion("abcde"));// → "edcba"
            Console.WriteLine(StringInReverseOrderRecursion("Sed lectus est, elementum ut urna eu"));// → "ue anru tu mutnemele ,tse sutcel deS"
        }
    }
}