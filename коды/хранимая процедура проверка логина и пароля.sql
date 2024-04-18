create PROCEDURE [dbo].[CheckName]
    @name nchar(100),
	@pass nchar(100),
    @user_id int OUTPUT
AS
BEGIN
    SET @user_id = NULL

    IF EXISTS (SELECT 1 FROM Users WHERE [name] = @name AND pass = @pass)
    BEGIN
        SELECT @user_id = [user_id] FROM Users WHERE [name] = @name AND pass = @pass
    END
END