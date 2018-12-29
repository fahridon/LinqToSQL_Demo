USE [Northwind]
GO

/****** Object:  Table [dbo].[Table_Urun]    Script Date: 29.12.2018 11:02:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Table_Urun](
	[UrunId] [int] NOT NULL,
	[UrunAdi] [nvarchar](50) NULL,
	[Fiyat] [decimal](18, 0) NULL,
	[KategoriId] [int] NULL,
	[SatisBaslangicTarihi] [datetime] NULL,
	[SatisBitisTarihi] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UrunId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


