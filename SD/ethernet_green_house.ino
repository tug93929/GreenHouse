#include <SPI.h>
#include <Ethernet.h>
#include "dht.h"
#define dht_apin A2 
dht DHT;
int PhotoResistor = A0;
int SoilMoisture = A1;

int PhotoFeedbackThreshold = -1;
int SoilFeedbackThreshold = -1;
int TemperatureFeedbackThreshold = -1;
int HumidityFeedbackThreshold = -1;

int LightReading;
int SoilReading;
int TempReading;
int HumReading;


/*Variables For Setting up server
 * 
 * 
 */
byte mac[] = { 0x00, 0xAA, 0xBB, 0xCC, 0xDE, 0x02 };
 
IPAddress ip(10,14,174,126); //IP address for your arduino.
IPAddress server(10,14,174,106);
IPAddress gateway(10,14,174,149);
IPAddress subnet(255, 255, 255, 0);

//byte ip[] = {10,14,174,126 }; //Enter the IP of ethernet shield ARDUINO
//byte server[] = {10,14,174,106} ; //Enter the IPv4 address COMPUTER

int interrupt=0; //Variable to control the iterations of void loop().

String mod="testing"; //Variable to be written on the database.

String rcv=""; //Variable in which the server response is recorded.

int port  = 80;

EthernetClient client;


/*Variables for setting up the timer 
 * 
 * 
 */
bool TimeToRead = false;

int pastTime = 0;//the start time of program

int currentTime = 0;//the current run time of the arduino

int seconds = 0;//the current number of seconds that has past

int WaitTime  = 900;//the desired waittime

unsigned long timePassed = 0;
 
void setup()
{
  
  pinMode(PhotoResistor,INPUT);     //sets up photoresistor
  pinMode(SoilMoisture,INPUT);      //sets up soil moisture sensor
  
  Serial.begin(9600);
  
  Ethernet.begin(mac, ip, gateway, gateway, subnet);
  isConnected();
 // httpRequest();
 // WriteDataBase();

 
  //WriteOneValue();
 // httpRequest();

}


bool isConnected(){

      if (client.connect(server, port) == 1) 
      {
        Serial.println("Connection Established ");   
        client.stop();
        return true; 
      }
      else
      {
        Serial.println("Connection failed ");
      }
      return false; 
      
}

void loop() 
{
  //isConnected();
  ExecuteReading();
}

int GetTimeFromTimer(){
  
  pastTime    = currentTime; //currentTime at this point is the current time from the previous iteration, this should now be pastTime
  currentTime = millis();    //currentTime is now the current time (again)
  timePassed = timePassed + currentTime - pastTime; //this is roll-over proof, if currentTime is small, and pastTime large, the result rolls over to a small positive value, the time that has passed
  Serial.print("Time passed= ");
  Serial.println(timePassed);
     if ( timePassed >= 1000)
     { 
           seconds ++;
           pastTime = currentTime;
           timePassed = 0;
     }

     return seconds;
}

void ReadSensors(){
  
   int photoReading = analogRead(PhotoResistor); 
   LightReading = map(photoReading,0,1023,0,100);

   DHT.read11(dht_apin);
   HumReading = DHT.humidity;
   TempReading = DHT.temperature* 9.0 / 5.0 + 32.0;
   
   int soilMoisture = analogRead(SoilMoisture);
   SoilReading = Soil_ConvertToPercent(soilMoisture);

}

int Soil_ConvertToPercent(int value)
{
  int percentValue = 0;
  percentValue = map(value, 1023, 465, 0, 100);
  return percentValue;
}

void WriteOneValue(){
  if(client.connect(server, port)){
    SoilReading = 200;
    
    Serial.println("Connection Established 2");
      client.print("GET /GreenHouse/info.php?"); //GET request to write data to the database.
      client.print("soil=");
      client.print(SoilReading);
      client.println(" HTTP/1.1"); 
      client.println("Host: 10.14.174.106"); 
      client.println("Connection: close"); 
      client.println(); 
      client.println(); 
      client.stop();
   
    /*char outbuf[128];
    sprintf(outbuf,"GET /GreenHouse/SendData.php?myValue=%u HTTP/1.1", TempReading);
    client.println(outbuf);

    client.println(outbuf);
    client.println("Host: localhost");
    client.println("Connection: close");
    client.println();
    
    Serial.println("Writing Complete");
      */
        Serial.println("done");
        client.stop();
    
  }else{
    Serial.println("Writing Failed");
  }
}

void WriteDataBase(){
  
  if(client.connect(server, port)){
    
     Serial.println("Connection Established 2");
      client.print("GET /GreenHouse/info.php?"); //GET request to write data to the database.
      client.print("time=");
      client.print(currentTime);
      client.print("&temp=");
      client.print(TempReading);
      client.print("&hum=");
      client.print(HumReading);
      client.print("&light=");
      client.print(LightReading);
      client.print("&soil=");
      client.print(SoilReading);
      client.println(" HTTP/1.1"); 
      client.println("Host: 10.14.174.106"); 
      client.println("Connection: close"); 
      client.println(); 
      client.println(); 
      client.stop();
   
        Serial.println("done");
        client.stop();
    
  }else{
    Serial.println("Writing Failed");
  }

}

void ControlSystem(){
  if(LightReading < PhotoFeedbackThreshold){
     
   }else{
    
   }
   
   if(HumReading < HumidityFeedbackThreshold){
     
   }else{
    
   }

   if(TempReading < TemperatureFeedbackThreshold){
     
   }else{
    
   }

   if(SoilReading < SoilFeedbackThreshold){
     
   }else{
    
   }
}

void ResetThresholds(){
  /*
   * if(threshold has an entry)
   *    update the variables from the threshold table
   * else
   *    update the variables to presets
   */
   
  //Read Newest Entry in Database table 'thresholds'
  PhotoFeedbackThreshold = -1;
  SoilFeedbackThreshold = -1;
  TemperatureFeedbackThreshold = -1;
  HumidityFeedbackThreshold = -1;
}

bool QueryRefresh(){
  //read from query refresh table
  /*
   * if(there is a refresh)
   *  remove the refresh 
   *  return true;
   */
  return false;
}

void ExecuteReading(){
  
  Serial.print(WaitTime);
  Serial.print("-");
  Serial.println(seconds);
  if(TimeToRead){
   
    TimeToRead = false;
    Serial.println("enter reader");
    ReadSensors();
    ControlSystem();

    if(isConnected()){
        httpRequest();
        WriteDataBase(); 
     }
    Serial.println("exit writer");
  }

  if(GetTimeFromTimer() == WaitTime || QueryRefresh()){
    TimeToRead  = true;
    seconds  = 0;
  }


  ResetThresholds();
      
}


void httpRequest()
{
  String rcv = "";
  if (client.connect(server, 80)) 
  {
    Serial.println("Connection established 1");
    client.print("GET "); 
    client.print("/GreenHouse/tryjson.php/HTTP/1.1\r\n Host: localhost");
    //client.print(" 10.14.174.106");
    client.print("\r\nConnection: close\r\n\r\n"); //GET request for server response.
    unsigned long timeout = millis();
    while (client.available() == 0) 
    {
      if (millis() - timeout > 25000) //If nothing is available on server for 25 seconds, close the connection.
      { 
        return;
      }
    }
    while(client.available())
    {
      String line = client.readStringUntil('\r'); //Read the server response line by line..
      rcv+=line; //And store it in rcv.
    }
    client.stop(); // Close the connection.
  }
  else
  {
    Serial.println("Connection failed 1");
  }
  Serial.println("Received string: ");
  Serial.println(rcv); //Display the server response.
}



 

