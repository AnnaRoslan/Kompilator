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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IGramatykaVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class GramatykaBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IGramatykaVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="GramatykaParser.prog"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProg([NotNull] GramatykaParser.ProgContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="GramatykaParser.block"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBlock([NotNull] GramatykaParser.BlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>print</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPrint([NotNull] GramatykaParser.PrintContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>assign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAssign([NotNull] GramatykaParser.AssignContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>exprAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExprAssign([NotNull] GramatykaParser.ExprAssignContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>vectDeclaration</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitVectDeclaration([NotNull] GramatykaParser.VectDeclarationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>vectAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitVectAssign([NotNull] GramatykaParser.VectAssignContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>vectExprAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitVectExprAssign([NotNull] GramatykaParser.VectExprAssignContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>vectAllAssign</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitVectAllAssign([NotNull] GramatykaParser.VectAllAssignContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>readInt</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReadInt([NotNull] GramatykaParser.ReadIntContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>readReal</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReadReal([NotNull] GramatykaParser.ReadRealContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>call</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCall([NotNull] GramatykaParser.CallContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>if</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIf([NotNull] GramatykaParser.IfContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>while</c>
	/// labeled alternative in <see cref="GramatykaParser.statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWhile([NotNull] GramatykaParser.WhileContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="GramatykaParser.value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValue([NotNull] GramatykaParser.ValueContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="GramatykaParser.vect"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitVect([NotNull] GramatykaParser.VectContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="GramatykaParser.numbers"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNumbers([NotNull] GramatykaParser.NumbersContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="GramatykaParser.number"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNumber([NotNull] GramatykaParser.NumberContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="GramatykaParser.arithmeticExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArithmeticExpr([NotNull] GramatykaParser.ArithmeticExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="GramatykaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpr([NotNull] GramatykaParser.ExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="GramatykaParser.element"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitElement([NotNull] GramatykaParser.ElementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="GramatykaParser.function"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunction([NotNull] GramatykaParser.FunctionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="GramatykaParser.equal"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEqual([NotNull] GramatykaParser.EqualContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="GramatykaParser.blockIf"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBlockIf([NotNull] GramatykaParser.BlockIfContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="GramatykaParser.condition"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCondition([NotNull] GramatykaParser.ConditionContext context) { return VisitChildren(context); }
}
