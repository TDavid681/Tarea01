def registrar_empleado(nombres, departamentos):
    # Ingresamos el texto
    nom = input("Ingresa el nombre del empleado: ")
    dep = input("Ingresa su departamento (ej. Ventas, IT): ")
    
    # TEMA 4.2: Transformación de texto
    # Limpiamos espacios accidentales y ponemos formato Título (Primera mayúscula)
    nom = nom.strip().capitalize()
    dep = dep.strip().upper() 
    
    # TEMA 4.3: Arreglos paralelos
    nombres.append(nom)
    departamentos.append(dep)
    print(f"¡{nom} registrado en {dep}!")

def ordenar_alfabeticamente(nombres, departamentos):
    n = len(nombres)
    for i in range(n):
        for j in range(n - 1):
            # TEMA 4.4: Comparación de textos
            # Compara alfabéticamente. "Ana" < "Zacarias"
            if nombres[j] > nombres[j + 1]:
                # TEMA 4.3: Si movemos el nombre, DEBEMOS mover su departamento
                nombres[j], nombres[j + 1] = nombres[j + 1], nombres[j]
                departamentos[j], departamentos[j + 1] = departamentos[j + 1], departamentos[j]
    print("¡Directorio ordenado de la A a la Z!")

def buscar_empleado(nombres, departamentos):
    buscado = input("¿A quién buscas?: ")
    # Estandarizamos la búsqueda para evitar errores
    buscado = buscado.strip().lower()
    
    encontrado = False
    for i in range(len(nombres)):
        # TEMA 4.4 y 4.2: Comparamos convirtiendo ambos a minúsculas[cite: 419, 420]
        if nombres[i].lower() == buscado:
            print(f"-> {nombres[i]} trabaja en el departamento de {departamentos[i]}")
            encontrado = True
            
    if not encontrado:
        print("Empleado no encontrado.")

def main():
    lista_nombres = ["carlos", "Ana", "luis"]
    lista_departamentos = ["VENTAS", "GERENCIA", "SOPORTE"]
    
    # Para el ejemplo, primero estandarizamos los datos iniciales
    for i in range(len(lista_nombres)):
        lista_nombres[i] = lista_nombres[i].capitalize()
    
    ordenar_alfabeticamente(lista_nombres, lista_departamentos)
    buscar_empleado(lista_nombres, lista_departamentos)

if __name__ == "__main__":
    main()