using System;
using System.Windows.Forms;
/// <summary>
/// С#2 ДЗ Урок_1 Гусач Игорь
/// 
///  1. Добавить свои объекты в иерархию объектов, чтобы получился красивый задний фон,
///     похожий на полет в звездном пространстве.
///  2. * Заменить кружочки картинками, используя метод DrawImage.
///  3. * Разработать собственный класс-заставку SplashScreen, аналогичный классу Game.Создать
///     в нем собственную иерархию объектов и задать их движение. Предусмотреть кнопки «Начало
///     игры», «Рекорды», «Выход». Добавить на заставку имя автора.
/// 
/// </summary>
namespace MyGamePrototype
{
    class Program 
    {
        static void Main (string[] args)
        {
            Form form = new Form();
            form.Width = 800;
            form.Height = 600;            
            Game.Init(form);
            form.Show();
            Scenery.Draw();
            Application.Run(form);
        }
    }
}
