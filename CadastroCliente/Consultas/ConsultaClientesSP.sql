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
