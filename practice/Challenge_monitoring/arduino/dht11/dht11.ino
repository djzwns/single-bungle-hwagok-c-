#include <stdio.h>
#include <DHT11.h>
#define DHTPIN A0

DHT11 dht11(DHTPIN);
char buf[50];

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  delay(500);
  float humi, temp;
  //dht11.read(humi, temp);
  if (dht11.read(humi, temp) == 0)
  {
    String message = "[" + String(humi, 1) + "," + String(temp,1) + "]";
    message.toCharArray(buf, message.length() + 1);
    Serial.write(buf);
  }
}
