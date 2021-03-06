using System;
using System.Collections.Generic;
using System.Text;

namespace StringOps
{

    class Aufgaben
    {
        public List<string> stringList = new List<string>() { "5.5 + 8", "19 % 5", "24.7 - 8.5", "5 * 6" };
        public int[] zahlen = new int[] { 3, 14, 7, 22, 19, 1, 46, 8, 55, 76 };

        /*
        Aufgabe 1: Schreibe eine Methode Berechne():void die die einzelnen Strings aus der stringListe ausliest, diese aufsplittet
        und die Rechnung und das jeweilige Ergebnis dazu ausgibt. */

        public void Main(){
            for(int i = 0; i <=3; i++){
                String[] result = stringList[i].Split(' ');
		    for(int i = 0; i <=3; i++){
			if(result[1].Contains("-")){
                   		double a = Convert.ToDouble(result[0]);
				double b = Convert.ToDouble(result[2]);
				double abc = a / b;
                        	Console.WriteLine(abc);
               		}
		        if(result[1].Contains("%")){
                    		double a = Convert.ToDouble(result[0]);
				double b = Convert.ToDouble(result[2]);
				double abc = a - b;
                        	Console.WriteLine(abc);
                	}
		        if(result[1].Contains("*")){
                    		double a = Convert.ToDouble(result[0]);
				double b = Convert.ToDouble(result[2]);
				double abc = a * b;
                   		Console.WriteLine(abc);
                	}   
			if(result[1].Contains("+")){
				double a = Convert.ToDouble(result[0]);
				double b = Convert.ToDouble(result[2]);
				double abc = a + b;
				Console.WriteLine(abc);
			} 
		    }        
            }
        
        }

        /*Aufgabe2: Schreibe ein Programm welches solange einzelne 
         * Worte einliest und zu einem String zusammenfügt bis die Eingabe 
         * „Ende“ lautet. Dann soll der String ausgegeben werden. 
         * Falls der eingelesene String dabei „Corona“ heißt, soll er nicht 
         * an den Ausgabestring angefügt werden (continue).*/
        
        public void Aufgabe2(){
            Console.WriteLine("Aufgabe 2");
            bool done = false;
            string strings = "";
            while(!done){
                string word = Console.ReadLine();
                Console.WriteLine(word);
                switch(word){
                    case "Corona":
                        continue;
                    case "Ende":
                        done = true;
                        break;
                    default:
                        string += word;
                        break;
                }
                Console.WriteLine(strings);
            }
        }


        
        /*Aufgabe 3: gib alle geraden Zahlen aus dem Array zahlen aus.*/

        public void aufgabe3(){
            foreach(int b in zahlen){
                if (b % 2 != 1){
                    Console.WriteLine(b);
                }
            }
        }

    }

}
