# Semana 1 - Cálculos Geométricos

## Descripción
Proyecto de la **Semana 1** que implementa cálculos geométricos básicos para figuras en el plano cartesiano 2D.

## Clases Principales

### 1. **Punto**
Estructura que representa un punto en el plano (x, y).
- Propiedades: `X`, `Y`
- Método: `DistanciaHacia()` - calcula la distancia entre dos puntos

### 2. **Operaciones**
Clase estática con operaciones matemáticas reutilizables.
- `CalcularDistancia(p1, p2)` - distancia entre dos puntos
- `CalcularPerimetro(puntos)` - suma de lados de un polígono
- `CalcularArea(puntos)` - área usando fórmula del determinante

### 3. **Triangulo**
Representa un triángulo con 3 vértices.
- Propiedades: `Punto1`, `Punto2`, `Punto3`
- Métodos: `Distancia()`, `Perimetro()`, `Area()`

### 4. **Rectangulo**
Representa un rectángulo con 4 vértices.
- Propiedades: `Punto1`, `Punto2`, `Punto3`, `Punto4`
- Métodos: `Distancia()`, `Perimetro()`, `Area()`

## Cómo usar

Al ejecutar el programa, se muestra un menú:

```
=== Cálculos Geométricos ===
1. Triángulo
2. Rectángulo
Seleccione opción (1 o 2):
```

Ingresa las coordenadas (x, y) de cada punto y el programa calcula:
- Perímetro
- Área
- Distancias entre vértices

## Ejemplo de uso

**Triángulo (3, 4, 5):**
```
Punto 1 - X: 0
Punto 1 - Y: 0
Punto 2 - X: 3
Punto 2 - Y: 0
Punto 3 - X: 0
Punto 3 - Y: 4

Triángulo: P1(0, 0), P2(3, 0), P3(0, 4)
Perímetro: 12.00
Área: 6.00
```

## Tecnología
- **.NET 8**
- **C#**
- **Visual Studio 2026**

## Estructura del proyecto
```
Semana012026B/
├── Punto.cs           # Estructura del punto
├── Operaciones.cs     # Clase estática de operaciones
├── Triangulo.cs       # Clase del triángulo
├── Rectangulo.cs      # Clase del rectángulo
├── Program.cs         # Menú principal
└── Producto.cs        # Clase auxiliar (de ejercicios anteriores)
```
