// Parametric Wall Generator
// Grasshopper C# Script Component
// Generates variable-density wall panels

private void RunScript(
  Curve boundary,
  int columns,
  int rows,
  double cellSize,
  double variation,
  ref object A) // A = generated geometry
{
  List<GeometryBase> panels = new List<GeometryBase>();
  
  for (int i = 0; i < columns; i++)
  {
    for (int j = 0; j < rows; j++)
    {
      // Base point
      double x = boundary.PointAtStart.X + i * cellSize;
      double y = boundary.PointAtStart.Y + j * cellSize;
      double z = Math.Sin(i * variation) * Math.Cos(j * variation) * cellSize * 0.3;
      
      Point3d center = new Point3d(x, y, z);
      
      // Create panel
      Brep panel = CreatePanel(center, cellSize * 0.8, z);
      panels.Add(panel);
    }
  }
  
  A = panels;
}

private Brep CreatePanel(Point3d center, double size, double depth)
{
  Interval interval = new Interval(-size/2, size/2);
  Plane plane = new Plane(center, Vector3d.ZAxis);
  return Brep.CreatePlanarBreps(new Circle(plane, size/2).ToNurbsCurve())[0];
}
