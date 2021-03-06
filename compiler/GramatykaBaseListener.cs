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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IGramatykaListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class GramatykaBaseListener : IGramatykaListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProg([NotNull] GramatykaParser.ProgContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProg([NotNull] GramatykaParser.ProgContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] GramatykaParser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] GramatykaParser.BlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>print</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrint([NotNull] GramatykaParser.PrintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>print</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrint([NotNull] GramatykaParser.PrintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>assign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssign([NotNull] GramatykaParser.AssignContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>assign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssign([NotNull] GramatykaParser.AssignContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprAssign([NotNull] GramatykaParser.ExprAssignContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprAssign([NotNull] GramatykaParser.ExprAssignContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>vectDeclaration</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVectDeclaration([NotNull] GramatykaParser.VectDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>vectDeclaration</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVectDeclaration([NotNull] GramatykaParser.VectDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>vectAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVectAssign([NotNull] GramatykaParser.VectAssignContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>vectAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVectAssign([NotNull] GramatykaParser.VectAssignContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>vectExprAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVectExprAssign([NotNull] GramatykaParser.VectExprAssignContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>vectExprAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVectExprAssign([NotNull] GramatykaParser.VectExprAssignContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>vectAllAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVectAllAssign([NotNull] GramatykaParser.VectAllAssignContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>vectAllAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVectAllAssign([NotNull] GramatykaParser.VectAllAssignContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>readInt</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReadInt([NotNull] GramatykaParser.ReadIntContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>readInt</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReadInt([NotNull] GramatykaParser.ReadIntContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>readReal</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReadReal([NotNull] GramatykaParser.ReadRealContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>readReal</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReadReal([NotNull] GramatykaParser.ReadRealContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>call</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCall([NotNull] GramatykaParser.CallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>call</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCall([NotNull] GramatykaParser.CallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>if</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIf([NotNull] GramatykaParser.IfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>if</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIf([NotNull] GramatykaParser.IfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>while</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhile([NotNull] GramatykaParser.WhileContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>while</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhile([NotNull] GramatykaParser.WhileContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValue([NotNull] GramatykaParser.ValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValue([NotNull] GramatykaParser.ValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.vect"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVect([NotNull] GramatykaParser.VectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.vect"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVect([NotNull] GramatykaParser.VectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.numbers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumbers([NotNull] GramatykaParser.NumbersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.numbers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumbers([NotNull] GramatykaParser.NumbersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumber([NotNull] GramatykaParser.NumberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumber([NotNull] GramatykaParser.NumberContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.arithmeticExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArithmeticExpr([NotNull] GramatykaParser.ArithmeticExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.arithmeticExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArithmeticExpr([NotNull] GramatykaParser.ArithmeticExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] GramatykaParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] GramatykaParser.ExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElement([NotNull] GramatykaParser.ElementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElement([NotNull] GramatykaParser.ElementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction([NotNull] GramatykaParser.FunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction([NotNull] GramatykaParser.FunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.equal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEqual([NotNull] GramatykaParser.EqualContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.equal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEqual([NotNull] GramatykaParser.EqualContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.blockIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlockIf([NotNull] GramatykaParser.BlockIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.blockIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlockIf([NotNull] GramatykaParser.BlockIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatykaParser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondition([NotNull] GramatykaParser.ConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatykaParser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondition([NotNull] GramatykaParser.ConditionContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
