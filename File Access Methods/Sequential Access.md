#[[File Access Methods]]

- Records are stored one after another in order of a key field
- In order to find the file the entire file-system may need to be searched but it tents to be faster than [[Serial Access]]
- ### Adding and Deleting records
	- With a sequential file, all records are in order of the key field so you cannot just add a new record to the end of the file.
	- The file is copied up to the position of the new record, the record is inserted and then the rest of the file is appended.
	- Deleting a record is the same as for a [[Serial Access]].
- ## Indexed Sequential File Organisation
- Records are sorted according to a primary key but a separate index is also kept.
- The index is an additional file that contains information about where records are stored and allows them be accessed directly.
- ### Adding and Deleting records
- Records are sorted according to a primary key but a separate index is also kept.
- The index is an additional file that contains information about where records are stored and allows them be accessed directly.