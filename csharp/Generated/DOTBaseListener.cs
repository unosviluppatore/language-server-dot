//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.1-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from DOT.g4 by ANTLR 4.6.1-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AntlrServer {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IDOTListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.1-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class DOTBaseListener : IDOTListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>globalAttrStmt</c>
	/// labeled alternative in <see cref="DOTParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGlobalAttrStmt([NotNull] DOTParser.GlobalAttrStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>globalAttrStmt</c>
	/// labeled alternative in <see cref="DOTParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGlobalAttrStmt([NotNull] DOTParser.GlobalAttrStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>nodeStmt</c>
	/// labeled alternative in <see cref="DOTParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNodeStmt([NotNull] DOTParser.NodeStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>nodeStmt</c>
	/// labeled alternative in <see cref="DOTParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNodeStmt([NotNull] DOTParser.NodeStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>edgeStmt</c>
	/// labeled alternative in <see cref="DOTParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEdgeStmt([NotNull] DOTParser.EdgeStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>edgeStmt</c>
	/// labeled alternative in <see cref="DOTParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEdgeStmt([NotNull] DOTParser.EdgeStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>attrStmt</c>
	/// labeled alternative in <see cref="DOTParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttrStmt([NotNull] DOTParser.AttrStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>attrStmt</c>
	/// labeled alternative in <see cref="DOTParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttrStmt([NotNull] DOTParser.AttrStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>subgraphStmt</c>
	/// labeled alternative in <see cref="DOTParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubgraphStmt([NotNull] DOTParser.SubgraphStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>subgraphStmt</c>
	/// labeled alternative in <see cref="DOTParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubgraphStmt([NotNull] DOTParser.SubgraphStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="DOTParser.graph"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGraph([NotNull] DOTParser.GraphContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DOTParser.graph"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGraph([NotNull] DOTParser.GraphContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="DOTParser.stmt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_list([NotNull] DOTParser.Stmt_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DOTParser.stmt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_list([NotNull] DOTParser.Stmt_listContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="DOTParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt([NotNull] DOTParser.StmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DOTParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt([NotNull] DOTParser.StmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="DOTParser.attr_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttr_stmt([NotNull] DOTParser.Attr_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DOTParser.attr_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttr_stmt([NotNull] DOTParser.Attr_stmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="DOTParser.attr_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttr_list([NotNull] DOTParser.Attr_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DOTParser.attr_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttr_list([NotNull] DOTParser.Attr_listContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="DOTParser.a_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_list([NotNull] DOTParser.A_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DOTParser.a_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_list([NotNull] DOTParser.A_listContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="DOTParser.edge_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEdge_stmt([NotNull] DOTParser.Edge_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DOTParser.edge_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEdge_stmt([NotNull] DOTParser.Edge_stmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="DOTParser.edgeRHS"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEdgeRHS([NotNull] DOTParser.EdgeRHSContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DOTParser.edgeRHS"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEdgeRHS([NotNull] DOTParser.EdgeRHSContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="DOTParser.edgeop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEdgeop([NotNull] DOTParser.EdgeopContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DOTParser.edgeop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEdgeop([NotNull] DOTParser.EdgeopContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="DOTParser.node_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNode_stmt([NotNull] DOTParser.Node_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DOTParser.node_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNode_stmt([NotNull] DOTParser.Node_stmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="DOTParser.node_id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNode_id([NotNull] DOTParser.Node_idContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DOTParser.node_id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNode_id([NotNull] DOTParser.Node_idContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="DOTParser.port"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPort([NotNull] DOTParser.PortContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DOTParser.port"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPort([NotNull] DOTParser.PortContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="DOTParser.subgraph"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubgraph([NotNull] DOTParser.SubgraphContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DOTParser.subgraph"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubgraph([NotNull] DOTParser.SubgraphContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="DOTParser.id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterId([NotNull] DOTParser.IdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DOTParser.id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitId([NotNull] DOTParser.IdContext context) { }

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
} // namespace AntlrServer
