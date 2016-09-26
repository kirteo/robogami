//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: symbolic.proto
namespace FabByExample.proto.symbolic
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Parameter")]
  public partial class Parameter : global::ProtoBuf.IExtensible
  {
    public Parameter() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private double _default = default(double);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"default", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double @default
    {
      get { return _default; }
      set { _default = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LinearExpr")]
  public partial class LinearExpr : global::ProtoBuf.IExtensible
  {
    public LinearExpr() {}
    
    private readonly global::System.Collections.Generic.List<int> _parameter_id = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(1, Name=@"parameter_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> parameter_id
    {
      get { return _parameter_id; }
    }
  
    private readonly global::System.Collections.Generic.List<double> _coeff = new global::System.Collections.Generic.List<double>();
    [global::ProtoBuf.ProtoMember(2, Name=@"coeff", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<double> coeff
    {
      get { return _coeff; }
    }
  
    private double _const = default(double);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"const", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double @const
    {
      get { return _const; }
      set { _const = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Point2S")]
  public partial class Point2S : global::ProtoBuf.IExtensible
  {
    public Point2S() {}
    
    private FabByExample.proto.symbolic.LinearExpr _x = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public FabByExample.proto.symbolic.LinearExpr x
    {
      get { return _x; }
      set { _x = value; }
    }
    private FabByExample.proto.symbolic.LinearExpr _y = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public FabByExample.proto.symbolic.LinearExpr y
    {
      get { return _y; }
      set { _y = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Point3S")]
  public partial class Point3S : global::ProtoBuf.IExtensible
  {
    public Point3S() {}
    
    private FabByExample.proto.symbolic.LinearExpr _x = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public FabByExample.proto.symbolic.LinearExpr x
    {
      get { return _x; }
      set { _x = value; }
    }
    private FabByExample.proto.symbolic.LinearExpr _y = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public FabByExample.proto.symbolic.LinearExpr y
    {
      get { return _y; }
      set { _y = value; }
    }
    private FabByExample.proto.symbolic.LinearExpr _z = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public FabByExample.proto.symbolic.LinearExpr z
    {
      get { return _z; }
      set { _z = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Vertex2S")]
  public partial class Vertex2S : global::ProtoBuf.IExtensible
  {
    public Vertex2S() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private FabByExample.proto.symbolic.Point2S _point = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"point", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public FabByExample.proto.symbolic.Point2S point
    {
      get { return _point; }
      set { _point = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Edge2S")]
  public partial class Edge2S : global::ProtoBuf.IExtensible
  {
    public Edge2S() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _vertex1_id = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"vertex1_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int vertex1_id
    {
      get { return _vertex1_id; }
      set { _vertex1_id = value; }
    }
    private int _vertex2_id = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"vertex2_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int vertex2_id
    {
      get { return _vertex2_id; }
      set { _vertex2_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Face2S")]
  public partial class Face2S : global::ProtoBuf.IExtensible
  {
    public Face2S() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _vertex_id = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(3, Name=@"vertex_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> vertex_id
    {
      get { return _vertex_id; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _edge_id = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(4, Name=@"edge_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> edge_id
    {
      get { return _edge_id; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Drawing2S")]
  public partial class Drawing2S : global::ProtoBuf.IExtensible
  {
    public Drawing2S() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private readonly global::System.Collections.Generic.List<FabByExample.proto.symbolic.Vertex2S> _vertex = new global::System.Collections.Generic.List<FabByExample.proto.symbolic.Vertex2S>();
    [global::ProtoBuf.ProtoMember(3, Name=@"vertex", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FabByExample.proto.symbolic.Vertex2S> vertex
    {
      get { return _vertex; }
    }
  
    private readonly global::System.Collections.Generic.List<FabByExample.proto.symbolic.Edge2S> _edge = new global::System.Collections.Generic.List<FabByExample.proto.symbolic.Edge2S>();
    [global::ProtoBuf.ProtoMember(4, Name=@"edge", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FabByExample.proto.symbolic.Edge2S> edge
    {
      get { return _edge; }
    }
  
    private readonly global::System.Collections.Generic.List<FabByExample.proto.symbolic.Face2S> _face = new global::System.Collections.Generic.List<FabByExample.proto.symbolic.Face2S>();
    [global::ProtoBuf.ProtoMember(5, Name=@"face", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FabByExample.proto.symbolic.Face2S> face
    {
      get { return _face; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Vertex3S")]
  public partial class Vertex3S : global::ProtoBuf.IExtensible
  {
    public Vertex3S() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private FabByExample.proto.symbolic.Point3S _point = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"point", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public FabByExample.proto.symbolic.Point3S point
    {
      get { return _point; }
      set { _point = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Edge3S")]
  public partial class Edge3S : global::ProtoBuf.IExtensible
  {
    public Edge3S() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _vertex1_id = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"vertex1_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int vertex1_id
    {
      get { return _vertex1_id; }
      set { _vertex1_id = value; }
    }
    private int _vertex2_id = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"vertex2_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int vertex2_id
    {
      get { return _vertex2_id; }
      set { _vertex2_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Face3S")]
  public partial class Face3S : global::ProtoBuf.IExtensible
  {
    public Face3S() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _vertex_id = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(3, Name=@"vertex_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> vertex_id
    {
      get { return _vertex_id; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _edge_id = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(4, Name=@"edge_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> edge_id
    {
      get { return _edge_id; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Mesh3S")]
  public partial class Mesh3S : global::ProtoBuf.IExtensible
  {
    public Mesh3S() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _name = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int name
    {
      get { return _name; }
      set { _name = value; }
    }
    private readonly global::System.Collections.Generic.List<FabByExample.proto.symbolic.Vertex3S> _vertex = new global::System.Collections.Generic.List<FabByExample.proto.symbolic.Vertex3S>();
    [global::ProtoBuf.ProtoMember(3, Name=@"vertex", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FabByExample.proto.symbolic.Vertex3S> vertex
    {
      get { return _vertex; }
    }
  
    private readonly global::System.Collections.Generic.List<FabByExample.proto.symbolic.Edge3S> _edge = new global::System.Collections.Generic.List<FabByExample.proto.symbolic.Edge3S>();
    [global::ProtoBuf.ProtoMember(4, Name=@"edge", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FabByExample.proto.symbolic.Edge3S> edge
    {
      get { return _edge; }
    }
  
    private readonly global::System.Collections.Generic.List<FabByExample.proto.symbolic.Face3S> _face = new global::System.Collections.Generic.List<FabByExample.proto.symbolic.Face3S>();
    [global::ProtoBuf.ProtoMember(5, Name=@"face", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FabByExample.proto.symbolic.Face3S> face
    {
      get { return _face; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AffineMatrix3S")]
  public partial class AffineMatrix3S : global::ProtoBuf.IExtensible
  {
    public AffineMatrix3S() {}
    
    private readonly global::System.Collections.Generic.List<FabByExample.proto.symbolic.LinearExpr> _value = new global::System.Collections.Generic.List<FabByExample.proto.symbolic.LinearExpr>();
    [global::ProtoBuf.ProtoMember(1, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FabByExample.proto.symbolic.LinearExpr> value
    {
      get { return _value; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Transform")]
  public partial class Transform : global::ProtoBuf.IExtensible
  {
    public Transform() {}
    
    private FabByExample.proto.symbolic.Control _control = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"control", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public FabByExample.proto.symbolic.Control control
    {
      get { return _control; }
      set { _control = value; }
    }
    private FabByExample.proto.symbolic.Point3S _axis = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"axis", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public FabByExample.proto.symbolic.Point3S axis
    {
      get { return _axis; }
      set { _axis = value; }
    }
    private FabByExample.proto.symbolic.Transform.TransformType _type = FabByExample.proto.symbolic.Transform.TransformType.REVOLUTE_TRANSFORM;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(FabByExample.proto.symbolic.Transform.TransformType.REVOLUTE_TRANSFORM)]
    public FabByExample.proto.symbolic.Transform.TransformType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private double _minVal = default(double);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"minVal", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double minVal
    {
      get { return _minVal; }
      set { _minVal = value; }
    }
    private double _maxVal = default(double);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"maxVal", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double maxVal
    {
      get { return _maxVal; }
      set { _maxVal = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"TransformType")]
    public enum TransformType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"REVOLUTE_TRANSFORM", Value=1)]
      REVOLUTE_TRANSFORM = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PRISMATIC_TRANSFORM", Value=2)]
      PRISMATIC_TRANSFORM = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Control")]
  public partial class Control : global::ProtoBuf.IExtensible
  {
    public Control() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private FabByExample.proto.symbolic.ControlMappingFunction _inputs = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"inputs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public FabByExample.proto.symbolic.ControlMappingFunction inputs
    {
      get { return _inputs; }
      set { _inputs = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ControlMappingFunction")]
  public partial class ControlMappingFunction : global::ProtoBuf.IExtensible
  {
    public ControlMappingFunction() {}
    
    private FabByExample.proto.symbolic.LinearMappingFuction1D _linear_1 = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"linear_1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public FabByExample.proto.symbolic.LinearMappingFuction1D linear_1
    {
      get { return _linear_1; }
      set { _linear_1 = value; }
    }
    private FabByExample.proto.symbolic.PiecewiseLinearFunction1D _piecewiselinear = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"piecewiselinear", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public FabByExample.proto.symbolic.PiecewiseLinearFunction1D piecewiselinear
    {
      get { return _piecewiselinear; }
      set { _piecewiselinear = value; }
    }
    private FabByExample.proto.symbolic.ParametricPiecewiseLinearFunction _piecewiseFunction = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"piecewiseFunction", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public FabByExample.proto.symbolic.ParametricPiecewiseLinearFunction piecewiseFunction
    {
      get { return _piecewiseFunction; }
      set { _piecewiseFunction = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ParametricPiecewiseLinearFunction")]
  public partial class ParametricPiecewiseLinearFunction : global::ProtoBuf.IExtensible
  {
    public ParametricPiecewiseLinearFunction() {}
    
    private readonly global::System.Collections.Generic.List<FabByExample.proto.symbolic.PWLinear> _pairs = new global::System.Collections.Generic.List<FabByExample.proto.symbolic.PWLinear>();
    [global::ProtoBuf.ProtoMember(1, Name=@"pairs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FabByExample.proto.symbolic.PWLinear> pairs
    {
      get { return _pairs; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LinearMappingFuction1D")]
  public partial class LinearMappingFuction1D : global::ProtoBuf.IExtensible
  {
    public LinearMappingFuction1D() {}
    
    private FabByExample.proto.symbolic.LinearExpr _linearTimeMap = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"linearTimeMap", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public FabByExample.proto.symbolic.LinearExpr linearTimeMap
    {
      get { return _linearTimeMap; }
      set { _linearTimeMap = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PiecewiseLinearFunction1D")]
  public partial class PiecewiseLinearFunction1D : global::ProtoBuf.IExtensible
  {
    public PiecewiseLinearFunction1D() {}
    
    private readonly global::System.Collections.Generic.List<FabByExample.proto.symbolic.TimeAndValuePair> _timesandvalues = new global::System.Collections.Generic.List<FabByExample.proto.symbolic.TimeAndValuePair>();
    [global::ProtoBuf.ProtoMember(1, Name=@"timesandvalues", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FabByExample.proto.symbolic.TimeAndValuePair> timesandvalues
    {
      get { return _timesandvalues; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TimeAndValuePair")]
  public partial class TimeAndValuePair : global::ProtoBuf.IExtensible
  {
    public TimeAndValuePair() {}
    
    private double _timeStamp = default(double);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"timeStamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double timeStamp
    {
      get { return _timeStamp; }
      set { _timeStamp = value; }
    }
    private double _value = default(double);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PWLinear")]
  public partial class PWLinear : global::ProtoBuf.IExtensible
  {
    public PWLinear() {}
    
    private readonly global::System.Collections.Generic.List<FabByExample.proto.symbolic.LinearExpr> _time = new global::System.Collections.Generic.List<FabByExample.proto.symbolic.LinearExpr>();
    [global::ProtoBuf.ProtoMember(1, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FabByExample.proto.symbolic.LinearExpr> time
    {
      get { return _time; }
    }
  
    private readonly global::System.Collections.Generic.List<FabByExample.proto.symbolic.LinearExpr> _value = new global::System.Collections.Generic.List<FabByExample.proto.symbolic.LinearExpr>();
    [global::ProtoBuf.ProtoMember(2, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FabByExample.proto.symbolic.LinearExpr> value
    {
      get { return _value; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}