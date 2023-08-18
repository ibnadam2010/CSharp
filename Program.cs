using System.Collections;
using System.Runtime.CompilerServices;

/* 
DECLARATION : Variable - Retrieve information 
*/
int note1 = 20;
int note2 = 15;
int moy = note1+note2 /2;
Console.WriteLine("Hello, World! \n La moyenne des deux notes est : "+moy);


/* 
CONDITION : IF - ELSE Usage 
*/
int age = 20;
if (age >= 15)
Console.WriteLine("Vous etes majeur, bravo!");
else
Console.WriteLine("Vous etes mineur, désolé!");


/* 
BOUCLE : FOR - Usage 
*/
int order;
for ( order = 1; order < 7; order++ ){
 Console.WriteLine("vous etes à la place : "+order);
}


/* 
CONDITION : CASES
*/
string mois ="Novembre";
switch(mois)
{
case "Mars":
case "Avril":
case "Mai":
Console.WriteLine("cest le printemps");
break;

case "Juin":
case "Juillet":
case "Aout":
Console.WriteLine("c'est l'été, bel été!");
break;

case "Septembre":
case "Octobre":
case "Novembre":
Console.WriteLine("c'est l'automne!");
break;

case "Décembre":
case "Janvier":
case "Février":
Console.WriteLine("c'est l'hiver!");
break;
default:
Console.WriteLine("période de l'année inconnue");
break;
}

