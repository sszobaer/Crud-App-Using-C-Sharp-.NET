
# Crud Application Using C#

Desktop CRUD App Written In C#(.NET Framework)


## Preview

![App Screenshot](https://via.placeholder.com/468x300?text=App+Screenshot+Here)


### Bulit With
- C#(.Net Framework)
- Microsoft Sql
- VS Code


## Features

- Insert Data
- Delete Data
- Update Data
- Search Data


## SQL Query
#### Design Table
```bash
  CREATE TABLE [dbo].[CATable] (
    [id]   INT          NOT NULL,
    [name] VARCHAR (50) NULL,
    [age]  FLOAT (53)   NULL,
    CONSTRAINT [PK_CATable] PRIMARY KEY CLUSTERED ([id] ASC)
);
```
#### Insert Data
```bash
INSERT INTO CATable(id, name, age) VALUES(@id, @name, @age)
```
#### Delete Data
```bash
DELETE CATable WHERE id=@id
```
#### Update Data
```bash
UPDATE CATable SET name=@name, age=@age WHERE id=@id
```
#### Search Data
```bash
SELECT * FROM CATable WHERE id=@id
```
## Tech Stack

**Client:** C#, .NET, MS SQL

**Server:** SQL Server


## 🛠 Skills
C#, .NET, SQL...


## Badges

Add badges from MIT [MIT License](https://choosealicense.com/licenses/mit/)

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/sszobaer/Crud-App-Using-C-.NET/blob/main/LICENSE)

