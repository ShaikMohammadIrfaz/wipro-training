CREATE PROCEDURE CheckProductExists
    @ProductID INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Products WHERE ProductID = @ProductID)
    BEGIN
        PRINT 'Product exists'
    END
    ELSE
    BEGIN
        PRINT 'Product not found'
    END
END

EXEC CheckProductExists @ProductID = 101;
