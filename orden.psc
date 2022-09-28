algoritmo problemacinco
    Definir a,b,c Como Entero
	
	Escribir "ingresa numero"
      Leer a;
	  
	Escribir "ingresar numero"
	  Leer b;
	  
	Escribir "ingresa numero"
	  Leer c;
	
	
	  si ( a > b & a > c) entonces 
		  escribir "numero mayor a menor"  a, "," b "," ,c ;
	  finsi
	  
		  
	  
	  si ( a > c & c > b) entonces
		  escribir "numero mayor a menor es: ", a,"," c,"," b;
	  FinSi
	  
	  
	
	  si ( b > a & b > c) entonces 
		  escribir "numero mayor a menor" " " b,"," a,"," c;
		  
	finsi
	
	
	si ( b > c & c > a) entonces
		escribir "numero mayor a menor" " " b,"," c,"," a;
		
	FinSi
	
	
	
	si ( c > a & c > b) entonces 
		   escribir "numero mayor a menor" " " c,"," a,"," b;
		
	finsi
	
	
	si ( c > a & b < a) entonces
		escribir "numero mayor a menor" " " c,"," b,"," a;
	
	FinSi

FinAlgoritmo