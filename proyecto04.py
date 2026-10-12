def mostrar_menu():
    print ("\n--- RASTREADOR DE PRECIOS DE VIDEOJUEGOS ---")
    print("1. Registrar precio")
    print("2. Ver lista ordenda y el mas barato")
    print("3. Eliminar el ultimo precio registrado")
    print("4. Salir")

def validar_precios():
    precios = int (input("Ingrese el precio del videojuego (ej.10000): "))
    while precios < 0:
        print("Los precios no pueden ser negativos.")
        precios = int(input("Ingrese el precio del videojuego: "))
    return precios

def agregar_precios(lista_precios):
    precios = validar_precios()
    lista_precios.append(precios)
    print("¡Registro completado!")

def ordenar_historial_de_burbuja(lista_precios):
    n = len(lista_precios)
    for i in range(n):
        for j in range(n - 1):
            if lista_precios[j] > lista_precios[j + 1]:
                lista_precios[j], lista_precios[j + 1] = lista_precios[j + 1], lista_precios[j]
    print("\nVideojuegos ordenados del mas barato al mas caro :", lista_precios)

def eliminar_ultimo_precio(lista_precios):
    if len(lista_precios) > 0:
        eliminado = lista_precios.pop()
        print(f"Se elimino el registro de ${eliminado}.")
    else:
        print("No hay nada que eliminar.")

def main():
 precios_juegos = []
 while True:
    mostrar_menu()
    opcion = input("Elige una opción: ")
    if opcion == "1":
        agregar_precios(precios_juegos)
    elif opcion == "2":
        ordenar_historial_de_burbuja(precios_juegos)
    elif opcion == "3":
        eliminar_ultimo_precio(precios_juegos)
    elif opcion == "4":
        print ("¡Buena suerte! Adios.")
        break
    else :
        print ("Opcion invalida.")
if __name__ == "__main__":
 main()