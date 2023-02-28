- In order for two computers to communicate they need a set of rules to tell them how to communicate
- A good protocol should include:
	- How to setup a connection
	- How to end a connection
	- How to start a message 
	- How to end a message
	- How to deal with corrupted data 
	- How to format the data being sent

## Layer Models
- A layer is a group of protocols organised by function. There are various models, which organise the protocols differently, but what all models have in common is that they arrange their layers so that protocols from one layer only interact with the layers directly above and below them.

- This means that is there is an error in a layer it is easier to debug
- Layers can be upgraded more quickly
- New protocols can be slotted into the system

![[Pasted image 20230227121040.png]]
![[Pasted image 20230227121146.png]]
![[Pasted image 20230227121356.png]]

### OSI
All prostitutes seem to need double penetration