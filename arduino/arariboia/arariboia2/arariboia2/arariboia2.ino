#include <Servo.h>

String data;
char d1;
String x;
int servoval;
int ledval;
Servo s1;
unsigned long lastDebounceTime = 0;
unsigned long debounceDelay = 5;
int buttonState;
int lastButtonState = HIGH;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(13,OUTPUT);
  pinMode(3 ,OUTPUT); //RED
  pinMode(4 ,INPUT_PULLUP);
  pinMode(5 ,OUTPUT); //GREEN
  pinMode(6, OUTPUT); //YELLOW
  s1.attach(9);     // make output 9 the servo chanel
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available()){
    data = Serial.readString();
    d1 = data.charAt(0);
    switch(d1){              //select action based upon first character
      case 'A':             // first character is an A = turn on pin 13 led
      digitalWrite(13 , HIGH);
      break;
      case 'a':             //first character is an a = turn off
      digitalWrite(13, LOW);
      break;
      case 'S':              //first character is an S = servo angle
      x = data.substring(1);
      servoval = x.toInt();
      s1.write(servoval);
      delay(100);  // wait for servo to finish
      break;
      case 'R':      //set the red LED intensity
      x = data.substring(1);
      ledval = x.toInt();
      analogWrite(3, ledval);
      break;
      case 'G':      //set the GREEN LED intensity
      x = data.substring(1);
      ledval = x.toInt();
      analogWrite(5, ledval);
      break;
      case 'Y':      //set the YELLOW LED intensity
      x = data.substring(1);
      ledval = x.toInt();
      analogWrite(6, ledval);
      break;
      
    }
  }
  HandleButton();
  HandlePot();
}

void HandleButton(void){  //function provides simple button debounce
  int reading = digitalRead(4);

  if(reading != lastButtonState){ //switch changed state
    lastDebounceTime = millis();  // reset debouncing timer - millis()
  }
  if((millis() - lastDebounceTime) > debounceDelay){  // wait fot the debouce time
    if(reading != buttonState){  // if the button state has changed;
      buttonState = reading;
      if(buttonState == HIGH){ //send data if button state is high
        Serial.println("p");
        
      }
    }
  }
  lastButtonState = reading;  //save the reading for use next time through
}

void HandlePot(void){
  String val;
  static int old = 0;
  int current = 0,upper,lower;
  current = analogRead(A0);
  upper = current + 2;
  lower = current - 2;
  if(current != old){
    if((old <= lower) || (old >=upper)){
      val = String(current);
      Serial.print("v");
      Serial.println(val);
      old = current;
    }
  }
}
