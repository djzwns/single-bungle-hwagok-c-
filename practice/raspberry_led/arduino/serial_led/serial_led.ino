#define BAUD 19200
#define LED1 2
#define LED2 3
#define LED3 4
#define SW  7
#define RATE 1000

boolean commandEnd = false;
char buffer[255] = { 0 };
int rxLen = 0;

void doRecv()
{
  int size = Serial.available();
  if (size > 0) {
    char readData = Serial.read();
    for (int i = 0; i < size; ++i) 
    {
      char b = *(&readData + i);
      Serial.print(b);
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
      Serial.write(buffer);
      digitalWrite(LED1, buffer[1] == '1');
      digitalWrite(LED2, buffer[2] == '1');
      digitalWrite(LED3, buffer[3] == '1');
      commandEnd = false;
      rxLen = 0;
    }
  }
}

void setup() {
  Serial.begin(BAUD);
  pinMode(LED1, OUTPUT);
  pinMode(LED2, OUTPUT);
  pinMode(LED3, OUTPUT);
  pinMode(SW, INPUT);
}

void loop() {
  doRecv();

  if (digitalRead(SW))
  {
    Serial.write("[111]");
  }
}
