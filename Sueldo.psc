Algoritmo Sueldo
	definir horas,doble, triple como Entero 
	definir pago, total Como Real
	escribir "ingresa las horas trabajadas";
	leer horas
	escribir "ingresa el pago por hora";
	leer pago
	
	Si horas <= 35 Entonces
		total = horas* pago
		escribir "las horas se pagan normal: ";
	SiNo 
		si (horas >= 35 && horas <=45) Entonces
			doble = horas-35
			total = (35* pago) + ( doble* pago* 2)
			escribir "las horas se pagan al doble: ";
		SiNo
			Si horas>=45 Entonces
				triple= horas- 45
				total = (45* pago)+ ( 10* pago* 2)+ (triple* pago * 3)
				escribir "las horas se pagan al triple: ";
			FinSi
		FinSi
	FinSi
	Escribir " el pago por las ",horas," horas trabajadas es: $",total

	
FinAlgoritmo
