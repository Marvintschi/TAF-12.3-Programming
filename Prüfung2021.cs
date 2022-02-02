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

        public void aufgabe15(){
            Motor motor = new Motor();
            string Status = motor.getStatus();
            string[] rückgabe = Status.Split(':', '-');
            //Ölstand prüfen
            if(Convert.ToInt32(rückgabe[1]) < 30){
                motor.schalteAus();
            }
            //Wasserstand prüfen
            if(Convert.ToInt32(rückgabe[3]) < 15){
                motor.schalteAus();
            }

        }

        public double aufgabe16(int value){
            return (value * 1.8) + 32;
        }

        public double aufgabe17(){
            Temperatursensor temperatursensor = new Temperatursensor();
            double temperaturenD = 0;
            int[] temperaturen = temperatursensor.getTemperaturen();
            for(int i = 0; i < temperaturen.Lengh(); i ++){
                temperaturenD += temperaturen[i];
            }
            return temperaturenD/temperaturen.Lenght();
        }

        public double aufgabe18(){
            int[] temperaturen = temperatursensor.getTemperaturen();
            Array.Sort(temperaturen);
            return temperaturen[temperaturen.Lenght()];
        }

        objekt sender

        Button btn = (Button) sender;
    }
}
