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
    //Call declared function
 afficherPlace(order);
}


/* 
FONCTIONS : Declaration 
*/
void afficherPlace(int place){
    Console.WriteLine("vous etes à la place : "+place);
}

void calculerPerimetre(string figureGeometrique, int Longueur=0, int Largeur=0, int Cote=0, int Rayon=0){
        switch (figureGeometrique)
        {
            case "cercle":
            Console.WriteLine("Le périmètre du "+figureGeometrique+" de rayon "+Rayon+" cm = "+2*3.14*Rayon+" cm");
            break;

            case "rectangle":
            Console.WriteLine("Le périmètre du "+figureGeometrique+" de longueur "+Longueur+" cm et de largeur "+Largeur+" cm = "+ (Longueur+Largeur)*2 +" cm");
            break;

            case "carré":
            Console.WriteLine("Le périmètre du "+figureGeometrique+" de côté "+Cote+" cm = "+Cote*4+" cm");
            break;
            default:
            Console.WriteLine("Aucune figure géometrique précisée");
            break;
        }
}

calculerPerimetre("cercle",0,0,0,3);
calculerPerimetre("rectangle",12,4,0,0);
calculerPerimetre("carré",0,0,4,0);


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

