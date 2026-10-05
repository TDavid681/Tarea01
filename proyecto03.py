def mostrar_menu():
    print("\n --- Registro de protenia diaria ---")
    print("1. Registrar comida")
    print("2. Ver historial y suma total")
    print("3. Eliminar la ultima comida")
    print("4. Salir")

def validar_proteina():
    proteina = float(input("Ingresa los gramos de proteina consumida: "))
    while proteina < 0:
        print("Los gramos de proteina deben ser mayores que 0.")
        proteina = float(input("Ingresa los gramos de proteina consumida: "))
    return proteina

def registrar_comida(lista_gramos):
    proteina = validar_proteina()
    lista_gramos.append(proteina)
    print("¡Registro completado!")

def historial_suma(lista_gramos):
    if len(lista_gramos) == 0:
       print("\nNo hay lista gil de mrd")
       return
    suma_gramos = sum(lista_gramos)
    lista_ordenada = lista_gramos.copy()
    n = len(lista_ordenada)
    for i in range(n):
        for j in range(n-1):
            if lista_ordenada[j] < lista_ordenada [j + 1]:
                lista_ordenada[j], lista_ordenada[j + 1] = lista_ordenada[j + 1] ,lista_ordenada[j]
    print("\nEl historial de prote es:",lista_ordenada)
    print("La suma de gramos es la siguiente :", suma_gramos)

def elminar_comida(lista_gramos):
    if len(lista_gramos) > 0:
       eliminado = lista_gramos.pop()
       print (f"Se elimino el registro de {eliminado} gramos.")
    else:
     print("No hay nada que eliminar")
    

def main ():
 historial_proteinas =[]
 while True:
  mostrar_menu()
  opcion = input("ELige una opcion(1-4):")
  if opcion == "1":
   registrar_comida(historial_proteinas)
  elif opcion == "2":
   historial_suma(historial_proteinas)
  elif opcion == "3":
   elminar_comida(historial_proteinas)
  elif opcion == "4":
    print("Saliendo del programa...")
    break
 else:
   print("Opcion invalida...")

if __name__=="__main__":
   main() 





