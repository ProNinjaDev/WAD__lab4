using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
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

namespace WpfControlLibrary2
{
    public partial class UserControl2 : UserControl
    {
        public Viewport3D myViewport3D = new Viewport3D();
        public PerspectiveCamera myPCamera = new PerspectiveCamera();
        public Point Point = new Point();
        public Point Point2 = new Point();
        public UserControl2()
        {
            this.Background = new SolidColorBrush(Colors.DarkGray);
            myPCamera.Position = new Point3D(3, 3, 3);
            myPCamera.LookDirection = new Vector3D(-3, -3, -3);
            myPCamera.UpDirection = new Vector3D(0, 1, 0);
            myPCamera.FieldOfView = 80;
            myViewport3D.Camera = myPCamera;
            Model3DGroup myModel3DGroup = new Model3DGroup();
            DirectionalLight directional = new DirectionalLight(Colors.White, new Vector3D(0, -1, -1));
            AmbientLight ambient = new AmbientLight(Colors.White);
            myModel3DGroup.Children.Add(ambient);
            myModel3DGroup.Children.Add(directional);
            myModel3DGroup.Children.Add(Cubik1());
            myModel3DGroup.Children.Add(Cubik2());
            myModel3DGroup.Children.Add(Cubik3());
            myModel3DGroup.Children.Add(Cubik4());
            myModel3DGroup.Children.Add(Cubik5());
            myModel3DGroup.Children.Add(Cubik6());
            myModel3DGroup.Children.Add(Cubik7());
            myModel3DGroup.Children.Add(Cubik8());
            myModel3DGroup.Children.Add(Cubik9());
            myModel3DGroup.Children.Add(Cubik10());
            myModel3DGroup.Children.Add(Cubik11());
            myModel3DGroup.Children.Add(Cubik12());
            myModel3DGroup.Children.Add(AxisY());
            myModel3DGroup.Children.Add(AxisY2());
            myModel3DGroup.Children.Add(AxisX());
            myModel3DGroup.Children.Add(AxisX2());
            myModel3DGroup.Children.Add(AxisZ());
            myModel3DGroup.Children.Add(AxisZ2());
            ModelVisual3D visual = new ModelVisual3D();
            visual.Content = myModel3DGroup;
            myViewport3D.Children.Add(visual);
            this.Content = myViewport3D;
        }
        public DiffuseMaterial myMaterial7 = new DiffuseMaterial(new SolidColorBrush(Colors.Gray));
        public MeshGeometry3D mesh1_1 = new MeshGeometry3D();
        public MeshGeometry3D mesh1_2 = new MeshGeometry3D();
        public MeshGeometry3D mesh1_3 = new MeshGeometry3D();
        public MeshGeometry3D mesh1_4 = new MeshGeometry3D();
        public MeshGeometry3D mesh1_5 = new MeshGeometry3D();
        public MeshGeometry3D mesh1_6 = new MeshGeometry3D();
        public MeshGeometry3D mesh_Dekor1 = new MeshGeometry3D();
        public MeshGeometry3D mesh_Dekor2 = new MeshGeometry3D();
        public MeshGeometry3D mesh_Dekor3 = new MeshGeometry3D();
        public MeshGeometry3D mesh_Dekor4 = new MeshGeometry3D();
        public MeshGeometry3D mesh_Dekor5 = new MeshGeometry3D();
        public MeshGeometry3D mesh_Dekor6 = new MeshGeometry3D();
        public GeometryModel3D model1_1 = new GeometryModel3D();
        public GeometryModel3D model1_2 = new GeometryModel3D();
        public GeometryModel3D model1_3 = new GeometryModel3D();
        public GeometryModel3D model1_4 = new GeometryModel3D();
        public GeometryModel3D model1_5 = new GeometryModel3D();
        public GeometryModel3D model1_6 = new GeometryModel3D();
        public MeshGeometry3D meshX_1 = new MeshGeometry3D();
        public MeshGeometry3D meshX_2 = new MeshGeometry3D();
        public MeshGeometry3D meshY_1 = new MeshGeometry3D();
        public MeshGeometry3D meshY_2 = new MeshGeometry3D();
        public MeshGeometry3D meshZ_1 = new MeshGeometry3D();
        public MeshGeometry3D meshZ_2 = new MeshGeometry3D();

        public GeometryModel3D Cubik1()
        {
            mesh1_1.Positions.Add(new Point3D(-1.5, -1.5, -1.5));
            mesh1_1.Positions.Add(new Point3D(-1.5, 1.5, -1.5));
            mesh1_1.Positions.Add(new Point3D(-1.5, 1.5, 1.5));
            mesh1_1.Positions.Add(new Point3D(-1.5, -1.5, 1.5));
            mesh1_1.TriangleIndices.Add(0);
            mesh1_1.TriangleIndices.Add(1);
            mesh1_1.TriangleIndices.Add(2);
            mesh1_1.TriangleIndices.Add(0);
            mesh1_1.TriangleIndices.Add(2);
            mesh1_1.TriangleIndices.Add(3);
            model1_1.Geometry = mesh1_1;
            model1_1.Material = myMaterial7;
            model1_1.BackMaterial = myMaterial7;
            return model1_1;
        }
        public GeometryModel3D Cubik2()
        {
            mesh1_2.Positions.Add(new Point3D(-1.5, -1.5, -1.5)); 
            mesh1_2.Positions.Add(new Point3D(-1.5, 1.5, -1.5));
            mesh1_2.Positions.Add(new Point3D(1.5, -1.5, -1.5)); 
            mesh1_2.Positions.Add(new Point3D(1.5, 1.5, -1.5)); 
            mesh1_2.TriangleIndices.Add(0);
            mesh1_2.TriangleIndices.Add(2);
            mesh1_2.TriangleIndices.Add(3);
            mesh1_2.TriangleIndices.Add(0);
            mesh1_2.TriangleIndices.Add(3);
            mesh1_2.TriangleIndices.Add(1);
            model1_2.Geometry = mesh1_2;
            model1_2.Material = myMaterial7;
            model1_2.BackMaterial = myMaterial7;
            return model1_2;
        }
        public GeometryModel3D Cubik3()
        {
            mesh1_3.Positions.Add(new Point3D(1.5, -1.5, -1.5)); 
            mesh1_3.Positions.Add(new Point3D(1.5, 1.5, -1.5)); 
            mesh1_3.Positions.Add(new Point3D(1.5, 1.5, 1.5)); 
            mesh1_3.Positions.Add(new Point3D(1.5, -1.5, 1.5)); 
            mesh1_3.TriangleIndices.Add(0);
            mesh1_3.TriangleIndices.Add(1);
            mesh1_3.TriangleIndices.Add(3);
            mesh1_3.TriangleIndices.Add(3);
            mesh1_3.TriangleIndices.Add(1);
            mesh1_3.TriangleIndices.Add(2);
            model1_3.Geometry = mesh1_3;
            model1_3.Material = myMaterial7;
            model1_3.BackMaterial = myMaterial7;
            return model1_3;
        }
        public GeometryModel3D Cubik4()
        {
            mesh1_4.Positions.Add(new Point3D(-1.5, 1.5, 1.5)); 
            mesh1_4.Positions.Add(new Point3D(-1.5, -1.5, 1.5)); 
            mesh1_4.Positions.Add(new Point3D(1.5, 1.5, 1.5)); 
            mesh1_4.Positions.Add(new Point3D(1.5, -1.5, 1.5)); 
            mesh1_4.TriangleIndices.Add(1);
            mesh1_4.TriangleIndices.Add(3);
            mesh1_4.TriangleIndices.Add(2);
            mesh1_4.TriangleIndices.Add(1);
            mesh1_4.TriangleIndices.Add(2);
            mesh1_4.TriangleIndices.Add(0);
            model1_4.Geometry = mesh1_4;
            model1_4.Material = myMaterial7;
            model1_4.BackMaterial = myMaterial7;
            return model1_4;
        }
        public GeometryModel3D Cubik5()
        {
            mesh1_5.Positions.Add(new Point3D(-1.5, 1.5, -1.5)); 
            mesh1_5.Positions.Add(new Point3D(-1.5, 1.5, 1.5)); 
            mesh1_5.Positions.Add(new Point3D(1.5, 1.5, -1.5)); 
            mesh1_5.Positions.Add(new Point3D(1.5, 1.5, 1.5)); 
            mesh1_5.TriangleIndices.Add(2);
            mesh1_5.TriangleIndices.Add(0);
            mesh1_5.TriangleIndices.Add(1);
            mesh1_5.TriangleIndices.Add(2);
            mesh1_5.TriangleIndices.Add(1);
            mesh1_5.TriangleIndices.Add(3);
            model1_5.Geometry = mesh1_5;
            model1_5.Material = myMaterial7;
            model1_5.BackMaterial = myMaterial7;
            return model1_5;
        }
        public GeometryModel3D Cubik6()
        {
            mesh1_6.Positions.Add(new Point3D(-1.5, -1.5, -1.5)); 
            mesh1_6.Positions.Add(new Point3D(-1.5, -1.5, 1.5)); 
            mesh1_6.Positions.Add(new Point3D(1.5, -1.5, -1.5));
            mesh1_6.Positions.Add(new Point3D(1.5, -1.5, 1.5)); 
            mesh1_6.TriangleIndices.Add(3);
            mesh1_6.TriangleIndices.Add(2);
            mesh1_6.TriangleIndices.Add(1);
            mesh1_6.TriangleIndices.Add(1);
            mesh1_6.TriangleIndices.Add(2);
            mesh1_6.TriangleIndices.Add(0);
            model1_6.Geometry = mesh1_6;
            model1_6.Material = myMaterial7;
            model1_6.BackMaterial = myMaterial7;
            return model1_6;
        }
        public GeometryModel3D Cubik7()
        {
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, -1.5, -1.5));
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, 1.5, -1.5)); 
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, 1.5, 1.5)); 
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, -1.5, 1.5)); 
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, -1.5, -1.1)); 
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, -1.1, -1.5)); 
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, 1.1, 1.5));
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, 1.5, 1.1));
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, 0.5, -0.5));
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, -0.5, -0.5));
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, 0.5, 0.5));
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, -0.5, 0.5));
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, 0.5, -0.3));
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, -0.5, -0.3));
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, 0.5, 0.3));
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, -0.5, 0.3));
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, 0.1, -1));
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, -0.1, -1));
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, 0.1, -0.5));
            mesh_Dekor1.Positions.Add(new Point3D(-1.505, -0.1, -0.5));
            mesh_Dekor1.TriangleIndices.Add(0);
            mesh_Dekor1.TriangleIndices.Add(5);
            mesh_Dekor1.TriangleIndices.Add(3);
            mesh_Dekor1.TriangleIndices.Add(3);
            mesh_Dekor1.TriangleIndices.Add(2);
            mesh_Dekor1.TriangleIndices.Add(7);
            mesh_Dekor1.TriangleIndices.Add(1);
            mesh_Dekor1.TriangleIndices.Add(2);
            mesh_Dekor1.TriangleIndices.Add(6);
            mesh_Dekor1.TriangleIndices.Add(1);
            mesh_Dekor1.TriangleIndices.Add(0);
            mesh_Dekor1.TriangleIndices.Add(4);
            mesh_Dekor1.TriangleIndices.Add(8);
            mesh_Dekor1.TriangleIndices.Add(15);
            mesh_Dekor1.TriangleIndices.Add(12);
            mesh_Dekor1.TriangleIndices.Add(12);
            mesh_Dekor1.TriangleIndices.Add(15);
            mesh_Dekor1.TriangleIndices.Add(11);
            mesh_Dekor1.TriangleIndices.Add(9);
            mesh_Dekor1.TriangleIndices.Add(14);
            mesh_Dekor1.TriangleIndices.Add(13);
            mesh_Dekor1.TriangleIndices.Add(13);
            mesh_Dekor1.TriangleIndices.Add(14);
            mesh_Dekor1.TriangleIndices.Add(10);
            mesh_Dekor1.TriangleIndices.Add(16);
            mesh_Dekor1.TriangleIndices.Add(18);
            mesh_Dekor1.TriangleIndices.Add(17);
            mesh_Dekor1.TriangleIndices.Add(18);
            mesh_Dekor1.TriangleIndices.Add(17);
            mesh_Dekor1.TriangleIndices.Add(19);
            DiffuseMaterial myMaterial7 = new DiffuseMaterial(new SolidColorBrush(Colors.Red));
            GeometryModel3D model1_6 = new GeometryModel3D();
            model1_6.Geometry = mesh_Dekor1;
            model1_6.Material = myMaterial7;
            model1_6.BackMaterial = myMaterial7;
            return model1_6;
        }

        public GeometryModel3D Cubik8()
        {
            mesh_Dekor2.Positions.Add(new Point3D(1.505, -1.5, -1.5));
            mesh_Dekor2.Positions.Add(new Point3D(1.505, 1.5, -1.5)); 
            mesh_Dekor2.Positions.Add(new Point3D(1.505, 1.5, 1.5)); 
            mesh_Dekor2.Positions.Add(new Point3D(1.505, -1.5, 1.5)); 
            mesh_Dekor2.Positions.Add(new Point3D(1.505, -1.5, -1.1)); 
            mesh_Dekor2.Positions.Add(new Point3D(1.505, -1.1, -1.5)); 
            mesh_Dekor2.Positions.Add(new Point3D(1.505, 1.1, 1.5));
            mesh_Dekor2.Positions.Add(new Point3D(1.505, 1.5, 1.1));
            mesh_Dekor2.Positions.Add(new Point3D(1.505, 0.5, -0.5));
            mesh_Dekor2.Positions.Add(new Point3D(1.505, -0.5, -0.5));
            mesh_Dekor2.Positions.Add(new Point3D(1.505, 0.5, 0.5));
            mesh_Dekor2.Positions.Add(new Point3D(1.505, -0.5, 0.5));
            mesh_Dekor2.Positions.Add(new Point3D(1.505, 0.5, -0.3));
            mesh_Dekor2.Positions.Add(new Point3D(1.505, -0.5, -0.3));
            mesh_Dekor2.Positions.Add(new Point3D(1.505, 0.5, 0.3));
            mesh_Dekor2.Positions.Add(new Point3D(1.505, -0.5, 0.3));
            mesh_Dekor2.TriangleIndices.Add(0);
            mesh_Dekor2.TriangleIndices.Add(5);
            mesh_Dekor2.TriangleIndices.Add(3);
            mesh_Dekor2.TriangleIndices.Add(3);
            mesh_Dekor2.TriangleIndices.Add(2);
            mesh_Dekor2.TriangleIndices.Add(7);
            mesh_Dekor2.TriangleIndices.Add(1);
            mesh_Dekor2.TriangleIndices.Add(2);
            mesh_Dekor2.TriangleIndices.Add(6);
            mesh_Dekor2.TriangleIndices.Add(1);
            mesh_Dekor2.TriangleIndices.Add(0);
            mesh_Dekor2.TriangleIndices.Add(4);
            mesh_Dekor2.TriangleIndices.Add(8);
            mesh_Dekor2.TriangleIndices.Add(15);
            mesh_Dekor2.TriangleIndices.Add(12);
            mesh_Dekor2.TriangleIndices.Add(12);
            mesh_Dekor2.TriangleIndices.Add(15);
            mesh_Dekor2.TriangleIndices.Add(11);
            mesh_Dekor2.TriangleIndices.Add(9);
            mesh_Dekor2.TriangleIndices.Add(14);
            mesh_Dekor2.TriangleIndices.Add(13);
            mesh_Dekor2.TriangleIndices.Add(13);
            mesh_Dekor2.TriangleIndices.Add(14);
            mesh_Dekor2.TriangleIndices.Add(10);
            DiffuseMaterial myMaterial7 = new DiffuseMaterial(new SolidColorBrush(Colors.Red));
            GeometryModel3D model1_6 = new GeometryModel3D();
            model1_6.Geometry = mesh_Dekor2;
            model1_6.Material = myMaterial7;
            model1_6.BackMaterial = myMaterial7;
            return model1_6;
        }
        public GeometryModel3D Cubik9()
        {
            mesh_Dekor3.Positions.Add(new Point3D(-1.5, 1.5, 1.505)); 
            mesh_Dekor3.Positions.Add(new Point3D(-1.5, -1.5, 1.505)); 
            mesh_Dekor3.Positions.Add(new Point3D(1.5, 1.5, 1.505)); 
            mesh_Dekor3.Positions.Add(new Point3D(1.5, -1.5, 1.505)); 
            mesh_Dekor3.Positions.Add(new Point3D(-1.5, -1.1, 1.505)); 
            mesh_Dekor3.Positions.Add(new Point3D(-1.1, -1.5, 1.505)); 
            mesh_Dekor3.Positions.Add(new Point3D(1.5, 1.1, 1.505));
            mesh_Dekor3.Positions.Add(new Point3D(1.1, 1.5, 1.505));
            mesh_Dekor3.Positions.Add(new Point3D(-0.5, 0.5, 1.505)); 
            mesh_Dekor3.Positions.Add(new Point3D(0.5, 0.5, 1.505)); 
            mesh_Dekor3.Positions.Add(new Point3D(-0.1, -0.5, 1.505)); 
            mesh_Dekor3.Positions.Add(new Point3D(0.1, -0.5, 1.505)); 
            mesh_Dekor3.Positions.Add(new Point3D(0.1, 0, 1.505)); 
            mesh_Dekor3.Positions.Add(new Point3D(-0.1, 0, 1.505)); 
            mesh_Dekor3.Positions.Add(new Point3D(-0.3, 0.5, 1.505)); 
            mesh_Dekor3.Positions.Add(new Point3D(0.3, 0.5, 1.505)); 
            mesh_Dekor3.TriangleIndices.Add(1);
            mesh_Dekor3.TriangleIndices.Add(0);
            mesh_Dekor3.TriangleIndices.Add(5);
            mesh_Dekor3.TriangleIndices.Add(1);
            mesh_Dekor3.TriangleIndices.Add(3);
            mesh_Dekor3.TriangleIndices.Add(4);
            mesh_Dekor3.TriangleIndices.Add(2);
            mesh_Dekor3.TriangleIndices.Add(0);
            mesh_Dekor3.TriangleIndices.Add(6);
            mesh_Dekor3.TriangleIndices.Add(2);
            mesh_Dekor3.TriangleIndices.Add(3);
            mesh_Dekor3.TriangleIndices.Add(7);
            mesh_Dekor3.TriangleIndices.Add(8);
            mesh_Dekor3.TriangleIndices.Add(13);
            mesh_Dekor3.TriangleIndices.Add(14);
            mesh_Dekor3.TriangleIndices.Add(13);
            mesh_Dekor3.TriangleIndices.Add(14);
            mesh_Dekor3.TriangleIndices.Add(12);
            mesh_Dekor3.TriangleIndices.Add(9);
            mesh_Dekor3.TriangleIndices.Add(12);
            mesh_Dekor3.TriangleIndices.Add(15);
            mesh_Dekor3.TriangleIndices.Add(12);
            mesh_Dekor3.TriangleIndices.Add(15);
            mesh_Dekor3.TriangleIndices.Add(13);
            mesh_Dekor3.TriangleIndices.Add(13);
            mesh_Dekor3.TriangleIndices.Add(10);
            mesh_Dekor3.TriangleIndices.Add(11);
            mesh_Dekor3.TriangleIndices.Add(13);
            mesh_Dekor3.TriangleIndices.Add(11);
            mesh_Dekor3.TriangleIndices.Add(12);
            DiffuseMaterial myMaterial7 = new DiffuseMaterial(new SolidColorBrush(Colors.LimeGreen));
            GeometryModel3D model1_6 = new GeometryModel3D();
            model1_6.Geometry = mesh_Dekor3;
            model1_6.Material = myMaterial7;
            model1_6.BackMaterial = myMaterial7;
            return model1_6;
        }
        public GeometryModel3D Cubik10()
        {
            mesh_Dekor4.Positions.Add(new Point3D(-1.5, 1.5, -1.505)); 
            mesh_Dekor4.Positions.Add(new Point3D(-1.5, -1.5, -1.505)); 
            mesh_Dekor4.Positions.Add(new Point3D(1.5, 1.5, -1.505)); 
            mesh_Dekor4.Positions.Add(new Point3D(1.5, -1.5, -1.505)); 
            mesh_Dekor4.Positions.Add(new Point3D(-1.5, -1.1, -1.505)); 
            mesh_Dekor4.Positions.Add(new Point3D(-1.1, -1.5, -1.505)); 
            mesh_Dekor4.Positions.Add(new Point3D(1.5, 1.1, -1.505));
            mesh_Dekor4.Positions.Add(new Point3D(1.1, 1.5, -1.505));
            mesh_Dekor4.Positions.Add(new Point3D(-0.5, 0.5, -1.505)); 
            mesh_Dekor4.Positions.Add(new Point3D(0.5, 0.5, -1.505));
            mesh_Dekor4.Positions.Add(new Point3D(-0.1, -0.5, -1.505)); 
            mesh_Dekor4.Positions.Add(new Point3D(0.1, -0.5, -1.505)); 
            mesh_Dekor4.Positions.Add(new Point3D(0.1, 0, -1.505)); 
            mesh_Dekor4.Positions.Add(new Point3D(-0.1, 0,  -1.505)); 
            mesh_Dekor4.Positions.Add(new Point3D(-0.3, 0.5, -1.505)); 
            mesh_Dekor4.Positions.Add(new Point3D(0.3, 0.5, -1.505)); 
            mesh_Dekor4.Positions.Add(new Point3D(1, 0.1, - 1.505));
            mesh_Dekor4.Positions.Add(new Point3D(1, -0.1, -1.505));
            mesh_Dekor4.Positions.Add(new Point3D(0.5, 0.1, -1.505));
            mesh_Dekor4.Positions.Add(new Point3D(0.5, -0.1, -1.505));
            mesh_Dekor4.TriangleIndices.Add(1);
            mesh_Dekor4.TriangleIndices.Add(0);
            mesh_Dekor4.TriangleIndices.Add(5);
            mesh_Dekor4.TriangleIndices.Add(1);
            mesh_Dekor4.TriangleIndices.Add(3);
            mesh_Dekor4.TriangleIndices.Add(4);
            mesh_Dekor4.TriangleIndices.Add(2);
            mesh_Dekor4.TriangleIndices.Add(0);
            mesh_Dekor4.TriangleIndices.Add(6);
            mesh_Dekor4.TriangleIndices.Add(2);
            mesh_Dekor4.TriangleIndices.Add(3);
            mesh_Dekor4.TriangleIndices.Add(7);
            mesh_Dekor4.TriangleIndices.Add(8);
            mesh_Dekor4.TriangleIndices.Add(13);
            mesh_Dekor4.TriangleIndices.Add(14);
            mesh_Dekor4.TriangleIndices.Add(13);
            mesh_Dekor4.TriangleIndices.Add(14);
            mesh_Dekor4.TriangleIndices.Add(12);
            mesh_Dekor4.TriangleIndices.Add(9);
            mesh_Dekor4.TriangleIndices.Add(12);
            mesh_Dekor4.TriangleIndices.Add(15);
            mesh_Dekor4.TriangleIndices.Add(12);
            mesh_Dekor4.TriangleIndices.Add(15);
            mesh_Dekor4.TriangleIndices.Add(13);
            mesh_Dekor4.TriangleIndices.Add(13);
            mesh_Dekor4.TriangleIndices.Add(10);
            mesh_Dekor4.TriangleIndices.Add(11);
            mesh_Dekor4.TriangleIndices.Add(13);
            mesh_Dekor4.TriangleIndices.Add(11);
            mesh_Dekor4.TriangleIndices.Add(12);
            mesh_Dekor4.TriangleIndices.Add(16);
            mesh_Dekor4.TriangleIndices.Add(18);
            mesh_Dekor4.TriangleIndices.Add(17);
            mesh_Dekor4.TriangleIndices.Add(18);
            mesh_Dekor4.TriangleIndices.Add(17);
            mesh_Dekor4.TriangleIndices.Add(19);
            DiffuseMaterial myMaterial7 = new DiffuseMaterial(new SolidColorBrush(Colors.LimeGreen));
            GeometryModel3D model1_6 = new GeometryModel3D();
            model1_6.Geometry = mesh_Dekor4;
            model1_6.Material = myMaterial7;
            model1_6.BackMaterial = myMaterial7;
            return model1_6;
        }
        public GeometryModel3D Cubik11()
        {
            mesh_Dekor5.Positions.Add(new Point3D(-1.5, 1.505, -1.5)); 
            mesh_Dekor5.Positions.Add(new Point3D(-1.5, 1.505, 1.5));
            mesh_Dekor5.Positions.Add(new Point3D(1.5, 1.505, -1.5)); 
            mesh_Dekor5.Positions.Add(new Point3D(1.5, 1.505, 1.5)); 
            mesh_Dekor5.Positions.Add(new Point3D(-1.1, 1.505, 1.5)); 
            mesh_Dekor5.Positions.Add(new Point3D(-1.5, 1.505, 1.1)); 
            mesh_Dekor5.Positions.Add(new Point3D(1.1, 1.505, -1.5)); 
            mesh_Dekor5.Positions.Add(new Point3D(1.5, 1.505, -1.1)); 
            mesh_Dekor5.Positions.Add(new Point3D(-0.5, 1.505, 0.5)); 
            mesh_Dekor5.Positions.Add(new Point3D(-0.5, 1.505, 0.3)); 
            mesh_Dekor5.Positions.Add(new Point3D(0.5, 1.505, 0.5)); 
            mesh_Dekor5.Positions.Add(new Point3D(0.5, 1.505, 0.3)); 
            mesh_Dekor5.Positions.Add(new Point3D(-0.5, 1.505, -0.5)); 
            mesh_Dekor5.Positions.Add(new Point3D(-0.5, 1.505,-0.3)); 
            mesh_Dekor5.Positions.Add(new Point3D(0.5, 1.505, -0.5)); 
            mesh_Dekor5.Positions.Add(new Point3D(0.5, 1.505, -0.3)); 
            mesh_Dekor5.TriangleIndices.Add(1);
            mesh_Dekor5.TriangleIndices.Add(0);
            mesh_Dekor5.TriangleIndices.Add(4);
            mesh_Dekor5.TriangleIndices.Add(1);
            mesh_Dekor5.TriangleIndices.Add(3);
            mesh_Dekor5.TriangleIndices.Add(5);
            mesh_Dekor5.TriangleIndices.Add(2);
            mesh_Dekor5.TriangleIndices.Add(3);
            mesh_Dekor5.TriangleIndices.Add(6);
            mesh_Dekor5.TriangleIndices.Add(2);
            mesh_Dekor5.TriangleIndices.Add(0);
            mesh_Dekor5.TriangleIndices.Add(7);
            mesh_Dekor5.TriangleIndices.Add(12);
            mesh_Dekor5.TriangleIndices.Add(13);
            mesh_Dekor5.TriangleIndices.Add(15);
            mesh_Dekor5.TriangleIndices.Add(12);
            mesh_Dekor5.TriangleIndices.Add(15);
            mesh_Dekor5.TriangleIndices.Add(14);
            mesh_Dekor5.TriangleIndices.Add(15);
            mesh_Dekor5.TriangleIndices.Add(14);
            mesh_Dekor5.TriangleIndices.Add(8);
            mesh_Dekor5.TriangleIndices.Add(14);
            mesh_Dekor5.TriangleIndices.Add(9);
            mesh_Dekor5.TriangleIndices.Add(8);
            mesh_Dekor5.TriangleIndices.Add(8);
            mesh_Dekor5.TriangleIndices.Add(9);
            mesh_Dekor5.TriangleIndices.Add(10);
            mesh_Dekor5.TriangleIndices.Add(9);
            mesh_Dekor5.TriangleIndices.Add(10);
            mesh_Dekor5.TriangleIndices.Add(11);
            DiffuseMaterial myMaterial7 = new DiffuseMaterial(new SolidColorBrush(Colors.Blue));
            GeometryModel3D model1_6 = new GeometryModel3D();
            model1_6.Geometry = mesh_Dekor5;
            model1_6.Material = myMaterial7;
            model1_6.BackMaterial = myMaterial7;
            return model1_6;
        }
        public GeometryModel3D Cubik12()
        {
            mesh_Dekor6.Positions.Add(new Point3D(-1.5, -1.505, -1.5)); 
            mesh_Dekor6.Positions.Add(new Point3D(-1.5, -1.505, 1.5)); 
            mesh_Dekor6.Positions.Add(new Point3D(1.5, -1.505, -1.5)); 
            mesh_Dekor6.Positions.Add(new Point3D(1.5, -1.505, 1.5)); 
            mesh_Dekor6.Positions.Add(new Point3D(-1.1, -1.505, 1.5)); 
            mesh_Dekor6.Positions.Add(new Point3D(-1.5, -1.505, 1.1)); 
            mesh_Dekor6.Positions.Add(new Point3D(1.1, -1.505, -1.5)); 
            mesh_Dekor6.Positions.Add(new Point3D(1.5, -1.505, -1.1)); 
            mesh_Dekor6.Positions.Add(new Point3D(-0.5, -1.505, 0.5)); 
            mesh_Dekor6.Positions.Add(new Point3D(-0.5, -1.505, 0.3)); 
            mesh_Dekor6.Positions.Add(new Point3D(0.5, -1.505, 0.5)); 
            mesh_Dekor6.Positions.Add(new Point3D(0.5, -1.505, 0.3)); 
            mesh_Dekor6.Positions.Add(new Point3D(-0.5, -1.505, -0.5)); 
            mesh_Dekor6.Positions.Add(new Point3D(-0.5, -1.505, -0.3)); 
            mesh_Dekor6.Positions.Add(new Point3D(0.5, -1.505, -0.5)); 
            mesh_Dekor6.Positions.Add(new Point3D(0.5, -1.505, -0.3)); 
            mesh_Dekor6.Positions.Add(new Point3D(-1, -1.505, 0.1)); 
            mesh_Dekor6.Positions.Add(new Point3D(-1, -1.505, -0.1)); 
            mesh_Dekor6.Positions.Add(new Point3D(-0.5, -1.505, 0.1)); 
            mesh_Dekor6.Positions.Add(new Point3D(-0.5, -1.505, -0.1)); 
            mesh_Dekor6.TriangleIndices.Add(1);
            mesh_Dekor6.TriangleIndices.Add(0);
            mesh_Dekor6.TriangleIndices.Add(4);
            mesh_Dekor6.TriangleIndices.Add(1);
            mesh_Dekor6.TriangleIndices.Add(3);
            mesh_Dekor6.TriangleIndices.Add(5);
            mesh_Dekor6.TriangleIndices.Add(2);
            mesh_Dekor6.TriangleIndices.Add(3);
            mesh_Dekor6.TriangleIndices.Add(6);
            mesh_Dekor6.TriangleIndices.Add(2);
            mesh_Dekor6.TriangleIndices.Add(0);
            mesh_Dekor6.TriangleIndices.Add(7);
            mesh_Dekor6.TriangleIndices.Add(12);
            mesh_Dekor6.TriangleIndices.Add(13);
            mesh_Dekor6.TriangleIndices.Add(15);
            mesh_Dekor6.TriangleIndices.Add(12);
            mesh_Dekor6.TriangleIndices.Add(15);
            mesh_Dekor6.TriangleIndices.Add(14);
            mesh_Dekor6.TriangleIndices.Add(10);
            mesh_Dekor6.TriangleIndices.Add(11);
            mesh_Dekor6.TriangleIndices.Add(12);
            mesh_Dekor6.TriangleIndices.Add(10);
            mesh_Dekor6.TriangleIndices.Add(12);
            mesh_Dekor6.TriangleIndices.Add(13);
            mesh_Dekor6.TriangleIndices.Add(8);
            mesh_Dekor6.TriangleIndices.Add(9);
            mesh_Dekor6.TriangleIndices.Add(10);
            mesh_Dekor6.TriangleIndices.Add(9);
            mesh_Dekor6.TriangleIndices.Add(10);
            mesh_Dekor6.TriangleIndices.Add(11);
            mesh_Dekor6.TriangleIndices.Add(16);
            mesh_Dekor6.TriangleIndices.Add(17);
            mesh_Dekor6.TriangleIndices.Add(18);
            mesh_Dekor6.TriangleIndices.Add(17);
            mesh_Dekor6.TriangleIndices.Add(18);
            mesh_Dekor6.TriangleIndices.Add(19);
            DiffuseMaterial myMaterial7 = new DiffuseMaterial(new SolidColorBrush(Colors.Blue));
            GeometryModel3D model1_6 = new GeometryModel3D();
            model1_6.Geometry = mesh_Dekor6;
            model1_6.Material = myMaterial7;
            model1_6.BackMaterial = myMaterial7;
            return model1_6;
        }
        public GeometryModel3D AxisZ()
        {
            meshZ_1.Positions.Add(new Point3D(-0.07, -5, 0));
            meshZ_1.Positions.Add(new Point3D(0.07, -5, 0));
            meshZ_1.Positions.Add(new Point3D(-0.07, 0, 0));
            meshZ_1.Positions.Add(new Point3D(0.07, 0, 0));
            meshZ_1.Positions.Add(new Point3D(0, -5, -0.07));
            meshZ_1.Positions.Add(new Point3D(0, -5, 0.07));
            meshZ_1.Positions.Add(new Point3D(0, 0, -0.07));
            meshZ_1.Positions.Add(new Point3D(0, 0, 0.07));
            createTriangleIndices(meshZ_1);
            DiffuseMaterial myMaterial3 = new DiffuseMaterial(new SolidColorBrush(Colors.Blue));
            GeometryModel3D model2 = new GeometryModel3D(meshZ_1, myMaterial3);
            model2.BackMaterial = myMaterial3;
            return model2;
        }
        public GeometryModel3D AxisZ2()
        {
            meshZ_2.Positions.Add(new Point3D(-0.07, 0, 0));
            meshZ_2.Positions.Add(new Point3D(0.07, 0, 0));
            meshZ_2.Positions.Add(new Point3D(-0.07, 5, 0));
            meshZ_2.Positions.Add(new Point3D(0.07, 5, 0));
            meshZ_2.Positions.Add(new Point3D(0, 0, -0.07));
            meshZ_2.Positions.Add(new Point3D(0, 0, 0.07));
            meshZ_2.Positions.Add(new Point3D(0, 5, -0.07));
            meshZ_2.Positions.Add(new Point3D(0, 5, 0.07));
            createTriangleIndices(meshZ_2);
            DiffuseMaterial myMaterial3 = new DiffuseMaterial(new SolidColorBrush(Colors.Blue));
            GeometryModel3D model2 = new GeometryModel3D(meshZ_2, myMaterial3);
            model2.BackMaterial = myMaterial3;
            return model2;
        }
        public GeometryModel3D AxisX()
        {
            meshX_1.Positions.Add(new Point3D(-5, 0, -0.07));
            meshX_1.Positions.Add(new Point3D(-5, 0, 0.07));
            meshX_1.Positions.Add(new Point3D(0, 0, -0.07));
            meshX_1.Positions.Add(new Point3D(0, 0, 0.07));
            meshX_1.Positions.Add(new Point3D(-5, -0.07, 0));
            meshX_1.Positions.Add(new Point3D(-5, 0.07, 0));
            meshX_1.Positions.Add(new Point3D(0, -0.07, 0));
            meshX_1.Positions.Add(new Point3D(0, 0.07, 0));
            createTriangleIndices(meshX_1);
            DiffuseMaterial myMaterial3 = new DiffuseMaterial(new SolidColorBrush(Colors.Red));
            GeometryModel3D model5 = new GeometryModel3D(meshX_1, myMaterial3);
            model5.BackMaterial = myMaterial3;
            return model5;
        }
        public GeometryModel3D AxisX2()
        {
            meshX_2.Positions.Add(new Point3D(0, 0, -0.07));
            meshX_2.Positions.Add(new Point3D(0, 0, 0.07));
            meshX_2.Positions.Add(new Point3D(5, 0, -0.07));
            meshX_2.Positions.Add(new Point3D(5, 0, 0.07));
            meshX_2.Positions.Add(new Point3D(0, -0.07, 0));
            meshX_2.Positions.Add(new Point3D(0, 0.07, 0));
            meshX_2.Positions.Add(new Point3D(5, -0.07, 0));
            meshX_2.Positions.Add(new Point3D(5, 0.07, 0));
            createTriangleIndices(meshX_2);
            DiffuseMaterial myMaterial3 = new DiffuseMaterial(new SolidColorBrush(Colors.Red));
            GeometryModel3D model5 = new GeometryModel3D(meshX_2, myMaterial3);
            model5.BackMaterial = myMaterial3;
            return model5;
        }
        public GeometryModel3D AxisY()
        {
            meshY_1.Positions.Add(new Point3D(-0.07, 0, -5));
            meshY_1.Positions.Add(new Point3D(0.07, 0, -5));
            meshY_1.Positions.Add(new Point3D(-0.07, 0, 0));
            meshY_1.Positions.Add(new Point3D(0.07, 0, 0));
            meshY_1.Positions.Add(new Point3D(0, 0.07, -5));
            meshY_1.Positions.Add(new Point3D(0, -0.07, -5));
            meshY_1.Positions.Add(new Point3D(0, 0.07, 0));
            meshY_1.Positions.Add(new Point3D(0, -0.07, 0));
            createTriangleIndices(meshY_1);
            DiffuseMaterial myMaterial3 = new DiffuseMaterial(new SolidColorBrush(Colors.LimeGreen));
            GeometryModel3D model4 = new GeometryModel3D(meshY_1, myMaterial3);
            model4.BackMaterial = myMaterial3;
            return model4;
        }
        public GeometryModel3D AxisY2()
        {
            meshY_2.Positions.Add(new Point3D(-0.07, 0, 0));
            meshY_2.Positions.Add(new Point3D(0.07, 0, 0));
            meshY_2.Positions.Add(new Point3D(-0.07, 0, 5));
            meshY_2.Positions.Add(new Point3D(0.07, 0, 5));
            meshY_2.Positions.Add(new Point3D(0, 0.07, 0));
            meshY_2.Positions.Add(new Point3D(0, -0.07, 0));
            meshY_2.Positions.Add(new Point3D(0, 0.07, 5));
            meshY_2.Positions.Add(new Point3D(0, -0.07, 5));
            createTriangleIndices(meshY_2);
            DiffuseMaterial myMaterial3 = new DiffuseMaterial(new SolidColorBrush(Colors.LimeGreen));
            GeometryModel3D model4 = new GeometryModel3D(meshY_2, myMaterial3);
            model4.BackMaterial = myMaterial3;
            return model4;
        }
        public void createTriangleIndices(MeshGeometry3D mesh)
        {
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(7);
        }
        public void update()
        {
            myPCamera.Position = new Point3D(3, 3, 3);
            myPCamera.LookDirection = new Vector3D(-3, -3, -3);
            myPCamera.UpDirection = new Vector3D(0, 1, 0);
            myPCamera.FieldOfView = 80;
        }
        public void updateColorGr(GeometryModel3D model)
        {
            DiffuseMaterial myMaterial = new DiffuseMaterial(new SolidColorBrush(Colors.Yellow));
            model.Material = myMaterial;
            model.BackMaterial = myMaterial;
        }
        public void OrigninalColorGr()
        {
            model1_1.Material = myMaterial7;
            model1_1.BackMaterial = myMaterial7;
            model1_2.Material = myMaterial7;
            model1_2.BackMaterial = myMaterial7;
            model1_3.Material = myMaterial7;
            model1_3.BackMaterial = myMaterial7;
            model1_4.Material = myMaterial7;
            model1_4.BackMaterial = myMaterial7;
            model1_5.Material = myMaterial7;
            model1_5.BackMaterial = myMaterial7;
            model1_6.Material = myMaterial7;
            model1_6.BackMaterial = myMaterial7;
        }
    }
}
