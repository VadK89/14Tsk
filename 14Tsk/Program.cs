using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Tsk
{
    /*Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:

    абстрактное свойство - название животного.

    В классе Animal нужно определить следующие методы:

    конструктор, устанавливающий значение по умолчанию для названия;
    абстрактный метод Say(), который выводит звук, который издает животное;
    неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).

     Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:

    свойство – название животного;
    метод Say (), выводящий на экран «Мяу» либо «Гав» соответственно.

     Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.      
     */
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем экземпляры классов для проверки
            Console.WriteLine("Введите слово собака)");
            string type= Console.ReadLine();
            Dog dog = new Dog(type);
            dog.ShowInfo();
            Console.WriteLine("Введите слово кошка)");
            string type1= Console.ReadLine();
            Cat cat = new Cat(type1);
            cat.ShowInfo();
            Console.ReadKey();
        }
    }
    //Создаем абстрактный класс
    abstract class Animal
    {
        public abstract string AnimalTit { get; set; }//Задаем абстрактное свойство - название животного.
        //Задаем конструктор поумолчанию
        public Animal(string title)
        {
            AnimalTit = title;
        }
        //Задаем абстрактный метод для издаваемого звука
        public abstract void Say();

        //Задаем метод для вывода информации
        public void ShowInfo()
        {
            Console.WriteLine("Это {0}", AnimalTit);
            Say();
        }
    }
    //создаем дочерный класс собака
    class Dog : Animal
    {
        string anit;
        // Задаем свойство – название животного

        public override string AnimalTit
        {
            get
            {
                return anit;

            }
            set
            {
                anit = value;
            }
        }
        //Задаем конструктор для создания экземпляра в основной программе
        public Dog(string title)
            :base(title)
        {
           
        } 
        //Задаем издаваемый звук
        public override void Say()
        {
            Console.WriteLine("Гав гав");            
        }
        

    }
    //создаем дочерний класс кошка
    class Cat : Animal
    {
        string anit1;
        // Задаем свойство – название животного

        public override string AnimalTit
        {
            get
            {
                return anit1;

            }
            set
            {
                anit1 = value;
            }
        }
        //Задаем конструктор для создания экземпляра в основной программе
        public Cat(string title)
            :base(title)
        {
           
        }
        //Задаем издаваемый звук
        public override void Say()
        {
            Console.WriteLine("Мяу мяу мяу");            
        }
    }
    
}
