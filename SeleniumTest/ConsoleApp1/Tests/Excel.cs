using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
namespace TelefonosCRUD.Test
{
    public class Excel
    {
        /*public static Excel()
        {

        }*/
        public static Object[] leerExcel(String archivo, int cantcol,int cantreg)
        {
            Object[] lista= new Object[cantreg];

            try
            {

                FileStream file = new FileStream(archivo, FileMode.Open, FileAccess.Read);

                XSSFWorkbook archivoexcel = new XSSFWorkbook(file);
                var a = archivoexcel.GetSheetAt(0);

                int fil = 1;
                bool cellvl = true;
                
                while (cellvl)
                {
                    cellvl = false;
                    String[] listtemp = new String[cantcol];
                    for (int i = 0; i <cantcol ; i++)
                    {
                        String b;
                        try
                        {
                           b = a.GetRow(fil).GetCell(i).StringCellValue;
                        }catch(Exception e)
                        {
                            double c = a.GetRow(fil).GetCell(i).NumericCellValue;
                            b = c.ToString();
                        }
                        listtemp[i] = b;
                        if (!cellvl&&listtemp[i] != "")
                            cellvl = true;
                    }
                    if (cellvl) lista[fil-1] = listtemp;

                    fil++;
                }
               
                archivoexcel.Close();
                archivoexcel.Close();
            }
            catch (Exception e)
            {

            }
            return lista;
        }
    }
}