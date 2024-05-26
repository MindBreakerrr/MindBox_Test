CREATE TABLE Products
(
    Id INT PRIMARY KEY IDENTITY,
    ProductName VARCHAR(30),
	UNIQUE(ProductName)
);

INSERT INTO Products VALUES ('Карп'), ('Камбала'), ('Краб'), ('Молоко')

CREATE TABLE Categories
(
    Id INT PRIMARY KEY IDENTITY,
    CategoryName VARCHAR(30),
	UNIQUE(CategoryName)
);

INSERT INTO Categories VALUES ('Рыба'), ('Морепродукты'), ('Ракообразные')

CREATE TABLE ProductCategories
(
	ProductsId INT,
	CategoriesId INT,
    FOREIGN KEY (ProductsId)  REFERENCES Products (Id),
    FOREIGN KEY (CategoriesId)  REFERENCES Categories (Id)
)

INSERT INTO ProductCategories VALUES (1, 1), (2, 1), (3, 2), (3, 3)

SELECT Products.ProductName, Categories.CategoryName
FROM Products 
LEFT JOIN ProductCategories ON ProductCategories.ProductsId = Products.Id
LEFT JOIN Categories ON Categories.Id = ProductCategories.CategoriesId