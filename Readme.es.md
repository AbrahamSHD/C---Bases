# Proyecto de Bases en C#

Este proyecto tiene como objetivo proporcionar una introducción a los fundamentos del lenguaje de programación C#. A lo largo del código, se exploran conceptos básicos como variables, tipos de datos, herencia, interfaces y genéricos. A continuación se describen los principales temas cubiertos:

## Contenido

1. **Variables y Tipos de Datos Básicos**  
   El proyecto comienza con la declaración y uso de variables en C#, cubriendo varios tipos de datos como `int`, `decimal`, `double`, `float`, `bool` y `dynamic`. También se demuestra el uso de interpolación de cadenas para imprimir los valores de estas variables en consola.

2. **Herencia**  
   Se muestra un ejemplo de cómo funciona la herencia en C#, creando una clase base `Sale` y una clase derivada `SaleWithTax`. La clase derivada hereda de la clase base y sobrescribe el método `GetInfo` para agregar más detalles específicos de la clase derivada.

3. **Interfaces**  
   El proyecto introduce las interfaces mediante la creación de dos interfaces: `ISale` y `ISave`. Se ejemplifica cómo una clase puede implementar varias interfaces, lo que le permite tener diferentes responsabilidades. La clase `Sale` y `Beer` implementan la interfaz `ISave`, lo que les permite usar el método `Save` para realizar una acción definida por cada clase.

4. **Genéricos**  
   Se presenta el uso de genéricos en C# mediante la implementación de una clase `MyList<T>`, que puede almacenar cualquier tipo de datos y tiene un límite de elementos que puede contener. Esto se hace posible gracias a los genéricos, que permiten trabajar con tipos de datos de manera más flexible y reutilizable.

## Estructura del Proyecto

El proyecto está compuesto por un archivo principal llamado `Program.cs`, donde se encuentran implementados los ejemplos de código que ilustran los conceptos mencionados.

## Requisitos

- **.NET SDK**: Para ejecutar el proyecto, necesitas tener instalado el SDK de .NET.
- **Editor**: Se recomienda usar un editor como Visual Studio o Visual Studio Code para desarrollar y ejecutar el código.

## Cómo Ejecutar

1. Clona este repositorio en tu máquina local.
2. Abre una terminal o línea de comandos.
3. Navega hasta la carpeta del proyecto.
4. Ejecuta el siguiente comando para compilar y ejecutar el proyecto:

   ```bash
   dotnet run
