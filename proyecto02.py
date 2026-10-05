
def mostrar_menu():
    print ("\n--- APP DE PASOS DIARIOS ---")
    print("1. Registrar pasos del día")
    print("2. Ver historial y el día mas activo")
    print("3. Ordenar historial (Mayor a Menor)")
    print("4.Salir")

def pedir_pasos_diarios():
    pasos = int (input("Ingrese la cantidad  de pasos (ej.10000): "))
    while pasos < 0:
        print("Los pasos no pueden ser negativos.")
        pasos = int(input("Ingrese la cantidad de pasos: "))
    return pasos

def registar_dia (lista_pasos):
    pasos = pedir_pasos_diarios()
    lista_pasos.append(pasos)
    print("¡Registro completado!")

def mostrar_estadisticas(lista_pasos):
    if len(lista_pasos) ==0:
        print ("No hay registros aun.")
    else:
        print("\nHistorial actual:",lista_pasos)
        print("Tu record es:",max(lista_pasos),"pasos")

def ordenar_historial_de_burbuja(lista_pasos):
    n= len(lista_pasos)
    for i in range(n):
        for j in range (n-1):
            if lista_pasos[j] < lista_pasos [j + 1]:
                lista_pasos[j], lista_pasos[j + 1] = lista_pasos[j + 1],lista_pasos[j]
    print("\nHistorial ordenado de mayor a menor:", lista_pasos)


def main():
 historial = []
 while True:
    mostrar_menu()
    opcion = input("Elige una opción: ")
    if opcion == "1":
        registar_dia(historial)
    elif opcion == "2":
        mostrar_estadisticas(historial)
    elif opcion == "3":
        ordenar_historial_de_burbuja(historial)
    elif opcion == "4":
        print ("¡Sigue moviendote! Adios.")
        break
    else :
        print ("Opcion invalida.")
if __name__ == "__main__":
 main()