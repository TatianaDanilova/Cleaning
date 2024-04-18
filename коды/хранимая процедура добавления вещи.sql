create PROCEDURE [dbo].[AddThing]
    @thing_type NVARCHAR(100),
    @name nchar(100),
    @material nchar(100),
	@price int,
	@color nchar(100),
	@user_id int
AS
BEGIN
	-- Генерируем новый уникальный oi_id
	DECLARE @mi_id INT
	SELECT @mi_id = ISNULL(MAX(mi_id), 0) + 1 FROM Things

	-- Вставляем новую запись в OrderItems
	INSERT INTO Things(mi_id, thing_type, [name], material, price, color, [user_id])
	VALUES (@mi_id, @thing_type, @name, @material, @price, @color, @user_id)
END