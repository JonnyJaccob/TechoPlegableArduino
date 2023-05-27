#include <SoftwareSerial.h>

const int motorPinCerrar = 2;
const int motorPinAbrir = 8;
bool Abierto = true;
bool Cerrado = false;
int umbralMax = 32;  // Umbral máximo de temperatura
int umbralMin = 26;  // Umbral mínimo de temperatura

SoftwareSerial serial(10, 11);  // RX, TX (puertos 10 y 11 del Arduino)

void setup() {
  Serial.begin(9600);
  serial.begin(9600);  // Inicia la comunicación serie con la aplicación en C#
  pinMode(motorPinCerrar, OUTPUT);
  digitalWrite(motorPinCerrar, HIGH);
  pinMode(motorPinAbrir, OUTPUT);
  digitalWrite(motorPinAbrir, HIGH);
}

void loop() {
  int value = analogRead(A0);
  float volts = (value * 5) / 1023.0;
  float celsius = volts * 100;

  Serial.print(celsius);
  Serial.println(" C");

  serial.print(celsius);  // Envía los datos de temperatura a través de la comunicación serie

  if (celsius >= umbralMax && Abierto) { // Variable que cambia desde C#
    digitalWrite(motorPinCerrar, LOW);
    delay(1000);
    digitalWrite(motorPinCerrar, HIGH);
    Serial.println("Se cerro");
    Abierto = false;
    Cerrado = true;
  }

  if (celsius <= umbralMin && Cerrado) { // UmbralMin que cambie desde C#
    digitalWrite(motorPinAbrir, LOW);
    delay(3000);
    digitalWrite(motorPinAbrir, HIGH);
    Serial.println("Se abrio");
    Abierto = true;
    Cerrado = false;
  }

  delay(4000);
}
