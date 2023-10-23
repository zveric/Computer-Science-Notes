#[[File Access Methods]]

- Not stored in a particular order except chronology
- New records are appended onto the end of a file
- There is no way of finding a particular record except by linear searching through all the entries
- Deleting records in a serial file is complex
	- Think of a magnetic tape storing a file - to find the record to be deleted the tape must be read from the beginning.
	- Once it has been found the computer cannot simply rewind and erase the record, leaving a blank space.
	- A new tape must be created, copying all of the records up to the position of the one to be removed.
	- The records following the one to be removed are then appended to this new tape.
- ### Uses
- When the order doesn't matter
- Data must be stored in the order that it is received
- Backups