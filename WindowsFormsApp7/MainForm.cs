using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using WpfControlLibrary1;
using static System.Windows.Forms.AxHost;
using static WpfControlLibrary1.UserControl1;
using Color = System.Drawing.Color;
using TabControl = System.Windows.Forms.TabControl;
using UserControl1 = WpfControlLibrary1.UserControl1;


namespace WindowsFormsApp7
{
    public partial class MainForm : Form
    {
        UserControl1 wpf = new UserControl1();
        public Vector3D vector3D = new Vector3D();
        public double distance;

        public double scale = 1.0;
        public double prevScale;

        public double horizontRotation;
        public double vertRotation;
        public double eDelta = 0;
        public MainForm()
        {
            // Инициализация компонентов формы
            InitializeComponent();

            // Получение ссылки на элемент UserControl1 из ElementHost
            wpf = (UserControl1)elementHost1.Child;

            // Подписка на события мыши для UserControl1
            wpf.MouseDown += Wpf_MouseDown;
            wpf.MouseMove += Wpf_MouseMove;
            wpf.MouseWheel += Wpf_MouseWheel;

            // Создание и настройка динамической вкладки
            TabControl dynamicTabControl = new TabControl();
            dynamicTabControl.Name = "DynamicTabControl";
            dynamicTabControl.BackColor = Color.White;
            dynamicTabControl.ForeColor = Color.Black;
            dynamicTabControl.Font = new Font("Georgia", 16);
            dynamicTabControl.Dock = DockStyle.Fill;
            dynamicTabControl.Selected += DynamicTabControl_Selected;
            dynamicTabControl.Deselected += DynamicTabControl_Deselected;

            // Добавление динамической вкладки на форму
            Controls.Add(dynamicTabControl);

            // Добавление вкладок на динамическую вкладку
            for (int i = 1; i <= 5; i++)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = $"Функция {i}";
                tabPage.Font = new Font("TT Firs Neue", 12);
                tabPage.Controls.Add(elementHost1);
                dynamicTabControl.TabPages.Add(tabPage);
            }
            dynamicTabControl.TabPages[dynamicTabControl.TabCount - 1].Text = "Гаусс";
            dynamicTabControl.TabPages[dynamicTabControl.TabCount - 2].Text = "Шуберт";

            // Инициализация вектора и расстояния для камеры в 3D пространстве
            vector3D = new Vector3D(wpf.PCamera.Position.X, wpf.PCamera.Position.Y, wpf.PCamera.Position.Z);
            distance = vector3D.Length;
        }


        private void Wpf_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                wpf.point = e.GetPosition(wpf);
            }
        }
        private void Wpf_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // Проверяем, нажата ли правая кнопка мыши
            if (e.RightButton == MouseButtonState.Pressed)
            {
                // Получаем текущие координаты мыши
                wpf.point2 = e.GetPosition(wpf);

                // Рассчитываем изменение координат по X и Y
                double deltaX = wpf.point2.X - wpf.point.X;
                double deltaY = wpf.point2.Y - wpf.point.Y;

                // Задаем скорость вращения камеры
                double rotationSpeed = 0.5;

                // Рассчитываем углы поворота 
                horizontRotation = deltaX * rotationSpeed;
                vertRotation = deltaY * rotationSpeed;

                // Вызываем метод для вращения камеры вокруг объекта
                RotateCamera(horizontRotation, vertRotation, wpf.PCamera.Position.X, wpf.PCamera.Position.Y, wpf.PCamera.Position.Z, distance);

                // Сохраняем координатки
                wpf.point = wpf.point2;
            }
        }

        private void Wpf_MouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            //eDelta += e.Delta;
            //prevScale = scale;
            //if (e.Delta > 0 && scale <= 1.4)
            //{
            //    scale = Math.Round(scale + 0.2, 1);
            //}
            //else if (scale > 0.2)
            //{
            //    scale = Math.Round(scale - 0.2, 1);
            //}

            //if (scale == 1)
            //{
            //    ScaleLabel.Visible = false;
            //}
            //else
            //{
            //    ScaleLabel.Visible = true;
            //    ScaleLabel.Text = $"{scale * 100}%";
            //}
            eDelta += e.Delta;
            if (eDelta <= 1500)
            {
                RotateCamera(horizontRotation, vertRotation, wpf.PCamera.Position.X, wpf.PCamera.Position.Y, wpf.PCamera.Position.Z, distance - eDelta/360);
            }
        }
        private void RotateCamera(double horizontalRotation, double verticalRotation, double X, double Y, double Z, double dis)
        {
            // Рассчитываем текущие углы камеры
            double currentHorizontalRotation = Math.Atan2(Z, X);
            double currentVerticallRotation = Math.Asin(Y / dis);

            // Рассчитываем новые углы поворота
            double newHorizontalRotation = currentHorizontalRotation + ToRadians(horizontalRotation);
            double newVerticalRotation = currentVerticallRotation + ToRadians(verticalRotation);

            // Ограничиваем угол наклона в пределах от -pi/2 до pi/2
            newVerticalRotation = Math.Max(-Math.PI / 2, Math.Min(Math.PI / 2, newVerticalRotation));

            // Рассчитываем новые координаты камеры
            double x = dis * Math.Cos(newHorizontalRotation) * Math.Cos(newVerticalRotation);
            double y = dis * Math.Sin(newVerticalRotation);
            double z = dis * Math.Sin(newHorizontalRotation) * Math.Cos(newVerticalRotation);

            // Устанавливаем новую позицию и направление камеры
            wpf.PCamera.Position = new Point3D(x, y, z);
            wpf.PCamera.LookDirection = new Vector3D(-x, -y, -z);
        }

        private void MovingCamera(double horizontalRotation, double verticalRotation, double X, double Y, double Z, double dis)
        {
            // Рассчитываем текущие углы камеры
            double currentHorizontalRotation = Math.Atan2(Z, X);
            double currentVerticallRotation = Math.Asin(Y / dis);

            // Рассчитываем новые углы поворота
            double newHorizontalRotation = currentHorizontalRotation + ToRadians(horizontalRotation);
            double newVerticalRotation = currentVerticallRotation + ToRadians(verticalRotation);

            // Ограничиваем угол наклона в пределах от -pi/2 до pi/2
            newVerticalRotation = Math.Max(-Math.PI / 2, Math.Min(Math.PI / 2, newVerticalRotation));

            // Рассчитываем новые координаты камеры
            double x = dis * Math.Cos(newHorizontalRotation) * Math.Cos(newVerticalRotation);
            double y = dis * Math.Sin(newVerticalRotation);
            double z = dis * Math.Sin(newHorizontalRotation) * Math.Cos(newVerticalRotation);

            // Устанавливаем новую позицию и направление камеры
            wpf.PCamera.Position = new Point3D(x, y, z);
            wpf.PCamera.LookDirection = new Vector3D(-x, -y, -z);
        }
        public static double ToRadians(double degrees)
        {
            return degrees * (Math.PI / 180);
        }
        private void DynamicTabControl_Deselected(object sender, TabControlEventArgs e)
        {
            e.TabPage.Controls.Remove(elementHost1);
        }
        private void DynamicTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                wpf.index = 0;
                e.TabPage.Controls.Add(elementHost1);
            }
            else if (e.TabPageIndex == 1)
            {
                wpf.index = 1;
                e.TabPage.Controls.Add(elementHost1);
            }
            else if (e.TabPageIndex == 2)
            {
                wpf.index = 2;
                e.TabPage.Controls.Add(elementHost1);
            }
            else if (e.TabPageIndex == 3)
            {
                wpf.index = 3;
                e.TabPage.Controls.Add(elementHost1);
            }
            else if (e.TabPageIndex == 4)
            {
                wpf.index = 4;
                e.TabPage.Controls.Add(elementHost1);
            }
            wpf.UpdateViewport();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
