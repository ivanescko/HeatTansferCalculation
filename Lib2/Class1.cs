using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace Lib2
{
    
    [Serializable]
    public class cHeatCalculation
    {
        cWall Wall = new cWall();
        cMedium MediumHeat = new cMedium();
        cMedium MediumQ = new cMedium();

        public double Thickness;

        public void SetWallCountLayers(int d)
        {
            Wall.CountLayers = d;
        }
        public void SetMediumHeatAlfa(double d)
        {
            if (d < 0)
                throw new ArgumentException("Ошибка ввода коэффициента теплоотдачи", "d");
            else
                MediumHeat.Alfa = d;
        } // проверить позже
        public void SetMediumHeatTemperature(double d)
        {
            MediumHeat.Temperature = d;
        }
        public void SetMediumQAlfa(double d)//MediumOut
        {
            MediumQ.Alfa = d;
        }
        public void SetMediumQTemperature(double d)
        {
            MediumQ.Temperature = d;
        }
        public void SetWallLambda1(double f)
        {
            Wall.Lambda1 = f;
        }
        public void SetWallLambda2(double f)
        {
            Wall.Lambda2 = f;
        }

        //public void SetWallLamdaMin(double f)
        //{
        //    Wall.LambdaMin = f;
        //}
        //public void SetWallLamdaMax(double f)
        //{
        //    Wall.LambdaMax = f;
        //}
        public void SetWallThickness1(double f)
        {
            Wall.Thickness1 = f;
        }
        public void SetWallThickness2(double f)
        {
            Wall.Thickness2 = f;
        }
        public double GetWallCountLayers()
        {
            return Wall.CountLayers;
        }
        public double GetMediumHeatAlfa()
        {
            double _d = MediumHeat.Alfa;
            return _d;
        }

        public cHeatCalculation LoadData(string FileName)
        {
            // Восстановить данные путем десериализации из XML-файла            
            SoapFormatter myXMLFormat = new SoapFormatter();
            FileStream myStreamB = File.OpenRead(FileName);
            cHeatCalculation _hcc = (cHeatCalculation)myXMLFormat.Deserialize(myStreamB);
            myStreamB.Close();
            return _hcc;
        }

        public double GetMediumHeatTemperature()
        {
            double _d = MediumHeat.Temperature;
            return _d;
        }
        /// <summary>
        /// Показать коэффициент теплоотдачи окружающей среды
        /// </summary>  
        public double GetQMediumAlfa()
        {
            double _d = MediumQ.Alfa;
            return _d;
        }
        /// <summary>
        /// Показать температуру окружающей среды
        /// </summary>  
        public double GetQMediumTemperature()
        {
            double _d = MediumQ.Temperature;
            return _d;
        }

        public void SaveData(cHeatCalculation exmpl, string NameFile)
        {
            FileStream myStream = File.Create(NameFile);
            SoapFormatter myXMLFormat = new SoapFormatter();
            myXMLFormat.Serialize(myStream, exmpl);
            myStream.Close();
        }
        #region Огнеупорная стенка

        /// <summary>
        /// Показать коэффициент теплопроводности огнеупорной стенки
        /// </summary>  
        public double GetWallLambda1()
        {
            double _d = Wall.Lambda1;
            return _d;
        }
        public double GetWallLambda2()
        {
            double _d = Wall.Lambda2;
            return _d;
        }



        /// <summary>
        /// Показать минимальное значение коэффициента теплопроводности огнеупорной стенки
        /// </summary>  
        //public double GetWallLambdaMin()
        //{
        //    double _d = Wall.LambdaMin;
        //    return _d;
        //}


        /// <summary>
        /// Показать максимальное значение коэффициента теплопроводности огнеупорной стенки
        /// </summary>  
        //public double GetWallLambdaMax()
        //{
        //    double _d = Wall.LambdaMax;
        //    return _d;
        //}

        public double SetWallThickness()
        {
            return 0;
        }

        /// <summary>
        /// Показать толщину огнеупорной стенки
        /// </summary>  
        public double GetWallThickness1()
        {
            double _d = Wall.Thickness1;
            return _d;
        }
        public double GetWallThickness2()
        {
            double _d = Wall.Thickness2;
            return _d;
        }
        #endregion
        public double AlfaWork
        {
            set
            {
                MediumHeat.Alfa = value;
            }
            get
            {
                return MediumHeat.Alfa;
            }
        }

        public double TemperatureWork { get; set; }
        public double AlfaExternal { get; set; }
        public double TemperatureExternal { get; set; }

        #region --- Расчет плотности теплового потока

        /// <summary>
        /// Показать плотность теплового потока, Вт/м2
        /// </summary>
        //Плотность теплового потока, Вт/м2
        public double GetQ()
        {
            // В первую очередь, необходимо проверить все аргументы
            if (MediumHeat == null)
                throw new ArgumentNullException("Не определен объект WorkMediumCalc");
            else if (MediumQ == null)
                throw new ArgumentNullException("Не определен объект OutMediumCalc");
            else if (Wall == null)
                throw new ArgumentNullException("Не определен объект WallCalc");

            double _d = 0;

            double tmp = MediumHeat.GetResistance() + Wall.GetResistance() + MediumQ.GetResistance();
            _d = (MediumHeat.Temperature - MediumQ.Temperature) / tmp;

            return _d;
        }

        /// <summary>
        /// ....
        /// </summary>
        public double GetRWork()
        {
            //// В первую очередь, необходимо проверить все аргументы
            //if (MediumHeat == null)
            //    throw new ArgumentNullException("Не определен объект WorkMediumCalc");
            //else if (MediumQ == null)
            //    throw new ArgumentNullException("Не определен объект OutMediumCalc");
            //else if (Wall == null)
            //    throw new ArgumentNullException("Не определен объект WallCalc");

            double _d = MediumHeat.GetResistance();
            return _d;
        }

        public double GetRWall()
        {




            double _d = Wall.GetResistance();

            return _d;
        }

        /// <summary>
        /// ....
        /// </summary>
        public double GetRExternal()
        {
            //// В первую очередь, необходимо проверить все аргументы
            //if (MediumHeat == null)
            //    throw new ArgumentNullException("Не определен объект WorkMediumCalc");
            //else if (MediumQ == null)
            //    throw new ArgumentNullException("Не определен объект OutMediumCalc");
            //else if (Wall == null)
            //    throw new ArgumentNullException("Не определен объект WallCalc");

            double _d = MediumQ.GetResistance();
            return _d;
        }



        /// <summary>
        /// Показать плотность теплового потока, Вт/м2
        /// </summary>
        ///<param name="oma">Коэффициент теплоотдачи окружающей среды, Вт/(м2*К)</param>        
        //Плотность теплового потока, Вт/м2
        public double GetQ(double oma)
        {
            //В первую очередь, необходимо проверить все аргументы
            if (MediumHeat == null)
                throw new ArgumentNullException("Не определен объект WorkMediumCalc");
            else if (MediumQ == null)
                throw new ArgumentNullException("Не определен объект OutMediumCalc");
            else if (Wall == null)
                throw new ArgumentNullException("Не определен объект WallCalc");

            double _d = 0;
            double tmp;

            if (oma != 0)
            {
                tmp = MediumHeat.GetResistance() + Wall.GetResistance() + 1d / oma;
                _d = (MediumHeat.Temperature - MediumQ.Temperature) / tmp;
            }
            else
                throw new ArgumentException("Величина параметра принимает нулевое значение");
            return _d;
        }

        /// <summary>
        /// Показать плотность теплового потока для многослойной огнеупорной стенки
        /// </summary>
        //Плотность теплового потока, Вт/м2
        //Плотность теплового потока, Вт/м2
        public double GetQ(cLayerFlux[] lf)
        {
            // В первую очередь, необходимо проверить все аргументы
            if (MediumHeat == null)
                throw new ArgumentNullException("Не определен объект WorkMediumCalc");
            else if (MediumQ == null)
                throw new ArgumentNullException("Не определен объект OutMediumCalc");
            else if (Wall == null)
                throw new ArgumentNullException("Не определен объект WallCalc");

            double _d = 0;
            double tmp;

            cLayerFlux[] _lf;
            _lf = lf;

            tmp = MediumHeat.GetResistance() + Wall.GetResistance() + MediumQ.GetResistance();
            _d = (MediumHeat.Temperature - MediumQ.Temperature) / tmp;

            return _d;
        }
        #endregion --- Расчет плотности теплового потока
    } 

    [Serializable]
    public class cLayerFlux
    {
        protected double _Lambda1 = 20d;
        protected double _Lambda2 = 20d;
        protected double _LambdaMin = 0d;
        protected double _LambdaMax = 50d;
        protected double _Thickness1 = 0d;
        protected double _Thickness2 = 0d;

        public cLayerFlux() { }



        public double Lambda1
        {
            get
            {
                return _Lambda1;
            }
            set
            {
                //_Lambda = value;
                if (value < _LambdaMin || value > _LambdaMax)
                    throw new ArgumentException("Ошибка ввода коэффициента теплопроводности", "Lambda");
                else if (_Lambda1 != value)
                    _Lambda1 = value;
            }
        }
        public double Lambda2
        {
            get
            {
                return _Lambda2;
            }
            set
            {
                //_Lambda = value;
                if (value < _LambdaMin || value > _LambdaMax)
                    throw new ArgumentException("Ошибка ввода коэффициента теплопроводности", "Lambda");
                else if (_Lambda2 != value)
                    _Lambda2 = value;
            }
        }

        ///// <summary>
        ///// Ограничение на минимум: Коэффициент теплопроводности огнеупорного слоя, Вт/(м*К)
        ///// </summary>  
        //public double LambdaMin
        //
        //    get { return _LambdaMin; }
        //    set
        //    {
        //        if (value < 0)
        //            throw new ArgumentException("Ошибка ввода величины ограничений", "LamdaMin");
        //        else if (_LambdaMin != value)
        //            _LambdaMin = value;
        //    }
        //}

        ///// <summary>
        ///// Ограничение на максимум: Коэффициент теплопроводности огнеупорного слоя, Вт/(м*К)
        ///// </summary>  
        //public double LambdaMax
        //{
        //    get { return _LambdaMax; }
        //    set
        //    {
        //        if (value < 0)
        //            throw new ArgumentException("Ошибка ввода величины ограничений", "LamdaMax");
        //        else if (_LambdaMax != value)
        //            _LambdaMax = value;
        //    }
        //}

        /// <summary>
        /// Толщина огнеупорного слоя, м
        /// </summary>  
        public double Thickness1
        {
            get { return _Thickness1; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ошибка ввода толщины огнеупорного слоя", "Thickness");
                else if (_Thickness1 != value)
                    _Thickness1 = value;
            }
        }
        public double Thickness2
        {
            get { return _Thickness2; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ошибка ввода толщины огнеупорного слоя", "Thickness");
                else if (_Thickness2 != value)
                    _Thickness2 = value;
            }
        }

        /// <summary>
        /// Показать тепловое сопротивление огнеупорного слоя.
        /// Метод объявлен как виртуальный, чтобы его можно было заместить в производном классе
        /// </summary>
        public virtual double GetResistance1()
        {
            // Проверить знаменатель на 0 и непустоту
            if (_Lambda1 == 0)
                throw new ArgumentException("Ошибка определения Lambda");
            return _Thickness1 / _Lambda1;
        }
        public virtual double GetResistance2()
        {
            // Проверить знаменатель на 0 и непустоту
            if (_Lambda2 == 0)
                throw new ArgumentException("Ошибка определения Lambda");
            return _Thickness2 / _Lambda2;
        }
    }
 
}

[Serializable]
    public class cWall : Lib2.cLayerFlux
{
        protected int _CountLayers = 2;

        public cWall() { }
        public cWall(int InCountLayers)
        {
            CountLayers = InCountLayers;
        }
        public int CountLayers
        {
            get { return _CountLayers; }
            set
            {
                if (value < 1 || value > 2)
                    throw new ArgumentException("Ошибка ввода количества огнеупорных слоев. Возможны 1 или 2 слоя", "CountLayers");
                else if (_CountLayers != value)
                    _CountLayers = value;
            }
        }
        public virtual double GetResistance()
        {
            double _d = 0;
            switch (CountLayers)
            {
                case 1:
                    // Проверить знаменатель на 0 
                    if (Lambda1 == 0)
                        throw new ArgumentException("Ошибка определения Lambda");
                    _d = Thickness1 / Lambda1;
                    break;

                case 2:
                    // Проверить знаменатель на 0 
                    if (Lambda1 == 0 || Lambda2 == 0)
                        throw new ArgumentException("Ошибка определения Lambda");
                    _d = Thickness1 / Lambda1 + Thickness2 / Lambda2;
                    break;

                default:
                    // Проверить знаменатель на 0 и непустоту
                    if (Lambda1 == 0)
                        throw new ArgumentException("Ошибка определения Lamda");
                    _d = Thickness1 / Lambda1;
                    break;
            }
            return _d;
        }
    }

[Serializable]
public class cMedium
{
    private double _Temperature;
    private double _Alfa;

    public cMedium() { }

    /// <summary>
    /// Температура омывающей среды, °С
    /// </summary>  
    public double Temperature
    {
        get { return _Temperature; }
        set
        {
            if (value <= -50)
                throw new ArgumentException("Ошибка ввода температуры", "Temperature");
            else if (_Temperature != value)
                _Temperature = value;
        }
    }

    /// <summary>
    /// Коэффициент теплоотдачи омывающей среды, Вт/(м2*К)
    /// </summary>  
    public double Alfa
    {
        get { return _Alfa; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Ошибка ввода коэффициента теплоотдачи омывающей среды", "Alfa");
            else if (_Alfa != value)
                _Alfa = value;
        }
    }

    /// <summary>
    /// Показать тепловое сопротивление омывающей среды
    /// </summary>
    public double GetResistance()
    {
        // Проверить знаменатель на 0 и непустоту
        if (_Alfa == 0)
            throw new ArgumentException("Ошибка определения Alfa");
        double _d = 1d / _Alfa;
        return _d;
    }


}

