/*Author Charlie Yingling                                        Date 10/18/21
2. Write a method IntegerPower(base, exponent) that returns the value.
*/
using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Please enter Base");
     int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Please enter Exponent");
     int e = Convert.ToInt32(Console.ReadLine());
     int answer = IntegerPower(b,e);
     Console.WriteLine("{0} to the power of {1} is {2}", b,e,answer);
  }
  public static int IntegerPower(int baseNum,int expo) {
    int answer = 1;
    for(int i = 0; i < expo; i++) {
        answer *= baseNum;
    }
    return answer;
   }
  }