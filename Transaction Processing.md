- **Acid (Atomicity, Consistency, Isolation, Durability)**

## Atomicity
- Atomicity ensures that a transaction must be processed in its entirety or not at all.
- This means that if the system fails then the transaction wont be completed. 
- Transactions should succeed or fail but never partially succeed.

## Consistency
- The transaction should only change the database according to the rules of the database.
- When a relational database is created, **Referential Integrity** rules are specified between linked tables.
- Changes in one table must take into account data in linked tables.
- This means that it will not be possible to create or delete a record if related records exist in linked tables
- For example:
	- an employee cannot be deleted if they have salary details in another table
	- you can’t create a salary for an employee that doesn’t exist