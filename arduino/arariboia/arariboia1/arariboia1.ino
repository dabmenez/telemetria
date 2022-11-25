#include <Servo.h> //biblioteca do servo

String data; //pegar a primeira string transmitida pelo pc
char d1; //variável para a string
String x; // pegar a informação do angulo do servo do pc
int servoval; //o valor do angulo
int ledval; // valor do led
Servo s1; // referencia para o servo

unsigned long lastDebounceTime = 0;
unsigned long debounceDelay = 5;
int buttonState;
int lastButtonState = HIGH;


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(13, OUTPUT);
  pinMode(3, OUTPUT);  //led vermelho
  pinMode(4, INPUT_PULLUP);
  pinMode(5, OUTPUT);  // led verde
  pinMode(6, OUTPUT); //led azul
  
  s1.attach(9); //make output 9 the servo channel
  
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available()){
    data = Serial.readString();
    d1 = data.charAt(0);
    switch(d1){
      case 'A': // A= liga o pin13 led
      digitalWrite(13,HIGH);
      break;
      case 'a': // a= desliga o led do pin13
      digitalWrite(13,LOW);
      break;
      case 'S': // S= angulo do servo
      x = data.substring(1);
      servoval = x.toInt();
      s1.write(servoval);
      delay(100); // esperar o servo terminar
      break;
      case 'R': //intensidade do LED vermelho
      x= data.substring(1);
      //printf(x);
      ledval = x.toInt();
      analogWrite(3, ledval);
      break;
      case 'G': //intensidade do LED vermelho
      x= data.substring(1);
      //printf(x);
      ledval = x.toInt();
      analogWrite(5, ledval);
      break;
      case 'B': //intensidade do LED vermelho
      x= data.substring(1);
      //printf(x);
      ledval = x.toInt();
      analogWrite(6, ledval);
      break;
    }
  }
  HandleButton();
  HandlePot();
}

void HandleButton(void){

  int reading = digitalRead(4);

  if (reading != lastButtonState){
    lastDebounceTime = millis();
  }

  if ((millis() - lastDebounceTime) > debounceDelay){
    if ( reading != buttonState){
      buttonState = reading;
      if (buttonState == HIGH){
        Serial.println("p");
      }
    }
  }
  lastButtonState = reading;
}


void HandlePot(void){
  String val;
  static int old = 0;
  int current = 0, upper, lower;
  current = analogRead(A0);
  upper = current+2;
  lower = current -2;
  if(current != old){
    if((old <= lower) || (old >= upper)){
      val = String(current);
      Serial.print("v");
      Serial.println(val);
      old = current;
    }
  }
}
