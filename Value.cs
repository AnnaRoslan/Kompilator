using AntlrTemplate;
using System.Collections.Generic;
public class Value
{
    public string content;
    public VarType type;
    public VarType VectorType;
    public int stringVersion;
    public List<string> values;

    public Value(string content, VarType type)
    {
        this.content = content;
        this.type = type;
        stringVersion = 0;
        values = new List<string>();
        VectorType = VarType.REAL;
    }
}