// Serial Temperatura
// IFACI- Senai São Carlos 
// CSTADS
// 02/04/2025
// Autor: Cayque Lima dos Santos

int SENSOR = A0; // Define o pino analógico A0 como entrada do sensor
int D = 0; // Variável para armazenar o valor lido do sensor (0-1023)
int T = 0; // Variável para armazenar a temperatura calculada

void setup() { 
  Serial.begin(9600); // Inicia a comunicação serial com taxa de 9600 bauds
}

void loop() { 
  D = analogRead(SENSOR); // Lê o valor do sensor
  T = (D * 5.0 * 100) / 1023.0; // Converte para temperatura
  Serial.println(T); // Exibe a temperatura e pula linha

  delay(1000); // Aguarda 1 segundo antes da próxima leitura
}


int main(void) { 
  init (); //Inicializa hardware(função interna do Arduino);
  setup (); //Chama a função setup;
  for (;;) //Loop infinito;
  loop(); //Chama continuamente a função loop();

  return 0; 
}