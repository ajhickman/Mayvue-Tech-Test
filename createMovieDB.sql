CREATE TABLE [dbo].[Movie] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)  NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [Year]        INT            NOT NULL,
    CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO Movie (Name, Description, Year)
VALUES ('The Lord of the Rings: The Fellowship of the Ring', 'A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.', 2001);

INSERT INTO Movie (Name, Description, Year)
VALUES ('The Fifth Element', 'In the colorful future, a cab driver unwittingly becomes the central figure in the search for a legendary cosmic weapon to keep Evil and Mr. Zorg at bay.', 1997);

INSERT INTO Movie (Name, Description, Year)
VALUES ('The Shawshank Redemption', 'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.', 1994);


