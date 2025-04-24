#include <dht11.h>

#define DHT11PIN 4        // Pino onde o DHT11 está conectado
#define SENSOR_POT A0     // Pino do potenciômetro
#define LED 13            // LED

dht11 DHT11;              // Objeto do sensor

void setup() {
  pinMode(LED, OUTPUT);
  Serial.begin(9600);
  delay(2000);
}

void loop() {
  // Lê comandos da serial
  if (Serial.available() > 0) {
    char comando = Serial.read();
    if (comando == 'L') {
      digitalWrite(LED, HIGH);
    } else if (comando == 'D') {
      digitalWrite(LED, LOW);
    }
  }

  // Leitura do DHT11
  int chk = DHT11.read(DHT11PIN);
  int temperatura = (int)DHT11.temperature;

  // Leitura do potenciômetro
  int leituraPot = analogRead(SENSOR_POT);
  float tensao = leituraPot * 5.0 / 1023.0;

  // Envia os dados formatados
  Serial.print(temperatura);
  Serial.print(",");                
  Serial.println(tensao, 2);         


  delay(1000);
}
