## Casting
1. str(x) converts items to a string

For example:
~~~ 
str(3)
~~~
Would return "3"

2. int("x") converts items to intergers

For example:
~~~ 
int("3")
~~~
Would return the interger 3

## Output to screen
'print' is used to output to the screen
~~~ 
print("Hello")
~~~
This would output 'Hello' to the screen

## Iteration – Count Controlled
~~~
for i=0 to 7
 print(“Hello”)
next i
~~~
Will print hello 8 times (0-7 inclusive).

## Iteration – Condition Controlled
~~~
while answer!=”computer” 
 answer=input(“What is the password?”)
endwhile
~~~
~~~
do
 answer=input(“What is the password?”)
until answer==”computer"
~~~
Both would ask the user for their password untill it = "Computer"

## Selection 
1. if statement
   ~~~
   if entry==”a” then
   	print(“You selected A”)
   ~~~
2. else if statment
   ~~~
   elseif entry==”b” then
   	print(“You selected B”)
   ~~~
3. else statement
   ~~~
   else
   	print(“Unrecognised selection”)
   ~~~
4. Always end a if statement with
   ~~~
   endif
   ~~~
5. switch/case
   ~~~
   switch entry:
   	case “A”:
   		print(“You selected A”)
   	case “B”:1
   		print(“You selected B”)
   	default:
   		print(“Unrecognised selection”)
   endswitch
   ~~~

## Arrays
~~~
array names[5]
names[0]=”Ahmad”
names[1]=”Ben”
names[2]=”Catherine”
names[3]=”Dana”
names[4]=”Elijah”
print(names[3])
~~~