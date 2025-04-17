// Definindo os pinos
int SENSOR_TEMP = 4;   // Sensor de temperatura conectado
int SENSOR_POT = A0;   // Potenciômetro conectado ao pino A1
int LED = 13; 

float D = 0;           // Leitura do sensor de temperatura
int T = 0;             // Temperatura em Celsius
int P = 0;             // Valor bruto do potenciômetro
float V = 0;           // Voltagem do potenciômetro

void setup() {
  Serial.begin(9600);   
  delay(2000);          
  Serial.println("Leitura de Temperatura e Potenciômetro Iniciada");
}

void loop() {

    // Verifica se recebeu comando via serial
  if (Serial.available() > 0) {
    char comando = Serial.read();
    if (comando == 'L') {
      digitalWrite(LED, HIGH);  // Liga o LED
    } 
    else if (comando == 'D') {
      digitalWrite(LED, LOW);   // Desliga o LED
    }
  }
  
  D = analogRead(SENSOR_TEMP);  
  T = (D * 5.0 * 100.0) / 1023.0;

  if (T > 120) {
    T = 120;
  }

  P = analogRead(SENSOR_POT);
  V = (P * 5.0) / 1023.0;  // Conversão para volts

  Serial.print(T);         // Temperatura
  Serial.print(", ");
  Serial.println(V, 2);    // Potenciômetro em volts, com 2 casas decimais
  
  delay(1000);
}


