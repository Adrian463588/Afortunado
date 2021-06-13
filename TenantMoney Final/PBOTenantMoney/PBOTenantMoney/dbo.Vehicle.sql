CREATE TABLE [dbo].[Vehicle] (
    [Id]                INT         IDENTITY (1, 1) NOT NULL,
    [Merek]             NCHAR (30)  NOT NULL,
    [PlatNomor]         NCHAR (15)  NOT NULL,
    [Harga]             INT         NOT NULL,
    [NamaPeminjam]      NCHAR (100) NULL,
    [NIK]               NCHAR (30)  NULL,
    [NoHp]              NCHAR (20)  NULL,
    [TanggalPeminjaman] NCHAR (50)  NULL,
    [LamaPeminjaman]    INT         NULL,
    [TotalHarga]        INT         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
