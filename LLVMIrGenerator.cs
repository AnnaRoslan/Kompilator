// Include namespace system
using AntlrTemplate;
using System;
using System.Collections;
using System.Collections.Generic;

public class LLVMIrGenerator
{
    public static int Label = 1;
    private static string BeforeMainCode = "";
    private static string MainTextCode = "";
    private static string Buffer = "";
    private static int StrLabel = 0;
    private static int MainLabel = 1;
    private static int BrLabel = 0;
    public static Stack BrStack = new Stack();

    public static string generate()
    {
        MainTextCode += Buffer;
        //formatMainText();
        var preparationText = "";
        preparationText += "declare i32 @printf(i8*, ...)\n";
        preparationText += "declare i32 @scanf(i8*, ...)\n";
        preparationText += "declare i32 @puts(i8*)\n";
        preparationText += "@strpi = constant [4 x i8] c\"%d\\0A\\00\"\n";
        preparationText += "@strpd = constant [4 x i8] c\"%f\\0A\\00\"\n";
        preparationText += "@strps = constant [4 x i8] c\"%s\\0A\\00\"\n";
        preparationText += "@strsi = constant [3 x i8] c\"%d\\00\"\n";
        preparationText += "@strsd = constant [4 x i8] c\"%lf\\00\"\n";
        preparationText += "\n";
        preparationText += BeforeMainCode;
        preparationText += "define i32 @main() nounwind {\n";
        preparationText += MainTextCode;
        preparationText += "  ret i32 0\n";
        preparationText += "}\n";
        return preparationText;
    }

    public static void FunctionStart(string id)
    {
        MainTextCode += Buffer;
        MainLabel = Label;
        Buffer = $"define void @{id}() nounwind {{\n";
        Label = 1;
    }

    public static void FunctionEnd()
    {
        Buffer += "ret void\n";
        //formatBuffer();
        Buffer += "}\n";
        BeforeMainCode += Buffer;
        Buffer = "";
        Label = MainLabel;
    }

    public static void Call(string func)
    {
        Buffer += "call void @" + func + "()\n";
    }

    public static void PrintText(string text)
    {
        var textLen = text.Length;
        var textype = $"[{ textLen + 2} x i8]";
        BeforeMainCode += $"@str{ StrLabel} = constant{ textype} c\"{ text}\\0A\\00\"\n";
        Buffer += $"%{ Label} = call i32 (i8*, ...) @printf(i8* getelementptr inbounds ( { textype}, { textype} * @str{StrLabel}, i32 0, i32 0))\n";
        StrLabel++;
        Label++;
    }

    public static void PrintfI32(string id, HashSet<string> globalNames)
    {
        if (globalNames.Contains(id))
        {
            Buffer += $"%{Label} = load i32, i32* @{id}\n";
        }
        else
        {
            Buffer += $"%{Label} = load i32, i32* %{id}\n";
        }
        Label++;
        Buffer += $"%{Label}= call i32 (i8*, ...) @printf(i8* getelementptr inbounds ([4 x i8], [4 x i8]* @strpi, i32 0, i32 0), i32 %{ Label - 1})\n";
        Label++;
    }


    public static void PrintfDouble(string id, HashSet<string> globalNames)
    {
        if (globalNames.Contains(id))
        {
            Buffer += $"%{Label} = load double, double* @{ id}\n";
        }
        else
        {
            Buffer += $"%{Label} = load double, double* %{id}\n";
        }
        Label++;
        Buffer += $"%{Label} = call i32 (i8*, ...) @printf(i8* getelementptr inbounds ([4 x i8], [4 x i8]* @strpd, i32 0, i32 0), double %{Label - 1})\n";
        Label++;
    }

    public static void PrintfString(string id, int length, int stringVersion, HashSet<string> globalNames, string function)
    {
        if (globalNames.Contains(id))
        {
            Buffer += $"%{Label} = bitcast [{length + 1} x i8]* @{id}_{stringVersion}global to i8* \n";
        }
        else
        {
            Buffer += $"%{Label} = bitcast [{length + 1} x i8]* @{function}.{id}_{stringVersion}global to i8*\n";
        }
        Label++;
        Buffer += $"%{Label} = call i32 @puts(i8* %{Label - 1})\n";
        Label++;
    }

    public static void PrintfVector(string id, Value vect, string index, HashSet<string> globalNames)
    {
        var vectType = vect.VectorType == VarType.INT ? "i32" : "double";
        var len = vect.values.Count;
        //    if (globalNames.Contains(id))
        //    {
        //        //todo
        //    }
        //    else
        //    {
        //} 
        Buffer += $"%{Label} = load <{len} x {vectType}>, <{len} x {vectType}> * %{id}\n";
        Buffer += $"%{Label + 1} = extractelement <{len} x {vectType}> %{Label}, i32 {index}\n";
        Label +=2;
        if (vect.VectorType == VarType.INT)
        {
            Buffer += $"%{Label} = call i32 (i8*, ...) @printf(i8* getelementptr inbounds ([4 x i8], [4 x i8]* @strpi, i32 0, i32 0), i32 %{Label-1})\n";
        }
        else
        {
            Buffer += $"%{Label} = call i32 (i8*, ...) @printf(i8* getelementptr inbounds ([4 x i8], [4 x i8]* @strpd, i32 0, i32 0), double %{Label-1})\n";

        }
        Label++;
    }

    public static void ScanfI32(string id, HashSet<string> globalNames)
    {
        AssignI32(id, "0", globalNames);
        if (globalNames.Contains(id))
        {
            Buffer += $"%{Label} = call i32 (i8*, ...) @scanf(i8* getelementptr inbounds ([3 x i8], [3 x i8]* @strsi, i32 0, i32 0), i32* @{id})\n";
        }
        else
        {
            Buffer += $"%{Label} = call i32 (i8*, ...) @scanf(i8* getelementptr inbounds ([3 x i8], [3 x i8]* @strsi, i32 0, i32 0), i32* %{id})\n";
        }
        Label++;
    }

    public static void ScanfDouble(string id, HashSet<string> globalNames)
    {
        AssignDouble(id, "0.0", globalNames);
        if (globalNames.Contains(id))
        {
            Buffer += $"%{Label} = call i32 (i8*, ...) @scanf(i8* getelementptr inbounds ([4 x i8], [4 x i8]* @strsd, i32 0, i32 0), double* @{id})\n";
        }
        else
        {
            Buffer += $"%{Label} = call i32 (i8*, ...) @scanf(i8* getelementptr inbounds ([4 x i8], [4 x i8]* @strsd, i32 0, i32 0), double* %{id})\n";
        }
        Label++;
    }

    public static void DeclareI32(string id, bool isGlobal)
    {
        if (isGlobal)
        {
            BeforeMainCode += $"@{id} = global i32 0\n";
        }
        else
        {
            Buffer += $"%{id} = alloca i32\n";
        }
    }

    public static void DeclareDouble(string id, bool isGlobal)
    {
        if (isGlobal)
        {
            BeforeMainCode += $"@{id} = global double 0.0\n";
        }
        else
        {
            Buffer += $"%{id} = alloca double\n";
        }
    }

    public static void DeclareVector(string id, string len, VarType type, bool isGlobal)
    {
        var vectType = type == VarType.INT ? "i32" : "double";
        //if (isGlobal)
        //{
        //    //todo
        //}
        //else
        //{
        Buffer += $"%{id} = alloca <{len} x {vectType}>\n";
        Buffer += $"store <{len} x {vectType}> zeroinitializer, <{len} x {vectType}>* %{id} \n";
        //}
    }

    public static void AssignI32(string id, string value, HashSet<string> globalNames)
    {
        if (globalNames.Contains(id))
        {
            Buffer += $"store i32 {value}, i32* @{id}\n";
        }
        else
        {
            Buffer += $"store i32 {value}, i32* %{id}\n";
        }
    }

    public static void AssignDouble(string id, string value, HashSet<string> globalNames)
    {
        if (globalNames.Contains(id))
        {
            Buffer += $"store double {value}, double* @{id}\n";
        }
        else
        {
            Buffer += $"store double {value}, double* %{id}\n";
        }
    }

    public static void AssignVector(Value vectValue, string value, string index, HashSet<string> globalNames)
    {
        var vectType = vectValue.VectorType == VarType.INT ? "i32" : "double";
        var len = vectValue.values.Count;
        //if (globalNames.Contains(id))
        //{
        //   //todo
        //}
        //else
        //{
        Buffer += $"%{Label} = load <{len} x {vectType}>, <{len} x {vectType}> * %{vectValue.content} \n";
        Buffer += $"%{Label + 1} = insertelement <{len} x {vectType}> %{Label}, {vectType} {value}, i32 {index} \n";
        Label++;
        Buffer += $"store<{len} x {vectType}> %{Label}, <{len} x {vectType}> * %{vectValue.content} \n";
        Label++;
        //}
    }

    public static void AssignString(string id, string text, int stringVersion, bool isGlobal, string function)
    {
        var len = text.Length + 1;
        var strType = $"[{len} x i8]";
        if (isGlobal)
        {
            BeforeMainCode += $"@{id}_{stringVersion}global = constant{strType} c\"{text}\\00\"\n";
        }
        else
        {
            BeforeMainCode += $"@{function}.{id}_{stringVersion}global = constant{strType} c\"{text}\\00\"\n";
        }
    }

    public static void AddI32(string val1, string val2)
    {
        Buffer += $"%{Label} = add i32 {val1}, {val2}\n";
        Label++;
    }

    public static void AddDouble(string val1, string val2)
    {
        Buffer += $"%{Label} = fadd double {val1}, {val2}\n";
        Label++;
    }

    public static void MulI32(string val1, string val2)
    {
        Buffer += $"%{Label} = mul i32 {val1}, {val2}\n";
        Label++;
    }

    public static void MulDouble(string val1, string val2)
    {
        Buffer += $"%{Label} = fmul double {val1}, {val2}\n";
        Label++;
    }

    public static void SubI32(string val1, string val2)
    {
        Buffer += $"%{Label} = sub i32 {val1}, {val2}\n";
        Label++;
    }

    public static void SubDouble(string val1, string val2)
    {
        Buffer += $"%{Label} = fsub double {val1}, {val2}\n";
        Label++;
    }

    public static void DivI32(string val1, string val2)
    {
        Buffer += $"%{Label} = sdiv i32 {val1}, {val2}\n";
        Label++;
    }

    public static void DivDouble(string val1, string val2)
    {
        Buffer += $"%{Label} = fdiv double {val1}, {val2}\n";
        Label++;
    }

    public static void LoadI32(string id, HashSet<string> globalNames)
    {
        if (globalNames.Contains(id))
        {
            Buffer += $"%{Label} = load i32, i32 * @{id}\n";
        }
        else
        {
            Buffer += $"%{Label} = load i32, i32* %{id}\n";
        }
        Label++;
    }

    public static void LoadDouble(string id, HashSet<string> globalNames)
    {
        if (globalNames.Contains(id))
        {
            Buffer += $"%{Label} = load double, double* @{id}\n";
        }
        else
        {
            Buffer += $"%{Label} = load double, double* %{id}\n";
        }
        Label++;
    }


    internal static void LoadVector(Value value, HashSet<string> globalNames, string index)
    {
        var vectType = value.VectorType == VarType.INT ? "i32" : "double";
        var len = value.values.Count;

        Buffer += $"%{Label} = load <{len} x {vectType}>, <{len} x {vectType}>* %{value.content} \n";
        Label++;
        Buffer += $"%{Label}= extractelement <{len} x {vectType}> %{Label -1}, i32 {index} \n";
        Label++;
    }
    internal static void AssignVectorTo(string id, VarType vectType)
    {
        var type = vectType == VarType.INT ? "i32" : "double";

        Buffer += $"store {type} %{Label-1}, {type}* %{id} \n";
    }
    internal static void AssignWholeVector(string id, Value vect)
    {
        var type = vect.VectorType == VarType.INT ? "i32" : "double";
        var len = vect.values.Count;

        Buffer += $"%{Label++} = load <{len} x {type}>, <{len} x {type}> * %{vect.content}\n ";
        Buffer += $"store <{len} x {type}> %{Label - 1}, <{len} x {type}> * %{id} \n";
    }

    public static void IsEqualI32(string id, string value, HashSet<string> globalNames)
    {
        LoadI32(id, globalNames);
        Buffer += $"%{Label} = icmp eq i32 %{Label - 1}, {value}\n";
        Label++;
    }

    public static void IfStart()
    {
        BrLabel++;
        Buffer += $"br i1 %{Label - 1}, label %If.Body{BrLabel}, label %If.Else{BrLabel}\n";
        Buffer += $"If.Body{BrLabel}:\n";
        BrStack.Push(BrLabel);
    }

    public static void IfEnd()
    {
        var b = BrStack.Pop();
        Buffer += $"br label %If.Else{b}\n";
        Buffer += $"If.Else{b}:\n";
    }

    // do poprawy
    public static void RepeatStart(string ID, HashSet<string> globalNames, bool isReal)
    {
        if (isReal)
        {
            LoadDouble(ID, globalNames);
            Fptosi($"%{Label - 1} "); // po co cto  ??
        }
        else
        {
            LoadI32(ID, globalNames);
        }
        var repetitions = Label - 1;
        DeclareI32(Convert.ToString(Label), false);
        var counter = Label;
        Label++;
        AssignI32(Convert.ToString(counter), "0", new HashSet<string>());
        BrLabel++;
        Buffer += $"br label %cond{BrLabel}\n";
        Buffer += $"cond{BrLabel}:\n";
        LoadI32(Convert.ToString(counter), new HashSet<string>());
        AddI32($"%{Label - 1}", "1");
        AssignI32(Convert.ToString(counter), $"%{Label - 1}", new HashSet<string>());
        Buffer += $"%{Label} = icmp slt i32 %{Label - 2}, %{repetitions}\n";
        Label++;
        Buffer += $"br i1 %{Label - 1}, label %true{BrLabel}, label %false{BrLabel}\n";
        Buffer += $"true{BrLabel}:\n";
        BrStack.Push(BrLabel);
    }

    public static void RepeatEnd()
    {
        var br = BrStack.Pop();
        Buffer += $"br label %cond{br}\n";
        Buffer += $"false{br}:\n";
    }

    public static void Fptosi(string id)
    {
        Buffer += $"%{Label} = fptosi double {id} to i32\n";
        Label++;
    }


    //public static void sitofp(string id)
    //{
    //    buffer += "%" + Label + " = sitofp i32 " + id + " to double\n";
    //    Label++;
    //}

    // helpers
    //private static void formatBuffer()
    //{
    //    string[] lines = buffer.Split("\n");
    //    var sb = new StringBuilder();
    //    sb.Append(lines[0]).Append("\n");
    //    for (int i = 1; i < lines.Length; i++)
    //    {
    //        sb.Append("  ").Append(lines[i]).Append("\n");
    //    }
    //    buffer = sb.ToString();
    //}
    //private static void formatMainText()
    //{
    //    string[] lines = MainText.Split("\n");
    //    var sb = new StringBuilder();
    //    foreach (string line in lines)
    //    {
    //        sb.Append("  ").Append(line).Append("\n");
    //    }
    //    MainText = sb.ToString();
    //}
}