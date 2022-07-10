[![LinkedIn][linkedin-shield]][linkedin-url]

# WinFormsApp


[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/hilal-cerit


* This project is basic implementation of using Form Application.I wrote this project using C# programming langauge.For database ,taking into account the ease of use, 
I used Visual Studio's own Sql Server.

* The content of this project is doing CRUD operations with connected database.Whenever user does something with data in Form App it affects the database as well.

*Code for Creating Table :*

CREATE TABLE [dbo].[Products] (
    [Id]          INT            NULL,
    [ProductName] NVARCHAR (100) NULL,
    [Price]       MONEY          NULL,
    [Url]         NVARCHAR (350) NULL,
    [Description] TEXT           NULL
);

*DB looks like  :*


![db](https://user-images.githubusercontent.com/77547891/178144491-65c83140-b47a-4db1-940a-2e21cd1c3c30.PNG)


*The UI looks like after running the project :*


![firstPic2](https://user-images.githubusercontent.com/77547891/178144728-39d96f07-e5ce-467f-9a0c-457d7d9e591f.PNG)

*After click the "Get All Data" button :*

![firstPic1](https://user-images.githubusercontent.com/77547891/178144767-90e6358c-e63e-491d-b5ad-e2ebe07721c2.PNG)



*After click the "Update" button :*

![Update e bastıktan sonra](https://user-images.githubusercontent.com/77547891/178144809-b9343a49-4d32-4e42-82f3-5b5444238357.PNG)






