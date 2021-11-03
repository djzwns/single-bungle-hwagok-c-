#include <stdio.h>
#include <DHT11.h>
#define DHTPIN A0
#define LED1 13
#define LED2 12
#define LED3 11
#define SW1 2
#define SW2 3

DHT11 dht11(DHTPIN);
char buf[50];

bool messageEnd = false;
char rxBuf[255] = { 0 };
int rxLen = 0;

long time = millis();
void doRecv()
{
  int size = Serial.available();
  if (size > 0) {
    char readData = Serial.read();
    for (int i = 0; i < size; ++i) 
    {
      char b = *(&readData + i);
      switch(rxLen) 
      {
        case 0:
          if (b == '[')
          {
            rxBuf[rxLen++] = b;
          }
        break;

        default:
          rxBuf[rxLen++] = b;
          if (b == ']')
            messageEnd = true;
        break;
      }
    }

    if (messageEnd == true)
    {
      //Serial.write(buffer);
      messageEnd = false;
      if (rxBuf[3] == '0')
        digitalWrite(LED1, !digitalRead(LED1));
      else if (rxBuf[3] == '1')
        digitalWrite(LED2, !digitalRead(LED2));
      else if (rxBuf[3] == '2')
        digitalWrite(LED3, !digitalRead(LED3));
      memset(rxBuf, 0, rxLen);
      rxLen = 0;
    }
  }
}

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(LED1, OUTPUT);
  pinMode(LED2, OUTPUT);
  pinMode(LED3, OUTPUT);
  pinMode(SW1, INPUT);
  pinMode(SW2, INPUT);
}

void loop() {
  doRecv();
  
  if (time + 500 >= millis())
  {
    time = millis();
    float humi, temp;
  
    if (dht11.read(temp, humi) == 0)
    {
      String message = "[0," + String(digitalRead(LED1)) + "," + String(digitalRead(LED2)) + "," + String(digitalRead(LED3)) + "," + String(digitalRead(SW1)) + "," + String(digitalRead(SW2)) + "," + String(humi, 1) + "," + String(temp,1) + "]";
      message.toCharArray(buf, message.length() + 1);
      Serial.write(buf);
    }
  }
}
