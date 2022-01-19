class Fahrzeuge{

  private string kennzeichen;
  private double kilometerstand;
  private int kapazität;
  private double grundpreis;
  private double kilometerpreis;
  
  
  public Fahrzeug(string kennzeichen, double kilometerstand, int kapazität, double grundpreis, double kilometerpreis){
    this.kennzeichen = kennzeichen;
    this.kilometerstand = kilometerstand;
    this.kapazität = kapazität;
    this.grundpreis = kilometerpreis;
  }
  
  public String getKennzeichen(){
    return kennzeichen;
  }
  public void setKennzeichen(string value){
    kennzeichen = value;
  }
  
  public double getKilometerstand(){
    return kilometerstand;
  }
  public void setKilometerstand(double value){
    kilometerstand = value;
  }
  
  public int getKapazität(){
    return kapazität;
  }
  public void setKapazität(int value){
    kapazität = value;
  }
  
  public double getGrundpreis(){
    return grundpreis;
  }
  public void setGrundpreis(double value){
    grundpreis = value;
  }
  
  public double getKilometerpreis(){
    return kilometerpreis;
  }
  public void setKilometerpreis(double value){
    kilometerpreis = value;
  }
  
  public Fahrzeug(){
    kennzeichen = "PIZ-000";
    kilometerstand = 0.0;
    kapazität = 15;
    grundpreis = 2.0;
    kilometerpreis = 0.40;
  }
  
  public double berechnePreis(double strecke){
    kilometerstand += strecke;
    double preis;
    if(strecke <= 3){
      preis = (stecke - 3.0) * kilometerpreis;
      return preis;
    }
    else(){
      preis = stecke + kilometerpreis;
      return preis;
    }
    
}
