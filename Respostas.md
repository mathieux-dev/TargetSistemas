# Respostas

1. O valor final de SOMA será **77**.

2. **Sequências e Lógicas**:

   2.a) **Lógica**: Números ímpares ou { n, n + 2 }.  
   **Próximo valor**: 9.

   2.b) **Lógica**: O dobro do anterior ou { n, n * 2 }.  
   **Próximo valor**: 72.

   2.c) **Lógica**: Cada número é quadrado dos números inteiros { 0², 1², 2², 3², 4², 5², 6² }.  
   **Próximo valor**: 7² = 49.

   2.d) **Lógica**: Cada número é o quadrado de um número par crescente { 2², 4², 6², 8² }.  
   **Próximo valor**: 10² = 100.

   2.e) **Lógica**: Sequência de Fibonacci, onde cada número é a soma dos dois números anteriores { n1, n2, (n1 + n2) }.  
   **Próximo valor**: 13 = 8 + 5.

   2.f) **Lógica**: Cada número começa com "d".  
   **Próximo valor**: 200.

3. [Código no GitHub - Target Sistemas](https://github.com/mathieux-dev/TargetSistemas/blob/main/Target.BE/Program.cs)

4. [Repositório no GitHub - Cadastro Cliente](https://github.com/mathieux-dev/TargetSistemas/tree/main/CadastroCliente)

5. **Análise do Encontro dos Veículos**:

   Para determinar qual veículo estará mais próximo de Ribeirão Preto no momento em que se cruzarem:

   1. **Tempo para o encontro**:
      - Velocidade relativa dos veículos: \( 170 \, \text{km/h} \) (soma das velocidades).
      - Tempo até o encontro: \( \frac{125 \, \text{km}}{170 \, \text{km/h}} \approx 44,1 \, \text{min} \).

   2. **Atraso do carro devido aos pedágios**:
      - Carro leva 15 minutos adicionais.
      - Tempo total do carro: \( 44,1 \, \text{min} + 15 \, \text{min} = 59,1 \, \text{min} \).

   3. **Distâncias percorridas**:
      - **Carro**: \( 90 \, \text{km/h} \times \frac{59,1 \, \text{min}}{60} \approx 97,65 \, \text{km} \) de Ribeirão Preto.
      - **Caminhão**: \( 80 \, \text{km/h} \times \frac{44,1 \, \text{min}}{60} \approx 58,8 \, \text{km} \) de Barretos, ou \( 125 - 58,8 = 66,2 \, \text{km} \) de Ribeirão Preto.

   **Conclusão**: O caminhão estará mais próximo de Ribeirão Preto.
