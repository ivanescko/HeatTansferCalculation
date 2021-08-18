using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ZedGraph;
using Lib2;

namespace _3
{
    public partial class frmGraph : Form
    {
        cHeatCalculation _exmpl = new cHeatCalculation();
        public frmGraph(cHeatCalculation exmpl)
        {
            _exmpl = exmpl;
            InitializeComponent();
            // Для генерации случайных точек и случайного цвета кривой
            Random rnd = new Random();

            GraphPane pane = zedGraph.GraphPane;
            pane.XAxis.Title.Text = "Коэффициент теплопередачи, ВТ/(м2**С)";

            // Изменим параметры шрифта для оси X



            // Изменим текст по оси Y
            pane.YAxis.Title.Text = "Плотность теплового потока, Вт/м2";

            // Изменим текст заголовка графика
            pane.Title.Text = "Зависимость плотности теплового потока от \n коэффициента теплопередачи окружающей среды";
            // Создадим список точек
            PointPairList list = new PointPairList();

            double xmin = 30;
            double xmax = 50;

            // Заполняем список точек. Приращение по оси X тоже случайно
            for (double x = xmin; x <= xmax; x += (0.1 * (xmax - xmin)))
            {
                // Случайная координата по Y
                double y = _exmpl.GetQ(x);

                // добавим в список точку
                list.Add(x, y);
            }

            // Выберем случайный цвет для графика
            Color curveColor = _colors[rnd.Next(_colors.Length)];
            LineItem myCurve = pane.AddCurve("", list, curveColor, SymbolType.None);

            // Включим сглаживание
            myCurve.Line.IsSmooth = true;

            // Обновим график
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        // Массив цветов, из которых будем выбирать случайным образом цвет для графика
        Color[] _colors = new Color[] {
            Color.Black,
            Color.Blue,
            Color.Brown,
            Color.Gray,
            Color.Green,
            Color.Indigo,
            Color.Orange,
            Color.Red,
            Color.YellowGreen};

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            // Для генерации случайных точек и случайного цвета кривой
            Random rnd = new Random();

            GraphPane pane = zedGraph.GraphPane;
            pane.XAxis.Title.Text = "Коэффициент теплопередачи, ВТ/(м2**С)";

            // Изменим параметры шрифта для оси X
    
          

            // Изменим текст по оси Y
            pane.YAxis.Title.Text = "Плотность теплового потока, Вт/м2";

            // Изменим текст заголовка графика
            pane.Title.Text = "Зависимость плотности теплового потока от \n коэффициента теплопередачи окружающей среды";
            // Создадим список точек
            PointPairList list = new PointPairList();

            double xmin = 30;
            double xmax = 50;

            // Заполняем список точек. Приращение по оси X тоже случайно
            for (double x = xmin; x <= xmax; x += (0.1 * (xmax - xmin)))
            {
                // Случайная координата по Y
                double y = _exmpl.GetQ(x);

                // добавим в список точку
                list.Add(x, y);
            }

            // Выберем случайный цвет для графика
            Color curveColor = _colors[rnd.Next(_colors.Length)];
            LineItem myCurve = pane.AddCurve("", list, curveColor, SymbolType.None);

            // Включим сглаживание
            myCurve.Line.IsSmooth = true;

            // Обновим график
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            // Генератор случайных чисел для выбора номера графика, который нужно удалить
            Random rnd = new Random();

            GraphPane pane = zedGraph.GraphPane;

            // Если есть что удалять
            if (pane.CurveList.Count > 0)
            {
                // Номер графика для удаления
                int index = rnd.Next(pane.CurveList.Count);

                // Удалим кривую по индексу
                pane.CurveList.RemoveAt(index);

                // Обновим график
                zedGraph.AxisChange();
                zedGraph.Invalidate();
            }
        }

        private void frmGraph_Load(object sender, EventArgs e)
        {

        }

        private void zedGraph_Load(object sender, EventArgs e)
        {

        }
    }
}