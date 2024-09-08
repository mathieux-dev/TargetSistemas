// Valores de faturamento
decimal[] faturamentoDiario = [0, 1500, 2000, 0, 0, 2500, 3000, 0, 3200, 500, 0, 4000];

// Remove dias com faturamento 0
var diasComFaturamento = faturamentoDiario.Where(faturamento => faturamento > 0).ToArray();

// Calcula as métricas
decimal menorFaturamento = diasComFaturamento.Min();
decimal maiorFaturamento = diasComFaturamento.Max();
decimal mediaAnual = diasComFaturamento.Average();
int diasAcimaDaMedia = diasComFaturamento.Count(faturamento => faturamento > mediaAnual);

Console.WriteLine($"Menor faturamento: {menorFaturamento}");
Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");