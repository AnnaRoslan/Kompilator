using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntlrTemplate
{
    public class LLVMListener : GramatykaBaseListener
    {

        private readonly Dictionary<string, Value> variables = new Dictionary<string, Value>();

        private readonly HashSet<string> globalNames = new HashSet<string>();

        private HashSet<string> localNames = new HashSet<string>();

        private bool isGlobal = true;

        private string functionName = "";

        private CommonTokenStream Tokens { get; }

        public LLVMListener(CommonTokenStream tokens)
        {
            Tokens = tokens;
        }
                       
        public override void EnterAssign(GramatykaParser.AssignContext context){}

        public override void ExitAssign(GramatykaParser.AssignContext context)
        {
            isGlobal = false;
            var ID = context.ID().GetText();
            var value = GetValue(context.value());
            if (value.type == VarType.VECTOR && context.value().GetText().Contains("["))
            {
                if (isGlobal)
                {
                    var vect = variables[value.content];
                     var index = context.value().vect().INT().GetText();
                    var itemValue = new Value(vect.values[int.Parse(index)], vect.VectorType);

                    DeclareVariableIfNotExist(ID, itemValue);
                    AssignVariable(ID, vect, context.Start.Line, false);
                }
                else
                {
                    var vect = variables[value.content];
                    value.VectorType = vect.VectorType;
                    var index = context.value().vect().INT().GetText();
                    var itemValue = new Value(vect.values[int.Parse(index)], vect.VectorType);

                    var vectContext = (GramatykaParser.VectContext)context.value().vect().Payload;
                    DeclareVariableIfNotExist(ID, itemValue);

                    AssignVariable(ID, vect, context.Start.Line, false,index);

                }
            }
            else if (value.type == VarType.VECTOR && !context.value().GetText().Contains("["))
            {
                if (isGlobal)
                {
                    //TODO
                }
                else
                {
                    var vect = variables[value.content];
                    value.VectorType = vect.VectorType;
                    DeclareVariableIfNotExist(ID, vect);
                    AssignVariable(ID, vect, context.Start.Line, false);
                }
            }
            else
            {
                DeclareVariableIfNotExist(ID, value);
                AssignVariable(ID, value, context.Start.Line, false);

            }
        }
        public override void EnterExprAssign(GramatykaParser.ExprAssignContext context) { }

        public override void ExitExprAssign(GramatykaParser.ExprAssignContext context)
        {
            var start = context.arithmeticExpr().Start.TokenIndex;
            var stop = context.arithmeticExpr().Stop.TokenIndex;
            var expression = Tokens.GetTokens(start, stop).Select(x => x.Text).ToList();

            while (expression.Contains("["))
            {
                var vectStart = expression.IndexOf("[") - 1;
                var vectStop = expression.IndexOf("]");
                var vectId = expression[vectStart];
                var index = expression[vectStart + 2];
                expression.Insert(vectStop+1, $"{vectId}[{index}]");
                expression.RemoveRange(vectStart, 4);
            }

            var ID = context.ID().GetText();
            Value value = MathOperations.DeclareOperation(expression, globalNames, variables);
            DeclareVariableIfNotExist(ID, value);
            AssignVariable(ID, value, context.Start.Line, true);
        }

        public override void EnterPrint(GramatykaParser.PrintContext context) { }

        public override void ExitPrint(GramatykaParser.PrintContext context)
        {
            var ID = context.value().GetText();

            var vect = context.value().vect();
            string index = null;
            if (vect != null)
            {
                var vectContext = (GramatykaParser.VectContext)context.value().vect().Payload;
                ID = vectContext.ID().GetText();
                index = vectContext.INT().GetText();
            }
            if (variables.ContainsKey(ID))
            {
                PrintVariable(ID, context.Start.Line,index);
            }
            else
            {
                PrintConstant(context.value());
            }

        }
        
        public override void EnterReadInt(GramatykaParser.ReadIntContext context) { }

        public override void ExitReadInt(GramatykaParser.ReadIntContext context)
        {
            string ID= context.value().GetText();
            if (context.value().vect() != null)
            {
                ID = context.value().vect().ID().GetText();
            }
            if (!variables.ContainsKey(ID))
            {
                if (isGlobal)
                {
                    globalNames.Add(ID);
                }

                LLVMIrGenerator.DeclareI32(ID, isGlobal);
                LLVMIrGenerator.ScanfI32(ID, globalNames);
                variables.Add(ID, new Value(ID, VarType.INT));
            }
            else
            {
                if ((context.value().vect() != null))
                {
                    var id = $"{ID}_scanf";
                    LLVMIrGenerator.DeclareI32(id, false);
                    LLVMIrGenerator.ScanfI32(id, globalNames);

                    var index = context.value().vect().INT().GetText();
                    var value = new Value(id, VarType.INT);

                    AssignVector(ID, value, context.Start.Line, false, index);


                }
                else
                {
                   LLVMIrGenerator.ScanfI32(ID, globalNames);
                }
            }

        }

        public override void EnterReadReal(GramatykaParser.ReadRealContext context) { }

        public override void ExitReadReal(GramatykaParser.ReadRealContext context)
        {
            string ID = context.value().GetText();
            if (context.value().vect() != null)
            {
                ID = context.value().vect().ID().GetText();
            }

            if (!variables.ContainsKey(ID))
            {
                if (isGlobal)
                {
                    globalNames.Add(ID);
                }

                LLVMIrGenerator.DeclareDouble(ID, isGlobal);
                LLVMIrGenerator.ScanfDouble(ID, globalNames);
                variables.Add(ID, new Value(ID, VarType.REAL));
            }
            else
            {
                if ((context.value().vect() != null))
                {
                    var id = $"{ID}_scanf";
                    LLVMIrGenerator.DeclareDouble(id, false);
                    LLVMIrGenerator.ScanfDouble(id, globalNames);

                    var index = context.value().vect().INT().GetText();
                    var value = new Value(id, VarType.REAL);

                    AssignVector(ID, value, context.Start.Line, false, index);


                }
                else
                {
                    LLVMIrGenerator.ScanfDouble(ID, globalNames);
                }
            }

        }

        public override void EnterVectDeclaration(GramatykaParser.VectDeclarationContext context){ }

        public override void ExitVectDeclaration(GramatykaParser.VectDeclarationContext context)
        {
            var ID= context.ID().GetText();
            var num = context.INT().GetText();
            var type = context.TYPE().GetText();

            if (int.Parse(num) <=0)
            {
                PrintError(context.Start.Line, "Invalid vector size");
            }

            var varType = type == "INT" ? VarType.INT : VarType.REAL;
            var value = new Value(ID, VarType.VECTOR) { VectorType = varType, values = Enumerable.Repeat(string.Empty, int.Parse(num) ).ToList() };

            DeclareVariableIfNotExist(ID, value);
        }

        public override void EnterVectAssign(GramatykaParser.VectAssignContext context){ }

        public override void ExitVectAssign(GramatykaParser.VectAssignContext context)
        {
            var ID = context.ID().GetText();
            var index = context.INT().GetText();
            var value = GetValue(context.value());

            AssignVector(ID, value, context.Start.Line, false,index);
        }

        public override void EnterVectExprAssign(GramatykaParser.VectExprAssignContext context) { }

        public override void ExitVectExprAssign(GramatykaParser.VectExprAssignContext context)
        {

            var start = context.arithmeticExpr().Start.TokenIndex;
            var stop = context.arithmeticExpr().Stop.TokenIndex;
            var expression = Tokens.GetTokens(start, stop).Select(x => x.Text).ToList();

            Value value = MathOperations.DeclareOperation(expression, globalNames, variables);

            var ID = context.ID().GetText();
            var index = context.INT().GetText();
            AssignVector(ID, value, context.Start.Line, true, index);

        }

        public override void EnterVectAllAssign(GramatykaParser.VectAllAssignContext context) { }

        public override void ExitVectAllAssign(GramatykaParser.VectAllAssignContext context)
        {
            var ID = context.ID().GetText();
            var start = context.numbers().Start.TokenIndex;
            var stop = context.numbers().Stop.TokenIndex;
            var numbers = context.numbers().children.Where(x => x.GetText() != ",").ToList();

            var vect = variables[ID];

            if (vect == null)
            {
                PrintError(context.Start.Line, $"Vector variable {ID} was not declared");
            }
            if (vect.values.Count() != numbers.Count)
            {
                PrintError(context.Start.Line, $"Wrong number of items. Get {numbers.Count}, required {vect.content}");
            }

            int index = 0;
            foreach (var number in numbers)
            {
                var numberContext = (GramatykaParser.NumberContext)number.Payload;
                var value = GetValue(numberContext);

                if (value.type != vect.VectorType)
                {
                    PrintError(context.Start.Line, $"Invalid number {value.content}, required {vect.VectorType}");
                }
                AssignVector(ID, value, context.Start.Line, false, index.ToString());
                index++;
            }

        }

        public override void EnterNumbers([NotNull] GramatykaParser.NumbersContext context)
        {
            base.EnterNumbers(context);
        }

        public override void ExitNumbers([NotNull] GramatykaParser.NumbersContext context)
        {
            base.ExitNumbers(context);
        }

        public override void EnterElement([NotNull] GramatykaParser.ElementContext context)
        {
            base.EnterElement(context);
        }

        public override void ExitElement([NotNull] GramatykaParser.ElementContext context)
        {
            base.ExitElement(context);
        }

        public override void EnterNumber([NotNull] GramatykaParser.NumberContext context)
        {
            base.EnterNumber(context);
        }

        public override void ExitNumber([NotNull] GramatykaParser.NumberContext context)
        {
            base.ExitNumber(context);
        }

        public override void EnterFunction(GramatykaParser.FunctionContext context)
        {
            isGlobal = false;
            functionName = context.ID().GetText();

            var a = context.block().GetText();
            var abx = context.block().children.Select(x => x.GetText()); // potem analiza dynamiczne returna


            LLVMIrGenerator.FunctionStart(functionName);
        }

        public override void ExitFunction(GramatykaParser.FunctionContext context)
        {
            isGlobal = true;
            LLVMIrGenerator.FunctionEnd();
            RemoveLocalVariables();
        }

        public override void EnterCall(GramatykaParser.CallContext context) { }

        public override void ExitCall(GramatykaParser.CallContext context)
        {
            var ID= context.ID().GetText();
            LLVMIrGenerator.Call(ID);
        }

        public override void EnterBlockIf(GramatykaParser.BlockIfContext context)
        {
            LLVMIrGenerator.IfStart();
        }
        public override void ExitBlockIf(GramatykaParser.BlockIfContext context)
        {
            LLVMIrGenerator.IfEnd();
        }

        public override void EnterEqual(GramatykaParser.EqualContext context) { }
        public override void ExitEqual(GramatykaParser.EqualContext context)
        {
            var ID= context.ID().GetText();
            var INT = context.INT().GetText();
            if (variables.ContainsKey(ID))
            {
                LLVMIrGenerator.IsEqualI32(ID, INT, globalNames);
            }
            else
            {
                PrintError(context.Start.Line, ("Unknown variable: " + ID));
            }

        }

        public override void EnterCondition(GramatykaParser.ConditionContext context) { }
        public override void ExitCondition(GramatykaParser.ConditionContext context)
        {
            var ID= context.ID().GetText();
            if (variables.ContainsKey(ID))
            {
                if ((variables[ID].type == VarType.INT))
                {
                    LLVMIrGenerator.RepeatStart(ID, globalNames, false);
                }
                else if ((variables[ID].type == VarType.REAL))
                {
                    LLVMIrGenerator.RepeatStart(ID, globalNames, true);
                }
                else
                {
                    PrintError(context.Start.Line, "Repeat value must be an integer or real.");
                }

            }
            else
            {
                PrintError(context.Start.Line, ("Unknown variable: " + ID));
            }

        }
        public override void EnterBlock(GramatykaParser.BlockContext context) { }
        public override void ExitBlock(GramatykaParser.BlockContext context)
        {
            if ((context.Parent is GramatykaParser.WhileContext))
            {
                LLVMIrGenerator.RepeatEnd();
            }

        }
        public override void EnterProg(GramatykaParser.ProgContext context) { }
        public override void ExitProg(GramatykaParser.ProgContext context)
        {
            var result = LLVMIrGenerator.generate();
            Console.WriteLine(result);
            File.WriteAllText("C:\\Users\\annar\\Desktop\\Kompilator\\Kom\\test.ll", result);
        }

        private Value GetValue(GramatykaParser.ValueContext context)
        {
            if ((context.INT() != null))
            {
                return new Value(context.INT().GetText(), VarType.INT);
            }
            else if (context.REAL() != null)
            {
                return new Value(context.REAL().GetText(), VarType.REAL);
            }
            else if (context.STRING() != null)
            {
                return new Value(GetTextWithoutQuotes(context), VarType.STRING);
            }
            else if (context.vect() != null)
            {
                var ID = context.vect().ID();
                return new Value(ID.ToString(), VarType.VECTOR);
            }
            else
            {

                var declaredValue = variables[context.ID().GetText()];
                if(declaredValue == null)
                {
                PrintError(context.Start.Line, "Invalid value.");

                }

                return new Value(context.ID().GetText(), declaredValue.type);
            }
        }
        private Value GetValue(GramatykaParser.NumberContext context)
        {
            if ((context.INT() != null))
            {
                return new Value(context.INT().GetText(), VarType.INT);
            }
            else if ((context.REAL() != null))
            {
                return new Value(context.REAL().GetText(), VarType.REAL);
            }           
            else
            {
                PrintError(context.Start.Line, "Invalid value.");
                return null;
            }
        }

        private void DeclareVariableIfNotExist(string ID, Value value)
        {
            if (!variables.ContainsKey(ID))
            {
                if ((value.type != VarType.STRING))
                {
                    variables.Add(ID, value);
                }

                if ((value.type == VarType.INT))
                {
                    LLVMIrGenerator.DeclareI32(ID, isGlobal);
                }
                if ((value.type == VarType.REAL))
                {
                    LLVMIrGenerator.DeclareDouble(ID, isGlobal);
                }
                else if (value.type == VarType.VECTOR)
                {
                    LLVMIrGenerator.DeclareVector(ID,value.values.Count.ToString(),value.VectorType, isGlobal);
                }

            }

        }

        private void AssignVector(string ID, Value value, int line, bool isMathExpr, string index)
        {
            var vect = variables[ID];
            if (vect == null)
            {
                PrintError(line, $"Vector variable {ID} was not declared");
            }
            if (vect.VectorType != value.type)
            {
                PrintError(line, $"Assigned value {value.content} type do not match vector {ID} type");
            }
            if (vect.values.Count < int.Parse(index))
            {
                PrintError(line, $"index {index} out of boundary of vector {ID}");
            }

            vect.values[int.Parse(index)] = value.content;
            var v = GetValue(value, isMathExpr);
            LLVMIrGenerator.AssignVector(vect, v, index, globalNames);

        }
        private void AssignVariable(string ID, Value value, int line, bool isMathExpr, string index = null)
        {
            if (isGlobal)
            {
                globalNames.Add(ID);
            }
            else if (!globalNames.Contains(ID))
            {
                localNames.Add(ID);
            }

            if (value.type == VarType.INT)
            {
                LLVMIrGenerator.AssignI32(ID, GetValue(value, isMathExpr), globalNames);
            }
            else if ((value.type == VarType.REAL))
            {
                LLVMIrGenerator.AssignDouble(ID, GetValue(value, isMathExpr), globalNames);
            }
            else if (value.type == VarType.STRING)
            {
                AssignString(ID, value, line);
            }
            else if (value.type == VarType.VECTOR)
            {
                var vect = variables[value.content];
                if (index != null)
                {
                    if (vect.values.Count < int.Parse(index))
                    {
                        PrintError(line, $"index {index} out of boundary of vector {ID}");
                    }
                    var val = GetValue(value, false, index);
                    LLVMIrGenerator.AssignVectorTo(ID,vect.VectorType);

                }
                else
                {
                    LLVMIrGenerator.AssignWholeVector(ID, vect);
                }

            } 
            else
            {
                PrintError(line, $"Assign error: {ID}");
            }

        }

        private string GetValue(Value value, bool isMathExpr, string index = null)
        {
            if (isMathExpr)
            {
                return value.content;
            }

            if (MathOperations.IsNumeric(value.content))
            {
                return value.content;
            }
            else
            {
                if (value.type == VarType.REAL)
                {
                    LLVMIrGenerator.LoadDouble(value.content, globalNames);
                }
                else if(value.type == VarType.INT)
                {
                    LLVMIrGenerator.LoadI32(value.content, globalNames);
                }
                else
                {
                    LLVMIrGenerator.LoadVector(value, globalNames,index);
                }


                return ("%"
                            + (LLVMIrGenerator.Label - 1));
            }

        }

        private void AssignString(string ID, Value value, int line)
        {
            if (!variables.ContainsKey(ID))
            {
                LLVMIrGenerator.AssignString(ID, value.content,value.stringVersion, isGlobal, functionName);
                variables.Add(ID, value);
            }
            else
            {
                value.stringVersion++;
                variables[ID] = value;
                LLVMIrGenerator.AssignString(ID, value.content, value.stringVersion, isGlobal, functionName);
            }

        }

        private void PrintConstant(GramatykaParser.ValueContext context)
        {
            if ((context.STRING() != null))
            {
                LLVMIrGenerator.PrintText(GetTextWithoutQuotes(context));
            }
            else
            {
                LLVMIrGenerator.PrintText(context.GetText());
            }

        }

        private void PrintVariable(string ID, int line, string index = null)
        {
            if (variables[ID].type == VarType.INT)
            {
                LLVMIrGenerator.PrintfI32(ID, globalNames);
            }
            else if (variables[ID].type == VarType.REAL)
            {
                LLVMIrGenerator.PrintfDouble(ID, globalNames);
            }
            else if (variables[ID].type == VarType.STRING)
            {
                LLVMIrGenerator.PrintfString(ID, variables[ID].content.Length, variables[ID].stringVersion, globalNames, functionName);
            }
            else if(variables[ID].type == VarType.VECTOR)
            {
                var vect = variables[ID];

                if (vect.values.Count < int.Parse(index))
                {
                    PrintError(line, $"index {index} out of boundary of vector {ID}");
                }
                LLVMIrGenerator.PrintfVector(ID, vect, index, globalNames);
            }

        }

        private string GetTextWithoutQuotes(GramatykaParser.ValueContext context)
        {
            var text = context.STRING().GetText();
            text = text.Replace("\"", string.Empty);
            return text;
        }

        private void RemoveLocalVariables()
        {
            foreach (var id in localNames)
            {
                variables.Remove(id);
            }

            localNames.Clear();
        }

        private static void PrintError(int line, string msg)
        {
            Console.Error.WriteLine(("Error, line "
                            + (line + (", " + msg))));
            Environment.Exit(-1);
        }

        // **

        public override void EnterIf(GramatykaParser.IfContext context) { }
        public override void ExitIf(GramatykaParser.IfContext context) { }


        public override void EnterWhile(GramatykaParser.WhileContext context) { }
        public override void ExitWhile(GramatykaParser.WhileContext context) { }

        public override void EnterValue(GramatykaParser.ValueContext context) { }
        public override void ExitValue(GramatykaParser.ValueContext context) { }

        public override void EnterArithmeticExpr(GramatykaParser.ArithmeticExprContext context) { }
        public override void ExitArithmeticExpr(GramatykaParser.ArithmeticExprContext context) { }


        public override void EnterExpr(GramatykaParser.ExprContext context) { }
        public override void ExitExpr(GramatykaParser.ExprContext context) { }

        public override void EnterEveryRule(ParserRuleContext context) { }
        public override void ExitEveryRule(ParserRuleContext context) { }

        public override void VisitTerminal(ITerminalNode node) { }

        public override void VisitErrorNode(IErrorNode node) { }

        public override void EnterVect([NotNull] GramatykaParser.VectContext context) { }
        public override void ExitVect([NotNull] GramatykaParser.VectContext context) { }


        // **



    }
}
