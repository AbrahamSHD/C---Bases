// ? Bases

using System;

namespace CSharpHelloWorld 
{
    class HelloWorld
    {
        static void Main( string[] args )
        {
            /*
            Console.WriteLine("Hola Mundo desde C#");
            string myString = "Cadena de texto";
            Console.WriteLine( myString );
            */
            
            /*
                ? En C#, la convención para escribir los nombres de las variables sigue el formato camelCase. Esto significa que la primera letra de la variable es minúscula y las palabras subsiguientes empiezan con mayúscula, sin espacios ni guiones bajos.

                * camelCase para variables locales y parámetros de métodos: la primera palabra comienza en minúscula y las siguientes en mayúscula.
                ?{
                    * int totalAmount;
                    * string userName;
                    * bool isActive;
                ?}
                * Campos privados pueden llevar un guion bajo al principio (aunque esto puede variar según las preferencias del equipo o el proyecto).
                ?{
                    * private int _totalAmount;
                    * private string _userName;
                    * private bool _isActive;
                ?}
            */
            int myInt = 11;
            Console.WriteLine($"El valor de MyInt es: { myInt }");
            Console.WriteLine( myInt );

            /*
            ? Bits 128
            * Dígitos significativos	28-29
            ! Aplicación típica	Finanzas, cálculos exactos
            */
            decimal myDecimal = 10.55m;
            Console.WriteLine( $"El valor de MyDecimal es: { myDecimal }" );
            Console.WriteLine( myDecimal );

            /*
            ? Bits 64
            * Dígitos significativos 15-16
            ! Aplicación típica	Científicos, genéricos
            */
            double myDouble = 10.55;
            Console.WriteLine( $"El valor de MyDouble es: { myDouble }" );
            Console.WriteLine( myDouble );
            
            /*
            ? Bits 32
            * Dígitos significativos 6-9
            ! Aplicación típica	Gráficos, videojuegos
            */
            float myFloat = 10.55f;
            Console.WriteLine( $"El valor de MyFloat es: { myFloat }" );
            Console.WriteLine( myFloat );

            bool myBool = false;
            Console.WriteLine( $"El valor de MyBool es: { myBool }" );
            Console.WriteLine( myBool );

            dynamic myDynamic = 6;
            myDynamic = "Mi dato dinámico";
            Console.WriteLine( $"Mi tipo dinámico es: { myDynamic + myDecimal }" );
            Console.WriteLine( myDynamic );

            /*
                ? En C#, la convención estándar para nombrar constantes es usar mayúsculas y separar las palabras con guiones bajos (_). Esta convención es conocida como PascalCase para constantes globales y UPPER_CASE para constantes locales.

                * Uso de mayúsculas.
                * Separación por guiones bajos (_).
                * No se usa camelCase o PascalCase para constantes.
            */
            const string MY_CONST = "Mi constante 'String'";
            Console.WriteLine( MY_CONST );

            // ? Estructuras
            
            var myArray = new string[] { "A", "B", "C", "D", "E" };
            Console.WriteLine( myArray[0] );

            // * <clave, valor>
            var myDictionary = new Dictionary<string, int> 
            {
                {"Perro", 10},
                {"Gato", 10},
                {"Ratón", 10},
            };

            // ? Estructura desordenada
            var mySet = new HashSet<string> { "A", "B", "C", "D", "E", "E", "E" };

            var myTuple = ( "A", "B", "C", "D", "E", "myTuple" );
            Console.WriteLine(myTuple);

            // ? Bucles
            
            for ( int index = 0; index < 10; index++ )
            {
                Console.WriteLine(index);
            }

            Console.WriteLine("---------");
            
            foreach ( var item in myArray )
            {
                Console.WriteLine( item );
            };

            Console.WriteLine("---------");
            
            foreach ( var item in myDictionary )
            {
                Console.WriteLine( item );
            };

            Console.WriteLine("---------");
            
            foreach ( var item in mySet )
            {
                Console.WriteLine( item );
            };

            Console.WriteLine("---------");

            // ? Flujos

            // * Se pueden cumplir varios Criterios
            // ? Ejemplo 
            // * if ( myInt == 11 && myBool == true )
            // * else if ( myInt == 11 || myBool == true )
            if ( myInt == 11 )
            {
                Console.WriteLine("If - El valor de myInt es 11");
            }
            else if ( myInt == 12 )
            {
                Console.WriteLine("If - El valor de myInt es 12");
            }
            else 
            {
                Console.WriteLine("El valor de myInt no es 11 ni 12");
            }

            Console.WriteLine("---------");

            MyFunction();
            Console.WriteLine( MyFunctionWithReturn(12) );

            Console.WriteLine("---------");
            var myClass = new MyClass("MyName");
            Console.WriteLine( myClass.MyName );

        }

        // ? Funciones
        static void MyFunction()
        {
            Console.WriteLine("My Function");
        }

        static int MyFunctionWithReturn( int param )
        {
            return 10 + param;
        }

        class MyClass 
        {
            // * Es una propiedad pública de tipo string
            public string MyName { get; set; }

            // * Constructor
            public MyClass( string myCurrentName ) 
            {
                MyName = myCurrentName;
            }
        }
    }

}


// ? Herencia

// var sale  = new SaleWithTax(10, 1.16m);
// var message = sale.GetInfo();

// Console.WriteLine(message);

// class SaleWithTax: Sale
// {
//     public decimal Tax { get; set; }

//     public SaleWithTax(decimal total, decimal tax) : base(total)
//     {
//         Tax = tax;
//     }

//     public override string GetInfo()
//     {
//         return $"El total es: { Total } y el impuesto es: { Tax }";
//     }
// }

// class Sale
// {
//     public decimal Total { get; set; }

//     public Sale(decimal total) 
//     {
//         Total = total;
//     }

//     public virtual string GetInfo()
//     {
//         return $"El total es { Total }";
//     }

// }

// ? Interfaces

// var sale = new Sale();
// var beer = new Beer();

// Some(sale);
// Some(beer);

// void Some(ISave save)
// {
//     save.Save();
// }

// interface ISale
// {
//     decimal Total { get; set; }

// }

// interface ISave
// {
//     public void Save();
// }

// public class Sale: ISale, ISave
// {
//     public decimal Total { get; set; }

//     public void Save()
//     {
//         Console.WriteLine("Sale se guardó");
//     }
// }

// public class Beer: ISave
// {
//     public void Save()
//     {
//         Console.WriteLine("Beer se guardó en la BD");
//     }
// }

// ? Generics

// var numbers = new MyList<int>(10);
// var names = new MyList<string>(10);
// public class MyList <T> 
// {
//     private List<T> _list;
//     private int _limit;

//     public MyList( int limit ) 
//     {
//         _limit = limit;
//     }

//     public void Add(T element) 
//     {
//         if ( _list.Count < _limit ) 
//         {
//             _list.Add(element);
//         }
//     }
// }