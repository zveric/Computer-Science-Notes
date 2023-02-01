## Relational Database management system
- Maintains data integrity
- A good RDBMS contains:
	- A command language that allows you to create delete and alter the database (Data definition language or DDL). SQL is an example of this.
	- A data dictionary (Documenting all the internal structures that make up the database)
- Users:
	- Simple RDMS may be designed with a single user and the database is locked whilst editing.
	- Enterprise level DBMS can support a huge number of simultaneous users with thousands of internal tables and complex 'roll back' capabilities
	- This kind of system may require professionals to administrate the databases
### Data Dictionary
- Data dictionary is used by database managers
- It is a file containing descriptions of the data held within the the tables in a database.
- The data dictionary provides metadata about how the data is stored
- It describes the structure of attributes as well as including names and descriptions of tables.
- It also includes the field lengths
![[Pasted image 20230130120232.png]]

### Data Manipulation
- One of the functions of a RDBMS is to provide a means of manipulating data within the database. 
- This is the role of the data manipulation language (DML) built in to the system and includes operations such as CRUD (Create, Read, Update, Delete)
- The DML is used to :
	- access/query/sort/search data
	- store/insert data
	- change/update/delete data.

### Data Definition Language
- One of the basic functions of a RDBMS is to provide a method of creating a database from scratch, which is the role of the data definition language (DDL). 
- The DDL is used to write schema (designs) which describes data items to be stored and the relationships between them.
- It allows tables to be created and primary/foreign keys to be defined.
- It also defines validation rules.

### Views of Data
1. Physical View:
	- This view exposes all the internal details of how the data is stored on the physical computer. 
	- For example the data structures used in memory, the nature of the indexes used for searching, what physical devices are used to store the database and so on.
2. Logical View:
	- At this level, there is no concern about the physical nature of the database, but rather the concept behind the database. It shows:
		- a model of all the information within the database
		- the kind of records it holds
		- the type of authorisation and validation methods used.
	- This is the kind of view the database designer is using to set out the whole database
	- The data dictionary is produced at this level.
3. External View:
	- This is the view that sets out what an authorised user can see of the database. 
	- It sets out the data they are allowed to see and their authority level to change the records. 