using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Volkov_HW_UML_10
{
    internal class VideoCard
    {
        public void BeginWork()
        {
            Console.WriteLine("Видеокарта: запуск");
            Console.WriteLine("Видеокарта: проверка связи с монитором");
        }
        public void BeginWork2()
        {
            Console.WriteLine("Видеокарта: вывод данных об оперативной памяти");
        }

        public void BeginWork3()
        {
            Console.WriteLine("Видеокарта: вывод информации об устройстве чтения дисков");
        }

        public void BeginWork4()
        {
            Console.WriteLine("Видеокарта: вывод данных о винчестере");
        }



        public void EndWork()
        {
            Console.WriteLine("Видео карта: вывести на монитор данные прощальное сообщение");
        }
    }

    internal class PowerUnit
    {
        Sensor obj;

        public PowerUnit()
        {
            obj = new Sensor();
        }

        public void BeginWork()
        {
            Console.WriteLine("Блок питания: Подать питание");
            obj.BeginWork();
            Console.WriteLine("Блок питания: Подать питание на видеокарту");
        }

        public void BeginWork2()
        {
            Console.WriteLine("Блок питания: подать температуру в оперативной памяти");
        }

        public void BeginWork3()
        {
            Console.WriteLine("Блок питания: подать питание на устройство чтения дисков");
        }

        public void BeginWork4()
        {
            Console.WriteLine("Блок питания: подать питание на винчестер");
        }


        public void EndWork()
        {
            Console.WriteLine("Блок питания: прекратить питание видео карты");
            Console.WriteLine("Блок питания: прекратить питание оперативной памяти");
            Console.WriteLine("Блок питания: прекратить питание устройства чтения дисков");
            Console.WriteLine("Блок питания: прекратить питание винчестера");
        }

        public void EndWork2()
        {
            Console.WriteLine("Блок питания: выключение");
        }
    }

    internal class Sensor
    {
        public void BeginWork()
        {
            Console.WriteLine("Датчик: Проверяет напряжение");
            Console.WriteLine("Датчик: Проверяет температуру в блоке питания");
            Console.WriteLine("Датчик: Проверяет температуру в видеокарте");
        }
        public void BeginWork2()
        {
            Console.WriteLine("Датчик: проверить температуру в оперативной памяти");
        }

        public void BeginWork3()
        {
            Console.WriteLine("Датчики: проверить температуру всех систем");
        }

        public void EndWork() 
        {
            Console.WriteLine("Датчики проверить напряжение");
        }
    }

    internal class RAM
    {
        public void BeginWork() 
        {
            Console.WriteLine("Оперативная память: запуск устройств");
            Console.WriteLine("Оперативная память: анализ памяти");
        }

        public void EndWork()
        {
            Console.WriteLine("Оперативная память: очистка памяти");
            Console.WriteLine("Оперативная память: анализ памяти");
        }
    }

    internal class ReadDisk
    {
        public void BeginWork()
        {
            Console.WriteLine("Устройство чтения оптических дисков: запуск");
            Console.WriteLine("Устройство чтения оптических дисков: проверка наличия диска");
        }

        public void EndWork()
        {
            Console.WriteLine("Устройство чтения дисков: вернуть в исходную позицию");
        }
    }

    internal class Disk
    {
        public void BeginWord()
        {
            Console.WriteLine("Винчестер: запуск");
            Console.WriteLine("Винчестер: проверка загрузочного сектора");
        }

        public void EndWork()
        {
            Console.WriteLine("Винчестер: остановка устройства");
        }
    }


    internal class Facade
    {
        RAM ram;
        Disk disk;
        ReadDisk readdisk;
        Sensor sensor;
        PowerUnit powerunit;
        VideoCard videocard;

        public Facade(RAM ram, Disk disk, ReadDisk readdisk, Sensor sensor, PowerUnit powerunit, VideoCard videocard)
        {
            this.ram = ram;
            this.disk = disk;
            this.readdisk = readdisk;
            this.sensor = sensor;
            this.powerunit = powerunit;
            this.videocard = videocard;
        }

        public void Start()
        {
            powerunit.BeginWork();
            videocard.BeginWork();
            sensor.BeginWork2();
            powerunit.BeginWork2();
            ram.BeginWork();
            videocard.BeginWork2();
            powerunit.BeginWork3();
            readdisk.BeginWork();
            videocard.BeginWork3();
            powerunit.BeginWork4();
            disk.BeginWord();
            videocard.BeginWork4();
            sensor.BeginWork3();
        }

        public void End()
        {
            disk.EndWork();
            ram.EndWork();
            videocard.EndWork();
            readdisk.EndWork();
            powerunit.EndWork();
            sensor.EndWork();
            powerunit.EndWork2();
        }
    }


    internal class Client
    {
        public void StartPC(Facade obj)
        {
            obj.Start();
        }

        public void StopPC(Facade obj)
        {
            obj.End();
        }
    }
}
