using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfControlLibrary1
{
    public partial class UserControl1 : UserControl
    {
        public Viewport3D viewport3D = new Viewport3D();
        public PerspectiveCamera PCamera = new PerspectiveCamera();
        public int index = 0;
        public Point point = new Point();
        public Point point2 = new Point();

        public UserControl1()
        {
            functions.Add(new Fun1());
            functions.Add(new Fun2());
            functions.Add(new Fun3());
            functions.Add(new Fun4());
            functions.Add(new Fun5());
            PCamera.Position = new Point3D(9, 9, 9);
            PCamera.LookDirection = new Vector3D(-9, -9, -9);
            PCamera.UpDirection = new Vector3D(0, 1, 0);
            PCamera.FieldOfView = 80;
            viewport3D.Camera = PCamera;
            viewport3D.Children.Add(CreateModel(-5, 5, -5, 5, 0.1, 0.1));
            this.Content = viewport3D;

        }
        List<IFunction> functions = new List<IFunction>();

        public MeshGeometry3D CreateMesh(double xMin, double xMax, double zMin, double zMax, double deltaX, double deltaZ)
        {
            // Вычисление количества шагов по осям X и Z
            int xSteps = (int)((xMax - xMin) / deltaX) + 1;
            int zSteps = (int)((zMax - zMin) / deltaZ) + 1;
            MeshGeometry3D mesh = new MeshGeometry3D();

            for (int z = 0; z < zSteps; z++)
            {
                double currentZ = zMin + z * deltaZ;

                for (int x = 0; x < xSteps; x++)
                {
                    double currentX = xMin + x * deltaX;
                    double u = (double)x / (xSteps - 1);
                    double v = (double)z / (zSteps - 1);

                    // Добавление вершины в позиции (currentX, f(currentX, currentZ), currentZ)
                    mesh.Positions.Add(new Point3D(currentX, functions[index].calc(currentX, currentZ), currentZ));

                    // Добавление текстурных координат для мэппинга текстуры
                    mesh.TextureCoordinates.Add(new Point(u, 1 - v));

                    // Формирование треугольников для создания поверхности
                    if (x > 0 && z > 0)
                    {
                        int currentPoint = (xSteps * z) + x;
                        int leftPoint = (xSteps * z) + x - 1;
                        int upperLeftPoint = (xSteps * (z - 1)) + x - 1;
                        int upperPoint = (xSteps * (z - 1)) + x;


                        // Добавление индексов вершин для треугольников
                        mesh.TriangleIndices.Add(currentPoint);
                        mesh.TriangleIndices.Add(leftPoint);
                        mesh.TriangleIndices.Add(upperLeftPoint);
                        mesh.TriangleIndices.Add(currentPoint);
                        mesh.TriangleIndices.Add(upperLeftPoint);
                        mesh.TriangleIndices.Add(upperPoint);
                    }
                }
            }
            return mesh;
        }
        // Создаём геометрическую модель для оси Z
        public GeometryModel3D AxisZ()
        {
            MeshGeometry3D mesh = new MeshGeometry3D();

            // Задаём вершниы для линии оси Z
            mesh.Positions.Add(new Point3D(-0.05, -100, 0));
            mesh.Positions.Add(new Point3D(0.05, -100, 0));
            mesh.Positions.Add(new Point3D(-0.05, 100, 0));
            mesh.Positions.Add(new Point3D(0.05, 100, 0));

            // Задаём индексы вершин для создания линии
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3);

            // Материал для оси
            DiffuseMaterial myMaterial3 = new DiffuseMaterial(new SolidColorBrush(Colors.Black));

            // Модель с использованием геометрии и материала
            GeometryModel3D model = new GeometryModel3D(mesh, myMaterial3);

            model.BackMaterial = myMaterial3;

            return model;
        }

        // Прорисовка второй линии оси Z
        public GeometryModel3D AxisZ2()
        {
            MeshGeometry3D mesh = new MeshGeometry3D();

            mesh.Positions.Add(new Point3D(0, -100, 0.05));
            mesh.Positions.Add(new Point3D(0, -100, -0.05));
            mesh.Positions.Add(new Point3D(0, 100, 0.05));
            mesh.Positions.Add(new Point3D(0, 100, -0.05));

            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3);

            DiffuseMaterial myMaterial3 = new DiffuseMaterial(new SolidColorBrush(Colors.Black));

            GeometryModel3D model = new GeometryModel3D(mesh, myMaterial3);
            model.BackMaterial = myMaterial3;

            return model;
        }
        public GeometryModel3D AxisX()
        {
            MeshGeometry3D mesh = new MeshGeometry3D();

            mesh.Positions.Add(new Point3D(-100, 0, -0.05));
            mesh.Positions.Add(new Point3D(-100, 0, 0.05));
            mesh.Positions.Add(new Point3D(100, 0, -0.05));
            mesh.Positions.Add(new Point3D(100, 0, 0.05));

            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3);

            DiffuseMaterial myMaterial3 = new DiffuseMaterial(new SolidColorBrush(Colors.Black));

            GeometryModel3D model = new GeometryModel3D(mesh, myMaterial3);
            model.BackMaterial = myMaterial3;
            return model;
        }
        public GeometryModel3D AxisX2()
        {
            MeshGeometry3D mesh = new MeshGeometry3D();

            mesh.Positions.Add(new Point3D(-100, -0.05, 0));
            mesh.Positions.Add(new Point3D(-100,0.05, 0));
            mesh.Positions.Add(new Point3D(100, -0.05, 0));
            mesh.Positions.Add(new Point3D(100, 0.05, 0));

            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3);

            DiffuseMaterial myMaterial3 = new DiffuseMaterial(new SolidColorBrush(Colors.Black));

            GeometryModel3D model = new GeometryModel3D(mesh, myMaterial3);
            model.BackMaterial = myMaterial3;
            return model;
        }
        public GeometryModel3D AxisY()
        {
            MeshGeometry3D mesh = new MeshGeometry3D();

            mesh.Positions.Add(new Point3D(-0.05, 0, -100));
            mesh.Positions.Add(new Point3D(0.05, 0, -100));
            mesh.Positions.Add(new Point3D(-0.05, 0, 100));
            mesh.Positions.Add(new Point3D(0.05, 0, 100));

            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3);

            DiffuseMaterial myMaterial3 = new DiffuseMaterial(new SolidColorBrush(Colors.Black));

            GeometryModel3D model = new GeometryModel3D(mesh, myMaterial3);
            model.BackMaterial = myMaterial3;
            return model;
        }
        public GeometryModel3D AxisY2()
        {
            MeshGeometry3D mesh4 = new MeshGeometry3D();

            mesh4.Positions.Add(new Point3D(0, 0.05, -100));
            mesh4.Positions.Add(new Point3D(0, -0.05, -100));
            mesh4.Positions.Add(new Point3D(0, 0.05, 100));
            mesh4.Positions.Add(new Point3D(0, -0.05, 100));

            mesh4.TriangleIndices.Add(1);
            mesh4.TriangleIndices.Add(0);
            mesh4.TriangleIndices.Add(2);
            mesh4.TriangleIndices.Add(1);
            mesh4.TriangleIndices.Add(2);
            mesh4.TriangleIndices.Add(3);

            DiffuseMaterial myMaterial3 = new DiffuseMaterial(new SolidColorBrush(Colors.Black));

            GeometryModel3D model = new GeometryModel3D(mesh4, myMaterial3);
            model.BackMaterial = myMaterial3;
            return model;
        }

        // Правильная регистрация точки в пространстве
        public GeometryModel3D SpaceMarkerCube()
        {
            // Создание объекта MeshGeometry3D для геометрии куба
            MeshGeometry3D mesh = new MeshGeometry3D();

            // Задание координат вершин куба
            mesh.Positions.Add(new Point3D(-50, -50, -50));
            mesh.Positions.Add(new Point3D(-50, 50, -50));
            mesh.Positions.Add(new Point3D(-50, 50, 50));
            mesh.Positions.Add(new Point3D(-50, -50, 50));
            mesh.Positions.Add(new Point3D(50, -50, -50));
            mesh.Positions.Add(new Point3D(50, 50, -50));
            mesh.Positions.Add(new Point3D(50, 50, 50));
            mesh.Positions.Add(new Point3D(50, -50, 50));

            // Задание индексов треугольников для создания поверхности куба
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(0);

            // Создание прозрачного материала для куба
            DiffuseMaterial myMaterial = new DiffuseMaterial(new SolidColorBrush(Colors.Transparent));

            GeometryModel3D model = new GeometryModel3D(mesh, myMaterial);

            model.BackMaterial = myMaterial;

            // Возвращение созданной трехмерной модели куба
            return model;
        }
        public GeometryModel3D CreateGrid()
        {
            // Создание объекта MeshGeometry3D для хранения геометрии
            MeshGeometry3D gridMesh = new MeshGeometry3D();

            // Генерация горизонтальных линий сетки
            for (int i = -100; i <= 100; i++)
            {
                gridMesh.Positions.Add(new Point3D(i + 0.02, 0, -100)); // Верхняя точка линии
                gridMesh.Positions.Add(new Point3D(i - 0.02, 0, -100)); // Нижняя точка линии
                gridMesh.Positions.Add(new Point3D(i - 0.02, 0, 100));  // Верхняя точка следующей линии
                gridMesh.Positions.Add(new Point3D(i + 0.02, 0, -100)); // Закрываем треугольник
                gridMesh.Positions.Add(new Point3D(i - 0.02, 0, 100));  // Повторение верхней точки следующей линии
                gridMesh.Positions.Add(new Point3D(i + 0.02, 0, 100));  // Повторение нижней точки следующей линии
            }

            // Генерация вертикальных линий сетки
            for (int i = -100; i <= 100; i++)
            {
                gridMesh.Positions.Add(new Point3D(-100, 0, i + 0.02)); // Левая точка линии
                gridMesh.Positions.Add(new Point3D(-100, 0, i - 0.02)); // Правая точка линии
                gridMesh.Positions.Add(new Point3D(100, 0, i - 0.02));  // Левая точка следующей линии
                gridMesh.Positions.Add(new Point3D(-100, 0, i + 0.02)); // Закрываем треугольника
                gridMesh.Positions.Add(new Point3D(100, 0, i - 0.02));  // Повторение левой точки следующей линии
                gridMesh.Positions.Add(new Point3D(100, 0, i + 0.02));  // Повторение правой точки следующей линии
            }

            // Создание материала для сетки (в данном случае, серый цвет)
            DiffuseMaterial gridMaterial = new DiffuseMaterial(new SolidColorBrush(Colors.Gray));

            // Создание геометрической модели с использованием сетки и материала
            GeometryModel3D gridModel = new GeometryModel3D(gridMesh, gridMaterial);
            gridModel.BackMaterial = gridMaterial;

            // Возвращение созданной модели
            return gridModel;
        }
        public ModelVisual3D CreateModel(double xMin, double xMax, double zMin, double zMax, double deltaX, double deltaZ)
        {
            // Создание сетки с указанными параметрами
            MeshGeometry3D mesh = CreateMesh(xMin, xMax, zMin, zMax, deltaX, deltaZ);

            // Создание градиентной кисти для модели
            LinearGradientBrush oceanGradientBrush = new LinearGradientBrush();
            oceanGradientBrush.StartPoint = new Point(0, 0);
            oceanGradientBrush.EndPoint = new Point(1, 1);
            oceanGradientBrush.GradientStops.Add(new GradientStop(Colors.DarkBlue, 0.0));
            oceanGradientBrush.GradientStops.Add(new GradientStop(Colors.MediumBlue, 0.35));
            oceanGradientBrush.GradientStops.Add(new GradientStop(Colors.DodgerBlue, 0.65));
            oceanGradientBrush.GradientStops.Add(new GradientStop(Colors.Aqua, 1.00));


            // Создание материала для модели с использованием градиентной кисточки
            DiffuseMaterial myMaterial = new DiffuseMaterial(oceanGradientBrush);

            GeometryModel3D model = new GeometryModel3D(mesh, myMaterial);
            model.BackMaterial = myMaterial;

            // Создание группы моделей 3D
            Model3DGroup modelGroup = new Model3DGroup();

            // Добавление окружающего света к группе (кинул его на всю область)
            AmbientLight ambient = new AmbientLight(Colors.White);
            modelGroup.Children.Add(ambient);

            // Добавление созданных элементов к группе
            modelGroup.Children.Add(model);
            modelGroup.Children.Add(CreateGrid());
            modelGroup.Children.Add(AxisY());
            modelGroup.Children.Add(AxisY2());
            modelGroup.Children.Add(AxisX());
            modelGroup.Children.Add(AxisX2());
            modelGroup.Children.Add(AxisZ());
            modelGroup.Children.Add(AxisZ2());
            modelGroup.Children.Add(SpaceMarkerCube());

            // Создание 3D визуального элемента
            ModelVisual3D visualElement = new ModelVisual3D();
            visualElement.Content = modelGroup;

            // Возвращение созданного 3D-визуального элемента
            return visualElement;
        }
        public void UpdateViewport()
        {
            // Удаляем текущую модель из дочерних элементов Viewport3D
            viewport3D.Children.RemoveAt(0);

            // Создаем новую модель и добавляем её в дочерние элементы Viewport3D
            viewport3D.Children.Add(CreateModel(-5, 5, -5, 5, 0.1, 0.1));

            // Устанавливаем новую позицию, направление взгляда, вектор вверх, и угол обзора для камеры
            PCamera.Position = new Point3D(9, 9, 9);
            PCamera.LookDirection = new Vector3D(-9, -9, -9);
            PCamera.UpDirection = new Vector3D(0, 1, 0);
            PCamera.FieldOfView = 80;

            // Присваиваем камеру Viewport3D
            viewport3D.Camera = PCamera;
        }
    }
}

   
