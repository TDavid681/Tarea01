continuar = "s"
numero_cliente = 1

# El bucle while se ejecuta mientras la respuesta sea 's' o 'S'
while continuar.lower() == "s":
    print(f"\n--- Cliente {numero_cliente} ---")
    
    # Pedimos los precios al usuario separados por espacio (ejemplo: 120 40 80)
    entrada = input("Ingresa los precios de los productos separados por espacio: ")
    
    # Convertimos la entrada de texto en una lista de números
    precios = [float(p) for p in entrada.split()]
    total_cliente = 0
    
    # Recorremos la lista dinámica con el bucle for
    for precio in precios:
        if precio > 50:
            precio_final = precio * 0.90
            print(f"  Producto de ${precio:.2f} -> Con descuento (10%): ${precio_final:.2f}")
        else:
            precio_final = precio
            print(f"  Producto de ${precio:.2f} -> Sin descuento: ${precio_final:.2f}")
        
        total_cliente += precio_final
    
    print(f"Total del Cliente {numero_cliente}: ${total_cliente:.2f}")
    
    # Preguntamos si se desea procesar a otra persona
    continuar = input("\n¿Deseas procesar otro cliente? (s/n): ")
    numero_cliente += 1

print("\n¡Proceso terminado con éxito!")