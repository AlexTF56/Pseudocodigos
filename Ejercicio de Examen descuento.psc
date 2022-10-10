Algoritmo Ejercicio
    Definir opc, resultado, precio, total, pagototal,totaldescu,descuento como real
	definir  producto,error como caracter
    opc = 1
    
    
        Escribir "Nombre del prodcto"
        leer producto
        Escribir "Precio del producto"
        leer precio
        Escribir ""
        Escribir "1 = Aplicar descuento"
        Escribir "2 = No aplicar descuento"
        
        Escribir "Elige una opción"
		
        leer opc;
		;
        Segun opc Hacer
            
            1: 
				escribir "Ingresa descuento a desear del ",10,"% al ", 90,"%: "
                leer descuento
				totaldescu=descuento*precio/100
                
                total=(precio-totaldescu)
				Escribir "El descuento es de: ",totaldescu," pesos",;
				ESCRIBIR "Con un total de: ",total," pesos"
				escribir " Ingresa cantidad a pagar"
				leer cantidad
			
				
					
				si (cantidad>=total) Entonces
					pagototal=cantidad-total
					Escribir "El producto comprado es: ",producto
					escribir "El precio del producto es: ",precio," pesos",;
					Escribir "El descuento es de: ",totaldescu," pesos",;
					escribir "El total con descuento es :",total," pesos",;
					escribir "La cantidad a pagar es de: ",cantidad," pesos",;
					escribir "Su cambio es de :",pagototal," pesos",;
						
				
				SiNo
						
					repetir
							escribir "    CANTIDAD ERRONEA    " 
							
							escribir"Ingresa cantidad de nuevo: "
							leer cantidad
					Hasta Que (cantidad>=total)	
						
						pagototal=cantidad-total
						Escribir "El producto comprado es: ",producto
						escribir "El precio del producto es: ",precio," pesos",;
						Escribir "El descuento es de: ",totaldescu," pesos",;
						escribir "El total con descuento es :",total," pesos",;
						escribir "La cantidad a pagar es de: ",cantidad," pesos",;
						escribir "Su cambio es de :",pagototal," pesos",;
				FinSi
				
            2:
				total=precio
				Escribir "NO SE APLICO DESCUENTO"
				escribir " el total a pagar es : ",total," pesos",;
				escribir "cantidad a pagar"
				leer cantidad
				si (cantidad>=total) Entonces
					pagototal=cantidad-total
					
					Escribir "NO SE APLICO DESCUENTO"
					escribir " el total a pagar es : ",total," pesos",;
					
				SiNo
					
					repetir
						escribir "    CANTIDAD ERRONEA    "
						escribir"Ingresa cantidad de nuevo: "
						leer cantidad
					Hasta Que (cantidad>=total)	
					
				
                 total=cantidad-precio
					Escribir "El producto comprado es: ",producto
					escribir "El precio del producto es: ",precio," pesos"
					escribir "La cantidad a pagar es de: ",cantidad," pesos",;
					escribir"su cambio es de: ",total," pesos",;
					
					
				FinSi
				
				
				total=cantidad-precio
				Escribir "El producto comprado es: ",producto
				escribir "El precio del producto es: ",precio," pesos"
				escribir "La cantidad a pagar es de: ",cantidad," pesos",;
                escribir"su cambio es de: ",total," pesos",;
				
				
        FinSegun
    
FinProceso


