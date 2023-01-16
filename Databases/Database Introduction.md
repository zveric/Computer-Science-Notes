## What is a Database?
- A Database is a collection of related data stored in a logical and structured manner
- A data base contains records and these records are made up from feids

## Database components
### File(table):
- A collection of related records which contain the same type of information as all the other records 
- e.g. Information about ALL students in a class
### Record:
- All of the data relating to one item or “thing”.  
- e.g. All information about ONE student in the class
### Field:
- Stores one item of data in a record
- e.g. a single characteristic about a student (date of birth, surname etc.)

## Types of Databases
- Databases can be either flat file or relational.
![image](image.png)

## Flat file databases
- A flat file database usually has one table. In some cases they can have more than one table but they dont have connections between the tables.
### Advantages:
- Easy to set up and understand – no specialist knowledge needed
### Disadvantages:
- May have redundant data
- Potential duplication of data
- Harder to update the data due to duplication
- Records are not unique
- Security is poor as if access is gained all data is readily available
- Harder to perform complex queries

## Relational databases 
- A realational database has more than one table whitch are linked together by primary and foreign keys.
	- A primary key is used to **uniquely** identify a record
  - A foreign key is a primary key in one table which is used as an attribute in another table to provide a link between tables
  - ![image](image_3.png)
- Sometimes you can't identify a single key field in your database. By combining multiple feilds a **Compound Key** can be created.
- A secondary key does exist and is often used to help index results for searching quickly

### Advantages:
- Data is only stored once – this avoids data duplication and means that data is only stored once.
- Data integrity is maintained
- Easy to modify the format
- Security is better as sections of the data can be protected individually using authorisation
- More “future proof” as it is easier to update and expand the basic structure than a flat file.
- More complex queries can be run over the data

### Disadvantages:
- Difficult to set up

### Data integrity:
- Entity integrity: Every table must have a primary key whitch is unique and not empty
- Referential integrity: Foreign key must point to the primary key of another table but can be empty
- Domain integrity: All attributes in the database are related to the overall domain that the database is working on

### Data Inderpendence:
- In relational databases data is seperated meaning that only relevent data is shown





