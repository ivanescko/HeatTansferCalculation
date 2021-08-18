using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace Lib1
{
    [Serializable]
    public class cHeatCalculation
    {
        /// <summary>
        /// Сохранение исходных данных объекта на диск
        /// </summary>  
        /// <param name="hc">Объект  для сохранения на диск</param>
        /// <param name="NameFile">Имя файла для сохранения</param>
        public void SaveData(cHeatCalculation hc, string NameFile)
        {
            FileStream myStream = File.Create(NameFile);
            SoapFormatter myXMLFormat = new SoapFormatter();
            myXMLFormat.Serialize(myStream, hc);
            myStream.Close();
        }

        /// <summary>
        /// Загрузить исходные данные в экземпляр объекта расчета 
        /// </summary>  
        /// <param name="NameFile">Имя файла для извлечения данных</param>
        public cHeatCalculation LoadData(string FileName)
        {
            // Восстановить данные путем десериализации из XML-файла            
            SoapFormatter myXMLFormat = new SoapFormatter();
            FileStream myStreamB = File.OpenRead(FileName);
            cHeatCalculation _hc = (cHeatCalculation)myXMLFormat.Deserialize(myStreamB);
            myStreamB.Close();
            return _hc;
        }

        public double TemperatureWork /*температура рабочей среды в печи, K*/
        {
            set;
            get;
        }
        public double AlfaWork /*коэффициент теплоотдачи от рабочей среды к внутренней поверхности стенки, Вт/(м2 К)*/
        {
            set;
            get;
        }
        public double Lambda /*коэффициент теплопроводности огнеупорной стенки, Вт/(м К)*/
        {
            set;
            get;
        }
        public double Thickness /*толщина огнеупорной стенки, м*/
        {
            set;
            get;
        }
        public double TemperatureExternal /*температура наружной (окружающей) среды, К*/
        {
            set;
            get;
        }
        public double AlfaExternal /*коэффициент теплоотдачи от наружной поверхности стенки к окружающей среде, Вт/(м2 К)*/
        {
            set;
            get;
        }
        public double GetRWork() /*расчет теплового сопротивления при передачи теплоты от рабочей среды к стенке печи, (м2 К) /Вт*/
        {
            return 1.0d / AlfaWork;
        }
        public double GetRWall() /*расчет теплового сопротивления огнеупорной стенки печи, (м2 К) /Вт*/
        {
            return 1.0d / Lambda;
        }
        public double GetRExternal() /*расчет теплового сопротивления при передачи теплоты от стенки печи к наружной (окружающей) среде, (м2 К) /Вт*/
        {
            return 1.0d / AlfaExternal;
        }
        public double GetQ() /*расчет плотности теплового потока через огнеупорную стенку, Вт/м2*/
        {
            return Math.Round((TemperatureWork - TemperatureExternal) / (GetRWork() + GetRWall() + GetRExternal()), 4);
        }
    }
}
