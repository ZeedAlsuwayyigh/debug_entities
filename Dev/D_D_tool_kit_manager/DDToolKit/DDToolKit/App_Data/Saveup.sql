create table [dbo].[Saves](
	[ID]		INT IDENTITY(1,1)	NOT NULL,
	[Name]		Nvarchar(40)		NOT NULL,
	[OwnerID]	Nvarchar(128)		,
	[Monsters]  NvarChar(500),

	CONSTRAINT [PK_dbo.Saves] PRIMARY KEY CLUSTERED ([ID] ASC),

);

create table [dbo].[Players](
	[ID]		INT IDENTITY(1,1)	NOT NULL,
	[OwnerID]	Nvarchar(128)		,
	[GameID]	Int					,
	[Name]		NvarChar(30)		Not NULL,
	[Size]		NvarChar(15)		,
	[Type]		NvarChar(20)		,
	[Aligment]	NvarChar(20)		,
	[ArmorClass] Int				,
	[HitPoints] Int					,
	[Strength]	int					,
	[Dexterity] int					,
	[Constitution] int				,
	[Intelligence] int				,
	[Wisdom]	int					,
	[Charisma] int					,
	[Languages] NvarChar(500),
	[Speed] NvarChar(500)			,
	[Proficiencies] NvarChar(500),
	[DamageResistance] NvarChar(500),
	[ConditionImmunity] NvarChar(500),
	[Senses] NvarChar(500)			,
	[SpecialAbility] NvarChar(500),
	[Actions] NVarChar(MAX),

	CONSTRAINT [PK_dbo.Players] PRIMARY KEY CLUSTERED ([ID] ASC)
);