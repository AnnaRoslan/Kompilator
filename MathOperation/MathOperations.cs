using AntlrTemplate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

partial class MathOperations
{
    private  static List<string> operations = new List<string>() { "*", "+", "-", "/","(", ")" };
    public static Value DeclareOperation(List<string> expresion, HashSet<string> globalNames, Dictionary<string, Value> variables)
    {
        List<(string, VarType)> rpn = new List<(string, VarType)>();

        foreach (string ex in expresion)
        {
            if (IsNumeric(ex))
            {
                if (int.TryParse(ex, out _))
                {
                    rpn.Add((ex, VarType.INT));
                }
                else
                {
                    rpn.Add((ex, VarType.REAL));
                }
            }
            else
            {
                rpn.Add((ex, VarType.STRING));

            }

        }

        for (int i = 0; i < rpn.Count; i++)
        {
            if (!IsNumeric(rpn[i].Item1) && !operations.Contains(rpn[i].Item1))
            {
                rpn[i] = HandleVariable(rpn[i].Item1, variables, globalNames);
            }

        }
        var expressions = new List<Expression>();

        GenerateExpressions(rpn, expressions);

        if (AllValuesAreIntegers(expresion, variables))
        {
            return new Value($"%{LLVMIrGenerator.Label - 1}", VarType.INT);
        }
        else
        {
            return new Value($"%{LLVMIrGenerator.Label - 1}", VarType.REAL);
        }
    }

    public static void ParseToDouble(Expression ex)
    {
        int itemInt;
        if (int.TryParse(ex.val1, out itemInt))
        {
            double d = (double)itemInt;
            ex.val1 = (d.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture));
        }
        if (int.TryParse(ex.val2, out itemInt))
        {
            double d = (double)itemInt;
            ex.val2 = (d.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture));
        }

    }

    private static void GenerateExpressions(List<(string, VarType)> rpn, List<Expression> expressions)
    {
        while (true)
        {
            if (rpn.Any(x => x.Item1 == "("))
            {
                var br1Index = rpn.IndexOf(("(",VarType.STRING));
                var br2Index = rpn.IndexOf((")", VarType.STRING));

                var subRpn = rpn.GetRange(br1Index + 1, br2Index - br1Index - 1);
                
                var br1Count = subRpn.Where(x => x.Item1 == "(").Count();
                var br2Count = subRpn.Where(x => x.Item1 == ")").Count();

                while (br1Count != br2Count)
                {
                    br2Index = rpn.IndexOf((")", VarType.STRING), br2Index+1);
                    subRpn = rpn.GetRange(br1Index + 1, br2Index - br1Index - 1);

                    br1Count = subRpn.Where(x => x.Item1 == "(").Count();
                    br2Count = subRpn.Where(x => x.Item1 == ")").Count();
                }


                GenerateExpressions(subRpn, expressions);
                rpn.Insert(br2Index + 1, subRpn.First());

                rpn.RemoveRange(br1Index, br2Index - br1Index + 1);

            }
            else if (rpn.Any(x => x.Item1 == "*"))
            {
                AddExpression("*", rpn, expressions);
            }
            else if (rpn.Any(x => x.Item1 == "/"))
            {
                AddExpression("/", rpn, expressions);

            }
            else if (rpn.Any(x => x.Item1 == "+"))
            {
                AddExpression("+", rpn, expressions);
            }
            else if (rpn.Any(x => x.Item1 == "-"))
            {
                AddExpression("-", rpn, expressions);
            }
            else
            {
                break;
            }
        }
    }


    private static void AddExpression(string oper, List<(string, VarType)> rpn, List<Expression> expressions)
    {
        var operIndex = rpn.IndexOf((oper,VarType.STRING));
        var val1 = rpn[operIndex - 1];
        var val2 = rpn[operIndex + 1];
        var ex = new Expression(val1.Item1, val2.Item1, oper);
        expressions.Add(ex);
        VarType type = VarType.REAL;

        switch (ex.oper)
        {
            case "+":
                if (rpn.Any(x => x.Item2 == VarType.REAL))
                {
                    ParseToDouble(ex);
                    LLVMIrGenerator.AddDouble(ex.val1, ex.val2);
                    type = VarType.REAL;
                }
                else
                {
                    LLVMIrGenerator.AddI32(ex.val1, ex.val2);
                    type = VarType.INT;
                }
                break;

            case "-":
                if (rpn.Any(x => x.Item2 == VarType.REAL))
                {
                    ParseToDouble(ex);
                    LLVMIrGenerator.SubDouble(ex.val1, ex.val2);
                    type = VarType.REAL;
                }
                else
                {
                    LLVMIrGenerator.SubI32(ex.val1, ex.val2);
                    type = VarType.INT;
                }
                break;
            case "*":
                if (rpn.Any(x => x.Item2 == VarType.REAL))
                {
                    ParseToDouble(ex);
                    LLVMIrGenerator.MulDouble(ex.val1, ex.val2);
                    type = VarType.REAL;
                }
                else
                {
                    LLVMIrGenerator.MulI32(ex.val1, ex.val2);
                    type = VarType.INT;
                }
                break;
            case "/":
                if (rpn.Any(x => x.Item2 == VarType.REAL))
                {
                    ParseToDouble(ex);
                    LLVMIrGenerator.DivDouble(ex.val1, ex.val2);
                    type = VarType.REAL;
                }
                else
                {
                    LLVMIrGenerator.DivI32(ex.val1, ex.val2);
                    type = VarType.INT;
                }
                break;
        }
        if (rpn.Any(x => x.Item2 == VarType.REAL))
        {
            type = VarType.REAL;
        }

        rpn.Insert(operIndex + 2, ($"%{(LLVMIrGenerator.Label - 1)}",type));
        rpn.RemoveRange(operIndex - 1, 3);
    }
    

        private static bool AllValuesAreIntegers(List<string> values, Dictionary<string, Value> variables)
        {
            foreach (string item in values)
            {
                if (IsNumeric(item))
                {
                    if (!int.TryParse(item, out _))
                    {
                        return false;
                    }

                }
                else if (variables.ContainsKey(item))
                {
                    if ((variables[item].type != VarType.INT))
                    {
                        return false;
                    }

                }

            }

            return true;
        }
        public static (string, VarType) HandleVariable(string item, Dictionary<string, Value> variables, HashSet<string> globalNames)
        {
            string index = "";
            if (item.Contains("["))
            {
                var vectItems = item.Split('[');
                item = vectItems[0];
                index = vectItems[1].Replace("]", "");
            }

            if (variables.ContainsKey(item))
            {
                Value value = variables[item];
                if (value.type == VarType.INT)
                {
                    LLVMIrGenerator.LoadI32(item, globalNames);
                    return (($"%{(LLVMIrGenerator.Label - 1)}"), VarType.INT);
                }

                if (value.type == VarType.REAL)
                {
                    LLVMIrGenerator.LoadDouble(item, globalNames);
                    return (($"%{(LLVMIrGenerator.Label - 1)}"), VarType.REAL);
                } 
                if (value.type == VarType.STRING)
                {
                    throw new Exception($"Unsuported operation of strings, invalid variable {item}");
                }
                else
                {
                   
                    value.content = item;
                    LLVMIrGenerator.LoadVector(value, globalNames, index);
                    return (($"%{(LLVMIrGenerator.Label - 1)}"), value.VectorType);
                }
            }
            else
            {
                throw new Exception(("Unknown variable: " + item));
            }

        }
    

     public static bool IsNumeric(string str)
    {
        return double.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out _);
    }
}