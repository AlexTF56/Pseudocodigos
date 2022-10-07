Algoritmo piramide
	definir a,b,c,n Como Entero
	escribir " escribe un numero"
	leer n
	para a= n hasta 1 con paso -1 Hacer
		para b=1 hasta a con paso 1 Hacer
			escribir " " sin saltar
		FinPara
		para c=a hasta n con paso 1 Hacer
			escribir "* " sin saltar
		FinPara
		escribir ""
	FinPara
FinAlgoritmo
