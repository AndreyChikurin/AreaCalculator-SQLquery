SELECT p.Name, c.Name
FROM ProductCategory pc
JOIN Category c ON pc.CategoryId = c.Id
RIGHT JOIN Products p ON pc.ProductId = p.Id