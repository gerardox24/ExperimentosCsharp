using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonosCRUD.Test;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] lista = Excel.leerExcel(@"D:\data\Datos.xlsx", 5, 2);
            //Excel temp = new Excel();

            //lista =Excel.leerExcel();
            //arr1= Excel.leerExcel(@"D:\data\Datos.xlsx", 3, 5);
            //lista = Excel.leerExcel(@"D:\dat
            Console.ReadKey();
        }
    }
}
