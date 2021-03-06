﻿//сережа запусти программу


using System;           //В языке с# существуют заранее написанные части кода, которые 
                        //позволяют например выводить сообщения на экран, считывать данные с клавиатуры и так далее. 
                        //Это уже сделанно - для нашего как программистов удобства, чтобы не приходилось даже самые базовые вещи писать с нуля
                        //system - это пространство имен. Можно воспринимать это как способ группировки написанных частей кода.

namespace DRE           //Так DRE - тоже пространство имен, и все что ты напишешь здесь будет находиться в пространстве имен DRE.
{                       //В будущем при помощи этого ты сможешь пользоваться кодом написанным ранее используя это пространство имен.
    
    
    class Program       //Класс - если вкратце - это тип данных который ты создаешь. Oн может группировать )
                        //данные и операции над ними(Но это довольно продвинутая тема, так что пока что не стоит заморачиваться
    {                      
        static void Main(string[] args)//Здесь ты видишь функцию. функция - это блок кода имеющий имя(Main), 
                                       //входные параметры(args который имеет тип string[])
                                       //и тип возвращаемого значения (в данном случае - void - 
                                       //значит что функция ничего не возвращает из себя, а только чтото делает)
                                       //насчет слова static - пока что заморачиваться не стоит

        {                              // символы { и } - отделяют различные части кода, так - здесь начинается main, а заканчивается 
                                       //там где стоит соответствующая закрывающая скобочка
            //со всем остальным придется разбираться самостоятельно. просто изучи каждое слово которое тут написано
            //и постарайся скомпоновать все вместе в своей голове. Позвони как разберешься:), или как поймешь что надо что-то спросить
            char[] letters ={          
                '\u041F',
                '\u0418',
                '\u0414',
                '\u0410',
                '\u0420' };
            Console.Write("Sergey is a ");
            foreach (char ch in letters)
                Console.Write(ch);
        }
    }
}
