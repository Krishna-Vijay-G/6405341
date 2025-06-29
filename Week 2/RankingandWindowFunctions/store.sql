CREATE TABLE Products (
    ProductID INTEGER PRIMARY KEY,
    ProductName TEXT,
    Category TEXT,
    Price REAL
);

INSERT INTO Products (ProductName, Category, Price) VALUES
('iPhone 13',       'Electronics', 999.99),
('Galaxy S22',      'Electronics', 899.99),
('Pixel 6',         'Electronics', 899.99),
('MacBook Pro',     'Electronics', 1999.99),
('T-shirt',         'Clothing', 29.99),
('Jeans',           'Clothing', 49.99),
('Jacket',          'Clothing', 89.99),
('Sweater',         'Clothing', 89.99),
('Cookware Set',    'Home', 149.99),
('Vacuum Cleaner',  'Home', 199.99),
('Air Fryer',       'Home', 149.99);

SELECT
    ProductID,
    ProductName,
    Category,
    Price,

    ROW_NUMBER() OVER (
        PARTITION BY Category ORDER BY Price DESC
    ) AS RowNum,

    RANK() OVER (
        PARTITION BY Category ORDER BY Price DESC
    ) AS RankNum,

    DENSE_RANK() OVER (
        PARTITION BY Category ORDER BY Price DESC
    ) AS DenseRankNum

FROM Products;