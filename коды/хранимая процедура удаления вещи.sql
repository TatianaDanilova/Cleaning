CREATE PROCEDURE DeleteThing
    @name NVARCHAR(100) -- параметр name
AS
BEGIN
    -- Удаление строки из таблицы Things, где name равен переданному параметру
    DELETE FROM Things WHERE [name] = @name;
END
