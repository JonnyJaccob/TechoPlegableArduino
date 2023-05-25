#include <SoftwareSerial.h>

const int motorPinAbrir = 2;
const int motorPinCerrar = 3;
bool Abierto = true;
bool Cerrado = false;
int umbralMax = 32;  // Umbral máximo de temperatura
int umbralMin = 20;  // Umbral mínimo de temperatura

SoftwareSerial serial(10, 11);  // RX, TX (puertos 10 y 11 del Arduino)

void setup() {
  Serial.begin(9600);
  serial.begin(9600);  // Inicia la comunicación serie con la aplicación en C#
  pinMode(motorPinAbrir, OUTPUT);
  pinMode(motorPinCerrar, OUTPUT);
}

void loop() {
  int value = analogRead(A0);
  float volts = (value * 5) / 1023.0;
  float celsius = volts * 100;

  Serial.print(celsius);
  Serial.println(" C");

  serial.print(celsius);  // Envía los datos de temperatura a través de la comunicación serie

  if (celsius >= umbralMax && Abierto) { //Variable que cambia desde c#
    analogWrite(motorPinAbrir, 150);
    delay(1000);
    analogWrite(motorPinAbrir, 0); 
    Serial.println("Se cerro");
    Abierto = false;
    Cerrado = true;
  }

  if (celsius <= umbralMin && Cerrado) { //umbralMin que cambie desde c#
    analogWrite(motorPinAbrir, 150);
    delay(1000);                    
    analogWrite(motorPinAbrir, 0);
    Serial.println("Se abrio");
    Abierto = true;
    Cerrado = false;
  }

  delay(2000);
}
