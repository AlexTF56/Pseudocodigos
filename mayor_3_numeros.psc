Algoritmo mayor_3_numeros
	definir a, b,c como entero 
	escribir "dame los siguientes numeros";
	leer a, b, c
	
	si a>b Entonces
		si a>c entonces 
			Escribir "el numero ",a," es el mayor de los tres"
		sino 
			escribir "el numero ",c," es el mayor de los tres"
			
		FinSi
	sino 
		si b>c entonces 
			escribir " el numero",b," es el mayor de los tres"
		sino
			escribir "el numero ",c," es el mayor de los tres"
			
		FinSi
	FinSi
	
	
	
FinAlgoritmo
