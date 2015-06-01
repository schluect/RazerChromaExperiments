using Corale.Colore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Drawing;
using System.Threading;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorContext context = new ColorContext();
            while(true)
            {
                ProcessResults(context);
            }
            context.Dispose();
        }

        private static void ProcessResults(ColorContext context)
        {
            List<ClassLibrary1.Color> colors = context.Colors.Where(x => !x.ActivatedDateTime.HasValue).OrderBy(x => x.QueueDateTime).ToList();
            foreach (ClassLibrary1.Color colorValue in colors)
            {
                try
                {
                    var color = (System.Drawing.Color)new ColorConverter().ConvertFromString(colorValue.ColorValue);
                    // Corale.Colore.Core.Keyboard.Instance.Clear();
                    Corale.Colore.Core.Keyboard.Instance.Set(new Corale.Colore.Core.Color(color.R, color.G, color.B));
                    colorValue.ActivatedDateTime = DateTime.Now;
                    var entity = context.Entry<ClassLibrary1.Color>(colorValue);
                    entity.State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    Console.WriteLine("Changing to: " + colorValue.ColorValue);

                }
                catch (Exception ex)
                {
                    colorValue.ActivatedDateTime = new DateTime(1990, 1, 1);
                    var entity = context.Entry<ClassLibrary1.Color>(colorValue);
                    entity.State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    Console.WriteLine("Failed to change to: " + colorValue.ColorValue);
                }
                Thread.Sleep(5000);
            }
        }
    }
}
