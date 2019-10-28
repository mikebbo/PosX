use PosX2019

GO

CREATE TABLE [tblProduct]([barcode][numeric] (18,10) IDENTITY(1,1) NOT NULL , 
				[itmNum] numeric, 
				[name] varchar(100) NULL, 
				[description] varchar(150) NULL,
				[sellPrice] money NULL, 
				[buyPrice] money NULL,
				[quant] int 		NULL,	
					
CONSTRAINT [PK_itmNum] PRIMARY KEY CLUSTERED
( [itmNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF,IGNORE_DUP_KEY = OFF, 
	ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY])
	ON [PRIMARY]

	GO



End
