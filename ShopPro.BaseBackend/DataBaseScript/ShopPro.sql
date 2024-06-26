USE [master]
GO
/****** Object:  Database [ShopPro]    Script Date: 4/5/2024 1:38:12 PM ******/
CREATE DATABASE [ShopPro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShopPro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ShopPro.mdf' , SIZE = 16384KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ShopPro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ShopPro_log.ldf' , SIZE = 16384KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ShopPro] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopPro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShopPro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShopPro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShopPro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShopPro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShopPro] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShopPro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ShopPro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShopPro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShopPro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShopPro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShopPro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShopPro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShopPro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShopPro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShopPro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShopPro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShopPro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShopPro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShopPro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShopPro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShopPro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShopPro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShopPro] SET RECOVERY FULL 
GO
ALTER DATABASE [ShopPro] SET  MULTI_USER 
GO
ALTER DATABASE [ShopPro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShopPro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShopPro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShopPro] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ShopPro] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ShopPro] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ShopPro', N'ON'
GO
ALTER DATABASE [ShopPro] SET QUERY_STORE = ON
GO
ALTER DATABASE [ShopPro] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ShopPro]
GO
/****** Object:  User [Farbod_Mirzaee]    Script Date: 4/5/2024 1:38:12 PM ******/
CREATE USER [Farbod_Mirzaee] FOR LOGIN [Farbod_Mirzaee] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Country] [nvarchar](300) NOT NULL,
	[CountryCode] [nvarchar](150) NOT NULL,
	[PostalCode] [smallint] NOT NULL,
	[City] [nvarchar](150) NOT NULL,
	[State] [nvarchar](150) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Street] [nvarchar](100) NOT NULL,
	[StreetLine] [smallint] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[UpdateDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](150) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](300) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Birthdate] [datetime] NOT NULL,
	[Gender] [smallint] NOT NULL,
	[PhoneNumber] [nvarchar](11) NOT NULL,
	[AddressId] [int] NULL,
	[EntryDate] [datetime] NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](150) NOT NULL,
	[Email] [nvarchar](300) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Birthdate] [datetime] NOT NULL,
	[GenderId] [int] NOT NULL,
	[PhoneNumber] [nvarchar](11) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[UpdateDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[EnumName] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderCode] [nvarchar](10) NOT NULL,
	[Date] [datetime] NOT NULL,
	[AddressDescription] [nvarchar](max) NOT NULL,
	[OrderDescription] [nvarchar](max) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[AddressId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[UpdateDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItem]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [smallint] NOT NULL,
	[PurchasePrice] [decimal](18, 2) NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[UpdateDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](300) NOT NULL,
	[Specificaion] [nvarchar](max) NOT NULL,
	[Image] [varbinary](max) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Brand] [nvarchar](300) NOT NULL,
	[Count] [smallint] NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Address] ADD  CONSTRAINT [DF_Address_EntryDate]  DEFAULT (getdate()) FOR [EntryDate]
GO
ALTER TABLE [dbo].[Address] ADD  CONSTRAINT [DF_Address_IsActive]  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_EntryDate]  DEFAULT (getdate()) FOR [EntryDate]
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_Date]  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_EntryDate]  DEFAULT (getdate()) FOR [EntryDate]
GO
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_EntryDate]  DEFAULT (getdate()) FOR [EntryDate]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_IsActive]  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Customer]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Address] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Address]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Product]
GO
/****** Object:  StoredProcedure [dbo].[DeleteAddressRecord]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteAddressRecord]
    @Id INT
AS
BEGIN
    DELETE FROM Address WHERE Id = @Id
END
	
GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomerRecord]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCustomerRecord]
    @Id INT
AS
BEGIN
    DELETE FROM Customer
    WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteOrder]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteOrder]
    @Id INT
AS
BEGIN
    DELETE FROM [Order]
    WHERE Id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteProduct]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteProduct]
    @Id INT
AS
BEGIN
    DELETE FROM Product
    WHERE Id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[GetAddressById]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAddressById]
    @Id INT
AS
BEGIN
    SELECT 
        [Id],
        [Country],
        [CountryCode],
        [PostalCode],
        [City],
        [State],
        [Description],
        [Street],
        [StreetLine],
        [CustomerId],
        [EntryDate],
        [UpdateDate],
        [IsActive]
    FROM 
        [Address]
    WHERE
        [Id] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllAddresses]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllAddresses]
AS
BEGIN
    SELECT 
        [Id],
        [Country],
        [CountryCode],
        [PostalCode],
        [City],
        [State],
        [Description],
        [Street],
        [StreetLine],
        [CustomerId],
        [EntryDate],
        [UpdateDate],
        [IsActive]
    FROM 
        [Address]
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllCustomers]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllCustomers]
AS
BEGIN
    SELECT 
        [Id],
        [Name],
        [LastName],
        [Birthdate],
        [GenderId],
        [UserName],
        [Email],
        [Password],
        [PhoneNumber],
        [EntryDate],
        [IsActive],
        [IsAdmin]
    FROM 
        Customer 
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllOrders]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllOrders]
AS
BEGIN
    SELECT [Id],[OrderCode],[Date],[AddressDescription],[OrderDescription],[CustomerId],[AddressId],[ProductId],[EntryDate],[UpdateDate],[IsActive]
    FROM [Order];
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllProducts]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllProducts]
AS
BEGIN
    SELECT [Id],[Name],[Specificaion],[Image],[Price],[Brand],[Count],[EntryDate],[UpdateDate],[IsActive]
    FROM Product;
END
GO
/****** Object:  StoredProcedure [dbo].[GetCustomerById]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCustomerById]
    @Id INT
AS
BEGIN
    SELECT 
        [Id],
        [Name],
        [LastName],
        [Birthdate],
        [GenderId],
        [UserName],
        [Email],
        [Password],
        [PhoneNumber],
        [EntryDate],
        [IsActive],
        [IsAdmin]
    FROM 
        Customer 
    WHERE
        [Id] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetOrderById]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetOrderById]
    @Id INT
AS
BEGIN
    SELECT [Id],[OrderCode],[Date],[AddressDescription],[OrderDescription],[CustomerId],[AddressId],[ProductId],[EntryDate],[UpdateDate],[IsActive]
    FROM [Order]
    WHERE Id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[GetProductById]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetProductById]
    @Id INT
AS
BEGIN
    SELECT *
    FROM Product
    WHERE Id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[InsertAddress]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertAddress]
    @Country NVARCHAR(100),
    @CountryCode NVARCHAR(10),
    @PostalCode SMALLINT,
    @City NVARCHAR(100),
    @State NVARCHAR(100),
    @Description NVARCHAR(MAX),
    @Street NVARCHAR(100),
    @StreetLine SMALLINT,
    @CustomerId INT,
    @IsActive BIT
AS
BEGIN
    INSERT INTO [Address] 
    (
        Country,
        CountryCode,
        PostalCode,
        City,
        State,
        Description,
        Street,
        StreetLine,
        CustomerId,
        IsActive
    )
    VALUES
    (
        @Country,
        @CountryCode,
        @PostalCode,
        @City,
        @State,
        @Description,
        @Street,
        @StreetLine,
        @CustomerId,
        @IsActive
    )
END
GO
/****** Object:  StoredProcedure [dbo].[InsertCustomer]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCustomer]
    @Name NVARCHAR(100),
    @LastName NVARCHAR(100),
    @Birthdate DATE,
    @GenderId INT,
    @UserName NVARCHAR(100),
    @Email NVARCHAR(100),
    @Password NVARCHAR(100),
    @PhoneNumber NVARCHAR(20),
    @IsAdmin BIT,
    @IsActive BIT
AS
BEGIN
    INSERT INTO Customer 
    (
        Name,
        LastName,
        Birthdate,
        GenderId,
        UserName,
        Email,
        [Password],
        PhoneNumber,
        IsAdmin,
        IsActive
    )
    VALUES
    (
        @Name,
        @LastName,
        @Birthdate,
        @GenderId,
        @UserName,
        @Email,
        @Password,
        @PhoneNumber,
        @IsAdmin,
        @IsActive
    )
END
GO
/****** Object:  StoredProcedure [dbo].[InsertOrder]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertOrder]
    @OrderCode NVARCHAR(50),
    @Date DATETIME,
    @AddressDescription NVARCHAR(100),
    @OrderDescription NVARCHAR(MAX),
    @CustomerId INT,
    @AddressId INT,
    @ProductId INT,
    @IsActive BIT
AS
BEGIN
    INSERT INTO [Order] ([OrderCode], [Date], [AddressDescription], [OrderDescription], [CustomerId], [AddressId], [ProductId], [IsActive])
    VALUES (@OrderCode, @Date, @AddressDescription, @OrderDescription, @CustomerId, @AddressId, @ProductId, @IsActive);
END
GO
/****** Object:  StoredProcedure [dbo].[InsertProduct]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertProduct]
    @Name NVARCHAR(100),
    @Specificaion NVARCHAR(MAX),
    @Image VARBINARY(MAX),
    @Price DECIMAL(18, 2),
    @Brand NVARCHAR(100),
    @Count INT,
    @IsActive BIT
AS
BEGIN
    INSERT INTO Product ([Name], [Specificaion], [Image], [Price], [Brand], [Count], [IsActive])
    VALUES (@Name, @Specificaion, @Image, @Price, @Brand, @Count, @IsActive);
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateAddress]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateAddress]
    @Id INT,
    @Country NVARCHAR(100),
    @CountryCode NVARCHAR(10),
    @PostalCode SMALLINT,
    @City NVARCHAR(100),
    @State NVARCHAR(100),
    @Description NVARCHAR(MAX),
    @Street NVARCHAR(100),
    @StreetLine SMALLINT,
    @CustomerId INT,
    @IsActive BIT
AS
BEGIN
    UPDATE [Address] 
    SET 
        Country = @Country,
        CountryCode = @CountryCode,
        PostalCode = @PostalCode,
        City = @City,
        State = @State,
        Description = @Description,
        Street = @Street,
        StreetLine = @StreetLine,
        CustomerId = @CustomerId,
        IsActive = @IsActive
    WHERE
        Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomer]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCustomer]
    @Id INT,
    @Name NVARCHAR(50),
    @LastName NVARCHAR(50),
    @UserName NVARCHAR(50),
    @GenderId INT,
    @Birthdate DATE,
    @Email NVARCHAR(100),
    @Password NVARCHAR(50),
    @PhoneNumber NVARCHAR(20),
    @IsAdmin BIT,
    @IsActive BIT
AS
BEGIN
    UPDATE dbo.Customer
    SET Name = @Name,
        LastName = @LastName,
        UserName = @UserName,
        GenderId = @GenderId,
        Birthdate = @Birthdate,
        Email = @Email,
        Password = @Password,
        PhoneNumber = @PhoneNumber,
        IsAdmin = @IsAdmin,
        IsActive = @IsActive
    WHERE Id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateOrder]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateOrder]
    @Id INT,
    @AddressDescription NVARCHAR(100),
    @OrderDescription NVARCHAR(MAX),
    @CustomerId INT,
    @AddressId INT,
    @ProductId INT,
    @IsActive BIT
AS
BEGIN
    UPDATE [Order]
    SET AddressDescription = @AddressDescription,
        OrderDescription = @OrderDescription,
        CustomerId = @CustomerId,
        AddressId = @AddressId,
        ProductId = @ProductId,
        IsActive = @IsActive
    WHERE Id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateProduct]    Script Date: 4/5/2024 1:38:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateProduct]
    @Id INT,
    @Name NVARCHAR(100),
    @Specificaion NVARCHAR(MAX),
    @Image VARBINARY(MAX),
    @Price DECIMAL(18, 2),
    @Brand NVARCHAR(100),
    @IsActive BIT
AS
BEGIN
    UPDATE Product
    SET Name = @Name,
        Specificaion = @Specificaion,
        Image = @Image,
        Price = @Price,
        Brand = @Brand,
        IsActive = @IsActive
    WHERE Id = @Id;
END
GO
USE [master]
GO
ALTER DATABASE [ShopPro] SET  READ_WRITE 
GO
