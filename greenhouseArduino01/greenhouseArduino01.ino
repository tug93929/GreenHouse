

#include "dht.h"
#define INPUT_SIZE 30
#define dht_apin A2 
dht DHT;

//char windowsData[INPUT_SIZE + 1];
String windowsData;
int x;                              //transmitted data

char reading;                       //the vairable read from the reciever port
bool wasInit;                       //tells us whether the initalizer has been sent

/*LEDs used for debugging the arduino code
 * 
 */
int startUpLed = 2;                 //led that determines if the arduino is in the set up 
int loopLed = 3;                    //led that determines if the arduino is in the loop
int cust = 4;                       //led that determines if the arduino is in the customize function
int pre = 5;                        //led that determines if the arduino is in the preset function  
int bleh = 13;         

int PhotoResistor = A0;
int SoilMoisture = A1;


int PhotoFeedbackThreshold;
int SoilFeedbackThreshold;
int TemperatureFeedbackThreshold;
int HumidityFeedbackThreshold;

void setup() {
  pinMode(PhotoResistor,INPUT);     //sets up photoresistor
  pinMode(SoilMoisture,INPUT);      //sets up soil moisture sensor
  

  /*
   * Sets up the LEDs as outputs
   */
  pinMode(startUpLed, OUTPUT);  
  pinMode(loopLed, OUTPUT);
  pinMode(cust, OUTPUT);
  pinMode(pre, OUTPUT);
  pinMode(bleh, OUTPUT);

  /*
   * Sets the default values for LEDs
   */
  digitalWrite(cust , HIGH);
  digitalWrite(pre,HIGH);
  digitalWrite(startUpLed,HIGH);
  digitalWrite(loopLed, LOW);
  digitalWrite(bleh, LOW);

  x=0;                              //sets the dummy transmission
  reading = '0' ;                   //initializes the recieved value to '0'
  wasInit = false;                  //sets the initializer to false 
  Start_Up();                        //Runs the start up function

}

void Start_Up(){
  Serial.begin(9600);               //starts the reciever serial connection
  Serial1.begin(9600);              //starts the transmitter serial connection
  wasInit = false;
  String serialDataIn;
  int counter = 0;
  char inbyte;

  while(!wasInit){
    if(Serial.available()){
        inbyte = Serial.read();

        if (inbyte == ':'){  // Handle delimiter
            Serial1.println(String(serialDataIn));    
            FindVariableThreshold(counter, serialDataIn);
            serialDataIn = String("");
            counter = counter + 1;
        }
        else if(counter > 3){  // end of line
               // handle end of line a do something with data
               Serial1.println("Setup is Complete");
               wasInit = true;
        }  
        else{
               serialDataIn += inbyte;
        }
    }
  }
}

void FindVariableThreshold(int counter, String serialDataIn){
  switch(counter){
                case(0):
                        PhotoFeedbackThreshold = serialDataIn.toInt();
                        Serial1.println(PhotoFeedbackThreshold);
                case(1):
                        
                        HumidityFeedbackThreshold = serialDataIn.toInt();
                        Serial1.println(HumidityFeedbackThreshold);     
                case(2):
                        TemperatureFeedbackThreshold = serialDataIn.toInt();
                        Serial1.println(TemperatureFeedbackThreshold);
                case(3):
                        SoilFeedbackThreshold = serialDataIn.toInt();
                        Serial1.println(SoilFeedbackThreshold);

  }
}


void loop() {
  digitalWrite(startUpLed, LOW);                            //truns off the start up led
  digitalWrite(loopLed, HIGH);                              //turn on the loop led

//read from sensors
   int photoReading = analogRead(PhotoResistor); 
   photoReading = map(photoReading,0,1023,0,100);

   DHT.read11(dht_apin);
   int humidity = DHT.humidity;
   int temperature = DHT.temperature;
   
   int soilMoisture = analogRead(SoilMoisture);
   soilMoisture = Soil_ConvertToPercent(soilMoisture);

//Conditionals for control system
   if(photoReading < PhotoFeedbackThreshold){
     
   }else{
    
   }
   
   if(humidity < HumidityFeedbackThreshold){
     
   }else{
    
   }

   if(temperature < TemperatureFeedbackThreshold){
     
   }else{
    
   }

   if(soilMoisture < SoilFeedbackThreshold){
     
   }else{
    
   }
  SendData(PhotoFeedbackThreshold, HumidityFeedbackThreshold,TemperatureFeedbackThreshold,SoilFeedbackThreshold);

 //conditional for stopping data aquisition
  if(Serial.read() == 's'){           //if the user tried to communicate with the arduino via the transmitter bus and send 's' (stop)
    digitalWrite(loopLed,LOW);                              //reset loop led
    digitalWrite(cust,LOW);                                //reset custom led
    digitalWrite(pre,LOW);                                  //reset preset led
    digitalWrite(startUpLed, HIGH);                         //reset start up led
    Serial.end();
    Serial1.end();
    Start_Up();                                              //rerun the start up function and listen for further instructions from the user
  }

  
}

void SendData(int a, int b, int c, int d){
  Serial1.println(String(a)+":"+String(b)+":"+String(c)+":"+String(d)+":");
}

int Soil_ConvertToPercent(int value)
{
  int percentValue = 0;
  percentValue = map(value, 1023, 465, 0, 100);
  return percentValue;
}


/*
 * Cusomtize function 
 * Sends data via the transmitter bus
 */
void customize(){
  x++;
  //checkX();
  Serial1.println(x);
    digitalWrite(bleh, HIGH);
  //setColor(x,0,0);
}

/*
 * Preset function
 * Sends data via the transmitter bus
 */
void preset(){
  x--;
  //checkX();

  Serial1.println(x);
    digitalWrite(loopLed, LOW);
  //setColor(255,x,0);
}


void checkX(){
  if(x > 255){
    x = 0;
  }else if(x<0){
     x=255;
  }
}

