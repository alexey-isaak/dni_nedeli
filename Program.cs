using System;
 
namespace dni
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер дня недели: ");
            int dayindex = int.Parse(Console.ReadLine());
             
    switch ( dayindex ) {
        case 1 :
            Console.WriteLine( "Понедельник" );
            break;
        case 2 :
            Console.WriteLine( "Вторник" );
            break;
        case 3 :
            Console.WriteLine( "Среда" );
            break;
        case 4 :
            Console.WriteLine( "Четверг" );
            break;
        case 5 :
            Console.WriteLine( "Пятница" );
            break;
        case 6 :
            Console.WriteLine( "Суббота" );
            break;
        case 7 :
            Console.WriteLine( "Воскресенье" );
            break;
        default :
            Console.WriteLine( "Неожиданный номер дня недели" );
            break;
      
        }
    }
}
}