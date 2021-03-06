//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\annar\Desktop\Kompilator\Kom\Gramatyka.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="GramatykaParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IGramatykaListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] GramatykaParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] GramatykaParser.ProgContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] GramatykaParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] GramatykaParser.BlockContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>print</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrint([NotNull] GramatykaParser.PrintContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>print</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrint([NotNull] GramatykaParser.PrintContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>assign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssign([NotNull] GramatykaParser.AssignContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>assign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssign([NotNull] GramatykaParser.AssignContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprAssign([NotNull] GramatykaParser.ExprAssignContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprAssign([NotNull] GramatykaParser.ExprAssignContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>vectDeclaration</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVectDeclaration([NotNull] GramatykaParser.VectDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>vectDeclaration</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVectDeclaration([NotNull] GramatykaParser.VectDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>vectAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVectAssign([NotNull] GramatykaParser.VectAssignContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>vectAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVectAssign([NotNull] GramatykaParser.VectAssignContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>vectExprAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVectExprAssign([NotNull] GramatykaParser.VectExprAssignContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>vectExprAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVectExprAssign([NotNull] GramatykaParser.VectExprAssignContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>vectAllAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVectAllAssign([NotNull] GramatykaParser.VectAllAssignContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>vectAllAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVectAllAssign([NotNull] GramatykaParser.VectAllAssignContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>readInt</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReadInt([NotNull] GramatykaParser.ReadIntContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>readInt</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReadInt([NotNull] GramatykaParser.ReadIntContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>readReal</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReadReal([NotNull] GramatykaParser.ReadRealContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>readReal</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReadReal([NotNull] GramatykaParser.ReadRealContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>call</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCall([NotNull] GramatykaParser.CallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>call</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCall([NotNull] GramatykaParser.CallContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>if</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIf([NotNull] GramatykaParser.IfContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>if</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIf([NotNull] GramatykaParser.IfContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>while</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhile([NotNull] GramatykaParser.WhileContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>while</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhile([NotNull] GramatykaParser.WhileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue([NotNull] GramatykaParser.ValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue([NotNull] GramatykaParser.ValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.vect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVect([NotNull] GramatykaParser.VectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.vect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVect([NotNull] GramatykaParser.VectContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.numbers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumbers([NotNull] GramatykaParser.NumbersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.numbers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumbers([NotNull] GramatykaParser.NumbersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumber([NotNull] GramatykaParser.NumberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumber([NotNull] GramatykaParser.NumberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.arithmeticExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArithmeticExpr([NotNull] GramatykaParser.ArithmeticExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.arithmeticExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArithmeticExpr([NotNull] GramatykaParser.ArithmeticExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] GramatykaParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] GramatykaParser.ExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElement([NotNull] GramatykaParser.ElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElement([NotNull] GramatykaParser.ElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction([NotNull] GramatykaParser.FunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction([NotNull] GramatykaParser.FunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.equal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqual([NotNull] GramatykaParser.EqualContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.equal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqual([NotNull] GramatykaParser.EqualContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.blockIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockIf([NotNull] GramatykaParser.BlockIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.blockIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockIf([NotNull] GramatykaParser.BlockIfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondition([NotNull] GramatykaParser.ConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondition([NotNull] GramatykaParser.ConditionContext context);
}
