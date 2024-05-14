﻿CREATE PROC BookingParty
@Customer nvarchar(100),@CreateDate date, @Adress nvarchar(100), @PhoneNumber nvarchar(100), @Email nvarchar(100), 
@GroomName nvarchar(100), @Bride nvarchar(100), @IdVenue int, @Shift nvarchar(100), @DueDate date, @NumberOfTable int, @ReserveTable int, @Deposit money,
 @ListIdFood nvarchar(max),
 @ListIdService nvarchar(max)
AS
BEGIN
IF @PhoneNumber NOT IN ( SELECT DIENTHOAI FROM KHACHHANGINFOR)
BEGIN
	Declare @CustomerId int
	IF NOT EXISTS (SELECT 1 FROM KHACHHANGINFOR WHERE DIENTHOAI = @PhoneNumber)
    BEGIN
        INSERT INTO KHACHHANGINFOR (NGAYLAP, TENKHACHHANG, DIACHI, DIENTHOAI, EMAIL)
        VALUES (@CreateDate, @Customer, @Adress, @PhoneNumber, @Email)

        SET @CustomerId = SCOPE_IDENTITY()
    END
    ELSE
    BEGIN
        SELECT @CustomerId = ID FROM KHACHHANGINFOR WHERE DIENTHOAI = @PhoneNumber
    END

    INSERT INTO TIEC (IDTHONGTINKHACHHANG, IDLOAISANH, CA, TENCHURE, TENCODAU, NGAYTOCHUC, SOLUONGBAN, BANDUTRU, TIENCOC)
    VALUES (@CustomerId, @IdVenue, @Shift, @GroomName, @Bride, @DueDate, @NumberOfTable, @ReserveTable, @Deposit)

    DECLARE @PartyId int
    SET @PartyId = SCOPE_IDENTITY()

	DECLARE @FoodTable TABLE (Id int)
    INSERT INTO @FoodTable (Id)
    SELECT value FROM STRING_SPLIT(@ListIdFood, ',')

    INSERT INTO FOODINUSE (IDTIEC, IDTHUCDON)
    SELECT @PartyId, Id FROM @FoodTable

    DECLARE @ServiceTable TABLE (Id int)
    INSERT INTO @ServiceTable (Id)
    SELECT value FROM STRING_SPLIT(@ListIdService, ',')

    INSERT INTO DICHVUINUSE (IDTIEC, IDDICHVU)
    SELECT @PartyId, Id FROM @ServiceTable
   END
END



SELECT DIENTHOAI FROM KHACHHANGINFOR


--detele sanh
GO
CREATE OR ALTER PROCEDURE CheckAndUpdateSanhStatus
    @IDSanh INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NgayToChuc DATE;
    DECLARE @Ca NVARCHAR(10);
    SELECT @NgayToChuc = NGAYTOCHUC
    FROM TIEC
    WHERE IDLOAISANH = @IDSanh;

    IF @NgayToChuc >= CONVERT(DATE, GETDATE())
    BEGIN
		RAISERROR (N'cant delete the venue',
           10, -- Severity,
           1, -- State,
           N'abcde');
        RETURN;
    END
    ELSE
    BEGIN
        IF EXISTS (SELECT 1 FROM TIEC WHERE IDLOAISANH = @IDSanh)
        BEGIN
            UPDATE SANHINFOR
            SET TRANGTHAISANH = 0
            WHERE ID = @IDSanh;
        END
        ELSE
        BEGIN
            DELETE FROM SANHINFOR
            WHERE ID = @IDSanh;
        END
    END
END


GO


CREATE OR ALTER PROCEDURE CheckAndUpdateFoodStatus
    @IDfood INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NgayToChuc DATE;
    
    -- Kiểm tra xem IDfood có trong bảng FOODINUSE hay không
    IF EXISTS (SELECT 1 FROM FOODINUSE WHERE IDTHUCDON = @IDfood)
    BEGIN
        -- Lấy ngày tổ chức từ bảng TIEC dựa trên IDtiec
        SELECT @NgayToChuc = NGAYTOCHUC
        FROM TIEC
        WHERE ID = (SELECT IDtiec FROM FOODINUSE WHERE IDTHUCDON = @IDfood);

        IF @NgayToChuc >= CONVERT(DATE, GETDATE())
        BEGIN
            RAISERROR (N'Cannot delete food, the party has not started yet',
               10, -- Severity,
               1 -- State
               );
            RETURN;
        END
        ELSE
        BEGIN
            -- Tiến hành cập nhật trạng thái của IDfood trong bảng SANHINFOR
            UPDATE FOOD
            SET TRANGTHAIMONAN = 0
            WHERE ID = @IDfood;
        END
    END
    ELSE
    BEGIN
        -- Xóa bản ghi nếu không có trong bảng FOODINUSE
        DELETE FROM FOOD WHERE ID = @IDfood;
    END
END

GO

CREATE OR ALTER PROCEDURE CheckAndUpdateServiceStatus
    @IDDICHVU INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NgayToChuc DATE;
    
    IF EXISTS (SELECT 1 FROM DICHVUINUSE WHERE IDDICHVU = @IDDICHVU)
    BEGIN
        -- Lấy ngày tổ chức từ bảng TIEC dựa trên IDtiec
        SELECT @NgayToChuc = NGAYTOCHUC
        FROM TIEC
        WHERE ID = (SELECT IDTIEC FROM DICHVUINUSE WHERE IDDICHVU = @IDDICHVU);

        IF @NgayToChuc >= CONVERT(DATE, GETDATE())
        BEGIN
            RAISERROR (N'Cannot delete food, the party has not started yet',
               10, -- Severity,
               1 -- State
               );
            RETURN;
        END
        ELSE
        BEGIN
            -- Tiến hành cập nhật trạng thái của IDfood trong bảng SANHINFOR
            UPDATE DICHVU
            SET TRANGTHAIDICHVU = 0
            WHERE ID = @IDDICHVU;
        END
    END
    ELSE
    BEGIN
        -- Xóa bản ghi nếu không có trong bảng FOODINUSE
        DELETE FROM DICHVU WHERE ID = @IDDICHVU;
    END
END
