Algoritmo sin_titulo
	definir n1,n2,r Como Real
	escribir "ingresa el primer valor";
	leer n1;
	escribir "ingresa el segundo valor";
	leer n2;
	si n1>n2 Entonces
		r=n1/n2
		escribir "el resultado es:", r 
	SiNo
		si n1<n2 Entonces
			r=n2/n1
			escribir "el resultado es :",r;
		FinSi
	FinSi
	
FinAlgoritmo