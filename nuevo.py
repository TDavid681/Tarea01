import os

# ========================================================
# TEMA 3: PROGRAMACIÓN ORIENTADA A OBJETOS (El Molde)
# ========================================================
class Venta:
    def __init__(self, codigo, cliente, producto, monto):
        self.codigo = codigo
        self.cliente = cliente
        self.producto = producto
        self.monto = monto

# ========================================================
# TEMA 2: MODULARIDAD (El Gestor)
# ========================================================
class GestorTienda:
    def __init__(self):
        # TEMA 3: Lista unidimensional de objetos
        self.ventas = []
        self.archivo_bd = "ventas_tienda.txt"
        
        # TEMA 5: Cargar datos al iniciar el programa
        self.cargar_archivo()

    # ----------------------------------------------------
    # TEMA 5: PERSISTENCIA (Lectura de CSV/TXT)
    # ----------------------------------------------------
    def cargar_archivo(self):
        if os.path.exists(self.archivo_bd):
            with open(self.archivo_bd, "r") as archivo:
                for linea in archivo:
                    # TEMA 5: split() para separar por comas
                    datos = linea.strip().split(",")
                    if len(datos) == 4:
                        # Reconstruimos el objeto Venta desde el texto
                        v = Venta(datos[0], datos[1], datos[2], float(datos[3]))
                        self.ventas.append(v)
            print("[SISTEMA] Base de datos cargada correctamente.")
        else:
            print("[SISTEMA] Archivo nuevo. Empezando de cero.")

    def guardar_archivo(self):
        # TEMA 5: Escritura en archivo ("w" sobrescribe con la lista actualizada)
        with open(self.archivo_bd, "w") as archivo:
            for v in self.ventas:
                # Formato CSV: Valor1,Valor2,Valor3,Valor4
                archivo.write(f"{v.codigo},{v.cliente},{v.producto},{v.monto}\n")

    # ----------------------------------------------------
    # TEMA 1 y 4: LÓGICA DE REGISTRO Y STRINGS
    # ----------------------------------------------------
    def registrar_venta(self):
        codigo = f"VEN-{len(self.ventas) + 1}"
        
        # TEMA 4: Manipulación de Strings (.strip() quita espacios, .upper() a mayúsculas)
        cliente = input("Nombre del cliente: ").strip().upper()
        producto = input("Zapatilla/Producto: ").strip().capitalize()
        
        monto = float(input("Monto total: S/ "))
        # TEMA 1: Bucle while para validar errores
        while monto <= 0:
            print("¡Error pe! No puedes vender gratis o en negativo.")
            monto = float(input("Monto total válido: S/ "))
            
        nueva_venta = Venta(codigo, cliente, producto, monto)
        self.ventas.append(nueva_venta)
        
        # Guardamos automáticamente en el txt
        self.guardar_archivo()
        print(f"\n[OK] Venta {codigo} a {cliente} registrada y guardada en disco.")

    # ----------------------------------------------------
    # TEMA 4: BÚSQUEDA TEXTUAL
    # ----------------------------------------------------
    def buscar_cliente(self):
        buscado = input("Ingrese el nombre del cliente a buscar: ").strip().upper()
        encontrado = False
        
        print(f"\n--- RESULTADOS PARA '{buscado}' ---")
        for v in self.ventas:
            # TEMA 4: Búsqueda textual parcial usando 'in'
            if buscado in v.cliente:
                print(f"Código: {v.codigo} | Producto: {v.producto} | Pagó: S/ {v.monto}")
                encontrado = True
                
        if not encontrado:
            print("No le hemos vendido nada a ese cliente.")

    # ----------------------------------------------------
    # TEMA 3: ALGORITMO DE ORDENAMIENTO (Burbuja)
    # ----------------------------------------------------
    def ordenar_ventas_top(self):
        n = len(self.ventas)
        # Ordenamiento Burbuja por Monto (De mayor a menor)
        for i in range(n - 1):
            for j in range(n - 1 - i):
                if self.ventas[j].monto < self.ventas[j + 1].monto:
                    # Intercambio de objetos completos
                    aux = self.ventas[j]
                    self.ventas[j] = self.ventas[j + 1]
                    self.ventas[j + 1] = aux
                    
        print("\n[OK] Ventas ordenadas de la más cara a la más barata.")
        self.guardar_archivo() # Guardamos el nuevo orden en el TXT

    def mostrar_todas(self):
        if len(self.ventas) == 0:
            print("\n[!] No hay ventas registradas.")
            return
            
        print("\n--- HISTORIAL DE VENTAS ---")
        total = 0
        for v in self.ventas:
            print(f"{v.codigo} | {v.cliente} | {v.producto} | S/ {v.monto}")
            total += v.monto
        print("-" * 30)
        print(f"INGRESOS TOTALES: S/ {total}")


# ========================================================
# EL MENÚ PRINCIPAL (TEMA 1 y 2)
# ========================================================
def main():
    tienda = GestorTienda()
    
    while True:
        print("\n=== SNEAKER STORE VIRTUAL ===")
        print("1. Registrar nueva venta")
        print("2. Buscar compras de un cliente")
        print("3. Ordenar ventas (Top más caras)")
        print("4. Ver todo el historial")
        print("5. Salir")
        
        op = input("Elige (1-5): ")
        
        if op == "1":
            tienda.registrar_venta()
        elif op == "2":
            tienda.buscar_cliente()
        elif op == "3":
            tienda.ordenar_ventas_top()
        elif op == "4":
            tienda.mostrar_todas()
        elif op == "5":
            print("Cerrando caja. ¡Nos vemos!")
            break
        else:
            print("Opción inválida choche, marca bien.")

if __name__ == "__main__":
    main()