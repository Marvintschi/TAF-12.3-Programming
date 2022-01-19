class Fahrzeuge{

  private string kennzeichen;
  private double kilometerstand;
  private int kapazität;
  private double grundpreis;
  private double kilometerpreis;
  
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
  
  

}
