
# Crud Application Using C#

Desktop CRUD App Written In C#(.NET Framework)


## Preview

![0819(1)](https://github.com/user-attachments/assets/2389887b-9a91-4f69-b009-0498fe029c0c) 

![Screenshot 2024-08-19 225202](https://github.com/user-attachments/assets/d69719c4-7416-4304-8be3-52d197639fec)





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

**Programming Language:** C#
**Database:** SQL Server
**Framework:** Windows Forms
**UI Components:** 
    -Text Box for entering data.
    - Button for response.
    - Data Grid View for displaying and managing data


## 🛠 Skills
C#, .NET, SQL...


## Badges

Add badges from MIT [MIT License](https://choosealicense.com/licenses/mit/)

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/sszobaer/Crud-App-Using-C-.NET/blob/main/LICENSE)

