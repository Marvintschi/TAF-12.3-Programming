using System;

namespace StringOps
{

    class Aufgaben
    {
    //Aufgabe1.2
       public void aufgabe1dot2(){
        string ausgabe;
        for(int i = 0; i <liste.size();i++){
	        ausgabe += liste[i];
        }
        Console.WriteLine(ausgabe);
       }
       
       //Aufgabe1.3
       public String toString()
        {
            Steuereinheit steuereinheit = new Steuereinheit();
            Temperatursensor temperatursensor = new Temperatursensor();
            Motor motor = new Motor();
            string maschninenbezeichnnug = steuereinheit.getMaschinenbezeichnung();
            string temperatur = Convert.ToString(temperatursensor.getTemperatur());
            string motorStatus = motor.getStatus();
            return maschninenbezeichnnug + temperatur + motorStatus;
        }
        
        //Aufgabe1.4
        public void pruefeTemperatur()
        {
            Motor motor = new Motor();
            Licht licht = new Licht();
            Temperatursensor temperatursensor = new Temperatursensor();
            private List<Licht> lichterliste = new lichterliste();

            if(temperatursensor.getTemperatur() > 190)
            {
                motor.schalteAus();
                foreach(Licht l in lichterliste){
                    if(Licht.getName().Equals("temperaturLicht")){
                        Licht.schalteEin();
                    }
                }
            }
            if(temperatursensor.getTemperatur() < 190)
            {
                foreach(Licht l in lichterliste){
                    if(Licht.getName().Equals("temperaturLicht")){
                        Licht.schalteAus();
                    }
                }
            }
        }
    }
}
