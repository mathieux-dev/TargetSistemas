# Modelo de Banco de Dados para Cadastro de Clientes

## Descrição

Este README descreve o modelo lógico do banco de dados criado para um sistema de cadastro de clientes. O modelo cobre a gestão de clientes, seus telefones, tipos de telefone e estados brasileiros.

## O que foi feito

1. **Tabelas Criadas**:
   - **Clientes**: Armazena informações sobre os clientes, incluindo a razão social e o estado em que estão localizados.
   - **Telefones**: Armazena os números de telefone associados a cada cliente, com referência ao tipo de telefone.
   - **TipoTelefone**: Define os diferentes tipos de telefone (e.g., comercial, residencial, celular).
   - **Estados**: Contém informações sobre os estados brasileiros, incluindo a sigla e o nome completo.

2. **Relacionamentos**:
   - **Clientes** está relacionado a **Estados** através da chave estrangeira `EstadoID`.
   - **Telefones** está relacionado a **Clientes** através da chave estrangeira `ClienteID` e a **TipoTelefone** através da chave estrangeira `TipoTelefoneID`.

## Diagrama do Modelo

Abaixo está a imagem do diagrama do modelo lógico do banco de dados:

![Diagrama do Modelo](./Modelagem/Cadastro%20Clientes.png)

## Consulta SQL

Para buscar o código, a razão social e os telefones de todos os clientes do estado de São Paulo (código “SP”), utilize a seguinte consulta SQL:

```sql
SELECT 
    c.ID AS CodigoCliente, 
    c.RazaoSocial, 
    t.Numero AS Telefone
FROM 
    clientes c
JOIN 
    estados e ON c.EstadoID = e.ID
JOIN 
    telefones t ON c.ID = t.ClienteID
WHERE 
    e.Sigla = 'SP';
```

Esta consulta faz o seguinte:
- Realiza **JOIN** entre as tabelas `clientes`, `estados` e `telefones`.
- Filtra os resultados para incluir apenas os clientes localizados no estado de São Paulo (`Sigla = 'SP'`).
- Retorna o código do cliente, a razão social e os números de telefone associados a cada cliente.
