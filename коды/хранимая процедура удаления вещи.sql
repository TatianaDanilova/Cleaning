CREATE PROCEDURE DeleteThing
    @name NVARCHAR(100) -- �������� name
AS
BEGIN
    -- �������� ������ �� ������� Things, ��� name ����� ����������� ���������
    DELETE FROM Things WHERE [name] = @name;
END
