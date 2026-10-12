def menu():
    print ("\n--- CATALOGO DE PELICULAS ---")
    print("1. Registrar pelicula")
    print("2. Mostrar catalogo ordenado (A-Z)")
    print("3. Buscar por palabra clave")
    print("4. Salir")

def registrar_pelicula(peli,direc):
    pelicula = input("Ingrese el nombre de la pelicula: ")
    director = input("Ingrese el nombre del director: ")
    director = director.strip().lower()
    pelicula = pelicula.strip().lower()
    while not pelicula or not director:
        print("Error: El nombre de la pelicula y el director son obligatorios.")
        pelicula = input("Ingrese el nombre de la pelicula: ")
        director = input("Ingrese el nombre del director: ")
        director = director.strip().lower()
        pelicula = pelicula.strip().lower()
    peli.append(pelicula)
    direc.append(director)
    print("¡Registro completado!")

def mostrar_catalogo_ordenado(peli,direc):
    if len(peli) == 0:
        print("No hay peliculas registradas.")
        return
    n = len(peli)
    for i in range(n):
        for j in range(n - 1):
            if peli[j] > peli[j + 1]:
                peli[j], peli[j + 1] = peli[j + 1], peli[j]
                direc[j], direc[j + 1] = direc[j + 1], direc[j]
    print("\n--- CATALOGO DE PELICULAS (A-Z) ---")
    n = len(peli)
    for i in range(n):
        print(f"Película: {peli[i].title()}, Director: {direc[i].title()}")

def buscar_por_palabra_clave(peli,direc):
    buscado = input("¿Que pelicula o director buscas?: ")
    buscado = buscado.strip().lower()
        
    encontrado = False
    n=len(peli)                     
    for i in range(n):
            # TEMA 4.4 y 4.2: Comparamos convirtiendo ambos a minúsculas[cite: 419, 420]
         if buscado in peli[i].lower() or buscado in direc[i].lower() :
                print(f"-> {peli[i].title()} fue hecho por el director {direc[i].title()}")
                encontrado = True
                
    if not encontrado:
            print("Pelicula o director no encontrado.")

def main():
    peliculas = []
    directores = []
    while True:
        menu()
        opcion = input("Elige una opción: ")
        if opcion == "1":
            registrar_pelicula(peliculas,directores)
        elif opcion == "2":
            mostrar_catalogo_ordenado(peliculas,directores)
        elif opcion == "3":
            buscar_por_palabra_clave(peliculas,directores)
        elif opcion == "4":
            print ("¡Hasta luego! Adios.")
            break
        else :
            print ("Opcion invalida.") 

if __name__ == "__main__":
    main()