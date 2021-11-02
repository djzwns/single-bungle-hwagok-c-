#define BAUD 19200
#define LED1 2
#define LED2 3
#define LED3 4
#define SW1  6
#define SW2  7
#define RATE 1000

boolean commandEnd = false;
char buffer[255] = { 0 };
// 1: start, 2-4: LED, 5-6: SW, 7: CS
char status[] = "[0000000]";
int rxLen = 0;

long currentTime = millis();
long prevTime = millis();

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
            buffer[rxLen++] = b;
          }
        break;

        default:
          buffer[rxLen++] = b;
          if (b == ']')
            commandEnd = true;
        break;
      }
    }

    if (commandEnd == true)
    {
      //Serial.write(buffer);
      commandEnd = false;
      rxLen = 0;
      
      if (buffer[1] - 48 != 0)
        return;
        
      int size = (buffer[2] - 48) + (buffer[3] - 48) + (buffer[4] - 48);
      if (size != (buffer[7] - 48))
        return;
        
      digitalWrite(LED1, buffer[2] == '1');
      digitalWrite(LED2, buffer[3] == '1');
      digitalWrite(LED3, buffer[4] == '1');
    }
  }
}

void setup() {
  Serial.begin(BAUD);
  pinMode(LED1, OUTPUT);
  pinMode(LED2, OUTPUT);
  pinMode(LED3, OUTPUT);
  pinMode(SW1, INPUT);
  pinMode(SW2, INPUT);
}

void loop() {
  
  doRecv();

//  if (digitalRead(SW1))
//  {
//    Serial.write("[00202]");
//    delay(500);
//  }
//  
//  if (digitalRead(SW2))
//  {
//    Serial.write("[00303]");
//    delay(500);
//  }

  currentTime = millis();
  if (currentTime - prevTime > 500)
  {
    prevTime = currentTime;
    byte led1 = digitalRead(LED1);
    byte led2 = digitalRead(LED2);
    byte led3 = digitalRead(LED3);
    byte sw1 = digitalRead(SW1);
    byte sw2 = digitalRead(SW2);
    status[2] = led1 + '0';
    status[3] = led2 + '0';
    status[4] = led3 + '0';
    status[5] = sw1 + '0';
    status[6] = sw2 + '0';
    status[7] = (led1 + led2 + led3 + sw1 + sw2) + '0';
    Serial.write(status);
  }
}
