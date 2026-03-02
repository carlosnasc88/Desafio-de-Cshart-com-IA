decimal temperaturaCelsius = 26.8m;

//calcule

double temperaturaFahrenhet = (decimal.ToDouble(temperaturaCelsius) * 9 / 5) + 32;
int temperaturaInteira = temperaturaCelsius > 0 ? (int)temperaturaCelsius : (int)temperaturaCelsius - 1;

Console.WriteLine($"A temperatura de {temperaturaCelsius}°C corresponde a {temperaturaFahrenhet}°F. A parte interira em Celsius é {temperaturaInteira}°C ");